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

        public bool WireRed { get => Wire; set => Wire = value; }
        public bool WireBlue { get => Wire2; set => Wire2 = value; }
        public bool WireGreen { get => Wire3; set => Wire3 = value; }
        public bool WireYellow { get => Wire4; set => Wire4 = value; }
        public BrickStyle BrickStyle
        {
            get
            {
                if (HalfBrick == true) return BrickStyle.Half;
                else if (Slope == 0) return BrickStyle.Full;
                else return (BrickStyle)(Slope + 1);
            }
            set
            {
                if (value == BrickStyle.Half) { HalfBrick = true; Slope = 0; }
                else if (value == BrickStyle.Full) { HalfBrick = false; Slope = 0; }
                else { HalfBrick = false; Slope = (byte)(value - 1); }
            }
        }
        public byte LiquidAmount { get => Liquid; set => Liquid = value; }
        public LiquidType LiquidType
        {
            get
            {
                if (Lava) return LiquidType.Lava;
                else if (Honey) return LiquidType.Honey;
                else if (Shimmer) return LiquidType.Shimmer;
                else if (Liquid != 0) return LiquidType.Water;
                else return LiquidType.None;
            }
            set
            {
                Lava = false; Honey = false; Shimmer = false; 
                Liquid = Liquid == 0 ? byte.MaxValue : Liquid;
                switch (value)
                {
                    case LiquidType.None: Liquid = 0; break;
                    case LiquidType.Water: break;
                    case LiquidType.Lava: Lava = true; break;
                    case LiquidType.Honey: Honey = true; break;
                    case LiquidType.Shimmer: Shimmer = true; break;
                }
            }
        }

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
        public override bool Equals(object? obj)
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
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Active.GetHashCode();
                hashCode = (hashCode * 397) ^ Type.GetHashCode();
                hashCode = (hashCode * 397) ^ FrameX.GetHashCode();
                hashCode = (hashCode * 397) ^ FrameY.GetHashCode();
                hashCode = (hashCode * 397) ^ Color.GetHashCode();
                hashCode = (hashCode * 397) ^ Wall.GetHashCode();
                hashCode = (hashCode * 397) ^ WallColor.GetHashCode();
                hashCode = (hashCode * 397) ^ Liquid.GetHashCode();
                hashCode = (hashCode * 397) ^ Lava.GetHashCode();
                hashCode = (hashCode * 397) ^ Honey.GetHashCode();
                hashCode = (hashCode * 397) ^ Shimmer.GetHashCode();
                hashCode = (hashCode * 397) ^ Wire.GetHashCode();
                hashCode = (hashCode * 397) ^ Wire2.GetHashCode();
                hashCode = (hashCode * 397) ^ Wire3.GetHashCode();
                hashCode = (hashCode * 397) ^ HalfBrick.GetHashCode();
                hashCode = (hashCode * 397) ^ Slope.GetHashCode();
                hashCode = (hashCode * 397) ^ Actuator.GetHashCode();
                hashCode = (hashCode * 397) ^ InActive.GetHashCode();
                hashCode = (hashCode * 397) ^ Wire4.GetHashCode();
                hashCode = (hashCode * 397) ^ InvisibleBlock.GetHashCode();
                hashCode = (hashCode * 397) ^ InvisibleWall.GetHashCode();
                hashCode = (hashCode * 397) ^ FullBrightBlock.GetHashCode();
                hashCode = (hashCode * 397) ^ FullBrightWall.GetHashCode();
                return hashCode;
            }
        }
    }
}
