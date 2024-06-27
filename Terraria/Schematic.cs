using TMake.IO;

namespace TMake.Terraria
{
    public class Schematic : TMakeFile, ITileArea
    {
        public override void Load(string filePath)
        {
            SchematicFile.Load(this, filePath);
        }
        public override void Save(string filePath)
        {
            SchematicFile.Save(this, filePath);
        }

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
