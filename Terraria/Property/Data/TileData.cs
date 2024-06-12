using System.Drawing;

namespace TMake.Terraria
{
    public class TileData
    {
        public ushort Type { get; set; }
        public string Name { get; set; } = "";
        public Point TextureGrid { get; set; } = new Point(16, 16);
        public bool Solid { get; set; } = false;
        public bool SaveSlope { get; set; } = false;
        public bool HasSlopes => Solid || SaveSlope;
    }
}
