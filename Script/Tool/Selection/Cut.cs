using System.Drawing;
using TMake.Terraria;

namespace TMake.Script
{
    public static partial class Tool
    {
        public static void Cut<T>(T area, Rectangle fromRectangle, Point toPosition) where T : ITileArea
        {
            Schematic sch = Cut<T, Schematic>(area, fromRectangle);
            Paste(area, toPosition, sch);
        }
        public static T2 Cut<T1, T2>(T1 area, Rectangle rectangle) where T1 : ITileArea where T2 : ITileArea, new()
        {
            T2 toArea = Copy<T1, T2>(area, rectangle);
            Delete(area, rectangle);
            return toArea;
        }
    }
}
