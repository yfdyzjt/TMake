using System.Drawing;

namespace TMake.Terraria
{
    public interface ITileData
    {
        string Name { get; set; }
        ushort Type { get; set; }
        Color Color { get; set; }
    }
}
