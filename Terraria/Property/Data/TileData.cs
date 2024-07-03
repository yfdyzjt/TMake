using System.Drawing;

namespace TMake.Terraria
{
    public class TileData
    {
        public ushort Type { get; set; }
        public string Name { get; set; } = string.Empty;
        public Point TextureGrid { get; set; } = new Point(16, 16);
        public bool Framed { get; set; } = false;
        public bool Solid { get; set; } = false;
        public bool SaveSlope { get; set; } = false;
        public bool HasSlopes => Solid || SaveSlope;
        public Color Color { get; set; } = Color.Magenta;
        public List<FrameData> Frames { get; set; } = [];
    }
}
