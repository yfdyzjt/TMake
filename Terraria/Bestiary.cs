namespace TMake.Terraria
{
    public class Bestiary
    {
        public Dictionary<string, int> KillCountsByNpcId { get; set; } = [];
        public HashSet<string> WasNearPlayer { get; set; } = [];
        public HashSet<string> ChattedWithPlayer { get; set; } = [];
    }
}
