using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static bool GetLogicLamp<T>(T area, Point pos) where T : ITileArea
        {
            ValidatePointInArea(area, pos);

            var tile = area.Tile[pos.X, pos.Y];

            ValidateTileIsNormalLogicLamp(tile);

            return FrameProperty.GetFrameData(tile).Variety == "On";
        }
    }
}
