using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        internal static void Validate<T>(T area, Rectangle selection) where T : ITileArea
        {
            selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));
        }
    }
}
