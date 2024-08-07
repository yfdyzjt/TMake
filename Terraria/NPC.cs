﻿using System.Numerics;

namespace TMake.Terraria
{
    public class NPC
    {
        public int Type { get; set; }
        public bool TownNPC { get; set; }
        public string LegacyName { get; set; } = string.Empty;
        public string GivenName { get; set; } = string.Empty;
        public Vector2 Position { get; set; }
        public bool Homeless { get; set; }
        public int HomeTileX { get; set; }
        public int HomeTileY { get; set; }
        public int TownNpcVariationIndex { get; set; }
        public bool ShimmeredTownNPC { get; set; }
        public NPC Copy()
        {
            return (NPC)MemberwiseClone();
        }
    }
}
