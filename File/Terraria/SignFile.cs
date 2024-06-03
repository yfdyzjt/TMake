using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMake.Terraria;

namespace TMake.File
{
    public static class SignFile
    {
        public static Sign[] Load(BinaryReader binaryReader)
        {
            short totalSigns = binaryReader.ReadInt16();
            var signs = new Sign[totalSigns];

            for (int i = 0; i < totalSigns; i++)
            {
                signs[i] = new()
                {
                    Text = binaryReader.ReadString(),
                    X = binaryReader.ReadInt32(),
                    Y = binaryReader.ReadInt32()
                };
            }
            return signs;
        }
        public static int Save(IList<Sign> signs, BinaryWriter bw, uint version)
        {
            bool useLegacyLimit = version < 216;
            Int16 count = useLegacyLimit ? (Int16)Math.Min(signs.Count, WorldProperty.MaxSigns) : (Int16)signs.Count;
            bw.Write(count);

            int written = 0;
            foreach (Sign sign in signs)
            {
                if (sign.Text != null)
                {
                    bw.Write(sign.Text);
                    bw.Write(sign.X);
                    bw.Write(sign.Y);
                }
                written++;
                if (useLegacyLimit && written >= WorldProperty.MaxSigns) { break; }
            }

            return (int)bw.BaseStream.Position;
        }
    }
}
