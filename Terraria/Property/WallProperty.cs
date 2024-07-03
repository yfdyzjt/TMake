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
				Color = Color.FromArgb(255, 255, 255),
			},
			[1] = new()
			{
				Type = 1,
				Name = "Stone Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[2] = new()
			{
				Type = 2,
				Name = "Dirt Wall (natural)",
				Color = Color.FromArgb(88, 61, 46),
			},
			[3] = new()
			{
				Type = 3,
				Name = "Ebonstone Wall (natural)",
				Color = Color.FromArgb(61, 58, 78),
			},
			[4] = new()
			{
				Type = 4,
				Name = "Wood Wall",
				Color = Color.FromArgb(73, 51, 36),
			},
			[5] = new()
			{
				Type = 5,
				Name = "Gray Brick Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[6] = new()
			{
				Type = 6,
				Name = "Red Brick Wall",
				Color = Color.FromArgb(91, 30, 30),
			},
			[7] = new()
			{
				Type = 7,
				Name = "Cursed Blue Brick Wall",
				Color = Color.FromArgb(27, 31, 42),
			},
			[8] = new()
			{
				Type = 8,
				Name = "Cursed Green Brick Wall",
				Color = Color.FromArgb(31, 39, 26),
			},
			[9] = new()
			{
				Type = 9,
				Name = "Cursed Pink Brick Wall",
				Color = Color.FromArgb(41, 28, 36),
			},
			[10] = new()
			{
				Type = 10,
				Name = "Gold Brick Wall",
				Color = Color.FromArgb(74, 62, 12),
			},
			[11] = new()
			{
				Type = 11,
				Name = "Silver Brick Wall",
				Color = Color.FromArgb(46, 56, 59),
			},
			[12] = new()
			{
				Type = 12,
				Name = "Copper Brick Wall",
				Color = Color.FromArgb(75, 32, 11),
			},
			[13] = new()
			{
				Type = 13,
				Name = "Hellstone Brick Wall (natural)",
				Color = Color.FromArgb(67, 37, 37),
			},
			[14] = new()
			{
				Type = 14,
				Name = "Obsidian Brick Wall (natural)",
				Color = Color.FromArgb(15, 15, 15),
			},
			[15] = new()
			{
				Type = 15,
				Name = "Mud Wall (natural)",
				Color = Color.FromArgb(52, 43, 45),
			},
			[16] = new()
			{
				Type = 16,
				Name = "Dirt Wall",
				Color = Color.FromArgb(88, 61, 46),
			},
			[17] = new()
			{
				Type = 17,
				Name = "Blue Brick Wall",
				Color = Color.FromArgb(27, 31, 42),
			},
			[18] = new()
			{
				Type = 18,
				Name = "Green Brick Wall",
				Color = Color.FromArgb(31, 39, 26),
			},
			[19] = new()
			{
				Type = 19,
				Name = "Pink Brick Wall",
				Color = Color.FromArgb(41, 28, 36),
			},
			[20] = new()
			{
				Type = 20,
				Name = "Obsidian Brick Wall",
				Color = Color.FromArgb(15, 15, 15),
			},
			[21] = new()
			{
				Type = 21,
				Name = "Glass Wall",
				Color = Color.FromArgb(0, 0, 0),
			},
			[22] = new()
			{
				Type = 22,
				Name = "Pearlstone Brick Wall",
				Color = Color.FromArgb(113, 99, 99),
			},
			[23] = new()
			{
				Type = 23,
				Name = "Iridescent Brick Wall",
				Color = Color.FromArgb(38, 38, 43),
			},
			[24] = new()
			{
				Type = 24,
				Name = "Mudstone Brick Wall",
				Color = Color.FromArgb(53, 39, 41),
			},
			[25] = new()
			{
				Type = 25,
				Name = "Cobalt Brick Wall",
				Color = Color.FromArgb(11, 35, 62),
			},
			[26] = new()
			{
				Type = 26,
				Name = "Mythril Brick Wall",
				Color = Color.FromArgb(21, 63, 70),
			},
			[27] = new()
			{
				Type = 27,
				Name = "Planked Wall",
				Color = Color.FromArgb(88, 61, 46),
			},
			[28] = new()
			{
				Type = 28,
				Name = "Pearlstone Wall (natural)",
				Color = Color.FromArgb(81, 84, 101),
			},
			[29] = new()
			{
				Type = 29,
				Name = "Red Candy Cane Wall",
				Color = Color.FromArgb(88, 23, 23),
			},
			[30] = new()
			{
				Type = 30,
				Name = "Green Candy Cane Wall",
				Color = Color.FromArgb(28, 88, 23),
			},
			[31] = new()
			{
				Type = 31,
				Name = "Snow Brick Wall",
				Color = Color.FromArgb(78, 87, 99),
			},
			[32] = new()
			{
				Type = 32,
				Name = "Adamantite Beam Wall",
				Color = Color.FromArgb(86, 17, 40),
			},
			[33] = new()
			{
				Type = 33,
				Name = "Demonite Brick Wall",
				Color = Color.FromArgb(49, 47, 83),
			},
			[34] = new()
			{
				Type = 34,
				Name = "Sandstone Brick Wall",
				Color = Color.FromArgb(69, 67, 41),
			},
			[35] = new()
			{
				Type = 35,
				Name = "Ebonstone Brick Wall",
				Color = Color.FromArgb(51, 51, 70),
			},
			[36] = new()
			{
				Type = 36,
				Name = "Red Stucco Wall",
				Color = Color.FromArgb(87, 59, 55),
			},
			[37] = new()
			{
				Type = 37,
				Name = "Yellow Stucco Wall",
				Color = Color.FromArgb(69, 67, 41),
			},
			[38] = new()
			{
				Type = 38,
				Name = "Green Stucco Wall",
				Color = Color.FromArgb(49, 57, 49),
			},
			[39] = new()
			{
				Type = 39,
				Name = "Gray Stucco Wall",
				Color = Color.FromArgb(78, 79, 73),
			},
			[40] = new()
			{
				Type = 40,
				Name = "Snow Wall (natural)",
				Color = Color.FromArgb(85, 102, 103),
			},
			[41] = new()
			{
				Type = 41,
				Name = "Ebonwood Wall",
				Color = Color.FromArgb(52, 50, 62),
			},
			[42] = new()
			{
				Type = 42,
				Name = "Rich Mahogany Wall",
				Color = Color.FromArgb(71, 42, 44),
			},
			[43] = new()
			{
				Type = 43,
				Name = "Pearlwood Wall",
				Color = Color.FromArgb(73, 66, 50),
			},
			[44] = new()
			{
				Type = 44,
				Name = "Rainbow Brick Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[45] = new()
			{
				Type = 45,
				Name = "Tin Brick Wall",
				Color = Color.FromArgb(60, 59, 51),
			},
			[46] = new()
			{
				Type = 46,
				Name = "Tungsten Brick Wall",
				Color = Color.FromArgb(48, 57, 47),
			},
			[47] = new()
			{
				Type = 47,
				Name = "Platinum Brick Wall",
				Color = Color.FromArgb(71, 77, 85),
			},
			[48] = new()
			{
				Type = 48,
				Name = "Amethyst Wall (natural)",
				Color = Color.FromArgb(52, 52, 52),
			},
			[49] = new()
			{
				Type = 49,
				Name = "Topaz Wall (natural)",
				Color = Color.FromArgb(52, 52, 52),
			},
			[50] = new()
			{
				Type = 50,
				Name = "Sapphire Wall (natural)",
				Color = Color.FromArgb(52, 52, 52),
			},
			[51] = new()
			{
				Type = 51,
				Name = "Emerald Wall (natural)",
				Color = Color.FromArgb(52, 52, 52),
			},
			[52] = new()
			{
				Type = 52,
				Name = "Ruby Wall (natural)",
				Color = Color.FromArgb(52, 52, 52),
			},
			[53] = new()
			{
				Type = 53,
				Name = "Diamond Wall (natural)",
				Color = Color.FromArgb(52, 52, 52),
			},
			[54] = new()
			{
				Type = 54,
				Name = "Green Mossy Wall (natural)",
				Color = Color.FromArgb(40, 56, 50),
			},
			[55] = new()
			{
				Type = 55,
				Name = "Brown Mossy Wall (natural)",
				Color = Color.FromArgb(49, 48, 36),
			},
			[56] = new()
			{
				Type = 56,
				Name = "Red Mossy Wall (natural)",
				Color = Color.FromArgb(43, 33, 32),
			},
			[57] = new()
			{
				Type = 57,
				Name = "Blue Mossy Wall (natural)",
				Color = Color.FromArgb(31, 40, 49),
			},
			[58] = new()
			{
				Type = 58,
				Name = "Purple Mossy Wall (natural)",
				Color = Color.FromArgb(48, 35, 52),
			},
			[59] = new()
			{
				Type = 59,
				Name = "Rocky Dirt Wall (natural)",
				Color = Color.FromArgb(88, 61, 46),
			},
			[60] = new()
			{
				Type = 60,
				Name = "Living Leaf Wall (natural)",
				Color = Color.FromArgb(1, 52, 20),
			},
			[61] = new()
			{
				Type = 61,
				Name = "Old Stone Wall (natural)",
				Color = Color.FromArgb(55, 39, 26),
			},
			[62] = new()
			{
				Type = 62,
				Name = "Infested Spider Wall",
				Color = Color.FromArgb(39, 33, 26),
			},
			[63] = new()
			{
				Type = 63,
				Name = "Grass Wall (natural)",
				Color = Color.FromArgb(30, 80, 48),
			},
			[64] = new()
			{
				Type = 64,
				Name = "Jungle Wall (natural)",
				Color = Color.FromArgb(53, 80, 30),
			},
			[65] = new()
			{
				Type = 65,
				Name = "Flower Wall (natural)",
				Color = Color.FromArgb(30, 80, 48),
			},
			[66] = new()
			{
				Type = 66,
				Name = "Grass Wall",
				Color = Color.FromArgb(30, 80, 48),
			},
			[67] = new()
			{
				Type = 67,
				Name = "Jungle Wall",
				Color = Color.FromArgb(53, 80, 30),
			},
			[68] = new()
			{
				Type = 68,
				Name = "Flower Wall",
				Color = Color.FromArgb(30, 80, 48),
			},
			[69] = new()
			{
				Type = 69,
				Name = "Corrupt Grass Wall (natural)",
				Color = Color.FromArgb(43, 42, 68),
			},
			[70] = new()
			{
				Type = 70,
				Name = "Hallowed Grass Wall (natural)",
				Color = Color.FromArgb(30, 70, 80),
			},
			[71] = new()
			{
				Type = 71,
				Name = "Ice Wall (natural)",
				Color = Color.FromArgb(78, 105, 135),
			},
			[72] = new()
			{
				Type = 72,
				Name = "Cactus Wall",
				Color = Color.FromArgb(52, 84, 12),
			},
			[73] = new()
			{
				Type = 73,
				Name = "Cloud Wall",
				Color = Color.FromArgb(190, 204, 223),
			},
			[74] = new()
			{
				Type = 74,
				Name = "Mushroom Wall",
				Color = Color.FromArgb(64, 62, 80),
			},
			[75] = new()
			{
				Type = 75,
				Name = "Bone Block Wall",
				Color = Color.FromArgb(65, 65, 35),
			},
			[76] = new()
			{
				Type = 76,
				Name = "Slime Block Wall",
				Color = Color.FromArgb(20, 46, 104),
			},
			[77] = new()
			{
				Type = 77,
				Name = "Flesh Block Wall",
				Color = Color.FromArgb(61, 13, 16),
			},
			[78] = new()
			{
				Type = 78,
				Name = "Living Wood Wall",
				Color = Color.FromArgb(63, 39, 26),
			},
			[79] = new()
			{
				Type = 79,
				Name = "Obsidian Back Wall (natural)",
				Color = Color.FromArgb(51, 47, 96),
			},
			[80] = new()
			{
				Type = 80,
				Name = "Mushroom Wall (natural)",
				Color = Color.FromArgb(64, 62, 80),
			},
			[81] = new()
			{
				Type = 81,
				Name = "Crimson Grass Wall (natural)",
				Color = Color.FromArgb(101, 51, 51),
			},
			[82] = new()
			{
				Type = 82,
				Name = "Disc Wall",
				Color = Color.FromArgb(77, 64, 34),
			},
			[83] = new()
			{
				Type = 83,
				Name = "Crimstone Wall (natural)",
				Color = Color.FromArgb(62, 38, 41),
			},
			[84] = new()
			{
				Type = 84,
				Name = "Ice Brick Wall",
				Color = Color.FromArgb(48, 78, 93),
			},
			[85] = new()
			{
				Type = 85,
				Name = "Shadewood Wall",
				Color = Color.FromArgb(54, 63, 69),
			},
			[86] = new()
			{
				Type = 86,
				Name = "Hive Wall (natural)",
				Color = Color.FromArgb(138, 73, 38),
			},
			[87] = new()
			{
				Type = 87,
				Name = "Forbidden Lihzahrd Brick Wall",
				Color = Color.FromArgb(50, 15, 8),
			},
			[88] = new()
			{
				Type = 88,
				Name = "Purple Stained Glass",
				Color = Color.FromArgb(0, 0, 0),
			},
			[89] = new()
			{
				Type = 89,
				Name = "Yellow Stained Glass",
				Color = Color.FromArgb(0, 0, 0),
			},
			[90] = new()
			{
				Type = 90,
				Name = "Blue Stained Glass",
				Color = Color.FromArgb(0, 0, 0),
			},
			[91] = new()
			{
				Type = 91,
				Name = "Green Stained Glass",
				Color = Color.FromArgb(0, 0, 0),
			},
			[92] = new()
			{
				Type = 92,
				Name = "Red Stained Glass",
				Color = Color.FromArgb(0, 0, 0),
			},
			[93] = new()
			{
				Type = 93,
				Name = "Multicolored Stained Glass",
				Color = Color.FromArgb(0, 0, 0),
			},
			[94] = new()
			{
				Type = 94,
				Name = "Cursed Blue Slab Wall",
				Color = Color.FromArgb(32, 40, 45),
			},
			[95] = new()
			{
				Type = 95,
				Name = "Cursed Blue Tiled Wall",
				Color = Color.FromArgb(44, 41, 50),
			},
			[96] = new()
			{
				Type = 96,
				Name = "Cursed Pink Slab Wall",
				Color = Color.FromArgb(72, 50, 77),
			},
			[97] = new()
			{
				Type = 97,
				Name = "Cursed Pink Tiled Wall",
				Color = Color.FromArgb(78, 50, 69),
			},
			[98] = new()
			{
				Type = 98,
				Name = "Cursed Green Slab Wall",
				Color = Color.FromArgb(36, 45, 44),
			},
			[99] = new()
			{
				Type = 99,
				Name = "Cursed Green Tiled Wall",
				Color = Color.FromArgb(38, 49, 50),
			},
			[100] = new()
			{
				Type = 100,
				Name = "Blue Slab Wall",
				Color = Color.FromArgb(32, 40, 45),
			},
			[101] = new()
			{
				Type = 101,
				Name = "Blue Tiled Wall",
				Color = Color.FromArgb(44, 41, 50),
			},
			[102] = new()
			{
				Type = 102,
				Name = "Pink Slab Wall",
				Color = Color.FromArgb(72, 50, 77),
			},
			[103] = new()
			{
				Type = 103,
				Name = "Pink Tiled Wall",
				Color = Color.FromArgb(78, 50, 69),
			},
			[104] = new()
			{
				Type = 104,
				Name = "Green Slab Wall",
				Color = Color.FromArgb(36, 45, 44),
			},
			[105] = new()
			{
				Type = 105,
				Name = "Green Tiled Wall",
				Color = Color.FromArgb(38, 49, 50),
			},
			[106] = new()
			{
				Type = 106,
				Name = "Wooden Fence",
				Color = Color.FromArgb(0, 0, 0),
			},
			[107] = new()
			{
				Type = 107,
				Name = "Lead Fence",
				Color = Color.FromArgb(0, 0, 0),
			},
			[108] = new()
			{
				Type = 108,
				Name = "Hive Wall",
				Color = Color.FromArgb(138, 73, 38),
			},
			[109] = new()
			{
				Type = 109,
				Name = "Palladium Column Wall",
				Color = Color.FromArgb(94, 25, 17),
			},
			[110] = new()
			{
				Type = 110,
				Name = "Bubblegum Block Wall",
				Color = Color.FromArgb(125, 36, 122),
			},
			[111] = new()
			{
				Type = 111,
				Name = "Titanstone Block Wall",
				Color = Color.FromArgb(51, 35, 27),
			},
			[112] = new()
			{
				Type = 112,
				Name = "Lihzahrd Brick Wall",
				Color = Color.FromArgb(50, 15, 8),
			},
			[113] = new()
			{
				Type = 113,
				Name = "Pumpkin Wall",
				Color = Color.FromArgb(135, 58, 0),
			},
			[114] = new()
			{
				Type = 114,
				Name = "Hay Wall",
				Color = Color.FromArgb(65, 52, 15),
			},
			[115] = new()
			{
				Type = 115,
				Name = "Spooky Wood Wall",
				Color = Color.FromArgb(39, 42, 51),
			},
			[116] = new()
			{
				Type = 116,
				Name = "Christmas Tree Wallpaper",
				Color = Color.FromArgb(89, 26, 27),
			},
			[117] = new()
			{
				Type = 117,
				Name = "Ornament Wallpaper",
				Color = Color.FromArgb(126, 123, 115),
			},
			[118] = new()
			{
				Type = 118,
				Name = "Candy Cane Wallpaper",
				Color = Color.FromArgb(8, 50, 19),
			},
			[119] = new()
			{
				Type = 119,
				Name = "Festive Wallpaper",
				Color = Color.FromArgb(95, 21, 24),
			},
			[120] = new()
			{
				Type = 120,
				Name = "Stars Wallpaper",
				Color = Color.FromArgb(17, 31, 65),
			},
			[121] = new()
			{
				Type = 121,
				Name = "Squiggles Wallpaper",
				Color = Color.FromArgb(192, 173, 143),
			},
			[122] = new()
			{
				Type = 122,
				Name = "Snowflake Wallpaper",
				Color = Color.FromArgb(114, 114, 131),
			},
			[123] = new()
			{
				Type = 123,
				Name = "Krampus Horn Wallpaper",
				Color = Color.FromArgb(136, 119, 7),
			},
			[124] = new()
			{
				Type = 124,
				Name = "Bluegreen Wallpaper",
				Color = Color.FromArgb(8, 72, 3),
			},
			[125] = new()
			{
				Type = 125,
				Name = "Grinch Finger Wallpaper",
				Color = Color.FromArgb(117, 132, 82),
			},
			[126] = new()
			{
				Type = 126,
				Name = "Fancy Gray Wallpaper",
				Color = Color.FromArgb(100, 102, 114),
			},
			[127] = new()
			{
				Type = 127,
				Name = "Ice Floe Wallpaper",
				Color = Color.FromArgb(30, 118, 226),
			},
			[128] = new()
			{
				Type = 128,
				Name = "Music Wallpaper",
				Color = Color.FromArgb(93, 6, 102),
			},
			[129] = new()
			{
				Type = 129,
				Name = "Purple Rain Wallpaper",
				Color = Color.FromArgb(64, 40, 169),
			},
			[130] = new()
			{
				Type = 130,
				Name = "Rainbow Wallpaper",
				Color = Color.FromArgb(39, 34, 180),
			},
			[131] = new()
			{
				Type = 131,
				Name = "Sparkle Stone Wallpaper",
				Color = Color.FromArgb(87, 94, 125),
			},
			[132] = new()
			{
				Type = 132,
				Name = "Starlit Heaven Wallpaper",
				Color = Color.FromArgb(6, 6, 6),
			},
			[133] = new()
			{
				Type = 133,
				Name = "Bubble Wallpaper",
				Color = Color.FromArgb(69, 72, 186),
			},
			[134] = new()
			{
				Type = 134,
				Name = "Copper Pipe Wallpaper",
				Color = Color.FromArgb(130, 62, 16),
			},
			[135] = new()
			{
				Type = 135,
				Name = "Ducky Wallpaper",
				Color = Color.FromArgb(22, 123, 163),
			},
			[136] = new()
			{
				Type = 136,
				Name = "Waterfall Wall",
				Color = Color.FromArgb(40, 86, 151),
			},
			[137] = new()
			{
				Type = 137,
				Name = "Lavafall Wall",
				Color = Color.FromArgb(183, 75, 15),
			},
			[138] = new()
			{
				Type = 138,
				Name = "Ebonwood Fence",
				Color = Color.FromArgb(83, 80, 100),
			},
			[139] = new()
			{
				Type = 139,
				Name = "Rich Mahogany Fence",
				Color = Color.FromArgb(115, 65, 68),
			},
			[140] = new()
			{
				Type = 140,
				Name = "Pearlwood Fence",
				Color = Color.FromArgb(119, 108, 81),
			},
			[141] = new()
			{
				Type = 141,
				Name = "Shadewood Fence",
				Color = Color.FromArgb(59, 67, 71),
			},
			[142] = new()
			{
				Type = 142,
				Name = "White Dynasty Wall",
				Color = Color.FromArgb(222, 216, 202),
			},
			[143] = new()
			{
				Type = 143,
				Name = "Blue Dynasty Wall",
				Color = Color.FromArgb(90, 112, 105),
			},
			[144] = new()
			{
				Type = 144,
				Name = "Arcane Rune Wall",
				Color = Color.FromArgb(62, 28, 87),
			},
			[145] = new()
			{
				Type = 145,
				Name = "Iron Fence",
				Color = Color.FromArgb(0, 0, 0),
			},
			[146] = new()
			{
				Type = 146,
				Name = "Copper Plating Wall",
				Color = Color.FromArgb(120, 59, 19),
			},
			[147] = new()
			{
				Type = 147,
				Name = "Stone Slab Wall",
				Color = Color.FromArgb(59, 59, 59),
			},
			[148] = new()
			{
				Type = 148,
				Name = "Sail",
				Color = Color.FromArgb(229, 218, 161),
			},
			[149] = new()
			{
				Type = 149,
				Name = "Boreal Wood Wall",
				Color = Color.FromArgb(73, 59, 50),
			},
			[150] = new()
			{
				Type = 150,
				Name = "Boreal Wood Fence",
				Color = Color.FromArgb(0, 0, 0),
			},
			[151] = new()
			{
				Type = 151,
				Name = "Palm Wood Wall",
				Color = Color.FromArgb(102, 75, 34),
			},
			[152] = new()
			{
				Type = 152,
				Name = "Palm Wood Fence",
				Color = Color.FromArgb(0, 0, 0),
			},
			[153] = new()
			{
				Type = 153,
				Name = "Amber Gemspark Wall",
				Color = Color.FromArgb(255, 145, 79),
			},
			[154] = new()
			{
				Type = 154,
				Name = "Amethyst Gemspark Wall",
				Color = Color.FromArgb(221, 79, 255),
			},
			[155] = new()
			{
				Type = 155,
				Name = "Diamond Gemspark Wall",
				Color = Color.FromArgb(240, 240, 247),
			},
			[156] = new()
			{
				Type = 156,
				Name = "Emerald Gemspark Wall",
				Color = Color.FromArgb(79, 255, 89),
			},
			[157] = new()
			{
				Type = 157,
				Name = "Offline Amber Gemspark Wall",
				Color = Color.FromArgb(154, 83, 49),
			},
			[158] = new()
			{
				Type = 158,
				Name = "Offline Amethyst Gemspark Wall",
				Color = Color.FromArgb(107, 49, 154),
			},
			[159] = new()
			{
				Type = 159,
				Name = "Offline Diamond Gemspark Wall",
				Color = Color.FromArgb(85, 89, 118),
			},
			[160] = new()
			{
				Type = 160,
				Name = "Offline Emerald Gemspark Wall",
				Color = Color.FromArgb(49, 154, 68),
			},
			[161] = new()
			{
				Type = 161,
				Name = "Offline Ruby Gemspark Wall",
				Color = Color.FromArgb(154, 49, 77),
			},
			[162] = new()
			{
				Type = 162,
				Name = "Offline Sapphire Gemspark Wall",
				Color = Color.FromArgb(49, 49, 154),
			},
			[163] = new()
			{
				Type = 163,
				Name = "Offline Topaz Gemspark Wall",
				Color = Color.FromArgb(154, 148, 49),
			},
			[164] = new()
			{
				Type = 164,
				Name = "Ruby Gemspark Wall",
				Color = Color.FromArgb(255, 79, 79),
			},
			[165] = new()
			{
				Type = 165,
				Name = "Sapphire Gemspark Wall",
				Color = Color.FromArgb(79, 102, 255),
			},
			[166] = new()
			{
				Type = 166,
				Name = "Topaz Gemspark Wall",
				Color = Color.FromArgb(250, 255, 79),
			},
			[167] = new()
			{
				Type = 167,
				Name = "Tin Plating Wall",
				Color = Color.FromArgb(70, 68, 51),
			},
			[168] = new()
			{
				Type = 168,
				Name = "Confetti Wall",
				Color = Color.FromArgb(0, 0, 0),
			},
			[169] = new()
			{
				Type = 169,
				Name = "Midnight Confetti Wall",
				Color = Color.FromArgb(5, 5, 5),
			},
			[170] = new()
			{
				Type = 170,
				Name = "Cave Dirt Wall (natural)",
				Color = Color.FromArgb(59, 39, 22),
			},
			[171] = new()
			{
				Type = 171,
				Name = "Rough Dirt Wall (natural)",
				Color = Color.FromArgb(59, 39, 22),
			},
			[172] = new()
			{
				Type = 172,
				Name = "Honeyfall Wall",
				Color = Color.FromArgb(163, 96, 0),
			},
			[173] = new()
			{
				Type = 173,
				Name = "Chlorophyte Brick Wall",
				Color = Color.FromArgb(94, 163, 46),
			},
			[174] = new()
			{
				Type = 174,
				Name = "Crimtane Brick Wall",
				Color = Color.FromArgb(117, 32, 59),
			},
			[175] = new()
			{
				Type = 175,
				Name = "Shroomite Plating Wall",
				Color = Color.FromArgb(20, 11, 203),
			},
			[176] = new()
			{
				Type = 176,
				Name = "Martian Conduit Wall",
				Color = Color.FromArgb(74, 69, 88),
			},
			[177] = new()
			{
				Type = 177,
				Name = "Hellstone Brick Wall",
				Color = Color.FromArgb(60, 30, 30),
			},
			[178] = new()
			{
				Type = 178,
				Name = "Marble Wall (natural)",
				Color = Color.FromArgb(111, 117, 135),
			},
			[179] = new()
			{
				Type = 179,
				Name = "Smooth Marble Wall",
				Color = Color.FromArgb(111, 117, 135),
			},
			[180] = new()
			{
				Type = 180,
				Name = "Granite Wall (natural)",
				Color = Color.FromArgb(25, 23, 54),
			},
			[181] = new()
			{
				Type = 181,
				Name = "Smooth Granite Wall",
				Color = Color.FromArgb(25, 23, 54),
			},
			[182] = new()
			{
				Type = 182,
				Name = "Meteorite Brick Wall",
				Color = Color.FromArgb(74, 71, 129),
			},
			[183] = new()
			{
				Type = 183,
				Name = "Marble Wall",
				Color = Color.FromArgb(111, 117, 135),
			},
			[184] = new()
			{
				Type = 184,
				Name = "Granite Wall",
				Color = Color.FromArgb(25, 23, 54),
			},
			[185] = new()
			{
				Type = 185,
				Name = "Craggy Stone Wall (natural)",
				Color = Color.FromArgb(52, 52, 52),
			},
			[186] = new()
			{
				Type = 186,
				Name = "Crystal Block Wall",
				Color = Color.FromArgb(38, 9, 66),
			},
			[187] = new()
			{
				Type = 187,
				Name = "Treacherous Sandstone Wall",
				Color = Color.FromArgb(149, 80, 51),
			},
			[188] = new()
			{
				Type = 188,
				Name = "Corrupt Growth Wall (natural)",
				Color = Color.FromArgb(82, 63, 80),
			},
			[189] = new()
			{
				Type = 189,
				Name = "Corrupt Mass Wall (natural)",
				Color = Color.FromArgb(65, 61, 77),
			},
			[190] = new()
			{
				Type = 190,
				Name = "Corrupt Pustule Wall (natural)",
				Color = Color.FromArgb(64, 65, 92),
			},
			[191] = new()
			{
				Type = 191,
				Name = "Corrupt Tendril Wall (natural)",
				Color = Color.FromArgb(76, 53, 84),
			},
			[192] = new()
			{
				Type = 192,
				Name = "Crimson Crust Wall (natural)",
				Color = Color.FromArgb(144, 67, 52),
			},
			[193] = new()
			{
				Type = 193,
				Name = "Crimson Scab Wall (natural)",
				Color = Color.FromArgb(149, 48, 48),
			},
			[194] = new()
			{
				Type = 194,
				Name = "Crimson Teeth Wall (natural)",
				Color = Color.FromArgb(111, 32, 36),
			},
			[195] = new()
			{
				Type = 195,
				Name = "Crimson Blister Wall (natural)",
				Color = Color.FromArgb(147, 48, 55),
			},
			[196] = new()
			{
				Type = 196,
				Name = "Layered Dirt Wall (natural)",
				Color = Color.FromArgb(97, 67, 51),
			},
			[197] = new()
			{
				Type = 197,
				Name = "Crumbling Dirt Wall (natural)",
				Color = Color.FromArgb(112, 80, 62),
			},
			[198] = new()
			{
				Type = 198,
				Name = "Cracked Dirt Wall (natural)",
				Color = Color.FromArgb(88, 61, 46),
			},
			[199] = new()
			{
				Type = 199,
				Name = "Wavy Dirt Wall (natural)",
				Color = Color.FromArgb(127, 94, 76),
			},
			[200] = new()
			{
				Type = 200,
				Name = "Hallowed Prism Wall (natural)",
				Color = Color.FromArgb(143, 50, 123),
			},
			[201] = new()
			{
				Type = 201,
				Name = "Hallowed Cavern Wall (natural)",
				Color = Color.FromArgb(136, 120, 131),
			},
			[202] = new()
			{
				Type = 202,
				Name = "Hallowed Shard Wall (natural)",
				Color = Color.FromArgb(219, 92, 143),
			},
			[203] = new()
			{
				Type = 203,
				Name = "Hallowed Crystalline Wall (natural)",
				Color = Color.FromArgb(113, 64, 150),
			},
			[204] = new()
			{
				Type = 204,
				Name = "Lichen Stone Wall (natural)",
				Color = Color.FromArgb(74, 67, 60),
			},
			[205] = new()
			{
				Type = 205,
				Name = "Leafy Jungle Wall (natural)",
				Color = Color.FromArgb(60, 78, 59),
			},
			[206] = new()
			{
				Type = 206,
				Name = "Ivy Stone Wall (natural)",
				Color = Color.FromArgb(0, 54, 21),
			},
			[207] = new()
			{
				Type = 207,
				Name = "Jungle Vine Wall (natural)",
				Color = Color.FromArgb(74, 97, 72),
			},
			[208] = new()
			{
				Type = 208,
				Name = "Ember Wall (natural)",
				Color = Color.FromArgb(40, 37, 35),
			},
			[209] = new()
			{
				Type = 209,
				Name = "Cinder Wall (natural)",
				Color = Color.FromArgb(77, 63, 66),
			},
			[210] = new()
			{
				Type = 210,
				Name = "Magma Wall (natural)",
				Color = Color.FromArgb(111, 6, 6),
			},
			[211] = new()
			{
				Type = 211,
				Name = "Smouldering Stone Wall (natural)",
				Color = Color.FromArgb(88, 67, 59),
			},
			[212] = new()
			{
				Type = 212,
				Name = "Worn Stone Wall (natural)",
				Color = Color.FromArgb(88, 87, 80),
			},
			[213] = new()
			{
				Type = 213,
				Name = "Stalactite Stone Wall (natural)",
				Color = Color.FromArgb(71, 71, 67),
			},
			[214] = new()
			{
				Type = 214,
				Name = "Mottled Stone Wall (natural)",
				Color = Color.FromArgb(76, 52, 60),
			},
			[215] = new()
			{
				Type = 215,
				Name = "Fractured Stone Wall (natural)",
				Color = Color.FromArgb(89, 48, 59),
			},
			[216] = new()
			{
				Type = 216,
				Name = "Treacherous Hardened Sand Wall",
				Color = Color.FromArgb(158, 100, 64),
			},
			[217] = new()
			{
				Type = 217,
				Name = "Treacherous Hardened Ebonsand Wall",
				Color = Color.FromArgb(62, 45, 75),
			},
			[218] = new()
			{
				Type = 218,
				Name = "Treacherous Hardened Crimsand Wall",
				Color = Color.FromArgb(57, 14, 12),
			},
			[219] = new()
			{
				Type = 219,
				Name = "Treacherous Hardened Pearlsand Wall",
				Color = Color.FromArgb(96, 72, 133),
			},
			[220] = new()
			{
				Type = 220,
				Name = "Treacherous Ebonsandstone Wall",
				Color = Color.FromArgb(67, 55, 80),
			},
			[221] = new()
			{
				Type = 221,
				Name = "Treacherous Crimsandstone Wall",
				Color = Color.FromArgb(64, 37, 29),
			},
			[222] = new()
			{
				Type = 222,
				Name = "Treacherous Pearlsandstone Wall",
				Color = Color.FromArgb(70, 51, 91),
			},
			[223] = new()
			{
				Type = 223,
				Name = "Desert Fossil Wall (natural)",
				Color = Color.FromArgb(51, 18, 4),
			},
			[224] = new()
			{
				Type = 224,
				Name = "Luminite Brick Wall",
				Color = Color.FromArgb(57, 55, 52),
			},
			[225] = new()
			{
				Type = 225,
				Name = "Cog Wall",
				Color = Color.FromArgb(68, 68, 68),
			},
			[226] = new()
			{
				Type = 226,
				Name = "Sandfall Wall",
				Color = Color.FromArgb(148, 138, 74),
			},
			[227] = new()
			{
				Type = 227,
				Name = "Snowfall Wall",
				Color = Color.FromArgb(95, 137, 191),
			},
			[228] = new()
			{
				Type = 228,
				Name = "Silly Pink Balloon Wall",
				Color = Color.FromArgb(160, 2, 75),
			},
			[229] = new()
			{
				Type = 229,
				Name = "Silly Purple Balloon Wall",
				Color = Color.FromArgb(100, 55, 164),
			},
			[230] = new()
			{
				Type = 230,
				Name = "Silly Green Balloon Wall",
				Color = Color.FromArgb(0, 117, 101),
			},
			[231] = new()
			{
				Type = 231,
				Name = "Iron Brick Wall",
				Color = Color.FromArgb(110, 90, 78),
			},
			[232] = new()
			{
				Type = 232,
				Name = "Lead Brick Wall",
				Color = Color.FromArgb(47, 69, 75),
			},
			[233] = new()
			{
				Type = 233,
				Name = "Lesion Block Wall",
				Color = Color.FromArgb(91, 67, 70),
			},
			[234] = new()
			{
				Type = 234,
				Name = "Crimstone Brick Wall",
				Color = Color.FromArgb(60, 36, 39),
			},
			[235] = new()
			{
				Type = 235,
				Name = "Smooth Sandstone Wall",
				Color = Color.FromArgb(140, 75, 48),
			},
			[236] = new()
			{
				Type = 236,
				Name = "Spider Nest Wall",
				Color = Color.FromArgb(127, 49, 44),
			},
			[237] = new()
			{
				Type = 237,
				Name = "Solar Brick Wall",
				Color = Color.FromArgb(200, 44, 18),
			},
			[238] = new()
			{
				Type = 238,
				Name = "Vortex Brick Wall",
				Color = Color.FromArgb(24, 93, 66),
			},
			[239] = new()
			{
				Type = 239,
				Name = "Nebula Brick Wall",
				Color = Color.FromArgb(160, 87, 234),
			},
			[240] = new()
			{
				Type = 240,
				Name = "Stardust Brick Wall",
				Color = Color.FromArgb(6, 106, 255),
			},
			[241] = new()
			{
				Type = 241,
				Name = "Orange Stained Glass",
				Color = Color.FromArgb(0, 0, 0),
			},
			[242] = new()
			{
				Type = 242,
				Name = "Gold Starry Wall",
				Color = Color.FromArgb(5, 5, 5),
			},
			[243] = new()
			{
				Type = 243,
				Name = "Blue Starry Wall",
				Color = Color.FromArgb(5, 5, 5),
			},
			[244] = new()
			{
				Type = 244,
				Name = "Living Wood Wall (natural)",
				Color = Color.FromArgb(63, 39, 26),
			},
			[245] = new()
			{
				Type = 245,
				Name = "Wrought Iron Fence",
				Color = Color.FromArgb(102, 102, 102),
			},
			[246] = new()
			{
				Type = 246,
				Name = "Ebonstone Wall",
				Color = Color.FromArgb(61, 58, 78),
			},
			[247] = new()
			{
				Type = 247,
				Name = "Mud Wall",
				Color = Color.FromArgb(52, 43, 45),
			},
			[248] = new()
			{
				Type = 248,
				Name = "Pearlstone Wall",
				Color = Color.FromArgb(81, 84, 101),
			},
			[249] = new()
			{
				Type = 249,
				Name = "Snow Wall",
				Color = Color.FromArgb(85, 102, 103),
			},
			[250] = new()
			{
				Type = 250,
				Name = "Amethyst Stone Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[251] = new()
			{
				Type = 251,
				Name = "Topaz Stone Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[252] = new()
			{
				Type = 252,
				Name = "Sapphire Stone Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[253] = new()
			{
				Type = 253,
				Name = "Emerald Stone Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[254] = new()
			{
				Type = 254,
				Name = "Ruby Stone Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[255] = new()
			{
				Type = 255,
				Name = "Diamond Stone Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[256] = new()
			{
				Type = 256,
				Name = "Green Mossy Wall",
				Color = Color.FromArgb(40, 56, 50),
			},
			[257] = new()
			{
				Type = 257,
				Name = "Brown Mossy Wall",
				Color = Color.FromArgb(49, 48, 36),
			},
			[258] = new()
			{
				Type = 258,
				Name = "Red Mossy Wall",
				Color = Color.FromArgb(43, 33, 32),
			},
			[259] = new()
			{
				Type = 259,
				Name = "Blue Mossy Wall",
				Color = Color.FromArgb(31, 40, 49),
			},
			[260] = new()
			{
				Type = 260,
				Name = "Purple Mossy Wall",
				Color = Color.FromArgb(48, 35, 52),
			},
			[261] = new()
			{
				Type = 261,
				Name = "Rocky Dirt Wall",
				Color = Color.FromArgb(88, 61, 46),
			},
			[262] = new()
			{
				Type = 262,
				Name = "Old Stone Wall",
				Color = Color.FromArgb(55, 39, 26),
			},
			[263] = new()
			{
				Type = 263,
				Name = "Spider Wall",
				Color = Color.FromArgb(39, 33, 26),
			},
			[264] = new()
			{
				Type = 264,
				Name = "Corrupt Grass Wall",
				Color = Color.FromArgb(43, 42, 68),
			},
			[265] = new()
			{
				Type = 265,
				Name = "Hallowed Grass Wall",
				Color = Color.FromArgb(30, 70, 80),
			},
			[266] = new()
			{
				Type = 266,
				Name = "Ice Wall",
				Color = Color.FromArgb(78, 105, 135),
			},
			[267] = new()
			{
				Type = 267,
				Name = "Obsidian Wall",
				Color = Color.FromArgb(51, 47, 96),
			},
			[268] = new()
			{
				Type = 268,
				Name = "Crimson Grass Wall",
				Color = Color.FromArgb(101, 51, 51),
			},
			[269] = new()
			{
				Type = 269,
				Name = "Crimstone Wall",
				Color = Color.FromArgb(62, 38, 41),
			},
			[270] = new()
			{
				Type = 270,
				Name = "Cave Dirt Wall",
				Color = Color.FromArgb(59, 39, 22),
			},
			[271] = new()
			{
				Type = 271,
				Name = "Rough Dirt Wall",
				Color = Color.FromArgb(59, 39, 22),
			},
			[272] = new()
			{
				Type = 272,
				Name = "Marble Wall (unused)",
				Color = Color.FromArgb(111, 117, 135),
			},
			[273] = new()
			{
				Type = 273,
				Name = "Granite Wall (unused)",
				Color = Color.FromArgb(25, 23, 54),
			},
			[274] = new()
			{
				Type = 274,
				Name = "Craggy Stone Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[275] = new()
			{
				Type = 275,
				Name = "Sandstone Wall",
				Color = Color.FromArgb(149, 80, 51),
			},
			[276] = new()
			{
				Type = 276,
				Name = "Corrupt Growth Wall",
				Color = Color.FromArgb(82, 63, 80),
			},
			[277] = new()
			{
				Type = 277,
				Name = "Corrupt Mass Wall",
				Color = Color.FromArgb(65, 61, 77),
			},
			[278] = new()
			{
				Type = 278,
				Name = "Corrupt Pustule Wall",
				Color = Color.FromArgb(64, 65, 92),
			},
			[279] = new()
			{
				Type = 279,
				Name = "Corrupt Tendril Wall",
				Color = Color.FromArgb(76, 53, 84),
			},
			[280] = new()
			{
				Type = 280,
				Name = "Crimson Crust Wall",
				Color = Color.FromArgb(144, 67, 52),
			},
			[281] = new()
			{
				Type = 281,
				Name = "Crimson Scab Wall",
				Color = Color.FromArgb(149, 48, 48),
			},
			[282] = new()
			{
				Type = 282,
				Name = "Crimson Teeth Wall",
				Color = Color.FromArgb(111, 32, 36),
			},
			[283] = new()
			{
				Type = 283,
				Name = "Crimson Blister Wall",
				Color = Color.FromArgb(147, 48, 55),
			},
			[284] = new()
			{
				Type = 284,
				Name = "Layered Dirt Wall",
				Color = Color.FromArgb(97, 67, 51),
			},
			[285] = new()
			{
				Type = 285,
				Name = "Crumbling Dirt Wall",
				Color = Color.FromArgb(112, 80, 62),
			},
			[286] = new()
			{
				Type = 286,
				Name = "Cracked Dirt Wall",
				Color = Color.FromArgb(88, 61, 46),
			},
			[287] = new()
			{
				Type = 287,
				Name = "Wavy Dirt Wall",
				Color = Color.FromArgb(127, 94, 76),
			},
			[288] = new()
			{
				Type = 288,
				Name = "Hallowed Prism Wall",
				Color = Color.FromArgb(143, 50, 123),
			},
			[289] = new()
			{
				Type = 289,
				Name = "Hallowed Cavern Wall",
				Color = Color.FromArgb(136, 120, 131),
			},
			[290] = new()
			{
				Type = 290,
				Name = "Hallowed Shard Wall",
				Color = Color.FromArgb(219, 92, 143),
			},
			[291] = new()
			{
				Type = 291,
				Name = "Hallowed Crystalline Wall",
				Color = Color.FromArgb(113, 64, 150),
			},
			[292] = new()
			{
				Type = 292,
				Name = "Lichen Stone Wall",
				Color = Color.FromArgb(74, 67, 60),
			},
			[293] = new()
			{
				Type = 293,
				Name = "Leafy Jungle Wall",
				Color = Color.FromArgb(60, 78, 59),
			},
			[294] = new()
			{
				Type = 294,
				Name = "Ivy Stone Wall",
				Color = Color.FromArgb(0, 54, 21),
			},
			[295] = new()
			{
				Type = 295,
				Name = "Jungle Vine Wall",
				Color = Color.FromArgb(74, 97, 72),
			},
			[296] = new()
			{
				Type = 296,
				Name = "Ember Wall",
				Color = Color.FromArgb(40, 37, 35),
			},
			[297] = new()
			{
				Type = 297,
				Name = "Cinder Wall",
				Color = Color.FromArgb(77, 63, 66),
			},
			[298] = new()
			{
				Type = 298,
				Name = "Magma Wall",
				Color = Color.FromArgb(111, 6, 6),
			},
			[299] = new()
			{
				Type = 299,
				Name = "Smouldering Stone Wall",
				Color = Color.FromArgb(88, 67, 59),
			},
			[300] = new()
			{
				Type = 300,
				Name = "Worn Stone Wall",
				Color = Color.FromArgb(88, 87, 80),
			},
			[301] = new()
			{
				Type = 301,
				Name = "Stalactite Stone Wall",
				Color = Color.FromArgb(71, 71, 67),
			},
			[302] = new()
			{
				Type = 302,
				Name = "Mottled Stone Wall",
				Color = Color.FromArgb(76, 52, 60),
			},
			[303] = new()
			{
				Type = 303,
				Name = "Fractured Stone Wall",
				Color = Color.FromArgb(89, 48, 59),
			},
			[304] = new()
			{
				Type = 304,
				Name = "Hardened Sand Wall",
				Color = Color.FromArgb(158, 100, 64),
			},
			[305] = new()
			{
				Type = 305,
				Name = "Hardened Ebonsand Wall",
				Color = Color.FromArgb(62, 45, 75),
			},
			[306] = new()
			{
				Type = 306,
				Name = "Hardened Crimsand Wall",
				Color = Color.FromArgb(57, 14, 12),
			},
			[307] = new()
			{
				Type = 307,
				Name = "Hardened Pearlsand Wall",
				Color = Color.FromArgb(96, 72, 133),
			},
			[308] = new()
			{
				Type = 308,
				Name = "Ebonsandstone Wall",
				Color = Color.FromArgb(67, 55, 80),
			},
			[309] = new()
			{
				Type = 309,
				Name = "Crimsandstone Wall",
				Color = Color.FromArgb(64, 37, 29),
			},
			[310] = new()
			{
				Type = 310,
				Name = "Pearlsandstone Wall",
				Color = Color.FromArgb(70, 51, 91),
			},
			[311] = new()
			{
				Type = 311,
				Name = "Desert Fossil Wall",
				Color = Color.FromArgb(51, 18, 4),
			},
			[312] = new()
			{
				Type = 312,
				Name = "Bamboo Wall",
				Color = Color.FromArgb(78, 110, 51),
			},
			[313] = new()
			{
				Type = 313,
				Name = "Large Bamboo Wall",
				Color = Color.FromArgb(78, 110, 51),
			},
			[314] = new()
			{
				Type = 314,
				Name = "Amber Stone Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
			[315] = new()
			{
				Type = 315,
				Name = "Bamboo Fence",
				Color = Color.FromArgb(181, 230, 29),
			},
			[316] = new()
			{
				Type = 316,
				Name = "Ash Wood Wall",
				Color = Color.FromArgb(125, 100, 100),
			},
			[317] = new()
			{
				Type = 317,
				Name = "Ash Wood Fence",
				Color = Color.FromArgb(125, 100, 100),
			},
			[318] = new()
			{
				Type = 318,
				Name = "Echo Wall",
				Color = Color.FromArgb(0, 0, 0),
			},
			[319] = new()
			{
				Type = 319,
				Name = "Reef Wall",
				Color = Color.FromArgb(105, 51, 108),
			},
			[320] = new()
			{
				Type = 320,
				Name = "Poo Wall",
				Color = Color.FromArgb(75, 30, 15),
			},
			[321] = new()
			{
				Type = 321,
				Name = "Aetherium Wall",
				Color = Color.FromArgb(91, 108, 130),
			},
			[322] = new()
			{
				Type = 322,
				Name = "Aetherium Brick Wall",
				Color = Color.FromArgb(91, 108, 130),
			},
			[323] = new()
			{
				Type = 323,
				Name = "Lunar Rust Brick Wall",
				Color = Color.FromArgb(55, 25, 33),
			},
			[324] = new()
			{
				Type = 324,
				Name = "Dark Celestial Brick Wall",
				Color = Color.FromArgb(60, 55, 145),
			},
			[325] = new()
			{
				Type = 325,
				Name = "Astra Brick Wall",
				Color = Color.FromArgb(10, 5, 50),
			},
			[326] = new()
			{
				Type = 326,
				Name = "Cosmic Ember Brick Wall",
				Color = Color.FromArgb(30, 105, 75),
			},
			[327] = new()
			{
				Type = 327,
				Name = "Cryocore Brick Wall",
				Color = Color.FromArgb(5, 45, 55),
			},
			[328] = new()
			{
				Type = 328,
				Name = "Mercury Brick Wall",
				Color = Color.FromArgb(20, 25, 35),
			},
			[329] = new()
			{
				Type = 329,
				Name = "Star Royale Brick Wall",
				Color = Color.FromArgb(15, 10, 50),
			},
			[330] = new()
			{
				Type = 330,
				Name = "Heavenforge Brick Wall",
				Color = Color.FromArgb(153, 164, 187),
			},
			[331] = new()
			{
				Type = 331,
				Name = "Ancient Blue Brick Wall",
				Color = Color.FromArgb(27, 31, 42),
			},
			[332] = new()
			{
				Type = 332,
				Name = "Ancient Green Brick Wall",
				Color = Color.FromArgb(31, 39, 26),
			},
			[333] = new()
			{
				Type = 333,
				Name = "Ancient Pink Brick Wall",
				Color = Color.FromArgb(41, 28, 36),
			},
			[334] = new()
			{
				Type = 334,
				Name = "Ancient Gold Brick Wall",
				Color = Color.FromArgb(74, 62, 12),
			},
			[335] = new()
			{
				Type = 335,
				Name = "Ancient Silver Brick Wall",
				Color = Color.FromArgb(46, 56, 59),
			},
			[336] = new()
			{
				Type = 336,
				Name = "Ancient Copper Brick Wall",
				Color = Color.FromArgb(75, 32, 11),
			},
			[337] = new()
			{
				Type = 337,
				Name = "Ancient Obsidian Brick Wall",
				Color = Color.FromArgb(15, 15, 15),
			},
			[338] = new()
			{
				Type = 338,
				Name = "Ancient Hellstone Brick Wall",
				Color = Color.FromArgb(67, 37, 37),
			},
			[339] = new()
			{
				Type = 339,
				Name = "Ancient Cobalt Brick Wall",
				Color = Color.FromArgb(11, 35, 62),
			},
			[340] = new()
			{
				Type = 340,
				Name = "Ancient Mythril Brick Wall",
				Color = Color.FromArgb(21, 63, 70),
			},
			[341] = new()
			{
				Type = 341,
				Name = "Lava Moss Brick Wall",
				Color = Color.FromArgb(100, 40, 1),
			},
			[342] = new()
			{
				Type = 342,
				Name = "Argon Moss Brick Wall",
				Color = Color.FromArgb(92, 30, 72),
			},
			[343] = new()
			{
				Type = 343,
				Name = "Krypton Moss Brick Wall",
				Color = Color.FromArgb(42, 81, 1),
			},
			[344] = new()
			{
				Type = 344,
				Name = "Xenon Moss Brick Wall",
				Color = Color.FromArgb(1, 81, 109),
			},
			[345] = new()
			{
				Type = 345,
				Name = "Neon Moss Brick Wall",
				Color = Color.FromArgb(56, 22, 97),
			},
			[346] = new()
			{
				Type = 346,
				Name = "Helium Moss Brick Wall",
				Color = Color.FromArgb(52, 52, 52),
			},
		};
    }
}
