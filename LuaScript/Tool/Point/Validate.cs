using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        internal static void Validate<T>(T area, Point position) where T : ITileArea
        {
            if (!new Rectangle(0, 0, area.MaxTilesX, area.MaxTilesY).Contains(position))
                throw new ArgumentOutOfRangeException(nameof(position), $"Missing Tile: {position}");
        }
    }
}
