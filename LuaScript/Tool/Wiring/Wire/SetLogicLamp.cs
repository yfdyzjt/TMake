using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static bool SetLogicLamp<T>(T area, Point pos, bool value) where T : ITileArea
        {
            ValidatePointInArea(area, pos);

            if (value)
                PlaceSprite(area, pos, FrameProperty.GetFrameData((ushort)TileID.LogicGateLamp, "On"));
            else
                PlaceSprite(area, pos, FrameProperty.GetFrameData((ushort)TileID.LogicGateLamp, "Off"));

            return value;
        }
    }
}
