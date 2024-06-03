using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMake.Terraria;

namespace TMake.File
{
    public static class PressurePlateFile
    {
        public static PressurePlate[] Load(BinaryReader reader)
        {
            int count = reader.ReadInt32();
            PressurePlate[] pressurePlates = new PressurePlate[count];
            for (int counter = 0; counter < count; counter++)
            {
                pressurePlates[counter].Key = new Point(reader.ReadInt32(), reader.ReadInt32());
            }
            return pressurePlates;
        }
        public static int Save(IList<PressurePlate> plates, BinaryWriter bw)
        {
            bw.Write(plates.Count);

            foreach (PressurePlate plate in plates)
            {
                bw.Write(plate.Key.X);
                bw.Write(plate.Key.Y);
            }

            return (int)bw.BaseStream.Position;
        }
    }
}
