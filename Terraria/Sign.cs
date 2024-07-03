namespace TMake.Terraria
{
    public class Sign
    {
        public string Text { get; set; } = string.Empty;
        public int X { get; set; }
        public int Y { get; set; }
        public Sign DeepCopy() => Copy();
        public Sign Copy()
        {
            return (Sign)MemberwiseClone();
        }
    }
}
