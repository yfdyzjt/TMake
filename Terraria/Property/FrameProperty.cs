using System.Drawing;

namespace TMake.Terraria
{
    public static class FrameProperty
    {
        public static List<FrameData> GetFrameDatas(ushort type)
        {
            return TileProperty.TileDatas[type].Frames;
        }
        public static FrameData GetFrameData(ushort type, int frameType = 0)
        {
            return GetFrameDatas(type).First(frame => frame.Type == frameType);
        }
        public static FrameData GetFrameData(ushort type, string variety)
        {
            return GetFrameDatas(type).First(frame => frame.Variety == variety);
        }
        public static FrameData GetFrameData(ushort type, FrameAnchor anchor)
        {
            return GetFrameDatas(type).First(frame => frame.Anchor == anchor);
        }
        public static List<FrameData> GetFrameDatas(string name)
        {
            return TileProperty.TileDatas.Values
            .SelectMany(tileData => tileData.Frames)
            .Where(frameData => frameData.Name == name).ToList();
        }
        public static FrameData GetFrameData(string name, int frameType = 0)
        {
            return GetFrameDatas(name).First(frame => frame.Type == frameType);
        }
        public static FrameData GetFrameData(string name, string variety)
        {
            return GetFrameDatas(name).First(frame => frame.Variety == variety);
        }
        public static FrameData GetFrameData(string name, FrameAnchor anchor)
        {
            return GetFrameDatas(name).First(frame => frame.Anchor == anchor);
        }
        public static FrameData GetFrameData(Tile tile)
        {
            var tileData = TileProperty.GetTileData(tile.Type);
            var point = new Point(tile.FrameX, tile.FrameY);

            try
            {
                return tileData.Frames.First(frame => new Rectangle(
                    new(frame.Origin.X, frame.Origin.Y),
                    new(frame.Size.X * (tileData.TextureGrid.X + tileData.TextureGap.X),
                        frame.Size.Y * (tileData.TextureGrid.Y + tileData.TextureGap.Y))
                    ).Contains(point));
            }
            catch
            {
                return tileData.Frames.OrderBy(frame => DistanceSquared(point, tileData, frame)).First();
            }
        }
        private static float DistanceSquared(Point point, TileData tile, FrameData frame)
        {
            var framePoint = new Point(
                frame.Origin.X + frame.Size.X / 2 * (tile.TextureGrid.X + tile.TextureGap.X),
                frame.Origin.Y + frame.Size.Y / 2 * (tile.TextureGrid.Y + tile.TextureGap.Y));
            var dx = point.X - framePoint.X;
            var dy = point.Y - framePoint.Y;
            return dx * dx + dy * dy;
        }
    }
}
