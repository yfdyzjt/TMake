using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TMake.Terraria
{
    public class NPC
    {
        public int Type { get; set; }
        public bool TownNPC { get; set; }
        public string LegacyName { get; set; } = "";
        public string GivenName { get; set; } = "";
        public Vector2 Position { get; set; }
        public bool Homeless { get; set; }
        public int HomeTileX { get; set; }
        public int HomeTileY { get; set; }
        public int TownNpcVariationIndex { get; set; }
        public bool ShimmeredTownNPC { get; set; }
    }
}
