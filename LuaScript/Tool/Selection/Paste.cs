using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static void Paste<T1, T2>(T1 toArea, Point position, T2 fromArea) where T1 : ITileArea where T2 : ITileArea
        {
            Paste(toArea, new Rectangle(position, new(fromArea.MaxTilesX, fromArea.MaxTilesY)), fromArea);
        }
        public static void Paste<T1, T2>(T1 toArea, Rectangle selection, T2 fromArea) where T1 : ITileArea where T2 : ITileArea
        {
            Validate(toArea, selection);

            PasteChests(toArea, selection, fromArea.Chest);
            PasteSigns(toArea, selection, fromArea.Sign);
            PasteTileEntities(toArea, selection, fromArea.TileEntity);
            PasteTiles(toArea, selection, fromArea.Tile);
        }
        public static void PasteChests<T>(T toArea, Rectangle selection, List<Chest> chests) where T : ITileArea
        {
            Validate(toArea, selection);

            DeleteChests(toArea, selection);

            toArea.Chest.AddRange(chests.Where(chest =>
            selection.Contains(chest.X, chest.Y)).Select(chest =>
            {
                var clone = chest.DeepCopy();
                clone.X += selection.Left;
                clone.Y += selection.Top;
                return clone;
            }));
        }
        public static void PasteSigns<T>(T toArea, Rectangle selection, List<Sign> signs) where T : ITileArea
        {
            Validate(toArea, selection);

            DeleteSigns(toArea, selection);

            toArea.Sign.AddRange(signs.Where(sign =>
            selection.Contains(sign.X, sign.Y)).Select(sign =>
            {
                var clone = sign.DeepCopy();
                clone.X += selection.Left;
                clone.Y += selection.Top;
                return clone;
            }));
        }
        public static void PasteTileEntities<T>(T toArea, Rectangle selection, List<TileEntity> tileEntities) where T : ITileArea
        {
            Validate(toArea, selection);

            DeleteTileEntities(toArea, selection);

            toArea.TileEntity.AddRange(tileEntities.Where(tileEntity =>
            selection.Contains(tileEntity.X, tileEntity.Y)).Select(tileEntity =>
            {
                var clone = tileEntity.DeepCopy();
                clone.X += selection.Left;
                clone.Y += selection.Top;
                return clone;
            }));
        }
        public static void PasteTiles<T>(T toArea, Rectangle selection, Tile[,] tiles) where T : ITileArea
        {
            Validate(toArea, selection);

            DeleteTiles(toArea, selection);

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
