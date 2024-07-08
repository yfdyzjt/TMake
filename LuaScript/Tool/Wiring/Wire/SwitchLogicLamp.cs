using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static bool SwitchLogicLamp<T>(T area, Point pos) where T : ITileArea
        {
            bool value = !GetLogicLamp(area, pos);
            return SetLogicLamp(area, pos, value);
        }
    }
}
