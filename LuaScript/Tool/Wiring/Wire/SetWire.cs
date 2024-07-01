using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static void SetWire<T>(Tile tile, T color, bool value) where T : struct, IConvertible, IComparable, IFormattable
        {
            switch ((WireColor)Enum.ToObject(typeof(WireColor), color))
            {
                case WireColor.Red: tile.WireRed = value; break;
                case WireColor.Blue: tile.WireBlue = value; break;
                case WireColor.Green: tile.WireGreen = value; break;
                case WireColor.Yellow: tile.WireYellow = value; break;
            }
        }
    }
}
