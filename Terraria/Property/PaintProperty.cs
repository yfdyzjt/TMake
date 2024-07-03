using System.Drawing;

namespace TMake.Terraria
{
    public class PaintProperty
    {
        public readonly static Dictionary<int, Color> PaintColor = new()
        {
            [0] = Color.FromArgb(255, 255, 255),
            [1] = Color.FromArgb(255, 0, 0),
            [13] = Color.FromArgb(255, 0, 0),
            [2] = Color.FromArgb(255, 127, 0),
            [14] = Color.FromArgb(255, 127, 0),
            [3] = Color.FromArgb(255, 255, 0),
            [15] = Color.FromArgb(255, 255, 0),
            [4] = Color.FromArgb(127, 255, 0),
            [16] = Color.FromArgb(127, 255, 0),
            [5] = Color.FromArgb(0, 255, 0),
            [17] = Color.FromArgb(0, 255, 0),
            [6] = Color.FromArgb(0, 255, 127),
            [18] = Color.FromArgb(0, 255, 127),
            [7] = Color.FromArgb(0, 255, 255),
            [19] = Color.FromArgb(0, 255, 255),
            [8] = Color.FromArgb(0, 127, 255),
            [20] = Color.FromArgb(0, 127, 255),
            [9] = Color.FromArgb(0, 0, 255),
            [21] = Color.FromArgb(0, 0, 255),
            [10] = Color.FromArgb(127, 0, 255),
            [22] = Color.FromArgb(127, 0, 255),
            [11] = Color.FromArgb(255, 0, 255),
            [23] = Color.FromArgb(255, 0, 255),
            [12] = Color.FromArgb(255, 0, 127),
            [24] = Color.FromArgb(255, 0, 127),
            [25] = Color.FromArgb(75, 75, 75),
            [26] = Color.FromArgb(255, 255, 255),
            [27] = Color.FromArgb(175, 175, 175),
            [28] = Color.FromArgb(255, 178, 125),
            [29] = Color.FromArgb(25, 25, 25),
            [30] = Color.FromArgb(150, 200, 200, 200),
            [31] = Color.FromArgb(255, 255, 255),
        };
    }
}
