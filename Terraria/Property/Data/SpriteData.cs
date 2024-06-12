using System.Drawing;

namespace TMake.Terraria
{
    public class SpriteData
    {
        public ushort TileType { get; set; }
        public FrameAnchor Anchor { get; set; } = FrameAnchor.None;
        public Point Size { get; set; } = new(1, 1);
        public Point Origin { get; set; } = new(0, 0);
        public string Name { get; set; } = "";
        public string Variety { get; set; } = "";
    }
}
