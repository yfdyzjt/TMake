using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static void Delete<T>(T area, Rectangle selection, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));

            DeleteChests(area, selection, false);
            DeleteSigns(area, selection, false);
            DeleteTileEntities(area, selection, false);
            DeleteTiles(area, selection, false);
        }
        public static void DeleteChests<T>(T area, Rectangle selection, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));
            area.Chest.RemoveAll(chest => selection.Contains(chest.X, chest.Y));
        }
        public static void DeleteSigns<T>(T area, Rectangle selection, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));
            area.Sign.RemoveAll(sign => selection.Contains(sign.X, sign.Y));
        }
        public static void DeleteTileEntities<T>(T area, Rectangle selection, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));
            area.TileEntity.RemoveAll(tileEntity => selection.Contains(tileEntity.X, tileEntity.Y));
        }
        public static void DeleteTiles<T>(T area, Rectangle selection, bool validate = true) where T : ITileArea
        {
            if (validate) selection.Intersect(new(0, 0, area.MaxTilesX, area.MaxTilesY));
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
