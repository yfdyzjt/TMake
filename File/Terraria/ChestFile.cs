using TMake.Terraria;

namespace TMake.File
{
    public static class ChestFile
    {
        public static Chest[] Load(BinaryReader binaryReader)
        {
            int totalChests = binaryReader.ReadInt16();
            int maxItems = binaryReader.ReadInt16();
            int itemsPerChest;
            int overflowItems;

            Chest[] chests = new Chest[totalChests];

            if (maxItems > ChestProperty.MaxItems)
            {
                itemsPerChest = ChestProperty.MaxItems;
                overflowItems = maxItems - ChestProperty.MaxItems;
            }
            else
            {
                itemsPerChest = maxItems;
                overflowItems = 0;
            }

            for (int i = 0; i < totalChests; i++)
            {
                Chest chest = new()
                {
                    X = binaryReader.ReadInt32(),
                    Y = binaryReader.ReadInt32(),
                    Name = binaryReader.ReadString()
                };

                for (int slot = 0; slot < itemsPerChest; slot++)
                {
                    short stackSize = binaryReader.ReadInt16();
                    chest.Item[slot].StackSize = stackSize;

                    if (stackSize > 0)
                    {
                        int id = binaryReader.ReadInt32();
                        byte prefix = binaryReader.ReadByte();

                        chest.Item[slot].Type = id;
                        chest.Item[slot].StackSize = stackSize;
                        chest.Item[slot].Prefix = prefix;
                    }
                }

                for (int overflow = 0; overflow < overflowItems; overflow++)
                {
                    var stackSize = binaryReader.ReadInt16();
                    if (stackSize > 0)
                    {
                        binaryReader.ReadInt32();
                        binaryReader.ReadByte();
                    }
                }

                chests[i] = chest;
            }

            return chests;
        }
        public static int Save(IList<Chest> chests, BinaryWriter bw, uint version)
        {
            bool useLegacyLimit = version < 216;
            Int16 count = useLegacyLimit ? (Int16)Math.Min(chests.Count, WorldProperty.MaxChests) : (Int16)chests.Count;
            bw.Write(count);
            bw.Write((Int16)ChestProperty.MaxItems);

            int written = 0;
            foreach (Chest chest in chests)
            {
                bw.Write(chest.X);
                bw.Write(chest.Y);
                bw.Write(chest.Name ?? string.Empty);

                for (int slot = 0; slot < ChestProperty.MaxItems; slot++)
                {
                    Item item = chest.Item[slot];

                    // check if target version allows item.
                    if (item != null && item.Type <= WorldProperty.GetVersionData(version).MaxItemId)
                    {
                        bw.Write((short)item.StackSize);
                        if (item.StackSize > 0)
                        {
                            bw.Write(item.Type);
                            bw.Write(item.Prefix);
                        }
                    }
                    else
                    {
                        bw.Write((short)0);
                    }
                }
                written++;
                if (useLegacyLimit && written >= WorldProperty.MaxChests) { break; }
            }

            return (int)bw.BaseStream.Position;
        }
    }
}
