using System.Drawing;
using TMake.Terraria;

namespace TMake.Script
{
    public static partial class Tool
    {
        public static void Paste<T1, T2>(T1 toArea, Point position, T2 fromArea) where T1 : ITileArea where T2 : ITileArea
        {
            Paste(toArea, new(position, new(fromArea.MaxTilesX, fromArea.MaxTilesY)), fromArea, true);
        }
        public static void Paste<T1, T2>(T1 toArea, Rectangle selection, T2 fromArea, bool validate = true) where T1 : ITileArea where T2 : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, toArea.MaxTilesX, toArea.MaxTilesY));

            PasteChests(toArea, selection, fromArea.Chest, false);
            PasteSigns(toArea, selection, fromArea.Sign, false);
            PasteTileEntities(toArea, selection, fromArea.TileEntity, false);
            PasteTiles(toArea, selection, fromArea.Tile, false);
        }
        public static void PasteChests<T>(T toArea, Rectangle selection, List<Chest> chests, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, toArea.MaxTilesX, toArea.MaxTilesY));

            DeleteChests(toArea, selection, false);

            toArea.Chest.AddRange(chests.Where(chest =>
            selection.Contains(chest.X, chest.Y)).Select(chest =>
            {
                var clone = chest.DeepCopy();
                clone.X += selection.Left;
                clone.Y += selection.Top;
                return clone;
            }));
        }
        public static void PasteSigns<T>(T toArea, Rectangle selection, List<Sign> signs, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, toArea.MaxTilesX, toArea.MaxTilesY));

            DeleteSigns(toArea, selection, false);

            toArea.Sign.AddRange(signs.Where(sign =>
            selection.Contains(sign.X, sign.Y)).Select(sign =>
            {
                var clone = sign.DeepCopy();
                clone.X += selection.Left;
                clone.Y += selection.Top;
                return clone;
            }));
        }
        public static void PasteTileEntities<T>(T toArea, Rectangle selection, List<TileEntity> tileEntities, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, toArea.MaxTilesX, toArea.MaxTilesY));

            DeleteTileEntities(toArea, selection, false);

            toArea.TileEntity.AddRange(tileEntities.Where(tileEntity =>
            selection.Contains(tileEntity.X, tileEntity.Y)).Select(tileEntity =>
            {
                var clone = tileEntity.DeepCopy();
                clone.X += selection.Left;
                clone.Y += selection.Top;
                return clone;
            }));
        }
        public static void PasteTiles<T>(T toArea, Rectangle selection, Tile[,] tiles, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, toArea.MaxTilesX, toArea.MaxTilesY));

            DeleteTiles(toArea, selection, false);

            for (int x = selection.Left, i = 0; x < selection.Right; x++, i++)
            {
                for (int y = selection.Top, j = 0; y < selection.Bottom; y++, j++)
                {
                    toArea.Tile[x, y] = tiles[i, j].Copy();
                }
            }
        }
    }
}
