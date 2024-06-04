namespace TMake.Terraria
{
    public class TileEntity
    {
        public int ID { get; set; }
        public Point16 Position { get; set; }
        public byte Type { get; set; }
        public NPC NPC { get; set; } = new NPC();
        public Item Item { get; set; } = new Item();
        public byte LogicCheck { get; set; }
        public bool On { get; set; }
        public Item[] Items { get; set; } = [];
        public Item[] Dyes { get; set; } = [];
    }
}
