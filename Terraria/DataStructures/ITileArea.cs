namespace TMake.Terraria
{
    public interface ITileArea
    {
        Tile[,] Tile { get; set; }
        List<Chest> Chest { get; set; }
        List<Sign> Sign { get; set; }
        List<TileEntity> TileEntity { get; set; }

        public int MaxTilesX { get; set; }
        public int MaxTilesY { get; set; }
    }
}
