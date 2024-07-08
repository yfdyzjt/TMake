using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static void Delete<T>(T area, Rectangle selection) where T : ITileArea
        {
            ValidateRectangleInArea(area, selection);

            DeleteChests(area, selection);
            DeleteSigns(area, selection);
            DeleteTileEntities(area, selection);
            DeleteTiles(area, selection);
        }
        public static void DeleteChests<T>(T area, Rectangle selection) where T : ITileArea
        {
            ValidateRectangleInArea(area, selection);
            area.Chest.RemoveAll(chest => selection.Contains(chest.X, chest.Y));
        }
        public static void DeleteSigns<T>(T area, Rectangle selection) where T : ITileArea
        {
            ValidateRectangleInArea(area, selection);
            area.Sign.RemoveAll(sign => selection.Contains(sign.X, sign.Y));
        }
        public static void DeleteTileEntities<T>(T area, Rectangle selection) where T : ITileArea
        {
            ValidateRectangleInArea(area, selection);
            area.TileEntity.RemoveAll(tileEntity => selection.Contains(tileEntity.X, tileEntity.Y));
        }
        public static void DeleteTiles<T>(T area, Rectangle selection) where T : ITileArea
        {
            ValidateRectangleInArea(area, selection);
            for (int x = selection.Left; x < selection.Right; x++)
            {
                for (int y = selection.Top; y < selection.Bottom; y++)
                {
                    area.Tile[x, y].Reset();
                }
            }
        }
    }
}
