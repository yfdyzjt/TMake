using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static void Fill<T>(T area, Rectangle selection, Tile tile, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));

            Delete(area, selection, false);

            for (int x = selection.Left; x < selection.Right; x++)
            {
                for (int y = selection.Top; y < selection.Bottom; y++)
                {
                    area.Tile[x, y] = tile.Copy();
                }
            }
        }
    }
}
