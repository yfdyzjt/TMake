using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static void Fill<T>(T area, Rectangle selection, Tile tile, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));
            Fill(area, selection, new(1, 1), (pos, offset) => area.Tile[pos.X, pos.Y] = tile.Copy(), false);
        }
        public static void Fill<T>(T area, Rectangle selection, SpriteData sprite, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));
            Fill(area, selection, sprite.Size, (pos, offset) => { if (offset.X == 0 && offset.Y == 0) PlaceSprite(area, pos, sprite); }, false);
        }
        public static void Fill<T>(T area, Rectangle selection, Point step, Action<Point, Point> func, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));

            Delete(area, selection, false);

            for (int x = selection.Left; x < selection.Right; x += step.X)
            {
                for (int y = selection.Top; y < selection.Bottom; y += step.Y)
                {
                    for (int i = 0; i < step.X; i++)
                    {
                        for (int j = 0; j < step.Y; j++)
                        {
                            func(new(x, y), new(i, j));
                        }
                    }
                }
            }
        }
    }
}
