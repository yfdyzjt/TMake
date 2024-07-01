using System.Drawing;
using TMake.Terraria;

namespace TMake.IO
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
