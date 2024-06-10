namespace TMake.Terraria
{
    public class Tile
    {
        public bool Active;
        public ushort Type;
        public short FrameX;
        public short FrameY;
        public byte Color;
        public ushort Wall;
        public byte WallColor;
        public byte Liquid;
        public bool Lava;
        public bool Honey;
        public bool Shimmer;
        public bool Wire;
        public bool Wire2;
        public bool Wire3;
        public bool HalfBrick;
        public byte Slope;
        public bool Actuator;
        public bool InActive;
        public bool Wire4;
        public bool InvisibleBlock;
        public bool InvisibleWall;
        public bool FullBrightBlock;
        public bool FullBrightWall;

        public void Reset()
        {
            Active = false;
            Type = 0;
            FrameX = 0;
            FrameY = 0;
            Color = 0;
            Wall = 0;
            WallColor = 0;
            Liquid = 0;
            Lava = false;
            Honey = false;
            Shimmer = false;
            Wire = false;
            Wire2 = false;
            Wire3 = false;
            HalfBrick = false;
            Slope = 0;
            Actuator = false;
            InActive = false;
            Wire4 = false;
            InvisibleBlock = false;
            InvisibleWall = false;
            FullBrightBlock = false;
            FullBrightWall = false;
        }
        public Tile Copy()
        {
            return (Tile)MemberwiseClone();
        }
        public static bool operator ==(Tile left, Tile right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Tile left, Tile right)
        {
            return !Equals(left, right);
        }
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Tile)obj);
        }
        protected bool Equals(Tile other)
        {
            return
                Active == other.Active &&
            Type == other.Type &&
            FrameX == other.FrameX &&
            FrameY == other.FrameY &&
            Color == other.Color &&
            Wall == other.Wall &&
            WallColor == other.WallColor &&
            Liquid == other.Liquid &&
            Lava == other.Lava &&
            Honey == other.Honey &&
            Shimmer == other.Shimmer &&
            Wire == other.Wire &&
            Wire2 == other.Wire2 &&
            Wire3 == other.Wire3 &&
            HalfBrick == other.HalfBrick &&
            Slope == other.Slope &&
            Actuator == other.Actuator &&
            InActive == other.InActive &&
            Wire4 == other.Wire4 &&
            InvisibleBlock == other.InvisibleBlock &&
            InvisibleWall == other.InvisibleWall &&
            FullBrightBlock == other.FullBrightBlock &&
            FullBrightWall == other.FullBrightWall;
        }
    }
}
