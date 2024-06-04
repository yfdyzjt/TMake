using TMake.Terraria;

namespace TMake.File
{
    public static class TileEntityFile
    {
        public static void LoadDummies(BinaryReader reader)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                reader.ReadInt16();
                reader.ReadInt16();
            }
        }
        public static TileEntity[] Load(BinaryReader reader)
        {
            int numEntities = reader.ReadInt32();
            var entities = new TileEntity[numEntities];
            for (int i = 0; i < numEntities; i++)
            {
                TileEntity entity = new()
                {
                    Type = reader.ReadByte(),
                    ID = reader.ReadInt32(),
                    Position = new Point16(reader.ReadInt16(), reader.ReadInt16())
                };

                switch ((TileEntityType)entity.Type)
                {
                    case TileEntityType.TrainingDummy: //it is a dummy
                        LoadTrainingDummy(reader, entity);
                        break;
                    case TileEntityType.ItemFrame: //it is a item frame
                        LoadStack(reader, entity);
                        break;
                    case TileEntityType.LogicSensor: //it is a logic sensor
                        LoadLogicCheck(reader, entity);
                        break;
                    case TileEntityType.DisplayDoll: // display doll
                        LoadDisplayDoll(reader, entity);
                        break;
                    case TileEntityType.WeaponRack: // weapons rack 
                        LoadStack(reader, entity);
                        break;
                    case TileEntityType.HatRack: // hat rack 
                        LoadHatRack(reader, entity);
                        break;
                    case TileEntityType.FoodPlatter: // food platter
                        LoadStack(reader, entity);
                        break;
                    case TileEntityType.TeleportationPylon: // teleportation pylon
                        break;
                }

                entities[i] = entity;
            }
            return entities;
        }
        public static int Save(IList<TileEntity> tileEntities, BinaryWriter bw)
        {
            bw.Write(tileEntities.Count);

            foreach (TileEntity tentity in tileEntities)
            {
                bw.Write(tentity.Type);
                bw.Write(tentity.ID);
                bw.Write(tentity.Position.X);
                bw.Write(tentity.Position.Y);
                switch (tentity.Type)
                {
                    case (byte)TileEntityType.TrainingDummy: //it is a dummy
                        SaveTrainingDummy(bw, tentity);
                        break;
                    case (byte)TileEntityType.ItemFrame: //it is a item frame
                        SaveStack(bw, tentity);
                        break;
                    case (byte)TileEntityType.LogicSensor: //it is a logic sensor
                        SaveLogicCheck(bw, tentity);
                        break;
                    case (byte)TileEntityType.DisplayDoll: // display doll
                        SaveDisplayDoll(bw, tentity);
                        break;
                    case (byte)TileEntityType.WeaponRack: // weapons rack 
                        SaveStack(bw, tentity);
                        break;
                    case (byte)TileEntityType.HatRack: // hat rack 
                        SaveHatRack(bw, tentity);
                        break;
                    case (byte)TileEntityType.FoodPlatter: // food platter
                        SaveStack(bw, tentity);
                        break;
                    case (byte)TileEntityType.TeleportationPylon: // teleportation pylon

                        break;
                }
            }


            return (int)bw.BaseStream.Position;
        }
        private static void LoadTrainingDummy(BinaryReader r, TileEntity e)
        {
            e.NPC.Type = r.ReadInt16();
        }
        private static void SaveTrainingDummy(BinaryWriter w, TileEntity e)
        {
            w.Write((short)e.NPC.Type);
        }
        private static void LoadStack(BinaryReader r, TileEntity e)
        {
            e.Item.Type = r.ReadInt16();
            e.Item.Prefix = r.ReadByte();
            e.Item.StackSize = r.ReadInt16();
        }
        private static void SaveStack(BinaryWriter w, TileEntity e)
        {
            w.Write((short)e.Item.Type);
            w.Write(e.Item.Prefix);
            w.Write((short)e.Item.StackSize);
        }
        private static void LoadLogicCheck(BinaryReader r, TileEntity e)
        {
            e.LogicCheck = r.ReadByte();
            e.On = r.ReadBoolean();
        }
        private static void SaveLogicCheck(BinaryWriter w, TileEntity e)
        {
            w.Write(e.LogicCheck);
            w.Write(e.On);
        }
        public static void LoadDisplayDoll(BinaryReader r, TileEntity e)
        {
            byte numSlots = 8;
            var itemSlots = (BitsByte)r.ReadByte();
            var dyeSlots = (BitsByte)r.ReadByte();
            e.Items = new Item[numSlots];
            e.Dyes = new Item[numSlots];
            for (int i = 0; i < numSlots; i++)
            {
                if (itemSlots[i])
                {
                    e.Items[i] = new Item
                    {
                        Type = r.ReadInt16(),
                        Prefix = r.ReadByte(),
                        StackSize = r.ReadInt16()
                    };
                }
            }
            for (int i = 0; i < numSlots; i++)
            {
                if (dyeSlots[i])
                {
                    e.Dyes[i] = new Item
                    {
                        Type = r.ReadInt16(),
                        Prefix = r.ReadByte(),
                        StackSize = r.ReadInt16()
                    };
                }
            }
        }
        private static void SaveDisplayDoll(BinaryWriter w, TileEntity e)
        {
            byte numSlots = 8;
            var items = new BitsByte();
            var dyes = new BitsByte();
            for (int i = 0; i < numSlots; i++)
            {
                items[i] = e.Items[i]?.IsValid ?? false;
            }
            for (int i = 0; i < numSlots; i++)
            {
                dyes[i] = e.Dyes[i]?.IsValid ?? false;
            }

            w.Write((byte)items);
            w.Write((byte)dyes);

            for (int i = 0; i < numSlots; i++)
            {
                if (items[i])
                {
                    w.Write((short)e.Items[i].Type);
                    w.Write(e.Items[i].Prefix);
                    w.Write((short)e.Items[i].StackSize);
                }
            }
            for (int i = 0; i < numSlots; i++)
            {
                if (dyes[i])
                {
                    w.Write((short)e.Dyes[i].Type);
                    w.Write(e.Dyes[i].Prefix);
                    w.Write((short)e.Dyes[i].StackSize);
                }
            }
        }
        public static void LoadHatRack(BinaryReader r, TileEntity e)
        {
            byte numSlots = 2;
            var slots = (BitsByte)r.ReadByte();
            e.Items = new Item[numSlots];
            e.Dyes = new Item[numSlots];
            for (int i = 0; i < numSlots; i++)
            {
                if (slots[i])
                {
                    e.Items[i] = new Item
                    {
                        Type = r.ReadInt16(),
                        Prefix = r.ReadByte(),
                        StackSize = r.ReadInt16()
                    };
                }
            }
            for (int i = 0; i < numSlots; i++)
            {
                if (slots[i + 2])
                {
                    e.Dyes[i] = new Item
                    {
                        Type = r.ReadInt16(),
                        Prefix = r.ReadByte(),
                        StackSize = r.ReadInt16()
                    };
                }
            }
        }
        private static void SaveHatRack(BinaryWriter w, TileEntity e)
        {
            byte numSlots = 2;
            var slots = new BitsByte();
            for (int i = 0; i < numSlots; i++)
            {
                slots[i] = e.Items[i]?.IsValid ?? false;
            }
            for (int i = 0; i < numSlots; i++)
            {
                slots[i + 2] = e.Dyes[i]?.IsValid ?? false;
            }

            w.Write((byte)slots);

            for (int i = 0; i < numSlots; i++)
            {
                if (slots[i])
                {
                    w.Write((short)e.Items[i].Type);
                    w.Write(e.Items[i].Prefix);
                    w.Write((short)e.Items[i].StackSize);
                }
            }
            for (int i = 0; i < numSlots; i++)
            {
                if (slots[i + 2])
                {
                    w.Write((short)e.Dyes[i].Type);
                    w.Write(e.Dyes[i].Prefix);
                    w.Write((short)e.Dyes[i].StackSize);
                }
            }
        }
    }
}
