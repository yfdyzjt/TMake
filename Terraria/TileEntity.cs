namespace TMake.Terraria
{
    public class TileEntity
    {
        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public byte Type { get; set; }
        public NPC NPC { get; set; } = new NPC();
        public Item Item { get; set; } = new Item();
        public byte LogicCheck { get; set; }
        public bool On { get; set; }
        public Item[] Items { get; set; } = [];
        public Item[] Dyes { get; set; } = [];
        public TileEntity Copy()
        {
            return (TileEntity)MemberwiseClone();
        }
        public TileEntity DeepCopy()
        {
            var tileEntity = Copy();
            tileEntity.NPC = NPC.Copy();
            tileEntity.Item = Item.Copy();
            for (int i = 0; i < Items.Length; i++)
            {
                tileEntity.Items[i] = Items[i].Copy();
            }
            for (int i = 0; i < Dyes.Length; i++)
            {
                tileEntity.Dyes[i] = Dyes[i].Copy();
            }
            return tileEntity;
        }
    }
}
