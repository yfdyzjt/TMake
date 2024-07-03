using System.Drawing;

namespace TMake.Terraria
{
    public enum LiquidType : byte
    {
        None = 0x0,
        Water = 0x01,
        Lava = 0x02,
        Honey = 0x03,
        Shimmer = 0x04,
    }
    public class LiquidProperty
    {
        public readonly static Dictionary<LiquidType, Color> LiquidColors = new()
        {
            [LiquidType.None] = Color.Transparent,
            [LiquidType.Water] = Color.FromArgb(9, 61, 191),
            [LiquidType.Lava] = Color.FromArgb(253, 32, 3),
            [LiquidType.Honey] = Color.FromArgb(254, 194, 20),
            [LiquidType.Shimmer] = Color.FromArgb(161, 127, 255),
        };
    }
}
