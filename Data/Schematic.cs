using System.Drawing;
using TMake.Terraria;

namespace TMake.Data
{
    public class Schematic
    {
        public Tile[,] Tile = new Tile[0, 0];
        public List<Chest> Chest = [];
        public List<Sign> Sign = [];
        public List<TileEntity> TileEntity = [];
        public string Name { get; set; } = "";
        public Point Size { get; set; }
        public uint Version { get; set; }
    }
}
