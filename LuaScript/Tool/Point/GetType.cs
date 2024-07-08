using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static Chest GetChest<T>(T area, Point position) where T : ITileArea
        {
            ValidatePointInArea(area, position);
            return area.Chest.First(chest => chest.X == position.X && chest.Y == position.Y);
        }
        public static Sign GetSign<T>(T area, Point position) where T : ITileArea
        {
            ValidatePointInArea(area, position);
            return area.Sign.First(sign => sign.X == position.X && sign.Y == position.Y);
        }
        public static TileEntity GetTileEntity<T>(T area, Point position) where T : ITileArea
        {
            ValidatePointInArea(area, position);
            return area.TileEntity.First(tileEntity => tileEntity.X == position.X && tileEntity.Y == position.Y);
        }
    }
}
