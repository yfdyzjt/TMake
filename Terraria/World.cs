namespace TMake.Terraria
{
    public class World : ITileArea
    {
        public Tile[,] Tile { get; set; } = new Tile[0, 0];
        public List<Chest> Chest { get; set; } = [];
        public List<Sign> Sign { get; set; } = [];
        public List<NPC> NPC { get; set; } = [];
        public List<TileEntity> TileEntity { get; set; } = [];
        public List<PressurePlate> PressurePlate { get; set; } = [];
        public List<TownRoomManager> TownManager { get; set; } = [];
        public Bestiary Bestiary { get; set; } = new();
        public CreativePowerManager CreativePowerManager { get; set; } = new();

        public uint Version { get; set; }
        public bool IsChinese { get; set; }
        public uint Revision { get; set; }
        public bool IsFavorite { get; set; }
        public string Name { get; set; } = "";
        public string Seed { get; set; } = "";
        public ulong WorldGenVersion { get; set; }
        public Guid Guid { get; set; }
        public int ID { get; set; }
        public int LeftWorld { get; set; }
        public int RightWorld { get; set; }
        public int TopWorld { get; set; }
        public int BottomWorld { get; set; }
        public int MaxTilesY { get; set; }
        public int MaxTilesX { get; set; }
        public int GameMode { get; set; }
        public bool DrunkWorld { get; set; }
        public bool GetGoodWorld { get; set; }
        public bool TenthAnniversaryWorld { get; set; }
        public bool DontStarveWorld { get; set; }
        public bool NotTheBeesWorld { get; set; }
        public bool RemixWorld { get; set; }
        public bool NoTrapsWorld { get; set; }
        public bool ZenithWorld { get; set; }
        public long CreationTime { get; set; }
        public byte MoonType { get; set; }
        public int[] TreeX { get; set; } = new int[3];
        public int[] TreeStyle { get; set; } = new int[4];
        public int[] CaveBackX { get; set; } = new int[3];
        public int[] CaveBackStyle { get; set; } = new int[4];
        public int IceBackStyle { get; set; }
        public int JungleBackStyle { get; set; }
        public int HellBackStyle { get; set; }
        public int SpawnTileX { get; set; }
        public int SpawnTileY { get; set; }
        public double SurfaceLayer { get; set; }
        public double RockLayer { get; set; }
        public double Time { get; set; }
        public bool DayTime { get; set; }
        public int MoonPhase { get; set; }
        public bool BloodMoon { get; set; }
        public bool Eclipse { get; set; }
        public int DungeonX { get; set; }
        public int DungeonY { get; set; }
        public bool Crimson { get; set; }
        public bool DownedBoss1 { get; set; }
        public bool DownedBoss2 { get; set; }
        public bool DownedBoss3 { get; set; }
        public bool DownedQueenBee { get; set; }
        public bool DownedMechBoss1 { get; set; }
        public bool DownedMechBoss2 { get; set; }
        public bool DownedMechBoss3 { get; set; }
        public bool DownedMechBossAny { get; set; }
        public bool DownedPlantBoss { get; set; }
        public bool DownedGolemBoss { get; set; }
        public bool DownedSlimeKingBoss { get; set; }
        public bool SavedGoblin { get; set; }
        public bool SavedWizard { get; set; }
        public bool SavedMech { get; set; }
        public bool DownedGoblins { get; set; }
        public bool DownedClown { get; set; }
        public bool DownedFrost { get; set; }
        public bool DownedPirates { get; set; }
        public bool ShadowOrbSmashed { get; set; }
        public bool SpawnMeteor { get; set; }
        public byte ShadowOrbCount { get; set; }
        public int AltarCount { get; set; }
        public bool HardMode { get; set; }
        public bool AfterPartyOfDoom { get; set; }
        public int InvasionDelay { get; set; }
        public int InvasionSize { get; set; }
        public int InvasionType { get; set; }
        public double InvasionX { get; set; }
        public double SlimeRainTime { get; set; }
        public byte SundialCooldown { get; set; }
        public bool Raining { get; set; }
        public int RainTime { get; set; }
        public float MaxRain { get; set; }
        public int SavedOreTiersCobalt { get; set; }
        public int SavedOreTiersMythril { get; set; }
        public int SavedOreTiersAdamantite { get; set; }
        public byte TreeBG { get; set; }
        public byte CorruptBG { get; set; }
        public byte JungleBG { get; set; }
        public byte SnowBG { get; set; }
        public byte HallowBG { get; set; }
        public byte CrimsonBG { get; set; }
        public byte DesertBG { get; set; }
        public byte OceanBG { get; set; }
        public int CloudBGActive { get; set; }
        public short NumClouds { get; set; }
        public float WindSpeedTarget { get; set; }
        public List<string> AnglerWhoFinishedToday { get; set; } = [];
        public bool SavedAngler { get; set; }
        public int AnglerQuest { get; set; }
        public bool SavedStylist { get; set; }
        public bool SavedTaxCollector { get; set; }
        public bool SavedGolfer { get; set; }
        public int InvasionSizeStart { get; set; }
        public int CultistDelay { get; set; }
        public int[] KillCount { get; set; } = [];
        public bool FastForwardTimeToDawn { get; set; }
        public bool DownedFishron { get; set; }
        public bool DownedMartians { get; set; }
        public bool DownedLunaticCultist { get; set; }
        public bool DownedMoonlord { get; set; }
        public bool DownedHalloweenKing { get; set; }
        public bool DownedHalloweenTree { get; set; }
        public bool DownedChristmasIceQueen { get; set; }
        public bool DownedChristmasSantank { get; set; }
        public bool DownedChristmasTree { get; set; }
        public bool DownedTowerSolar { get; set; }
        public bool DownedTowerVortex { get; set; }
        public bool DownedTowerNebula { get; set; }
        public bool DownedTowerStardust { get; set; }
        public bool TowerActiveSolar { get; set; }
        public bool TowerActiveVortex { get; set; }
        public bool TowerActiveNebula { get; set; }
        public bool TowerActiveStardust { get; set; }
        public bool LunarApocalypseIsUp { get; set; }
        public bool PartyManual { get; set; }
        public bool PartyGenuine { get; set; }
        public int PartyCooldown { get; set; }
        public List<int> PartyCelebratingNPCs { get; set; } = [];
        public bool SandStormHappening { get; set; }
        public int SandStormTimeLeft { get; set; }
        public float SandStormSeverity { get; set; }
        public float SandStormIntendedSeverity { get; set; }
        public bool SavedBartender { get; set; }
        public bool DownedInvasionT1 { get; set; }
        public bool DownedInvasionT2 { get; set; }
        public bool DownedInvasionT3 { get; set; }
        public byte MushroomBG { get; set; }
        public byte UnderworldBG { get; set; }
        public byte TreeBG2 { get; set; }
        public byte TreeBG3 { get; set; }
        public byte TreeBG4 { get; set; }
        public bool CombatBookWasUsed { get; set; }
        public int LanternNightCooldown { get; set; }
        public bool LanternNightGenuine { get; set; }
        public bool LanternNightManual { get; set; }
        public bool LanternNightNextNightIsGenuine { get; set; }
        public int[] TreeTopVariations { get; set; } = new int[13];
        public bool ForceHalloweenForToday { get; set; }
        public bool ForceXMasForToday { get; set; }
        public int SavedOreTiersCopper { get; set; }
        public int SavedOreTiersIron { get; set; }
        public int SavedOreTiersSilver { get; set; }
        public int SavedOreTiersGold { get; set; }
        public bool BoughtCat { get; set; }
        public bool BoughtDog { get; set; }
        public bool BoughtBunny { get; set; }
        public bool DownedEmpressOfLight { get; set; }
        public bool DownedQueenSlime { get; set; }
        public bool DownedDeerclops { get; set; }
        public bool UnlockedSlimeBlueSpawn { get; set; }
        public bool UnlockedMerchantSpawn { get; set; }
        public bool UnlockedDemolitionistSpawn { get; set; }
        public bool UnlockedPartyGirlSpawn { get; set; }
        public bool UnlockedDyeTraderSpawn { get; set; }
        public bool UnlockedTruffleSpawn { get; set; }
        public bool UnlockedArmsDealerSpawn { get; set; }
        public bool UnlockedNurseSpawn { get; set; }
        public bool UnlockedPrincessSpawn { get; set; }
        public bool CombatBookVolumeTwoWasUsed { get; set; }
        public bool PeddlersSatchelWasUsed { get; set; }
        public bool UnlockedSlimeGreenSpawn { get; set; }
        public bool UnlockedSlimeOldSpawn { get; set; }
        public bool UnlockedSlimePurpleSpawn { get; set; }
        public bool UnlockedSlimeRainbowSpawn { get; set; }
        public bool UnlockedSlimeRedSpawn { get; set; }
        public bool UnlockedSlimeYellowSpawn { get; set; }
        public bool UnlockedSlimeCopperSpawn { get; set; }
        public bool FastForwardTimeToDusk { get; set; }
        public byte MoondialCooldown { get; set; }
    }
}
