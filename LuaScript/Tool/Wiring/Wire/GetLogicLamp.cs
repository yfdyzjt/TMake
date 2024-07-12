using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static bool GetLogicLamp(Tile tile)
        {
            ValidateTileIsNormalLogicLamp(tile);

            return FrameProperty.GetFrameData(tile).Variety == "On";
        }
    }
}
