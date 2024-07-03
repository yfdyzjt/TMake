using System.Drawing;

namespace TMake.Terraria
{
    public class WallProperty
    {
        public static WallData GetWallData(ushort type)
        {
            ushort usetype = (type > WallDatas.Keys.Max()) ? WallDatas.Keys.Max() : type;
            if (WallDatas.TryGetValue(usetype, out var data))
            {
                return data;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(type), $"Missing tile data: {type}");
            }
        }

        public readonly static Dictionary<ushort, WallData> WallDatas = new()
        {
            [0] = new()
            {
                Type = 0,
                Name = "Sky",
                Color = Color.FromArgb(151, 107, 75),
            },
            [1] = new()
            {
                Type = 1,
                Name = "Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [2] = new()
            {
                Type = 2,
                Name = "Dirt Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [3] = new()
            {
                Type = 3,
                Name = "Ebonstone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [4] = new()
            {
                Type = 4,
                Name = "Wood Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [5] = new()
            {
                Type = 5,
                Name = "Gray Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [6] = new()
            {
                Type = 6,
                Name = "Red Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [7] = new()
            {
                Type = 7,
                Name = "Cursed Blue Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [8] = new()
            {
                Type = 8,
                Name = "Cursed Green Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [9] = new()
            {
                Type = 9,
                Name = "Cursed Pink Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [10] = new()
            {
                Type = 10,
                Name = "Gold Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [11] = new()
            {
                Type = 11,
                Name = "Silver Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [12] = new()
            {
                Type = 12,
                Name = "Copper Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [13] = new()
            {
                Type = 13,
                Name = "Hellstone Brick Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [14] = new()
            {
                Type = 14,
                Name = "Obsidian Brick Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [15] = new()
            {
                Type = 15,
                Name = "Mud Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [16] = new()
            {
                Type = 16,
                Name = "Dirt Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [17] = new()
            {
                Type = 17,
                Name = "Blue Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [18] = new()
            {
                Type = 18,
                Name = "Green Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [19] = new()
            {
                Type = 19,
                Name = "Pink Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [20] = new()
            {
                Type = 20,
                Name = "Obsidian Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [21] = new()
            {
                Type = 21,
                Name = "Glass Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [22] = new()
            {
                Type = 22,
                Name = "Pearlstone Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [23] = new()
            {
                Type = 23,
                Name = "Iridescent Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [24] = new()
            {
                Type = 24,
                Name = "Mudstone Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [25] = new()
            {
                Type = 25,
                Name = "Cobalt Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [26] = new()
            {
                Type = 26,
                Name = "Mythril Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [27] = new()
            {
                Type = 27,
                Name = "Planked Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [28] = new()
            {
                Type = 28,
                Name = "Pearlstone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [29] = new()
            {
                Type = 29,
                Name = "Red Candy Cane Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [30] = new()
            {
                Type = 30,
                Name = "Green Candy Cane Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [31] = new()
            {
                Type = 31,
                Name = "Snow Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [32] = new()
            {
                Type = 32,
                Name = "Adamantite Beam Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [33] = new()
            {
                Type = 33,
                Name = "Demonite Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [34] = new()
            {
                Type = 34,
                Name = "Sandstone Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [35] = new()
            {
                Type = 35,
                Name = "Ebonstone Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [36] = new()
            {
                Type = 36,
                Name = "Red Stucco Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [37] = new()
            {
                Type = 37,
                Name = "Yellow Stucco Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [38] = new()
            {
                Type = 38,
                Name = "Green Stucco Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [39] = new()
            {
                Type = 39,
                Name = "Gray Stucco Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [40] = new()
            {
                Type = 40,
                Name = "Snow Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [41] = new()
            {
                Type = 41,
                Name = "Ebonwood Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [42] = new()
            {
                Type = 42,
                Name = "Rich Mahogany Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [43] = new()
            {
                Type = 43,
                Name = "Pearlwood Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [44] = new()
            {
                Type = 44,
                Name = "Rainbow Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [45] = new()
            {
                Type = 45,
                Name = "Tin Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [46] = new()
            {
                Type = 46,
                Name = "Tungsten Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [47] = new()
            {
                Type = 47,
                Name = "Platinum Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [48] = new()
            {
                Type = 48,
                Name = "Amethyst Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [49] = new()
            {
                Type = 49,
                Name = "Topaz Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [50] = new()
            {
                Type = 50,
                Name = "Sapphire Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [51] = new()
            {
                Type = 51,
                Name = "Emerald Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [52] = new()
            {
                Type = 52,
                Name = "Ruby Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [53] = new()
            {
                Type = 53,
                Name = "Diamond Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [54] = new()
            {
                Type = 54,
                Name = "Green Mossy Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [55] = new()
            {
                Type = 55,
                Name = "Brown Mossy Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [56] = new()
            {
                Type = 56,
                Name = "Red Mossy Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [57] = new()
            {
                Type = 57,
                Name = "Blue Mossy Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [58] = new()
            {
                Type = 58,
                Name = "Purple Mossy Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [59] = new()
            {
                Type = 59,
                Name = "Rocky Dirt Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [60] = new()
            {
                Type = 60,
                Name = "Living Leaf Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [61] = new()
            {
                Type = 61,
                Name = "Old Stone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [62] = new()
            {
                Type = 62,
                Name = "Infested Spider Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [63] = new()
            {
                Type = 63,
                Name = "Grass Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [64] = new()
            {
                Type = 64,
                Name = "Jungle Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [65] = new()
            {
                Type = 65,
                Name = "Flower Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [66] = new()
            {
                Type = 66,
                Name = "Grass Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [67] = new()
            {
                Type = 67,
                Name = "Jungle Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [68] = new()
            {
                Type = 68,
                Name = "Flower Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [69] = new()
            {
                Type = 69,
                Name = "Corrupt Grass Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [70] = new()
            {
                Type = 70,
                Name = "Hallowed Grass Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [71] = new()
            {
                Type = 71,
                Name = "Ice Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [72] = new()
            {
                Type = 72,
                Name = "Cactus Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [73] = new()
            {
                Type = 73,
                Name = "Cloud Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [74] = new()
            {
                Type = 74,
                Name = "Mushroom Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [75] = new()
            {
                Type = 75,
                Name = "Bone Block Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [76] = new()
            {
                Type = 76,
                Name = "Slime Block Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [77] = new()
            {
                Type = 77,
                Name = "Flesh Block Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [78] = new()
            {
                Type = 78,
                Name = "Living Wood Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [79] = new()
            {
                Type = 79,
                Name = "Obsidian Back Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [80] = new()
            {
                Type = 80,
                Name = "Mushroom Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [81] = new()
            {
                Type = 81,
                Name = "Crimson Grass Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [82] = new()
            {
                Type = 82,
                Name = "Disc Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [83] = new()
            {
                Type = 83,
                Name = "Crimstone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [84] = new()
            {
                Type = 84,
                Name = "Ice Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [85] = new()
            {
                Type = 85,
                Name = "Shadewood Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [86] = new()
            {
                Type = 86,
                Name = "Hive Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [87] = new()
            {
                Type = 87,
                Name = "Forbidden Lihzahrd Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [88] = new()
            {
                Type = 88,
                Name = "Purple Stained Glass",
                Color = Color.FromArgb(151, 107, 75),
            },
            [89] = new()
            {
                Type = 89,
                Name = "Yellow Stained Glass",
                Color = Color.FromArgb(151, 107, 75),
            },
            [90] = new()
            {
                Type = 90,
                Name = "Blue Stained Glass",
                Color = Color.FromArgb(151, 107, 75),
            },
            [91] = new()
            {
                Type = 91,
                Name = "Green Stained Glass",
                Color = Color.FromArgb(151, 107, 75),
            },
            [92] = new()
            {
                Type = 92,
                Name = "Red Stained Glass",
                Color = Color.FromArgb(151, 107, 75),
            },
            [93] = new()
            {
                Type = 93,
                Name = "Multicolored Stained Glass",
                Color = Color.FromArgb(151, 107, 75),
            },
            [94] = new()
            {
                Type = 94,
                Name = "Cursed Blue Slab Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [95] = new()
            {
                Type = 95,
                Name = "Cursed Blue Tiled Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [96] = new()
            {
                Type = 96,
                Name = "Cursed Pink Slab Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [97] = new()
            {
                Type = 97,
                Name = "Cursed Pink Tiled Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [98] = new()
            {
                Type = 98,
                Name = "Cursed Green Slab Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [99] = new()
            {
                Type = 99,
                Name = "Cursed Green Tiled Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [100] = new()
            {
                Type = 100,
                Name = "Blue Slab Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [101] = new()
            {
                Type = 101,
                Name = "Blue Tiled Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [102] = new()
            {
                Type = 102,
                Name = "Pink Slab Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [103] = new()
            {
                Type = 103,
                Name = "Pink Tiled Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [104] = new()
            {
                Type = 104,
                Name = "Green Slab Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [105] = new()
            {
                Type = 105,
                Name = "Green Tiled Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [106] = new()
            {
                Type = 106,
                Name = "Wooden Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [107] = new()
            {
                Type = 107,
                Name = "Lead Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [108] = new()
            {
                Type = 108,
                Name = "Hive Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [109] = new()
            {
                Type = 109,
                Name = "Palladium Column Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [110] = new()
            {
                Type = 110,
                Name = "Bubblegum Block Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [111] = new()
            {
                Type = 111,
                Name = "Titanstone Block Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [112] = new()
            {
                Type = 112,
                Name = "Lihzahrd Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [113] = new()
            {
                Type = 113,
                Name = "Pumpkin Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [114] = new()
            {
                Type = 114,
                Name = "Hay Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [115] = new()
            {
                Type = 115,
                Name = "Spooky Wood Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [116] = new()
            {
                Type = 116,
                Name = "Christmas Tree Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [117] = new()
            {
                Type = 117,
                Name = "Ornament Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [118] = new()
            {
                Type = 118,
                Name = "Candy Cane Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [119] = new()
            {
                Type = 119,
                Name = "Festive Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [120] = new()
            {
                Type = 120,
                Name = "Stars Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [121] = new()
            {
                Type = 121,
                Name = "Squiggles Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [122] = new()
            {
                Type = 122,
                Name = "Snowflake Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [123] = new()
            {
                Type = 123,
                Name = "Krampus Horn Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [124] = new()
            {
                Type = 124,
                Name = "Bluegreen Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [125] = new()
            {
                Type = 125,
                Name = "Grinch Finger Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [126] = new()
            {
                Type = 126,
                Name = "Fancy Gray Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [127] = new()
            {
                Type = 127,
                Name = "Ice Floe Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [128] = new()
            {
                Type = 128,
                Name = "Music Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [129] = new()
            {
                Type = 129,
                Name = "Purple Rain Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [130] = new()
            {
                Type = 130,
                Name = "Rainbow Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [131] = new()
            {
                Type = 131,
                Name = "Sparkle Stone Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [132] = new()
            {
                Type = 132,
                Name = "Starlit Heaven Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [133] = new()
            {
                Type = 133,
                Name = "Bubble Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [134] = new()
            {
                Type = 134,
                Name = "Copper Pipe Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [135] = new()
            {
                Type = 135,
                Name = "Ducky Wallpaper",
                Color = Color.FromArgb(151, 107, 75),
            },
            [136] = new()
            {
                Type = 136,
                Name = "Waterfall Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [137] = new()
            {
                Type = 137,
                Name = "Lavafall Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [138] = new()
            {
                Type = 138,
                Name = "Ebonwood Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [139] = new()
            {
                Type = 139,
                Name = "Rich Mahogany Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [140] = new()
            {
                Type = 140,
                Name = "Pearlwood Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [141] = new()
            {
                Type = 141,
                Name = "Shadewood Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [142] = new()
            {
                Type = 142,
                Name = "White Dynasty Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [143] = new()
            {
                Type = 143,
                Name = "Blue Dynasty Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [144] = new()
            {
                Type = 144,
                Name = "Arcane Rune Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [145] = new()
            {
                Type = 145,
                Name = "Iron Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [146] = new()
            {
                Type = 146,
                Name = "Copper Plating Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [147] = new()
            {
                Type = 147,
                Name = "Stone Slab Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [148] = new()
            {
                Type = 148,
                Name = "Sail",
                Color = Color.FromArgb(151, 107, 75),
            },
            [149] = new()
            {
                Type = 149,
                Name = "Boreal Wood Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [150] = new()
            {
                Type = 150,
                Name = "Boreal Wood Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [151] = new()
            {
                Type = 151,
                Name = "Palm Wood Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [152] = new()
            {
                Type = 152,
                Name = "Palm Wood Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [153] = new()
            {
                Type = 153,
                Name = "Amber Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [154] = new()
            {
                Type = 154,
                Name = "Amethyst Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [155] = new()
            {
                Type = 155,
                Name = "Diamond Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [156] = new()
            {
                Type = 156,
                Name = "Emerald Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [157] = new()
            {
                Type = 157,
                Name = "Offline Amber Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [158] = new()
            {
                Type = 158,
                Name = "Offline Amethyst Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [159] = new()
            {
                Type = 159,
                Name = "Offline Diamond Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [160] = new()
            {
                Type = 160,
                Name = "Offline Emerald Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [161] = new()
            {
                Type = 161,
                Name = "Offline Ruby Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [162] = new()
            {
                Type = 162,
                Name = "Offline Sapphire Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [163] = new()
            {
                Type = 163,
                Name = "Offline Topaz Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [164] = new()
            {
                Type = 164,
                Name = "Ruby Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [165] = new()
            {
                Type = 165,
                Name = "Sapphire Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [166] = new()
            {
                Type = 166,
                Name = "Topaz Gemspark Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [167] = new()
            {
                Type = 167,
                Name = "Tin Plating Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [168] = new()
            {
                Type = 168,
                Name = "Confetti Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [169] = new()
            {
                Type = 169,
                Name = "Midnight Confetti Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [170] = new()
            {
                Type = 170,
                Name = "Cave Dirt Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [171] = new()
            {
                Type = 171,
                Name = "Rough Dirt Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [172] = new()
            {
                Type = 172,
                Name = "Honeyfall Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [173] = new()
            {
                Type = 173,
                Name = "Chlorophyte Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [174] = new()
            {
                Type = 174,
                Name = "Crimtane Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [175] = new()
            {
                Type = 175,
                Name = "Shroomite Plating Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [176] = new()
            {
                Type = 176,
                Name = "Martian Conduit Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [177] = new()
            {
                Type = 177,
                Name = "Hellstone Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [178] = new()
            {
                Type = 178,
                Name = "Marble Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [179] = new()
            {
                Type = 179,
                Name = "Smooth Marble Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [180] = new()
            {
                Type = 180,
                Name = "Granite Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [181] = new()
            {
                Type = 181,
                Name = "Smooth Granite Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [182] = new()
            {
                Type = 182,
                Name = "Meteorite Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [183] = new()
            {
                Type = 183,
                Name = "Marble Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [184] = new()
            {
                Type = 184,
                Name = "Granite Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [185] = new()
            {
                Type = 185,
                Name = "Craggy Stone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [186] = new()
            {
                Type = 186,
                Name = "Crystal Block Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [187] = new()
            {
                Type = 187,
                Name = "Treacherous Sandstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [188] = new()
            {
                Type = 188,
                Name = "Corrupt Growth Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [189] = new()
            {
                Type = 189,
                Name = "Corrupt Mass Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [190] = new()
            {
                Type = 190,
                Name = "Corrupt Pustule Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [191] = new()
            {
                Type = 191,
                Name = "Corrupt Tendril Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [192] = new()
            {
                Type = 192,
                Name = "Crimson Crust Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [193] = new()
            {
                Type = 193,
                Name = "Crimson Scab Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [194] = new()
            {
                Type = 194,
                Name = "Crimson Teeth Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [195] = new()
            {
                Type = 195,
                Name = "Crimson Blister Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [196] = new()
            {
                Type = 196,
                Name = "Layered Dirt Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [197] = new()
            {
                Type = 197,
                Name = "Crumbling Dirt Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [198] = new()
            {
                Type = 198,
                Name = "Cracked Dirt Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [199] = new()
            {
                Type = 199,
                Name = "Wavy Dirt Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [200] = new()
            {
                Type = 200,
                Name = "Hallowed Prism Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [201] = new()
            {
                Type = 201,
                Name = "Hallowed Cavern Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [202] = new()
            {
                Type = 202,
                Name = "Hallowed Shard Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [203] = new()
            {
                Type = 203,
                Name = "Hallowed Crystalline Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [204] = new()
            {
                Type = 204,
                Name = "Lichen Stone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [205] = new()
            {
                Type = 205,
                Name = "Leafy Jungle Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [206] = new()
            {
                Type = 206,
                Name = "Ivy Stone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [207] = new()
            {
                Type = 207,
                Name = "Jungle Vine Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [208] = new()
            {
                Type = 208,
                Name = "Ember Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [209] = new()
            {
                Type = 209,
                Name = "Cinder Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [210] = new()
            {
                Type = 210,
                Name = "Magma Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [211] = new()
            {
                Type = 211,
                Name = "Smouldering Stone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [212] = new()
            {
                Type = 212,
                Name = "Worn Stone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [213] = new()
            {
                Type = 213,
                Name = "Stalactite Stone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [214] = new()
            {
                Type = 214,
                Name = "Mottled Stone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [215] = new()
            {
                Type = 215,
                Name = "Fractured Stone Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [216] = new()
            {
                Type = 216,
                Name = "Treacherous Hardened Sand Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [217] = new()
            {
                Type = 217,
                Name = "Treacherous Hardened Ebonsand Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [218] = new()
            {
                Type = 218,
                Name = "Treacherous Hardened Crimsand Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [219] = new()
            {
                Type = 219,
                Name = "Treacherous Hardened Pearlsand Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [220] = new()
            {
                Type = 220,
                Name = "Treacherous Ebonsandstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [221] = new()
            {
                Type = 221,
                Name = "Treacherous Crimsandstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [222] = new()
            {
                Type = 222,
                Name = "Treacherous Pearlsandstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [223] = new()
            {
                Type = 223,
                Name = "Desert Fossil Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [224] = new()
            {
                Type = 224,
                Name = "Luminite Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [225] = new()
            {
                Type = 225,
                Name = "Cog Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [226] = new()
            {
                Type = 226,
                Name = "Sandfall Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [227] = new()
            {
                Type = 227,
                Name = "Snowfall Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [228] = new()
            {
                Type = 228,
                Name = "Silly Pink Balloon Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [229] = new()
            {
                Type = 229,
                Name = "Silly Purple Balloon Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [230] = new()
            {
                Type = 230,
                Name = "Silly Green Balloon Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [231] = new()
            {
                Type = 231,
                Name = "Iron Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [232] = new()
            {
                Type = 232,
                Name = "Lead Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [233] = new()
            {
                Type = 233,
                Name = "Lesion Block Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [234] = new()
            {
                Type = 234,
                Name = "Crimstone Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [235] = new()
            {
                Type = 235,
                Name = "Smooth Sandstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [236] = new()
            {
                Type = 236,
                Name = "Spider Nest Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [237] = new()
            {
                Type = 237,
                Name = "Solar Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [238] = new()
            {
                Type = 238,
                Name = "Vortex Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [239] = new()
            {
                Type = 239,
                Name = "Nebula Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [240] = new()
            {
                Type = 240,
                Name = "Stardust Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [241] = new()
            {
                Type = 241,
                Name = "Orange Stained Glass",
                Color = Color.FromArgb(151, 107, 75),
            },
            [242] = new()
            {
                Type = 242,
                Name = "Gold Starry Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [243] = new()
            {
                Type = 243,
                Name = "Blue Starry Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [244] = new()
            {
                Type = 244,
                Name = "Living Wood Wall (natural)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [245] = new()
            {
                Type = 245,
                Name = "Wrought Iron Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [246] = new()
            {
                Type = 246,
                Name = "Ebonstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [247] = new()
            {
                Type = 247,
                Name = "Mud Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [248] = new()
            {
                Type = 248,
                Name = "Pearlstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [249] = new()
            {
                Type = 249,
                Name = "Snow Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [250] = new()
            {
                Type = 250,
                Name = "Amethyst Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [251] = new()
            {
                Type = 251,
                Name = "Topaz Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [252] = new()
            {
                Type = 252,
                Name = "Sapphire Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [253] = new()
            {
                Type = 253,
                Name = "Emerald Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [254] = new()
            {
                Type = 254,
                Name = "Ruby Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [255] = new()
            {
                Type = 255,
                Name = "Diamond Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [256] = new()
            {
                Type = 256,
                Name = "Green Mossy Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [257] = new()
            {
                Type = 257,
                Name = "Brown Mossy Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [258] = new()
            {
                Type = 258,
                Name = "Red Mossy Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [259] = new()
            {
                Type = 259,
                Name = "Blue Mossy Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [260] = new()
            {
                Type = 260,
                Name = "Purple Mossy Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [261] = new()
            {
                Type = 261,
                Name = "Rocky Dirt Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [262] = new()
            {
                Type = 262,
                Name = "Old Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [263] = new()
            {
                Type = 263,
                Name = "Spider Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [264] = new()
            {
                Type = 264,
                Name = "Corrupt Grass Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [265] = new()
            {
                Type = 265,
                Name = "Hallowed Grass Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [266] = new()
            {
                Type = 266,
                Name = "Ice Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [267] = new()
            {
                Type = 267,
                Name = "Obsidian Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [268] = new()
            {
                Type = 268,
                Name = "Crimson Grass Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [269] = new()
            {
                Type = 269,
                Name = "Crimstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [270] = new()
            {
                Type = 270,
                Name = "Cave Dirt Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [271] = new()
            {
                Type = 271,
                Name = "Rough Dirt Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [272] = new()
            {
                Type = 272,
                Name = "Marble Wall (unused)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [273] = new()
            {
                Type = 273,
                Name = "Granite Wall (unused)",
                Color = Color.FromArgb(151, 107, 75),
            },
            [274] = new()
            {
                Type = 274,
                Name = "Craggy Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [275] = new()
            {
                Type = 275,
                Name = "Sandstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [276] = new()
            {
                Type = 276,
                Name = "Corrupt Growth Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [277] = new()
            {
                Type = 277,
                Name = "Corrupt Mass Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [278] = new()
            {
                Type = 278,
                Name = "Corrupt Pustule Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [279] = new()
            {
                Type = 279,
                Name = "Corrupt Tendril Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [280] = new()
            {
                Type = 280,
                Name = "Crimson Crust Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [281] = new()
            {
                Type = 281,
                Name = "Crimson Scab Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [282] = new()
            {
                Type = 282,
                Name = "Crimson Teeth Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [283] = new()
            {
                Type = 283,
                Name = "Crimson Blister Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [284] = new()
            {
                Type = 284,
                Name = "Layered Dirt Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [285] = new()
            {
                Type = 285,
                Name = "Crumbling Dirt Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [286] = new()
            {
                Type = 286,
                Name = "Cracked Dirt Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [287] = new()
            {
                Type = 287,
                Name = "Wavy Dirt Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [288] = new()
            {
                Type = 288,
                Name = "Hallowed Prism Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [289] = new()
            {
                Type = 289,
                Name = "Hallowed Cavern Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [290] = new()
            {
                Type = 290,
                Name = "Hallowed Shard Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [291] = new()
            {
                Type = 291,
                Name = "Hallowed Crystalline Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [292] = new()
            {
                Type = 292,
                Name = "Lichen Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [293] = new()
            {
                Type = 293,
                Name = "Leafy Jungle Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [294] = new()
            {
                Type = 294,
                Name = "Ivy Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [295] = new()
            {
                Type = 295,
                Name = "Jungle Vine Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [296] = new()
            {
                Type = 296,
                Name = "Ember Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [297] = new()
            {
                Type = 297,
                Name = "Cinder Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [298] = new()
            {
                Type = 298,
                Name = "Magma Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [299] = new()
            {
                Type = 299,
                Name = "Smouldering Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [300] = new()
            {
                Type = 300,
                Name = "Worn Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [301] = new()
            {
                Type = 301,
                Name = "Stalactite Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [302] = new()
            {
                Type = 302,
                Name = "Mottled Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [303] = new()
            {
                Type = 303,
                Name = "Fractured Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [304] = new()
            {
                Type = 304,
                Name = "Hardened Sand Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [305] = new()
            {
                Type = 305,
                Name = "Hardened Ebonsand Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [306] = new()
            {
                Type = 306,
                Name = "Hardened Crimsand Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [307] = new()
            {
                Type = 307,
                Name = "Hardened Pearlsand Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [308] = new()
            {
                Type = 308,
                Name = "Ebonsandstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [309] = new()
            {
                Type = 309,
                Name = "Crimsandstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [310] = new()
            {
                Type = 310,
                Name = "Pearlsandstone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [311] = new()
            {
                Type = 311,
                Name = "Desert Fossil Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [312] = new()
            {
                Type = 312,
                Name = "Bamboo Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [313] = new()
            {
                Type = 313,
                Name = "Large Bamboo Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [314] = new()
            {
                Type = 314,
                Name = "Amber Stone Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [315] = new()
            {
                Type = 315,
                Name = "Bamboo Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [316] = new()
            {
                Type = 316,
                Name = "Ash Wood Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [317] = new()
            {
                Type = 317,
                Name = "Ash Wood Fence",
                Color = Color.FromArgb(151, 107, 75),
            },
            [318] = new()
            {
                Type = 318,
                Name = "Echo Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [319] = new()
            {
                Type = 319,
                Name = "Reef Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [320] = new()
            {
                Type = 320,
                Name = "Poo Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [321] = new()
            {
                Type = 321,
                Name = "Aetherium Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [322] = new()
            {
                Type = 322,
                Name = "Aetherium Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [323] = new()
            {
                Type = 323,
                Name = "Lunar Rust Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [324] = new()
            {
                Type = 324,
                Name = "Dark Celestial Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [325] = new()
            {
                Type = 325,
                Name = "Astra Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [326] = new()
            {
                Type = 326,
                Name = "Cosmic Ember Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [327] = new()
            {
                Type = 327,
                Name = "Cryocore Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [328] = new()
            {
                Type = 328,
                Name = "Mercury Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [329] = new()
            {
                Type = 329,
                Name = "Star Royale Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [330] = new()
            {
                Type = 330,
                Name = "Heavenforge Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [331] = new()
            {
                Type = 331,
                Name = "Ancient Blue Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [332] = new()
            {
                Type = 332,
                Name = "Ancient Green Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [333] = new()
            {
                Type = 333,
                Name = "Ancient Pink Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [334] = new()
            {
                Type = 334,
                Name = "Ancient Gold Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [335] = new()
            {
                Type = 335,
                Name = "Ancient Silver Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [336] = new()
            {
                Type = 336,
                Name = "Ancient Copper Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [337] = new()
            {
                Type = 337,
                Name = "Ancient Obsidian Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [338] = new()
            {
                Type = 338,
                Name = "Ancient Hellstone Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [339] = new()
            {
                Type = 339,
                Name = "Ancient Cobalt Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [340] = new()
            {
                Type = 340,
                Name = "Ancient Mythril Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [341] = new()
            {
                Type = 341,
                Name = "Lava Moss Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [342] = new()
            {
                Type = 342,
                Name = "Argon Moss Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [343] = new()
            {
                Type = 343,
                Name = "Krypton Moss Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [344] = new()
            {
                Type = 344,
                Name = "Xenon Moss Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [345] = new()
            {
                Type = 345,
                Name = "Neon Moss Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
            [346] = new()
            {
                Type = 346,
                Name = "Helium Moss Brick Wall",
                Color = Color.FromArgb(151, 107, 75),
            },
        };
    }
}
