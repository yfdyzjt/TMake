using TMake.IO;

namespace TMake.Terraria
{
    public partial class Schematic : TMakeFile, ITileArea
    {
        public Tile[,] Tile { get; set; } = new Tile[0, 0];
        public List<Chest> Chest { get; set; } = [];
        public List<Sign> Sign { get; set; } = [];
        public List<TileEntity> TileEntity { get; set; } = [];

        public int MaxTilesX { get; set; }
        public int MaxTilesY { get; set; }
        public string Name { get; set; } = "";
        public uint Version { get; set; }
    }
}
