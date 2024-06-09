namespace TMake.Terraria
{
    public class Chest
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; } = "";
        public Item[] Item { get; set; }
        public Chest()
        {
            Item = new Item[ChestProperty.MaxItems];
            for (int i = 0; i < ChestProperty.MaxItems; i++)
            {
                Item[i] = new Item();
            }
        }
        public Chest Clone()
        {
            var chest = (Chest)MemberwiseClone();
            for (int i = 0; i < ChestProperty.MaxItems; i++)
            {
                chest.Item[i] = Item[i].Clone();
            }
            return chest;
        }
    }
}
