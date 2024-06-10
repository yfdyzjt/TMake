namespace TMake.Terraria
{
    public class Item
    {
        public int StackSize { get; set; }
        public byte Prefix { get; set; }
        public int Type { get; set; }
        public bool IsValid => StackSize > 0 && Type > 0;
        public Item Copy()
        {
            return (Item)MemberwiseClone();
        }
    }
}
