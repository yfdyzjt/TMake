namespace TMake.Terraria
{
    public class SaveVersionData
    {
        public int SaveVersion { get; set; }
        public string GameVersion { get; set; } = "";
        public int MaxTileId { get; set; }
        public int MaxWallId { get; set; }
        public int MaxItemId { get; set; }
        public int MaxNpcId { get; set; }
        public int MaxMoonId { get; set; }
        public bool[] TileFrameImportant
        {
            get
            {
                var frames = FramedTileIds;
                var tileCount = MaxTileId + 1;
                bool[] result = new bool[tileCount];

                for (int i = 0; i < tileCount; i++)
                {
                    if (frames.Contains(i)) { result[i] = true; }
                }

                return result;
            }
        }
        public HashSet<int> FramedTileIds { get; set; }

        public SaveVersionData(
            int saveVersion,
            string gameVersion,
            int maxTileId,
            int maxWallId,
            int maxItemId,
            int maxNpcId,
            int maxMoonId,
            int[] framedTileIds
            )
        {
            SaveVersion = saveVersion;
            GameVersion = gameVersion;
            MaxTileId = maxTileId;
            MaxWallId = maxWallId;
            MaxItemId = maxItemId;
            MaxNpcId = maxNpcId;
            MaxMoonId = maxMoonId;
            FramedTileIds = new HashSet<int>(framedTileIds);
        }
    }
}
