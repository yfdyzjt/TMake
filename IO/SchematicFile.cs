using TMake.Terraria;

namespace TMake.IO
{
    public class SchematicFile
    {
        public static Schematic Load(string filename)
        {
            Schematic sch = new();

            try
            {
                using var fileStream = new FileStream(filename, FileMode.Open);
                using var binaryReader = new BinaryReader(fileStream);

                string name = binaryReader.ReadString();
                int version = binaryReader.ReadInt32();

                if (version > 10000)
                {
                    version -= 10000;
                    LoadV4(sch, binaryReader);
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

            return sch;
        }
        public static void Save(Schematic sch, string filename)
        {
            try
            {
                using var fileStream = new FileStream(filename, FileMode.Create);
                using var binaryWriter = new BinaryWriter(fileStream);

                SaveV4(sch, binaryWriter);
            }
            catch
            {
                throw;
            }
        }
        private static void LoadV4(Schematic sch, BinaryReader br)
        {
            br.BaseStream.Position = 0L;

            sch.Name = br.ReadString();
            sch.Version = br.ReadUInt32() - 10000;

            var tileFrameImportant = ReadBitArray(br);
            sch.MaxTilesX = br.ReadInt32();
            sch.MaxTilesY = br.ReadInt32();

            sch.Tile = TileFile.Load(br, sch.MaxTilesX, sch.MaxTilesY, sch.Version, tileFrameImportant);
            sch.Chest.AddRange(ChestFile.Load(br));
            sch.Sign.AddRange(SignFile.Load(br));
            sch.TileEntity.AddRange(TileEntityFile.Load(br));

            string verifyName = br.ReadString();
            int verifyVersion = br.ReadInt32();
            int verifyX = br.ReadInt32();
            int verifyY = br.ReadInt32();

            if (sch.Name != verifyName ||
                sch.Version != verifyVersion ||
                sch.MaxTilesX != verifyX ||
                sch.MaxTilesY != verifyY)
            {
                throw new FileFormatException("Invalid Footer");
            }
        }
        private static void SaveV4(Schematic sch, BinaryWriter bw)
        {
            var tileFrameImportant = WorldProperty.GetVersionData(sch.Version).TileFrameImportant;

            bw.Write(sch.Name);
            bw.Write(sch.Version + 10000);
            WriteBitArray(bw, tileFrameImportant);
            bw.Write(sch.MaxTilesX);
            bw.Write(sch.MaxTilesY);

            TileFile.Save(sch.Tile, bw, sch.MaxTilesX, sch.MaxTilesY, sch.Version, tileFrameImportant);
            ChestFile.Save(sch.Chest, bw, sch.Version);
            SignFile.Save(sch.Sign, bw, sch.Version);
            TileEntityFile.Save(sch.TileEntity, bw);

            bw.Write(sch.Name);
            bw.Write(sch.Version);
            bw.Write(sch.MaxTilesX);
            bw.Write(sch.MaxTilesY);
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
