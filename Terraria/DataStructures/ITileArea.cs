namespace TMake.Terraria
{
    public interface ITileArea
    {
        Tile[,] Tile { get; set; }
        List<Chest> Chest { get; set; }
        List<Sign> Sign { get; set; }
        List<TileEntity> TileEntity { get; set; }

        int MaxTilesX { get; set; }
        int MaxTilesY { get; set; }
        uint Version { get; set; }
    }
}
