using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static void Fill<T>(T area, Rectangle selection, Tile tile) where T : ITileArea
        {
            Validate(area, selection);
            Fill(area, selection, new(1, 1), (pos, offset) => area.Tile[pos.X, pos.Y] = tile.Copy());
        }
        public static void Fill<T>(T area, Rectangle selection, SpriteData sprite) where T : ITileArea
        {
            Validate(area, selection);
            Fill(area, selection, sprite.Size, (pos, offset) => { if (offset.X == 0 && offset.Y == 0) PlaceSprite(area, pos, sprite); });
        }
        public static void Fill<T>(T area, Rectangle selection, Point step, Action<Point, Point> func) where T : ITileArea
        {
            Validate(area, selection);

            Delete(area, selection);

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
