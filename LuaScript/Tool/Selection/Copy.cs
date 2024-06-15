using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static void Copy<T>(T area, Rectangle selection, Point toPosition) where T : ITileArea
        {
            Schematic sch = Copy<T, Schematic>(area, selection);
            Paste(area, toPosition, sch);
        }
        public static T2 Copy<T1, T2>(T1 fromArea, Rectangle selection, bool validate = true) where T1 : ITileArea where T2 : ITileArea, new()
        {
            if (validate) selection.Intersect(new(0, 0, fromArea.MaxTilesX, fromArea.MaxTilesY));

            T2 toArea = new()
            {
                Version = fromArea.Version,
                MaxTilesX = selection.Width,
                MaxTilesY = selection.Height,
                Name = fromArea.Name,
            };

            toArea.Chest.AddRange(CopyChests(fromArea, selection, false));
            toArea.Sign.AddRange(CopySigns(fromArea, selection, false));
            toArea.TileEntity.AddRange(CopyTileEntities(fromArea, selection, false));
            toArea.Tile = CopyTile(fromArea, selection, false);

            return toArea;
        }
        public static List<Chest> CopyChests<T>(T fromArea, Rectangle selection, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, fromArea.MaxTilesX, fromArea.MaxTilesY));

            return fromArea.Chest.Where(chest =>
            selection.Contains(chest.X, chest.Y)).Select(chest =>
            {
                var clone = chest.DeepCopy();
                clone.X -= selection.Left;
                clone.Y -= selection.Top;
                return clone;
            }).ToList();
        }
        public static List<Sign> CopySigns<T>(T fromArea, Rectangle selection, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, fromArea.MaxTilesX, fromArea.MaxTilesY));

            return fromArea.Sign.Where(sign =>
            selection.Contains(sign.X, sign.Y)).Select(sign =>
            {
                var clone = sign.DeepCopy();
                clone.X -= selection.Left;
                clone.Y -= selection.Top;
                return clone;
            }).ToList();
        }
        public static List<TileEntity> CopyTileEntities<T>(T fromArea, Rectangle selection, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, fromArea.MaxTilesX, fromArea.MaxTilesY));

            return fromArea.TileEntity.Where(tileEntity =>
            selection.Contains(tileEntity.X, tileEntity.Y)).Select(tileEntity =>
            {
                var clone = tileEntity.DeepCopy();
                clone.X -= selection.Left;
                clone.Y -= selection.Top;
                return clone;
            }).ToList();
        }
        public static Tile[,] CopyTile<T>(T fromArea, Rectangle selection, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, fromArea.MaxTilesX, fromArea.MaxTilesY));

            Tile[,] tiles = new Tile[selection.Width, selection.Height];
            for (int x = selection.Left, i = 0; x < selection.Right; x++, i++)
            {
                for (int y = selection.Top, j = 0; y < selection.Bottom; y++, j++)
                {
                    tiles[i, j] = fromArea.Tile[x, y].Copy();
                }
            }

            return tiles;
        }
    }
}
