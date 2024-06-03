using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMake.Terraria;

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

        public void CopyFrom(Tile from)
        {
            Active = from.Active;
            Type = from.Type;
            FrameX = from.FrameX;
            FrameY = from.FrameY;
            Color = from.Color;
            Wall = from.Wall;
            WallColor = from.WallColor;
            Liquid = from.Liquid;
            Lava = from.Lava;
            Honey = from.Honey;
            Shimmer = from.Shimmer;
            Wire = from.Wire;
            Wire2 = from.Wire2;
            Wire3 = from.Wire3;
            HalfBrick = from.HalfBrick;
            Slope = from.Slope;
            Actuator = from.Actuator;
            InActive = from.InActive;
            Wire4 = from.Wire4;
            InvisibleBlock = from.InvisibleBlock;
            InvisibleWall = from.InvisibleWall;
            FullBrightBlock = from.FullBrightBlock;
            FullBrightWall = from.FullBrightWall;
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
