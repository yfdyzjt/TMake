using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static bool SwitchLogicLamp(Tile tile)
        {
            bool value = !GetLogicLamp(tile);
            return SetLogicLamp(tile, value);
        }
    }
}
