using System.Drawing;

namespace TMake.Terraria
{
    public static class SpriteProperty
    {
        public static List<FrameData> GetSprites(ushort type)
        {
            return TileProperty.TileDatas[type].Frames;
        }
        public static FrameData GetSprite(ushort type, int frameType = 0)
        {
            return GetSprites(type).First(frame => frame.Type == frameType);
        }
        public static FrameData GetSprite(ushort type, string variety)
        {
            return GetSprites(type).First(frame => frame.Variety == variety);
        }
        public static FrameData GetSprite(ushort type, FrameAnchor anchor)
        {
            return GetSprites(type).First(frame => frame.Anchor == anchor);
        }
        public static List<FrameData> GetSprites(string name)
        {
            return TileProperty.TileDatas.Values
            .SelectMany(tileData => tileData.Frames)
            .Where(frameData => frameData.Name == name).ToList();
        }
        public static FrameData GetSprite(string name, int frameType = 0)
        {
            return GetSprites(name).First(frame => frame.Type == frameType);
        }
        public static FrameData GetSprite(string name, string variety)
        {
            return GetSprites(name).First(frame => frame.Variety == variety);
        }
        public static FrameData GetSprite(string name, FrameAnchor anchor)
        {
            return GetSprites(name).First(frame => frame.Anchor == anchor);
        }
        public static FrameData GetSprite(Tile tile)
        {
            var tileData = TileProperty.GetTileData(tile.Type);

            var targetPoint = new Point(tile.FrameX, tile.FrameY);

            var closestFrame = tileData.Frames.Aggregate((closest, current) =>
            {
                var closestDistance = DistanceSquared(targetPoint, tileData, closest);
                var currentDistance = DistanceSquared(targetPoint, tileData, current);

                return currentDistance < closestDistance ? current : closest;
            });

            return closestFrame;
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
