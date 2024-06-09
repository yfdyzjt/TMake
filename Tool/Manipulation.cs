using System.Drawing;
using TMake.Data;
using TMake.Terraria;

namespace TMake
{
    public static partial class Tool
    {
        public static void Delete<T>(T area, Rectangle selection) where T : ITileArea
        {
            selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));

            area.Chest.RemoveAll(chest => selection.Contains(chest.X, chest.Y));
            area.Sign.RemoveAll(sign => selection.Contains(sign.X, sign.Y));
            area.TileEntity.RemoveAll(tileEntity => selection.Contains(tileEntity.X, tileEntity.Y));

            for (int x = selection.Left; x < selection.Right; x++)
            {
                for (int y = selection.Top; y < selection.Bottom; y++)
                {
                    area.Tile[x, y].Reset();
                }
            }
        }
        public static void Fill<T>(T area, Rectangle selection, Tile tile) where T : ITileArea
        {
            selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));

            for (int x = selection.Left; x < selection.Right; x++)
            {
                for (int y = selection.Top; y < selection.Bottom; y++)
                {
                    area.Tile[x, y] = tile.Clone();
                }
            }
        }
        public static void Copy<T>(T area, Rectangle selection, Point toPosition) where T : ITileArea
        {
            Schematic sch = Copy<T, Schematic>(area, selection);
            Paste(area, toPosition, sch);
        }
        public static T2 Copy<T1, T2>(T1 fromArea, Rectangle selection) where T1 : ITileArea where T2 : ITileArea, new()
        {
            selection.Intersect(new(0, 0, fromArea.MaxTilesX, fromArea.MaxTilesY));

            T2 toArea = new()
            {
                Version = fromArea.Version,
                MaxTilesX = selection.Width,
                MaxTilesY = selection.Height,
                Name = fromArea.Name,
                Tile = new Tile[selection.Width, selection.Height]
            };

            toArea.Chest.AddRange(fromArea.Chest.Where(chest =>
            selection.Contains(chest.X, chest.Y)).Select(chest =>
            {
                var clone = chest.Clone();
                clone.X -= selection.Left;
                clone.Y -= selection.Top;
                return clone;
            }));
            toArea.Sign.AddRange(fromArea.Sign.Where(sign =>
            selection.Contains(sign.X, sign.Y)).Select(sign =>
            {
                var clone = sign.Clone();
                clone.X -= selection.Left;
                clone.Y -= selection.Top;
                return clone;
            }));
            toArea.TileEntity.AddRange(fromArea.TileEntity.Where(tileEntity =>
            selection.Contains(tileEntity.X, tileEntity.Y)).Select(tileEntity =>
            {
                var clone = tileEntity.Clone();
                clone.X -= selection.Left;
                clone.Y -= selection.Top;
                return clone;
            }));

            for (int x = selection.Left, i = 0; x < selection.Right; x++, i++)
            {
                for (int y = selection.Top, j = 0; y < selection.Bottom; y++, j++)
                {
                    toArea.Tile[i, j] = fromArea.Tile[x, y].Clone();
                }
            }

            return toArea;
        }
        public static void Cut<T>(T area, Rectangle fromRectangle, Point toPosition) where T : ITileArea
        {
            Schematic sch = Cut<T, Schematic>(area, fromRectangle);
            Paste(area, toPosition, sch);
        }
        public static T2 Cut<T1, T2>(T1 area, Rectangle rectangle) where T1 : ITileArea where T2 : ITileArea, new()
        {
            T2 toArea = Copy<T1, T2>(area, rectangle);
            Delete(area, rectangle);
            return toArea;
        }
        public static void Paste<T1, T2>(T1 toArea, Point position, T2 fromArea) where T1 : ITileArea where T2 : ITileArea
        {
            Rectangle selection = Rectangle.Intersect(
                new(position,
                new(fromArea.MaxTilesX, fromArea.MaxTilesY)),
                new(0, 0, toArea.MaxTilesX, toArea.MaxTilesY));

            Delete(toArea, selection);

            toArea.Chest.AddRange(fromArea.Chest.Where(chest =>
            selection.Contains(chest.X, chest.Y)).Select(chest =>
            {
                var clone = chest.Clone();
                clone.X += selection.Left;
                clone.Y += selection.Top;
                return clone;
            }));
            toArea.Sign.AddRange(fromArea.Sign.Where(sign =>
            selection.Contains(sign.X, sign.Y)).Select(sign =>
            {
                var clone = sign.Clone();
                clone.X += selection.Left;
                clone.Y += selection.Top;
                return clone;
            }));
            toArea.TileEntity.AddRange(fromArea.TileEntity.Where(tileEntity =>
            selection.Contains(tileEntity.X, tileEntity.Y)).Select(tileEntity =>
            {
                var clone = tileEntity.Clone();
                clone.X += selection.Left;
                clone.Y += selection.Top;
                return clone;
            }));

            for (int x = selection.Left, i = 0; x < selection.Right; x++, i++)
            {
                for (int y = selection.Top, j = 0; y < selection.Bottom; y++, j++)
                {
                    toArea.Tile[x, y] = fromArea.Tile[i, j].Clone();
                }
            }
        }
    }
}
