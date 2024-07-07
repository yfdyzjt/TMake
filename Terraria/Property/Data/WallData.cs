using System.Drawing;

namespace TMake.Terraria
{
    public class WallData : ITileData
    {
        public ushort Type { get; set; }
        public string Name { get; set; } = string.Empty;
        public Color Color { get; set; } = Color.Transparent;
    }
}
