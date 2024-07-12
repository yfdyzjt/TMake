using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static bool SetLogicLamp(Tile tile, bool value)
        {
            if (value)
                PlaceSingleSprite(tile, FrameProperty.GetFrameData((ushort)TileID.LogicGateLamp, "On"));
            else
                PlaceSingleSprite(tile, FrameProperty.GetFrameData((ushort)TileID.LogicGateLamp, "Off"));

            return value;
        }
    }
}
