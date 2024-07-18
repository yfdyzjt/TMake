using System.Drawing;

namespace TMake.Terraria
{
    public class FrameData
    {
        public ushort Type { get; set; }
        public ushort TileType { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Variety { get; set; } = string.Empty;
        public FrameAnchor Anchor { get; set; } = FrameAnchor.None;
        public Point Size { get; set; } = new(1, 1);
        public Point Origin { get; set; } = new(0, 0);
        public Color Color { get; set; } = Color.Magenta;
    }
}
