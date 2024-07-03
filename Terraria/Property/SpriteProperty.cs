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
    }
}
