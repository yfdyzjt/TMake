using TMake.Terraria;

namespace TMake.IO
{
    public static class WorldFile
    {
        public static World Load(string filename)
        {
            World world = new();

            try
            {
                using var fileStream = new FileStream(filename, FileMode.Open);
                using var binaryReader = new BinaryReader(fileStream);

                world.Version = binaryReader.ReadUInt32();

                if (world.Version > 87)
                {
                    LoadV2(world, binaryReader);
                }
                else
                {
                    throw new FileFormatException("Unexpected Position: Invalid Verison");
                }
            }
            catch
            {
                throw;
            }

            return world;
        }
        public static void Save(World world, string filename)
        {
            try
            {
                using var fileStream = new FileStream(filename, FileMode.Create);
                using var binaryWriter = new BinaryWriter(fileStream);

                if (world.Version > 87)
                {
                    SaveV2(world, binaryWriter);
                }
            }
            catch
            {
                throw;
            }
        }
        private static void LoadV2(World world, BinaryReader binaryReader)
        {
            binaryReader.BaseStream.Position = 0L;

            if (!LoadFileFormatHeader(binaryReader, world, out var importance, out var positions))
                throw new FileFormatException("Invalid File Format Section");

            if (binaryReader.BaseStream.Position != positions[0])
                throw new FileFormatException("Unexpected Position: Invalid File Format Section");

            LoadHeader(binaryReader, world);
            if (binaryReader.BaseStream.Position != positions[1])
                throw new FileFormatException("Unexpected Position: Invalid Header Flags");

            LoadWorldTiles(binaryReader, world, importance);
            if (binaryReader.BaseStream.Position != positions[2])
                throw new FileFormatException("Unexpected Position: Invalid Tile Data");

            LoadChests(binaryReader, world);
            if (binaryReader.BaseStream.Position != positions[3])
                throw new FileFormatException("Unexpected Position: Invalid Chest Data");

            LoadSigns(binaryReader, world);
            if (binaryReader.BaseStream.Position != positions[4])
                throw new FileFormatException("Unexpected Position: Invalid Sign Data");

            LoadNPCs(binaryReader, world);
            if (binaryReader.BaseStream.Position != positions[5])
                throw new FileFormatException("Unexpected Position: Invalid NPC Data");

            if (world.Version >= 116)
            {
                LoadTileEntities(binaryReader, world);
                if (binaryReader.BaseStream.Position != positions[6])
                    throw new FileFormatException("Unexpected Position: Invalid Tile Entities Section");
            }
            if (world.Version >= 170)
            {
                LoadWeightedPressurePlates(binaryReader, world);
                if (binaryReader.BaseStream.Position != positions[7])
                    throw new FileFormatException("Unexpected Position: Invalid Weighted Pressure Plate Section");
            }
            if (world.Version >= 189)
            {
                LoadTownManager(binaryReader, world);
                if (binaryReader.BaseStream.Position != positions[8])
                    throw new FileFormatException("Unexpected Position: Invalid Town Manager Section");
            }
            if (world.Version >= 210)
            {
                LoadBestiary(binaryReader, world);
                if (binaryReader.BaseStream.Position != positions[9])
                    throw new FileFormatException("Unexpected Position: Invalid Bestiary Section");
            }
            if (world.Version >= 220)
            {
                LoadCreativePowers(binaryReader, world);
                if (binaryReader.BaseStream.Position != positions[10])
                    throw new FileFormatException("Unexpected Position: Invalid Creative Powers Section");
            }

            LoadFooter(binaryReader, world);
        }
        private static void SaveV2(World world, BinaryWriter binaryWriter)
        {
            int[] pointers = new int[WorldProperty.SectionCount];
            bool[] tileFrameImportant = WorldProperty.GetVersionData(world.Version).TileFrameImportant;

            pointers[0] = SaveFileFormatHeader(binaryWriter, world, tileFrameImportant);
            pointers[1] = SaveWorldHeader(binaryWriter, world);
            pointers[2] = SaveWorldTiles(binaryWriter, world, tileFrameImportant);

            pointers[3] = SaveChests(binaryWriter, world);
            pointers[4] = SaveSigns(binaryWriter, world); // p

            pointers[5] = SaveNPCs(binaryWriter, world); // p

            if (world.Version >= 140)
            {
                pointers[6] = SaveTileEntities(binaryWriter, world);
            }

            if (world.Version >= 170)
            {
                pointers[7] = SaveWeightedPressurePlates(binaryWriter, world);
            }

            if (world.Version >= 189)
            {
                pointers[8] = SaveTownManager(binaryWriter, world);
            }

            if (world.Version >= 210)
            {
                pointers[9] = SaveBestiary(binaryWriter, world);
            }

            if (world.Version >= 220)
            {
                pointers[10] = SaveCreativePowers(binaryWriter, world);
            }

            SaveFooter(binaryWriter, world);
            SaveHeaderPointers(binaryWriter, world, pointers);
        }
        private static int SaveHeaderPointers(BinaryWriter binaryWriter, World world, int[] sectionPointers)
        {
            binaryWriter.BaseStream.Position = 0;
            binaryWriter.Write((int)world.Version);


            binaryWriter.BaseStream.Position = (world.Version >= 140) ? 0x18L : 0x04;
            binaryWriter.Write((short)sectionPointers.Length);

            for (int i = 0; i < sectionPointers.Length; i++)
            {
                binaryWriter.Write(sectionPointers[i]);
            }

            return (int)binaryWriter.BaseStream.Position;
        }
        private static bool LoadFileFormatHeader(BinaryReader binaryReader, World world, out bool[] importance, out int[] positions)
        {
            if (binaryReader.ReadInt32() >= 140)
            {
                string headerFormat = new(binaryReader.ReadChars(7));
                FileType fileType = (FileType)binaryReader.ReadByte();

                if (fileType != FileType.World)
                {
                    throw new FileFormatException($"Is not a supported file type: {fileType.ToString()}");
                }

                if (headerFormat == WorldProperty.ChineseHeader)
                {
                    world.IsChinese = true;
                }
                else if (headerFormat != WorldProperty.DesktopHeader)
                {
                    throw new FileFormatException("Invalid world header");
                }

                world.Revision = binaryReader.ReadUInt32();

                world.IsFavorite = ((binaryReader.ReadUInt64() & 1uL) == 1uL);
            }

            short sectionCount = binaryReader.ReadInt16();
            positions = new int[sectionCount];
            for (int i = 0; i < sectionCount; i++)
            {
                positions[i] = binaryReader.ReadInt32();
            }

            // Read tile frame importance from bit-packed data
            importance = ReadBitArray(binaryReader);

            return true;
        }
        private static int SaveFileFormatHeader(BinaryWriter binaryWriter, World world, bool[] tileFrameImportant)
        {
            binaryWriter.Write(world.Version);

            // World features added in 1.3.0.1
            if (world.Version >= 140)
            {
                if (world.IsChinese)
                {
                    binaryWriter.Write(WorldProperty.ChineseHeader.ToCharArray());
                }
                else
                {
                    binaryWriter.Write(WorldProperty.DesktopHeader.ToCharArray());
                }
                binaryWriter.Write((byte)FileType.World);

                binaryWriter.Write((int)world.Revision);

                UInt64 worldHeaderFlags = 0;
                if (world.IsFavorite) { worldHeaderFlags |= 0x1; }

                binaryWriter.Write(worldHeaderFlags);
            }

            short sections = (short)WorldProperty.SectionCount;
            binaryWriter.Write(sections);

            // write section pointer placeholders
            for (int i = 0; i < sections; i++)
            {
                binaryWriter.Write((Int32)0);
            }

            // write bitpacked tile frame importance           
            WriteBitArray(binaryWriter, tileFrameImportant);

            return (int)binaryWriter.BaseStream.Position;
        }
        private static void LoadHeader(BinaryReader binaryReader, World world)
        {
            world.Name = binaryReader.ReadString();
            if (world.Version >= 179)
            {
                if (world.Version == 179)
                    world.Seed = binaryReader.ReadInt32().ToString();
                else
                    world.Seed = binaryReader.ReadString();
                world.WorldGenVersion = binaryReader.ReadUInt64();
            }
            else
                world.Seed = "";
            if (world.Version >= 181)
            {
                world.Guid = new Guid(binaryReader.ReadBytes(16));
            }
            else
            {
                world.Guid = Guid.NewGuid();
            }
            world.ID = binaryReader.ReadInt32();
            world.LeftWorld = binaryReader.ReadInt32();
            world.RightWorld = binaryReader.ReadInt32();
            world.TopWorld = binaryReader.ReadInt32();
            world.BottomWorld = binaryReader.ReadInt32();
            world.MaxTilesY = binaryReader.ReadInt32();
            world.MaxTilesX = binaryReader.ReadInt32();

            if (world.Version >= 209)
            {
                world.GameMode = binaryReader.ReadInt32();

                if (world.Version >= 222) { world.DrunkWorld = binaryReader.ReadBoolean(); }
                if (world.Version >= 227) { world.GetGoodWorld = binaryReader.ReadBoolean(); }
                if (world.Version >= 238) { world.TenthAnniversaryWorld = binaryReader.ReadBoolean(); }
                if (world.Version >= 239) { world.DontStarveWorld = binaryReader.ReadBoolean(); }
                if (world.Version >= 241) { world.NotTheBeesWorld = binaryReader.ReadBoolean(); }
                if (world.Version >= 249) { world.RemixWorld = binaryReader.ReadBoolean(); }
                if (world.Version >= 266) { world.NoTrapsWorld = binaryReader.ReadBoolean(); }
                world.ZenithWorld = (world.Version < 267) ? world.RemixWorld && world.DrunkWorld : binaryReader.ReadBoolean();
            }
            else if (world.Version == 208)
            {
                world.GameMode = binaryReader.ReadBoolean() ? 2 : 0;
            }
            else if (world.Version >= 112)
            {
                world.GameMode = binaryReader.ReadBoolean() ? 1 : 0;
            }
            else
            {
                world.GameMode = 0;
            }

            world.CreationTime = world.Version >= 141 ? binaryReader.ReadInt64() : DateTime.Now.ToBinary();

            world.MoonType = binaryReader.ReadByte();
            world.TreeX[0] = binaryReader.ReadInt32();
            world.TreeX[1] = binaryReader.ReadInt32();
            world.TreeX[2] = binaryReader.ReadInt32();
            world.TreeStyle[0] = binaryReader.ReadInt32();
            world.TreeStyle[1] = binaryReader.ReadInt32();
            world.TreeStyle[2] = binaryReader.ReadInt32();
            world.TreeStyle[3] = binaryReader.ReadInt32();
            world.CaveBackX[0] = binaryReader.ReadInt32();
            world.CaveBackX[1] = binaryReader.ReadInt32();
            world.CaveBackX[2] = binaryReader.ReadInt32();
            world.CaveBackStyle[0] = binaryReader.ReadInt32();
            world.CaveBackStyle[1] = binaryReader.ReadInt32();
            world.CaveBackStyle[2] = binaryReader.ReadInt32();
            world.CaveBackStyle[3] = binaryReader.ReadInt32();
            world.IceBackStyle = binaryReader.ReadInt32();
            world.JungleBackStyle = binaryReader.ReadInt32();
            world.HellBackStyle = binaryReader.ReadInt32();

            world.SpawnTileX = binaryReader.ReadInt32();
            world.SpawnTileY = binaryReader.ReadInt32();
            world.SurfaceLayer = binaryReader.ReadDouble();
            world.RockLayer = binaryReader.ReadDouble();
            world.Time = binaryReader.ReadDouble();
            world.DayTime = binaryReader.ReadBoolean();
            world.MoonPhase = binaryReader.ReadInt32();
            world.BloodMoon = binaryReader.ReadBoolean();
            world.Eclipse = binaryReader.ReadBoolean();
            world.DungeonX = binaryReader.ReadInt32();
            world.DungeonY = binaryReader.ReadInt32();

            world.Crimson = binaryReader.ReadBoolean();

            world.DownedBoss1 = binaryReader.ReadBoolean();
            world.DownedBoss2 = binaryReader.ReadBoolean();
            world.DownedBoss3 = binaryReader.ReadBoolean();
            world.DownedQueenBee = binaryReader.ReadBoolean();
            world.DownedMechBoss1 = binaryReader.ReadBoolean();
            world.DownedMechBoss2 = binaryReader.ReadBoolean();
            world.DownedMechBoss3 = binaryReader.ReadBoolean();
            world.DownedMechBossAny = binaryReader.ReadBoolean();
            world.DownedPlantBoss = binaryReader.ReadBoolean();
            world.DownedGolemBoss = binaryReader.ReadBoolean();

            if (world.Version >= 118) { world.DownedSlimeKingBoss = binaryReader.ReadBoolean(); }

            world.SavedGoblin = binaryReader.ReadBoolean();
            world.SavedWizard = binaryReader.ReadBoolean();
            world.SavedMech = binaryReader.ReadBoolean();
            world.DownedGoblins = binaryReader.ReadBoolean();
            world.DownedClown = binaryReader.ReadBoolean();
            world.DownedFrost = binaryReader.ReadBoolean();
            world.DownedPirates = binaryReader.ReadBoolean();

            world.ShadowOrbSmashed = binaryReader.ReadBoolean();
            world.SpawnMeteor = binaryReader.ReadBoolean();
            world.ShadowOrbCount = binaryReader.ReadByte();
            world.AltarCount = binaryReader.ReadInt32();
            world.HardMode = binaryReader.ReadBoolean();
            if (world.Version >= 257) { world.AfterPartyOfDoom = binaryReader.ReadBoolean(); } else { world.AfterPartyOfDoom = false; }
            world.InvasionDelay = binaryReader.ReadInt32();
            world.InvasionSize = binaryReader.ReadInt32();
            world.InvasionType = binaryReader.ReadInt32();
            world.InvasionX = binaryReader.ReadDouble();
            if (world.Version >= 118) { world.SlimeRainTime = binaryReader.ReadDouble(); }
            if (world.Version >= 113) { world.SundialCooldown = binaryReader.ReadByte(); }

            world.Raining = binaryReader.ReadBoolean();
            world.RainTime = binaryReader.ReadInt32();
            world.MaxRain = binaryReader.ReadSingle();
            world.SavedOreTiersCobalt = binaryReader.ReadInt32();
            world.SavedOreTiersMythril = binaryReader.ReadInt32();
            world.SavedOreTiersAdamantite = binaryReader.ReadInt32();
            world.TreeBG = binaryReader.ReadByte();
            world.CorruptBG = binaryReader.ReadByte();
            world.JungleBG = binaryReader.ReadByte();
            world.SnowBG = binaryReader.ReadByte();
            world.HallowBG = binaryReader.ReadByte();
            world.CrimsonBG = binaryReader.ReadByte();
            world.DesertBG = binaryReader.ReadByte();
            world.OceanBG = binaryReader.ReadByte();
            world.CloudBGActive = binaryReader.ReadInt32();
            world.NumClouds = binaryReader.ReadInt16();
            world.WindSpeedTarget = binaryReader.ReadSingle();

            if (world.Version < 95) { return; }

            for (int i = binaryReader.ReadInt32(); i > 0; i--)
            {
                world.AnglerWhoFinishedToday.Add(binaryReader.ReadString());
            }

            if (world.Version < 99) { return; }

            world.SavedAngler = binaryReader.ReadBoolean();


            if (world.Version < 101) { return; }
            world.AnglerQuest = binaryReader.ReadInt32();


            if (world.Version < 104) { return; }


            world.SavedStylist = binaryReader.ReadBoolean();

            if (world.Version >= 140)
            {
                world.SavedTaxCollector = binaryReader.ReadBoolean();
            }

            if (world.Version >= 201)
            {
                world.SavedGolfer = binaryReader.ReadBoolean();
            }

            if (world.Version >= 107)
            {
                world.InvasionSizeStart = binaryReader.ReadInt32();
            }
            world.CultistDelay = world.Version >= 108 ? binaryReader.ReadInt32() : 86400;

            if (world.Version < 109) { return; }

            world.KillCount = new int[binaryReader.ReadInt16()];
            for (int i = 0; i < world.KillCount.Length; i++)
            {
                world.KillCount[i] = binaryReader.ReadInt32();
            }

            if (world.Version < 128) { return; }

            if (world.Version >= 140)
            {
                world.FastForwardTimeToDawn = binaryReader.ReadBoolean();
            }

            if (world.Version < 131) { return; }

            world.DownedFishron = binaryReader.ReadBoolean();
            world.DownedMartians = binaryReader.ReadBoolean();
            world.DownedLunaticCultist = binaryReader.ReadBoolean();
            world.DownedMoonlord = binaryReader.ReadBoolean();
            world.DownedHalloweenKing = binaryReader.ReadBoolean();
            world.DownedHalloweenTree = binaryReader.ReadBoolean();
            world.DownedChristmasIceQueen = binaryReader.ReadBoolean();
            world.DownedChristmasSantank = binaryReader.ReadBoolean();
            world.DownedChristmasTree = binaryReader.ReadBoolean();

            if (world.Version < 140) { return; }

            world.DownedTowerSolar = binaryReader.ReadBoolean();
            world.DownedTowerVortex = binaryReader.ReadBoolean();
            world.DownedTowerNebula = binaryReader.ReadBoolean();
            world.DownedTowerStardust = binaryReader.ReadBoolean();
            world.TowerActiveSolar = binaryReader.ReadBoolean();
            world.TowerActiveVortex = binaryReader.ReadBoolean();
            world.TowerActiveNebula = binaryReader.ReadBoolean();
            world.TowerActiveStardust = binaryReader.ReadBoolean();
            world.LunarApocalypseIsUp = binaryReader.ReadBoolean();

            if (world.Version >= 170)
            {
                world.PartyManual = binaryReader.ReadBoolean();
                world.PartyGenuine = binaryReader.ReadBoolean();
                world.PartyCooldown = binaryReader.ReadInt32();
                int numparty = binaryReader.ReadInt32();
                for (int counter = 0; counter < numparty; counter++)
                {
                    world.PartyCelebratingNPCs.Add(binaryReader.ReadInt32());
                }
            }

            if (world.Version >= 174)
            {
                world.SandStormHappening = binaryReader.ReadBoolean();
                world.SandStormTimeLeft = binaryReader.ReadInt32();
                world.SandStormSeverity = binaryReader.ReadSingle();
                world.SandStormIntendedSeverity = binaryReader.ReadSingle();
            }

            if (world.Version >= 178)
            {
                world.SavedBartender = binaryReader.ReadBoolean();
                world.DownedInvasionT1 = binaryReader.ReadBoolean();
                world.DownedInvasionT2 = binaryReader.ReadBoolean();
                world.DownedInvasionT3 = binaryReader.ReadBoolean();
            }

            if (world.Version > 194)
            {
                world.MushroomBG = binaryReader.ReadByte();
            }

            if (world.Version >= 215)
            {
                world.UnderworldBG = binaryReader.ReadByte();
            }

            if (world.Version >= 195)
            {
                world.TreeBG2 = binaryReader.ReadByte();
                world.TreeBG3 = binaryReader.ReadByte();
                world.TreeBG4 = binaryReader.ReadByte();
            }
            else
            {
                world.TreeBG2 = world.TreeBG;
                world.TreeBG3 = world.TreeBG;
                world.TreeBG4 = world.TreeBG;
            }

            if (world.Version >= 204)
            {
                world.CombatBookWasUsed = binaryReader.ReadBoolean();
            }

            if (world.Version >= 207)
            {
                world.LanternNightCooldown = binaryReader.ReadInt32();
                world.LanternNightGenuine = binaryReader.ReadBoolean();
                world.LanternNightManual = binaryReader.ReadBoolean();
                world.LanternNightNextNightIsGenuine = binaryReader.ReadBoolean();
            }

            // tree tops
            if (world.Version >= 211)
            {
                int numTrees = binaryReader.ReadInt32();
                world.TreeTopVariations = new int[numTrees];
                for (int i = 0; i < numTrees; i++)
                {
                    world.TreeTopVariations[i] = binaryReader.ReadInt32();
                }
            }
            else
            {
                world.TreeTopVariations[0] = world.TreeStyle[0];
                world.TreeTopVariations[1] = world.TreeStyle[1];
                world.TreeTopVariations[2] = world.TreeStyle[2];
                world.TreeTopVariations[3] = world.TreeStyle[3];
                world.TreeTopVariations[4] = world.CorruptBG;
                world.TreeTopVariations[5] = world.JungleBG;
                world.TreeTopVariations[6] = world.SnowBG;
                world.TreeTopVariations[7] = world.HallowBG;
                world.TreeTopVariations[8] = world.CrimsonBG;
                world.TreeTopVariations[9] = world.DesertBG;
                world.TreeTopVariations[10] = world.OceanBG;
                world.TreeTopVariations[11] = world.MushroomBG;
                world.TreeTopVariations[12] = world.UnderworldBG;
            }

            if (world.Version >= 212)
            {
                world.ForceHalloweenForToday = binaryReader.ReadBoolean();
                world.ForceXMasForToday = binaryReader.ReadBoolean();
            }

            if (world.Version >= 216)
            {
                world.SavedOreTiersCopper = binaryReader.ReadInt32();
                world.SavedOreTiersIron = binaryReader.ReadInt32();
                world.SavedOreTiersSilver = binaryReader.ReadInt32();
                world.SavedOreTiersGold = binaryReader.ReadInt32();
            }
            else
            {
                world.SavedOreTiersCopper = -1;
                world.SavedOreTiersIron = -1;
                world.SavedOreTiersSilver = -1;
                world.SavedOreTiersGold = -1;
            }

            if (world.Version >= 217)
            {
                world.BoughtCat = binaryReader.ReadBoolean();
                world.BoughtDog = binaryReader.ReadBoolean();
                world.BoughtBunny = binaryReader.ReadBoolean();
            }

            if (world.Version >= 223)
            {
                world.DownedEmpressOfLight = binaryReader.ReadBoolean();
                world.DownedQueenSlime = binaryReader.ReadBoolean();
            }

            if (world.Version >= 240)
            {
                world.DownedDeerclops = binaryReader.ReadBoolean();
            }

            if (world.Version >= 250)
            {
                world.UnlockedSlimeBlueSpawn = binaryReader.ReadBoolean();
            }

            if (world.Version >= 251)
            {
                world.UnlockedMerchantSpawn = binaryReader.ReadBoolean();
                world.UnlockedDemolitionistSpawn = binaryReader.ReadBoolean();
                world.UnlockedPartyGirlSpawn = binaryReader.ReadBoolean();
                world.UnlockedDyeTraderSpawn = binaryReader.ReadBoolean();
                world.UnlockedTruffleSpawn = binaryReader.ReadBoolean();
                world.UnlockedArmsDealerSpawn = binaryReader.ReadBoolean();
                world.UnlockedNurseSpawn = binaryReader.ReadBoolean();
                world.UnlockedPrincessSpawn = binaryReader.ReadBoolean();
            }

            if (world.Version >= 259)
            {
                world.CombatBookVolumeTwoWasUsed = binaryReader.ReadBoolean();
            }

            if (world.Version >= 260)
            {
                world.PeddlersSatchelWasUsed = binaryReader.ReadBoolean();
            }

            if (world.Version >= 261)
            {
                world.UnlockedSlimeGreenSpawn = binaryReader.ReadBoolean();
                world.UnlockedSlimeOldSpawn = binaryReader.ReadBoolean();
                world.UnlockedSlimePurpleSpawn = binaryReader.ReadBoolean();
                world.UnlockedSlimeRainbowSpawn = binaryReader.ReadBoolean();
                world.UnlockedSlimeRedSpawn = binaryReader.ReadBoolean();
                world.UnlockedSlimeYellowSpawn = binaryReader.ReadBoolean();
                world.UnlockedSlimeCopperSpawn = binaryReader.ReadBoolean();
            }

            if (world.Version >= 264)
            {
                world.FastForwardTimeToDusk = binaryReader.ReadBoolean();
                world.MoondialCooldown = binaryReader.ReadByte();
            }
        }
        private static int SaveWorldHeader(BinaryWriter binaryWriter, World world)
        {
            binaryWriter.Write(world.Name);

            if (world.Version >= 179)
            {
                if (world.Version == 179)
                {
                    int.TryParse(world.Seed, out var seed);
                    binaryWriter.Write(seed);
                }
                else
                {
                    binaryWriter.Write(world.Seed);
                }

                binaryWriter.Write(world.WorldGenVersion);

            }

            if (world.Version >= 181)
            {
                binaryWriter.Write(world.Guid.ToByteArray());

            }

            binaryWriter.Write(world.ID);

            binaryWriter.Write(world.LeftWorld);

            binaryWriter.Write(world.RightWorld);

            binaryWriter.Write(world.TopWorld);

            binaryWriter.Write(world.BottomWorld);

            binaryWriter.Write(world.MaxTilesY);

            binaryWriter.Write(world.MaxTilesX);


            if (world.Version >= 209)
            {

                binaryWriter.Write(world.GameMode);


                if (world.Version >= 222)
                {
                    binaryWriter.Write(world.DrunkWorld);
                }
                if (world.Version >= 227)
                {
                    binaryWriter.Write(world.GetGoodWorld);
                }
                if (world.Version >= 238)
                {
                    binaryWriter.Write(world.TenthAnniversaryWorld);
                }
                if (world.Version >= 239)
                {
                    binaryWriter.Write(world.DontStarveWorld);
                }
                if (world.Version >= 241)
                {
                    binaryWriter.Write(world.NotTheBeesWorld);
                }
                if (world.Version >= 249)
                {
                    binaryWriter.Write(world.RemixWorld);
                }
                if (world.Version >= 266)
                {
                    binaryWriter.Write(world.NoTrapsWorld);
                }
                if (world.Version >= 266)
                {
                    binaryWriter.Write(world.ZenithWorld);
                }
            }
            else if (world.Version == 208)
            {
                binaryWriter.Write((bool)(world.GameMode == 2)); // true = Master: 2, else false

            }
            else if (world.Version >= 112)
            {
                binaryWriter.Write((bool)(world.GameMode == 1)); // true = expert: 1, else false

            }

            if (world.Version >= 141)
            {
                binaryWriter.Write(world.CreationTime);
            }

            // check if target moonType is over max
            if (world.MoonType > WorldProperty.GetVersionData(world.Version).MaxMoonId)
            {
                // target is out of range, reset to zero
                binaryWriter.Write((byte)0);
            }
            else
            {
                binaryWriter.Write((byte)world.MoonType);
            }
            binaryWriter.Write(world.TreeX[0]);
            binaryWriter.Write(world.TreeX[1]);
            binaryWriter.Write(world.TreeX[2]);
            binaryWriter.Write(world.TreeStyle[0]);
            binaryWriter.Write(world.TreeStyle[1]);
            binaryWriter.Write(world.TreeStyle[2]);
            binaryWriter.Write(world.TreeStyle[3]);
            binaryWriter.Write(world.CaveBackX[0]);
            binaryWriter.Write(world.CaveBackX[1]);
            binaryWriter.Write(world.CaveBackX[2]);
            binaryWriter.Write(world.CaveBackStyle[0]);
            binaryWriter.Write(world.CaveBackStyle[1]);
            binaryWriter.Write(world.CaveBackStyle[2]);
            binaryWriter.Write(world.CaveBackStyle[3]);
            binaryWriter.Write(world.IceBackStyle);
            binaryWriter.Write(world.JungleBackStyle);
            binaryWriter.Write(world.HellBackStyle);
            binaryWriter.Write(world.SpawnTileX);
            binaryWriter.Write(world.SpawnTileY);
            binaryWriter.Write(world.SurfaceLayer);
            binaryWriter.Write(world.RockLayer);
            binaryWriter.Write(world.Time);
            binaryWriter.Write(world.DayTime);
            binaryWriter.Write(world.MoonPhase);
            binaryWriter.Write(world.BloodMoon);
            binaryWriter.Write(world.Eclipse);
            binaryWriter.Write(world.DungeonX);
            binaryWriter.Write(world.DungeonY);
            binaryWriter.Write(world.Crimson);
            binaryWriter.Write(world.DownedBoss1);
            binaryWriter.Write(world.DownedBoss2);
            binaryWriter.Write(world.DownedBoss3);
            binaryWriter.Write(world.DownedQueenBee);
            binaryWriter.Write(world.DownedMechBoss1);
            binaryWriter.Write(world.DownedMechBoss2);
            binaryWriter.Write(world.DownedMechBoss3);
            binaryWriter.Write(world.DownedMechBossAny);
            binaryWriter.Write(world.DownedPlantBoss);
            binaryWriter.Write(world.DownedGolemBoss);

            if (world.Version >= 118)
            {
                binaryWriter.Write(world.DownedSlimeKingBoss);
            }

            binaryWriter.Write(world.SavedGoblin);
            binaryWriter.Write(world.SavedWizard);
            binaryWriter.Write(world.SavedMech);
            binaryWriter.Write(world.DownedGoblins);
            binaryWriter.Write(world.DownedClown);
            binaryWriter.Write(world.DownedFrost);
            binaryWriter.Write(world.DownedPirates);
            binaryWriter.Write(world.ShadowOrbSmashed);
            binaryWriter.Write(world.SpawnMeteor);
            binaryWriter.Write((byte)world.ShadowOrbCount);

            binaryWriter.Write(world.AltarCount);
            binaryWriter.Write(world.HardMode);

            if (world.Version >= 257)
            {
                binaryWriter.Write(world.AfterPartyOfDoom);
            }

            binaryWriter.Write(world.InvasionDelay);
            binaryWriter.Write(world.InvasionSize);
            binaryWriter.Write(world.InvasionType);
            binaryWriter.Write(world.InvasionX);

            if (world.Version >= 118)
            {
                binaryWriter.Write(world.SlimeRainTime);

            }

            if (world.Version >= 113)
            {
                binaryWriter.Write((byte)world.SundialCooldown);
            }

            binaryWriter.Write(world.Raining);
            binaryWriter.Write(world.RainTime);
            binaryWriter.Write(world.MaxRain);
            binaryWriter.Write(world.SavedOreTiersCobalt);
            binaryWriter.Write(world.SavedOreTiersMythril);
            binaryWriter.Write(world.SavedOreTiersAdamantite);
            binaryWriter.Write(world.TreeBG);
            binaryWriter.Write(world.CorruptBG);
            binaryWriter.Write(world.JungleBG);
            binaryWriter.Write(world.SnowBG);
            binaryWriter.Write(world.HallowBG);
            binaryWriter.Write(world.CrimsonBG);
            binaryWriter.Write(world.DesertBG);
            binaryWriter.Write(world.OceanBG);
            binaryWriter.Write(world.CloudBGActive);

            binaryWriter.Write(world.NumClouds);
            binaryWriter.Write(world.WindSpeedTarget);

            if (world.Version < 95)
            {
                return (int)binaryWriter.BaseStream.Position;
            }

            binaryWriter.Write(world.AnglerWhoFinishedToday.Count);


            foreach (string angler in world.AnglerWhoFinishedToday)
            {
                binaryWriter.Write(angler);
            }

            if (world.Version < 99)
            {
                return (int)binaryWriter.BaseStream.Position;
            }

            binaryWriter.Write(world.SavedAngler);

            if (world.Version < 101)
            {
                return (int)binaryWriter.BaseStream.Position;
            }

            binaryWriter.Write(world.AnglerQuest);

            if (world.Version < 104)
            {
                return (int)binaryWriter.BaseStream.Position;
            }

            if (world.Version > 104)
            {
                binaryWriter.Write(world.SavedStylist);
            }

            if (world.Version >= 129)
            {
                binaryWriter.Write(world.SavedTaxCollector);
            }
            if (world.Version >= 201)
            {
                binaryWriter.Write(world.SavedGolfer);
            }
            if (world.Version >= 107)
            {
                binaryWriter.Write(world.InvasionSizeStart);
            }

            if (world.Version >= 108)
            {
                binaryWriter.Write(world.CultistDelay);
            }

            if (world.Version < 109)
            {
                return (int)binaryWriter.BaseStream.Position;
            }

            var maxNPCId = WorldProperty.GetVersionData(world.Version).MaxNpcId;
            binaryWriter.Write((short)(maxNPCId + 1));
            for (int i = 0; i <= maxNPCId; i++)
            {
                if (world.KillCount.Length > i)
                {
                    binaryWriter.Write(world.KillCount[i]);
                }
                else
                {
                    binaryWriter.Write(0);
                }
            }

            if (world.Version < 128)
            {
                return (int)binaryWriter.BaseStream.Position;
            }

            if (world.Version >= 140)
            {
                binaryWriter.Write(world.FastForwardTimeToDawn);
            }

            if (world.Version < 131)
            {
                return (int)binaryWriter.BaseStream.Position;
            }

            binaryWriter.Write(world.DownedFishron);

            if (world.Version >= 140)
            {
                binaryWriter.Write(world.DownedMartians);
                binaryWriter.Write(world.DownedLunaticCultist);
                binaryWriter.Write(world.DownedMoonlord);
            }

            binaryWriter.Write(world.DownedHalloweenKing);
            binaryWriter.Write(world.DownedHalloweenTree);
            binaryWriter.Write(world.DownedChristmasIceQueen);

            if (world.Version < 140)
            {
                return (int)binaryWriter.BaseStream.Position;
            }

            binaryWriter.Write(world.DownedChristmasSantank);
            binaryWriter.Write(world.DownedChristmasTree);

            if (world.Version >= 140)
            {
                binaryWriter.Write(world.DownedTowerSolar);
                binaryWriter.Write(world.DownedTowerVortex);
                binaryWriter.Write(world.DownedTowerNebula);
                binaryWriter.Write(world.DownedTowerStardust);
                binaryWriter.Write(world.TowerActiveSolar);
                binaryWriter.Write(world.TowerActiveVortex);
                binaryWriter.Write(world.TowerActiveNebula);
                binaryWriter.Write(world.TowerActiveStardust);
                binaryWriter.Write(world.LunarApocalypseIsUp);
            }

            if (world.Version >= 170)
            {
                binaryWriter.Write(world.PartyManual);
                binaryWriter.Write(world.PartyGenuine);
                binaryWriter.Write(world.PartyCooldown);

                binaryWriter.Write(world.PartyCelebratingNPCs.Count);

                foreach (int partier in world.PartyCelebratingNPCs)
                {
                    binaryWriter.Write(partier);
                }

            }

            if (world.Version >= 174)
            {
                binaryWriter.Write(world.SandStormHappening);
                binaryWriter.Write(world.SandStormTimeLeft);
                binaryWriter.Write(world.SandStormSeverity);
                binaryWriter.Write(world.SandStormIntendedSeverity);
            }

            if (world.Version >= 178)
            {
                binaryWriter.Write(world.SavedBartender);
                binaryWriter.Write(world.DownedInvasionT1);
                binaryWriter.Write(world.DownedInvasionT2);
                binaryWriter.Write(world.DownedInvasionT3);
            }

            // 1.4 Journey's End
            if (world.Version > 194)
            {
                binaryWriter.Write((byte)world.MushroomBG);

            }

            if (world.Version >= 215)
            {
                binaryWriter.Write((byte)world.UnderworldBG);

            }

            if (world.Version >= 195)
            {
                binaryWriter.Write((byte)world.TreeBG2);

                binaryWriter.Write((byte)world.TreeBG3);

                binaryWriter.Write((byte)world.TreeBG4);

            }

            if (world.Version >= 204)
            {
                binaryWriter.Write(world.CombatBookWasUsed);
            }

            if (world.Version >= 207)
            {
                binaryWriter.Write(world.LanternNightCooldown);
                binaryWriter.Write(world.LanternNightGenuine);
                binaryWriter.Write(world.LanternNightManual);
                binaryWriter.Write(world.LanternNightNextNightIsGenuine);
            }

            if (world.Version >= 211)
            {
                // tree tops
                binaryWriter.Write(world.TreeTopVariations.Length);

                for (int i = 0; i < world.TreeTopVariations.Length; i++)
                {
                    binaryWriter.Write(world.TreeTopVariations[i]);
                }
            }

            if (world.Version >= 212)
            {
                binaryWriter.Write(world.ForceHalloweenForToday);
                binaryWriter.Write(world.ForceXMasForToday);
            }

            if (world.Version >= 216)
            {
                binaryWriter.Write(world.SavedOreTiersCopper);
                binaryWriter.Write(world.SavedOreTiersIron);
                binaryWriter.Write(world.SavedOreTiersSilver);
                binaryWriter.Write(world.SavedOreTiersGold);
            }

            if (world.Version >= 217)
            {
                binaryWriter.Write(world.BoughtCat);
                binaryWriter.Write(world.BoughtDog);
                binaryWriter.Write(world.BoughtBunny);
            }

            if (world.Version >= 223)
            {
                binaryWriter.Write(world.DownedEmpressOfLight);
                binaryWriter.Write(world.DownedQueenSlime);
            }

            if (world.Version >= 240)
            {
                binaryWriter.Write(world.DownedDeerclops);
            }

            if (world.Version >= 250)
            {
                binaryWriter.Write(world.UnlockedSlimeBlueSpawn);
            }

            if (world.Version >= 251)
            {
                binaryWriter.Write(world.UnlockedMerchantSpawn);
                binaryWriter.Write(world.UnlockedDemolitionistSpawn);
                binaryWriter.Write(world.UnlockedPartyGirlSpawn);
                binaryWriter.Write(world.UnlockedDyeTraderSpawn);
                binaryWriter.Write(world.UnlockedTruffleSpawn);
                binaryWriter.Write(world.UnlockedArmsDealerSpawn);
                binaryWriter.Write(world.UnlockedNurseSpawn);
                binaryWriter.Write(world.UnlockedPrincessSpawn);
            }

            if (world.Version >= 259)
            {
                binaryWriter.Write(world.CombatBookVolumeTwoWasUsed);
            }

            if (world.Version >= 260)
            {
                binaryWriter.Write(world.PeddlersSatchelWasUsed);
            }

            if (world.Version >= 261)
            {
                binaryWriter.Write(world.UnlockedSlimeGreenSpawn);
                binaryWriter.Write(world.UnlockedSlimeOldSpawn);
                binaryWriter.Write(world.UnlockedSlimePurpleSpawn);
                binaryWriter.Write(world.UnlockedSlimeRainbowSpawn);
                binaryWriter.Write(world.UnlockedSlimeRedSpawn);
                binaryWriter.Write(world.UnlockedSlimeYellowSpawn);
                binaryWriter.Write(world.UnlockedSlimeCopperSpawn);
            }

            if (world.Version >= 264)
            {
                binaryWriter.Write(world.FastForwardTimeToDusk);
                binaryWriter.Write((byte)world.MoondialCooldown);
            }

            return (int)binaryWriter.BaseStream.Position;
        }
        private static void LoadWorldTiles(BinaryReader binaryReader, World world, bool[] tileFrameImportant)
        {
            world.Tile = TileFile.Load(binaryReader, world.MaxTilesX, world.MaxTilesY, world.Version, tileFrameImportant);
        }
        private static int SaveWorldTiles(BinaryWriter binaryWriter, World world, bool[] tileFrameImportant)
        {
            return TileFile.Save(world.Tile, binaryWriter, world.MaxTilesX, world.MaxTilesY, world.Version, tileFrameImportant);
        }
        private static void LoadChests(BinaryReader binaryReader, World world)
        {
            world.Chest.AddRange(ChestFile.Load(binaryReader));
        }
        private static int SaveChests(BinaryWriter binaryWriter, World world)
        {
            return ChestFile.Save(world.Chest, binaryWriter, world.Version);
        }
        private static void LoadSigns(BinaryReader binaryReader, World world)
        {
            world.Sign.AddRange(SignFile.Load(binaryReader));
        }
        private static int SaveSigns(BinaryWriter binaryWriter, World world)
        {
            return SignFile.Save(world.Sign, binaryWriter, world.Version);
        }
        private static void LoadNPCs(BinaryReader binaryReader, World world)
        {
            world.NPC.AddRange(NPCFile.Load(binaryReader, world.Version));
        }
        private static int SaveNPCs(BinaryWriter binaryWriter, World world)
        {
            return NPCFile.Save(world.NPC, binaryWriter, world.Version);
        }
        private static void LoadTileEntities(BinaryReader binaryReader, World world)
        {
            if (world.Version < 122)
            {
                TileEntityFile.LoadDummies(binaryReader);
            }
            else
            {
                world.TileEntity.AddRange(TileEntityFile.Load(binaryReader));
            }
        }
        private static int SaveTileEntities(BinaryWriter binaryWriter, World world)
        {
            return TileEntityFile.Save(world.TileEntity, binaryWriter);
        }
        private static void LoadWeightedPressurePlates(BinaryReader binaryReader, World world)
        {
            world.PressurePlate.AddRange(PressurePlateFile.Load(binaryReader));
        }
        private static int SaveWeightedPressurePlates(BinaryWriter binaryWriter, World world)
        {
            return PressurePlateFile.Save(world.PressurePlate, binaryWriter);
        }
        private static void LoadTownManager(BinaryReader binaryReader, World world)
        {
            world.TownManager.AddRange(TownRoomManagerFile.Load(binaryReader));
        }
        private static int SaveTownManager(BinaryWriter binaryWriter, World world)
        {
            return TownRoomManagerFile.Save(world.TownManager, binaryWriter, world.Version);
        }
        private static void LoadBestiary(BinaryReader binaryReader, World world)
        {
            world.Bestiary = BestiaryFile.Load(binaryReader);
        }
        private static int SaveBestiary(BinaryWriter binaryWriter, World world)
        {
            return BestiaryFile.Save(world.Bestiary, binaryWriter);
        }
        private static void LoadCreativePowers(BinaryReader binaryReader, World world)
        {
            world.CreativePowerManager = CreativePowerManagerFile.Load(binaryReader);
        }
        private static int SaveCreativePowers(BinaryWriter binaryWriter, World world)
        {
            return CreativePowerManagerFile.Save(world.CreativePowerManager, binaryWriter);
        }
        private static void LoadFooter(BinaryReader binaryReader, World world)
        {
            if (!binaryReader.ReadBoolean())
                throw new FileFormatException("Invalid Footer");

            if (binaryReader.ReadString() != world.Name)
                throw new FileFormatException("Invalid Footer");

            if (binaryReader.ReadInt32() != world.ID)
                throw new FileFormatException("Invalid Footer");
        }
        private static int SaveFooter(BinaryWriter binaryWriter, World world)
        {
            binaryWriter.Write(true);
            binaryWriter.Write(world.Name);
            binaryWriter.Write(world.ID);

            return (int)binaryWriter.BaseStream.Position;
        }
        private static bool[] ReadBitArray(BinaryReader reader)
        {
            // get the number of bits
            int length = reader.ReadInt16();

            // read the bit data
            var booleans = new bool[length];
            byte data = 0;
            byte bitMask = 128;
            for (int i = 0; i < length; i++)
            {
                // If we read the last bit mask (B1000000 = 0x80 = 128), read the next byte from the stream and start the mask over.
                // Otherwise, keep incrementing the mask to get the next bit.
                if (bitMask != 128)
                {
                    bitMask = (byte)(bitMask << 1);
                }
                else
                {
                    data = reader.ReadByte();
                    bitMask = 1;
                }

                // Check the mask, if it is set then set the current boolean to true
                if ((data & bitMask) == bitMask)
                {
                    booleans[i] = true;
                }
            }

            return booleans;
        }
        private static void WriteBitArray(BinaryWriter writer, bool[] values)
        {
            // write the number of bits
            writer.Write((Int16)values.Length);

            // write the bit data
            byte data = 0;
            byte bitMask = 1;
            for (int i = 0; i < values.Length; i++)
            {
                // Check if the current value is true, if it is set then set the bit for the current mask in the data byte.
                if (values[i])
                {
                    data = (byte)(data | bitMask);
                }

                // If we wrote the last bit mask (B1000000 = 0x80 = 128), write the data byte to the stream and start the mask over.
                // Otherwise, keep incrementing the mask to write the next bit.
                if (bitMask != 128)
                {
                    bitMask = (byte)(bitMask << 1);
                }
                else
                {
                    writer.Write(data);
                    data = 0;
                    bitMask = 1;
                }
            }

            // Write any remaning data in the buffer.
            if (bitMask != 1)
            {
                writer.Write(data);
            }
        }
    }
}
