namespace TMake.Terraria
{
    public static class SpriteProperty
    {
        public static SpriteData GetSpriteData(ushort type, int count = 0)
        {
            var sprites = SpriteDatas.Where(sprite => sprite.TileType == type).ToList();

            if (count < sprites.Count)
            {
                return sprites[count];
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(type), $"Missing sprite data: {type}");
            }
        }
        public static SpriteData GetSpriteData(string name, string variety = "", FrameAnchor anchor = FrameAnchor.None)
        {
            var sprites = SpriteDatas.Where(sprite => (sprite.Name == name && sprite.Variety == variety && sprite.Anchor == anchor)).ToList();

            if (sprites.Count == 1)
            {
                return sprites[0];
            }
            else if(sprites.Count > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(name), $"Missing sprite data: {name}");
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(name), $"Not unique sprite data: {name}");
            }
        }
        public readonly static List<SpriteData> SpriteDatas = new()
{

new SpriteData()
{
TileType = 3,
Name = "Grass_Single_Blade",
},

new SpriteData()
{
TileType = 3,
Origin = new(18,0),
Name = "Grass_Double_Blade",
},

new SpriteData()
{
TileType = 3,
Origin = new(36,0),
Name = "Grass_Small_Y",
},

new SpriteData()
{
TileType = 3,
Origin = new(54,0),
Name = "Grass_Three_Small",
},

new SpriteData()
{
TileType = 3,
Origin = new(72,0),
Name = "Grass_Single_Blade",
},

new SpriteData()
{
TileType = 3,
Origin = new(90,0),
Name = "Grass_Three_Large",
},

new SpriteData()
{
TileType = 3,
Origin = new(144,0),
Name = "Mushroom",
},

new SpriteData()
{
TileType = 3,
Origin = new(108,0),
Name = "Magenta_Flower_A",
},

new SpriteData()
{
TileType = 3,
Origin = new(540,0),
Name = "Magenta_Flower_B",
},

new SpriteData()
{
TileType = 3,
Origin = new(558,0),
Name = "Magenta_Flower_C",
},

new SpriteData()
{
TileType = 3,
Origin = new(576,0),
Name = "Magenta_Flower_D",
},

new SpriteData()
{
TileType = 3,
Origin = new(126,0),
Name = "Pink_Flower_A",
},

new SpriteData()
{
TileType = 3,
Origin = new(306,0),
Name = "Pink_Flower_B",
},

new SpriteData()
{
TileType = 3,
Origin = new(594,0),
Name = "Pink_Flower_C",
},

new SpriteData()
{
TileType = 3,
Origin = new(612,0),
Name = "Pink_Flower_D",
},

new SpriteData()
{
TileType = 3,
Origin = new(630,0),
Name = "Pink_Flower_E",
},

new SpriteData()
{
TileType = 3,
Origin = new(162,0),
Name = "Blue_Flower_A",
},

new SpriteData()
{
TileType = 3,
Origin = new(288,0),
Name = "Blue_Flower_B",
},

new SpriteData()
{
TileType = 3,
Origin = new(360,0),
Name = "Blue_Flower_C",
},

new SpriteData()
{
TileType = 3,
Origin = new(180,0),
Name = "Yellow_Flower_A",
},

new SpriteData()
{
TileType = 3,
Origin = new(198,0),
Name = "Yellow_Flower_B",
},

new SpriteData()
{
TileType = 3,
Origin = new(234,0),
Name = "Yellow_Flower_C",
},

new SpriteData()
{
TileType = 3,
Origin = new(324,0),
Name = "Yellow_Flower_D",
},

new SpriteData()
{
TileType = 3,
Origin = new(432,0),
Name = "Yellow_Flower_E",
},

new SpriteData()
{
TileType = 3,
Origin = new(450,0),
Name = "Yellow_Flower_F",
},

new SpriteData()
{
TileType = 3,
Origin = new(468,0),
Name = "Yellow_Flower_G",
},

new SpriteData()
{
TileType = 3,
Origin = new(216,0),
Name = "Violet_Flower_A",
},

new SpriteData()
{
TileType = 3,
Origin = new(756,0),
Name = "Violet_Flower_B",
},

new SpriteData()
{
TileType = 3,
Origin = new(774,0),
Name = "Violet_Flower_C",
},

new SpriteData()
{
TileType = 3,
Origin = new(792,0),
Name = "Violet_Flower_D",
},

new SpriteData()
{
TileType = 3,
Origin = new(252,0),
Name = "White_Flower_A",
},

new SpriteData()
{
TileType = 3,
Origin = new(270,0),
Name = "White_Flower_B",
},

new SpriteData()
{
TileType = 3,
Origin = new(486,0),
Name = "White_Flower_C",
},

new SpriteData()
{
TileType = 3,
Origin = new(504,0),
Name = "White_Flower_D",
},

new SpriteData()
{
TileType = 3,
Origin = new(522,0),
Name = "White_Flower_E",
},

new SpriteData()
{
TileType = 3,
Origin = new(648,0),
Name = "White_Flower_F",
},

new SpriteData()
{
TileType = 3,
Origin = new(666,0),
Name = "White_Flower_G",
},

new SpriteData()
{
TileType = 3,
Origin = new(684,0),
Name = "White_Flower_H",
},

new SpriteData()
{
TileType = 3,
Origin = new(342,0),
Name = "Red_Flower_A",
},

new SpriteData()
{
TileType = 3,
Origin = new(378,0),
Name = "Red_Flower_B",
},

new SpriteData()
{
TileType = 3,
Origin = new(396,0),
Name = "Red_Flower_C",
},

new SpriteData()
{
TileType = 3,
Origin = new(414,0),
Name = "Red_Flower_D",
},

new SpriteData()
{
TileType = 3,
Origin = new(702,0),
Name = "Red_Flower_E",
},

new SpriteData()
{
TileType = 3,
Origin = new(720,0),
Name = "Red_Flower_F",
},

new SpriteData()
{
TileType = 3,
Origin = new(738,0),
Name = "Red_Flower_G",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Name = "Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,0),
Name = "Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,0),
Name = "Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,0),
Name = "Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,0),
Name = "Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,0),
Name = "Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,22),
Name = "Blue_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,22),
Name = "Blue_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,22),
Name = "Blue_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,22),
Name = "Blue_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,22),
Name = "Blue_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,22),
Name = "Blue_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,44),
Name = "Red_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,44),
Name = "Red_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,44),
Name = "Red_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,44),
Name = "Red_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,44),
Name = "Red_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,44),
Name = "Red_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,66),
Name = "Green_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,66),
Name = "Green_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,66),
Name = "Green_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,66),
Name = "Green_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,66),
Name = "Green_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,66),
Name = "Green_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,88),
Name = "Purple_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,88),
Name = "Purple_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,88),
Name = "Purple_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,88),
Name = "Purple_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,88),
Name = "Purple_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,88),
Name = "Purple_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,110),
Name = "White_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,110),
Name = "White_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,110),
Name = "White_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,110),
Name = "White_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,110),
Name = "White_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,110),
Name = "White_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,132),
Name = "Yellow_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,132),
Name = "Yellow_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,132),
Name = "Yellow_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,132),
Name = "Yellow_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,132),
Name = "Yellow_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,132),
Name = "Yellow_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,154),
Name = "Demon_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,154),
Name = "Demon_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,154),
Name = "Demon_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,154),
Name = "Demon_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,154),
Name = "Demon_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,154),
Name = "Demon_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,176),
Name = "Cursed_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,176),
Name = "Cursed_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,176),
Name = "Cursed_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,176),
Name = "Cursed_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,176),
Name = "Cursed_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,176),
Name = "Cursed_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,198),
Name = "Ice_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,198),
Name = "Ice_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,198),
Name = "Ice_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,198),
Name = "Ice_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,198),
Name = "Ice_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,198),
Name = "Ice_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,220),
Name = "Orange_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,220),
Name = "Orange_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,220),
Name = "Orange_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,220),
Name = "Orange_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,220),
Name = "Orange_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,220),
Name = "Orange_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,242),
Name = "Ichor_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,242),
Name = "Ichor_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,242),
Name = "Ichor_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,242),
Name = "Ichor_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,242),
Name = "Ichor_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,242),
Name = "Ichor_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,264),
Name = "Ultrabright_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,264),
Name = "Ultrabright_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,264),
Name = "Ultrabright_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,264),
Name = "Ultrabright_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,264),
Name = "Ultrabright_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,264),
Name = "Ultrabright_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,286),
Name = "Bone_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,286),
Name = "Bone_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,286),
Name = "Bone_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,286),
Name = "Bone_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,286),
Name = "Bone_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,286),
Name = "Bone_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,308),
Name = "Rainbow_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,308),
Name = "Rainbow_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,308),
Name = "Rainbow_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,308),
Name = "Rainbow_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,308),
Name = "Rainbow_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,308),
Name = "Rainbow_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,330),
Name = "Pink_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,330),
Name = "Pink_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,330),
Name = "Pink_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,330),
Name = "Pink_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,330),
Name = "Pink_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,330),
Name = "Pink_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,352),
Name = "Desert_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,352),
Name = "Desert_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,352),
Name = "Desert_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,352),
Name = "Desert_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,352),
Name = "Desert_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,352),
Name = "Desert_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,374),
Name = "Coral_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,374),
Name = "Coral_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,374),
Name = "Coral_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,374),
Name = "Coral_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,374),
Name = "Coral_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,374),
Name = "Coral_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,396),
Name = "Corrupt_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,396),
Name = "Corrupt_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,396),
Name = "Corrupt_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,396),
Name = "Corrupt_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,396),
Name = "Corrupt_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,396),
Name = "Corrupt_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,418),
Name = "Crimson_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,418),
Name = "Crimson_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,418),
Name = "Crimson_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,418),
Name = "Crimson_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,418),
Name = "Crimson_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,418),
Name = "Crimson_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,440),
Name = "Hallowed_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,440),
Name = "Hallowed_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,440),
Name = "Hallowed_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,440),
Name = "Hallowed_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,440),
Name = "Hallowed_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,440),
Name = "Hallowed_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,462),
Name = "Jungle_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,462),
Name = "Jungle_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,462),
Name = "Jungle_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,462),
Name = "Jungle_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,462),
Name = "Jungle_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,462),
Name = "Jungle_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,484),
Name = "Mushroom_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,484),
Name = "Mushroom_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,484),
Name = "Mushroom_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,484),
Name = "Mushroom_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,484),
Name = "Mushroom_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,484),
Name = "Mushroom_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(0,506),
Name = "Aether_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(22,506),
Name = "Aether_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(44,506),
Name = "Aether_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Bottom,
Origin = new(66,506),
Name = "Aether_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Left,
Origin = new(88,506),
Name = "Aether_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 4,
Anchor = FrameAnchor.Right,
Origin = new(110,506),
Name = "Aether_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 5,
Name = "Forest_Tree",
Variety = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,0),
Name = "Forest_Tree",
Variety = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,0),
Name = "Forest_Tree",
Variety = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,0),
Name = "Forest_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(88,0),
Name = "Forest_Tree",
Variety = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(110,0),
Name = "Forest_Tree",
Variety = "Top_Medium_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(132,0),
Name = "Forest_Tree",
Variety = "Top_Small_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(154,0),
Name = "Forest_Tree",
Variety = "Top_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,22),
Name = "Forest_Tree",
Variety = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,22),
Name = "Forest_Tree",
Variety = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,22),
Name = "Forest_Tree",
Variety = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,22),
Name = "Forest_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(88,22),
Name = "Forest_Tree",
Variety = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(110,22),
Name = "Forest_Tree",
Variety = "Top_Medium_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(132,22),
Name = "Forest_Tree",
Variety = "Top_Small_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(154,22),
Name = "Forest_Tree",
Variety = "Top_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,44),
Name = "Forest_Tree",
Variety = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,44),
Name = "Forest_Tree",
Variety = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,44),
Name = "Forest_Tree",
Variety = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,44),
Name = "Forest_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(88,44),
Name = "Forest_Tree",
Variety = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(110,44),
Name = "Forest_Tree",
Variety = "Top_Medium_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(132,44),
Name = "Forest_Tree",
Variety = "Top_Small_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(154,44),
Name = "Forest_Tree",
Variety = "Top_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,66),
Name = "Forest_Tree",
Variety = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,66),
Name = "Forest_Tree",
Variety = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,66),
Name = "Forest_Tree",
Variety = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,66),
Name = "Forest_Tree",
Variety = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(88,66),
Name = "Forest_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(110,66),
Name = "Forest_Tree",
Variety = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(132,66),
Name = "Forest_Tree",
Variety = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(154,66),
Name = "Forest_Tree",
Variety = "Top_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,88),
Name = "Forest_Tree",
Variety = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,88),
Name = "Forest_Tree",
Variety = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,88),
Name = "Forest_Tree",
Variety = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,88),
Name = "Forest_Tree",
Variety = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(88,88),
Name = "Forest_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(110,88),
Name = "Forest_Tree",
Variety = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(132,88),
Name = "Forest_Tree",
Variety = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(154,88),
Name = "Forest_Tree",
Variety = "Top_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,110),
Name = "Forest_Tree",
Variety = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,110),
Name = "Forest_Tree",
Variety = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,110),
Name = "Forest_Tree",
Variety = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,110),
Name = "Forest_Tree",
Variety = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(88,110),
Name = "Forest_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(110,110),
Name = "Forest_Tree",
Variety = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(132,110),
Name = "Forest_Tree",
Variety = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(154,110),
Name = "Forest_Tree",
Variety = "Top_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,132),
Name = "Forest_Tree",
Variety = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,132),
Name = "Forest_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,132),
Name = "Forest_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,132),
Name = "Forest_Tree",
Variety = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(88,132),
Name = "Forest_Tree",
Variety = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(132,132),
Name = "Forest_Tree",
Variety = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(154,132),
Name = "Forest_Tree",
Variety = "Top_Huge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,154),
Name = "Forest_Tree",
Variety = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,154),
Name = "Forest_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,154),
Name = "Forest_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,154),
Name = "Forest_Tree",
Variety = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(88,154),
Name = "Forest_Tree",
Variety = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(132,154),
Name = "Forest_Tree",
Variety = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(154,154),
Name = "Forest_Tree",
Variety = "Top_Huge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,176),
Name = "Forest_Tree",
Variety = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,176),
Name = "Forest_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,176),
Name = "Forest_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,176),
Name = "Forest_Tree",
Variety = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 5,
Origin = new(88,176),
Name = "Forest_Tree",
Variety = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 5,
Origin = new(132,176),
Name = "Forest_Tree",
Variety = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(154,176),
Name = "Forest_Tree",
Variety = "Top_Huge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,198),
Name = "Forest_Tree",
Variety = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,220),
Name = "Forest_Tree",
Variety = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(0,242),
Name = "Forest_Tree",
Variety = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,198),
Name = "Forest_Tree",
Variety = "Top_Leafy_A_(No_Sprite)",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,220),
Name = "Forest_Tree",
Variety = "Top_Leafy_B_(No_Sprite)",
},

new SpriteData()
{
TileType = 5,
Origin = new(22,242),
Name = "Forest_Tree",
Variety = "Top_Leafy_C_(No_Sprite)",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,198),
Name = "Forest_Tree",
Variety = "Branch_Left_Leafy_A_(No_Sprite)",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,220),
Name = "Forest_Tree",
Variety = "Branch_Left_Leafy_B_(No_Sprite)",
},

new SpriteData()
{
TileType = 5,
Origin = new(44,242),
Name = "Forest_Tree",
Variety = "Branch_Left_Leafy_C_(No_Sprite)",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,198),
Name = "Forest_Tree",
Variety = "Branch_Right_Leafy_A_(No_Sprite)",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,220),
Name = "Forest_Tree",
Variety = "Branch_Right_Leafy_B_(No_Sprite)",
},

new SpriteData()
{
TileType = 5,
Origin = new(66,242),
Name = "Forest_Tree",
Variety = "Branch_Right_Leafy_C_(No_Sprite)",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,0),
Name = "Corrupt_Tree",
Variety = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(198,0),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(220,0),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(242,0),
Name = "Corrupt_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(264,0),
Name = "Corrupt_Tree",
Variety = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(286,0),
Name = "Corrupt_Tree",
Variety = "Top_Medium_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(308,0),
Name = "Corrupt_Tree",
Variety = "Top_Small_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(330,0),
Name = "Corrupt_Tree",
Variety = "Top_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,22),
Name = "Corrupt_Tree",
Variety = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(198,22),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(220,22),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(242,22),
Name = "Corrupt_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(264,22),
Name = "Corrupt_Tree",
Variety = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(286,22),
Name = "Corrupt_Tree",
Variety = "Top_Medium_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(308,22),
Name = "Corrupt_Tree",
Variety = "Top_Small_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(330,22),
Name = "Corrupt_Tree",
Variety = "Top_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,44),
Name = "Corrupt_Tree",
Variety = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(198,44),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(220,44),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(242,44),
Name = "Corrupt_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(264,44),
Name = "Corrupt_Tree",
Variety = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(286,44),
Name = "Corrupt_Tree",
Variety = "Top_Medium_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(308,44),
Name = "Corrupt_Tree",
Variety = "Top_Small_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(330,44),
Name = "Corrupt_Tree",
Variety = "Top_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,66),
Name = "Corrupt_Tree",
Variety = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(198,66),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(220,66),
Name = "Corrupt_Tree",
Variety = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(242,66),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(264,66),
Name = "Corrupt_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(286,66),
Name = "Corrupt_Tree",
Variety = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(308,66),
Name = "Corrupt_Tree",
Variety = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(330,66),
Name = "Corrupt_Tree",
Variety = "Top_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,88),
Name = "Corrupt_Tree",
Variety = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(198,88),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(220,88),
Name = "Corrupt_Tree",
Variety = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(242,88),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(264,88),
Name = "Corrupt_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(286,88),
Name = "Corrupt_Tree",
Variety = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(308,88),
Name = "Corrupt_Tree",
Variety = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(330,88),
Name = "Corrupt_Tree",
Variety = "Top_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,110),
Name = "Corrupt_Tree",
Variety = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(198,110),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(220,110),
Name = "Corrupt_Tree",
Variety = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(242,110),
Name = "Corrupt_Tree",
Variety = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(264,110),
Name = "Corrupt_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(286,110),
Name = "Corrupt_Tree",
Variety = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(308,110),
Name = "Corrupt_Tree",
Variety = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(330,110),
Name = "Corrupt_Tree",
Variety = "Top_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,132),
Name = "Corrupt_Tree",
Variety = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(198,132),
Name = "Corrupt_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(220,132),
Name = "Corrupt_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(242,132),
Name = "Corrupt_Tree",
Variety = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(264,132),
Name = "Corrupt_Tree",
Variety = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(308,132),
Name = "Corrupt_Tree",
Variety = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(330,132),
Name = "Corrupt_Tree",
Variety = "Top_Huge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,154),
Name = "Corrupt_Tree",
Variety = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(198,154),
Name = "Corrupt_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(220,154),
Name = "Corrupt_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(242,154),
Name = "Corrupt_Tree",
Variety = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(264,154),
Name = "Corrupt_Tree",
Variety = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(308,154),
Name = "Corrupt_Tree",
Variety = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(330,154),
Name = "Corrupt_Tree",
Variety = "Top_Huge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,176),
Name = "Corrupt_Tree",
Variety = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 5,
Origin = new(198,176),
Name = "Corrupt_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(220,176),
Name = "Corrupt_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(242,176),
Name = "Corrupt_Tree",
Variety = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 5,
Origin = new(264,176),
Name = "Corrupt_Tree",
Variety = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 5,
Origin = new(308,176),
Name = "Corrupt_Tree",
Variety = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(330,176),
Name = "Corrupt_Tree",
Variety = "Top_Huge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,198),
Name = "Corrupt_Tree",
Variety = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,220),
Name = "Corrupt_Tree",
Variety = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(176,242),
Name = "Corrupt_Tree",
Variety = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,0),
Name = "Jungle_Tree",
Variety = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(374,0),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(396,0),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(418,0),
Name = "Jungle_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(440,0),
Name = "Jungle_Tree",
Variety = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(462,0),
Name = "Jungle_Tree",
Variety = "Top_Medium_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(484,0),
Name = "Jungle_Tree",
Variety = "Top_Small_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(506,0),
Name = "Jungle_Tree",
Variety = "Top_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,22),
Name = "Jungle_Tree",
Variety = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(374,22),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(396,22),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(418,22),
Name = "Jungle_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(440,22),
Name = "Jungle_Tree",
Variety = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(462,22),
Name = "Jungle_Tree",
Variety = "Top_Medium_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(484,22),
Name = "Jungle_Tree",
Variety = "Top_Small_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(506,22),
Name = "Jungle_Tree",
Variety = "Top_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,44),
Name = "Jungle_Tree",
Variety = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(374,44),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(396,44),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(418,44),
Name = "Jungle_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(440,44),
Name = "Jungle_Tree",
Variety = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(462,44),
Name = "Jungle_Tree",
Variety = "Top_Medium_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(484,44),
Name = "Jungle_Tree",
Variety = "Top_Small_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(506,44),
Name = "Jungle_Tree",
Variety = "Top_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,66),
Name = "Jungle_Tree",
Variety = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(374,66),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(396,66),
Name = "Jungle_Tree",
Variety = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(418,66),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(440,66),
Name = "Jungle_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(462,66),
Name = "Jungle_Tree",
Variety = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(484,66),
Name = "Jungle_Tree",
Variety = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(506,66),
Name = "Jungle_Tree",
Variety = "Top_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,88),
Name = "Jungle_Tree",
Variety = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(374,88),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(396,88),
Name = "Jungle_Tree",
Variety = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(418,88),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(440,88),
Name = "Jungle_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(462,88),
Name = "Jungle_Tree",
Variety = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(484,88),
Name = "Jungle_Tree",
Variety = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(506,88),
Name = "Jungle_Tree",
Variety = "Top_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,110),
Name = "Jungle_Tree",
Variety = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(374,110),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(396,110),
Name = "Jungle_Tree",
Variety = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(418,110),
Name = "Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(440,110),
Name = "Jungle_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(462,110),
Name = "Jungle_Tree",
Variety = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(484,110),
Name = "Jungle_Tree",
Variety = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(506,110),
Name = "Jungle_Tree",
Variety = "Top_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,132),
Name = "Jungle_Tree",
Variety = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(374,132),
Name = "Jungle_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(396,132),
Name = "Jungle_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(418,132),
Name = "Jungle_Tree",
Variety = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(440,132),
Name = "Jungle_Tree",
Variety = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(484,132),
Name = "Jungle_Tree",
Variety = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(506,132),
Name = "Jungle_Tree",
Variety = "Top_Huge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,154),
Name = "Jungle_Tree",
Variety = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(374,154),
Name = "Jungle_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(396,154),
Name = "Jungle_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(418,154),
Name = "Jungle_Tree",
Variety = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(440,154),
Name = "Jungle_Tree",
Variety = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(484,154),
Name = "Jungle_Tree",
Variety = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(506,154),
Name = "Jungle_Tree",
Variety = "Top_Huge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,176),
Name = "Jungle_Tree",
Variety = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 5,
Origin = new(374,176),
Name = "Jungle_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(396,176),
Name = "Jungle_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(418,176),
Name = "Jungle_Tree",
Variety = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 5,
Origin = new(440,176),
Name = "Jungle_Tree",
Variety = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 5,
Origin = new(484,176),
Name = "Jungle_Tree",
Variety = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(506,176),
Name = "Jungle_Tree",
Variety = "Top_Huge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,198),
Name = "Jungle_Tree",
Variety = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,220),
Name = "Jungle_Tree",
Variety = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(352,242),
Name = "Jungle_Tree",
Variety = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,0),
Name = "Hallow_Tree",
Variety = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(550,0),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(572,0),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(594,0),
Name = "Hallow_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(616,0),
Name = "Hallow_Tree",
Variety = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(638,0),
Name = "Hallow_Tree",
Variety = "Top_Medium_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(660,0),
Name = "Hallow_Tree",
Variety = "Top_Small_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(682,0),
Name = "Hallow_Tree",
Variety = "Top_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,22),
Name = "Hallow_Tree",
Variety = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(550,22),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(572,22),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(594,22),
Name = "Hallow_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(616,22),
Name = "Hallow_Tree",
Variety = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(638,22),
Name = "Hallow_Tree",
Variety = "Top_Medium_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(660,22),
Name = "Hallow_Tree",
Variety = "Top_Small_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(682,22),
Name = "Hallow_Tree",
Variety = "Top_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,44),
Name = "Hallow_Tree",
Variety = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(550,44),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(572,44),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(594,44),
Name = "Hallow_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(616,44),
Name = "Hallow_Tree",
Variety = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(638,44),
Name = "Hallow_Tree",
Variety = "Top_Medium_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(660,44),
Name = "Hallow_Tree",
Variety = "Top_Small_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(682,44),
Name = "Hallow_Tree",
Variety = "Top_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,66),
Name = "Hallow_Tree",
Variety = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(550,66),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(572,66),
Name = "Hallow_Tree",
Variety = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(594,66),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(616,66),
Name = "Hallow_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(638,66),
Name = "Hallow_Tree",
Variety = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(660,66),
Name = "Hallow_Tree",
Variety = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(682,66),
Name = "Hallow_Tree",
Variety = "Top_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,88),
Name = "Hallow_Tree",
Variety = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(550,88),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(572,88),
Name = "Hallow_Tree",
Variety = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(594,88),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(616,88),
Name = "Hallow_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(638,88),
Name = "Hallow_Tree",
Variety = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(660,88),
Name = "Hallow_Tree",
Variety = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(682,88),
Name = "Hallow_Tree",
Variety = "Top_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,110),
Name = "Hallow_Tree",
Variety = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(550,110),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(572,110),
Name = "Hallow_Tree",
Variety = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(594,110),
Name = "Hallow_Tree",
Variety = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(616,110),
Name = "Hallow_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(638,110),
Name = "Hallow_Tree",
Variety = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(660,110),
Name = "Hallow_Tree",
Variety = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(682,110),
Name = "Hallow_Tree",
Variety = "Top_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,132),
Name = "Hallow_Tree",
Variety = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(550,132),
Name = "Hallow_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(572,132),
Name = "Hallow_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(594,132),
Name = "Hallow_Tree",
Variety = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(616,132),
Name = "Hallow_Tree",
Variety = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(660,132),
Name = "Hallow_Tree",
Variety = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(682,132),
Name = "Hallow_Tree",
Variety = "Top_Huge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,154),
Name = "Hallow_Tree",
Variety = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(550,154),
Name = "Hallow_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(572,154),
Name = "Hallow_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(594,154),
Name = "Hallow_Tree",
Variety = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(616,154),
Name = "Hallow_Tree",
Variety = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(660,154),
Name = "Hallow_Tree",
Variety = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(682,154),
Name = "Hallow_Tree",
Variety = "Top_Huge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,176),
Name = "Hallow_Tree",
Variety = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 5,
Origin = new(550,176),
Name = "Hallow_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(572,176),
Name = "Hallow_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(594,176),
Name = "Hallow_Tree",
Variety = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 5,
Origin = new(616,176),
Name = "Hallow_Tree",
Variety = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 5,
Origin = new(660,176),
Name = "Hallow_Tree",
Variety = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(682,176),
Name = "Hallow_Tree",
Variety = "Top_Huge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,198),
Name = "Hallow_Tree",
Variety = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,220),
Name = "Hallow_Tree",
Variety = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(528,242),
Name = "Hallow_Tree",
Variety = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,0),
Name = "Boreal_Tree",
Variety = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(726,0),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(748,0),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(770,0),
Name = "Boreal_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(792,0),
Name = "Boreal_Tree",
Variety = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(814,0),
Name = "Boreal_Tree",
Variety = "Top_Medium_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(836,0),
Name = "Boreal_Tree",
Variety = "Top_Small_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(858,0),
Name = "Boreal_Tree",
Variety = "Top_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,22),
Name = "Boreal_Tree",
Variety = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(726,22),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(748,22),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(770,22),
Name = "Boreal_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(792,22),
Name = "Boreal_Tree",
Variety = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(814,22),
Name = "Boreal_Tree",
Variety = "Top_Medium_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(836,22),
Name = "Boreal_Tree",
Variety = "Top_Small_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(858,22),
Name = "Boreal_Tree",
Variety = "Top_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,44),
Name = "Boreal_Tree",
Variety = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(726,44),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(748,44),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(770,44),
Name = "Boreal_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(792,44),
Name = "Boreal_Tree",
Variety = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(814,44),
Name = "Boreal_Tree",
Variety = "Top_Medium_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(836,44),
Name = "Boreal_Tree",
Variety = "Top_Small_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(858,44),
Name = "Boreal_Tree",
Variety = "Top_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,66),
Name = "Boreal_Tree",
Variety = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(726,66),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(748,66),
Name = "Boreal_Tree",
Variety = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(770,66),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(792,66),
Name = "Boreal_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(814,66),
Name = "Boreal_Tree",
Variety = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(836,66),
Name = "Boreal_Tree",
Variety = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(858,66),
Name = "Boreal_Tree",
Variety = "Top_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,88),
Name = "Boreal_Tree",
Variety = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(726,88),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(748,88),
Name = "Boreal_Tree",
Variety = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(770,88),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(792,88),
Name = "Boreal_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(814,88),
Name = "Boreal_Tree",
Variety = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(836,88),
Name = "Boreal_Tree",
Variety = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(858,88),
Name = "Boreal_Tree",
Variety = "Top_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,110),
Name = "Boreal_Tree",
Variety = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(726,110),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(748,110),
Name = "Boreal_Tree",
Variety = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(770,110),
Name = "Boreal_Tree",
Variety = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(792,110),
Name = "Boreal_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(814,110),
Name = "Boreal_Tree",
Variety = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(836,110),
Name = "Boreal_Tree",
Variety = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(858,110),
Name = "Boreal_Tree",
Variety = "Top_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,132),
Name = "Boreal_Tree",
Variety = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(726,132),
Name = "Boreal_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(748,132),
Name = "Boreal_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(770,132),
Name = "Boreal_Tree",
Variety = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(792,132),
Name = "Boreal_Tree",
Variety = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(836,132),
Name = "Boreal_Tree",
Variety = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(858,132),
Name = "Boreal_Tree",
Variety = "Top_Huge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,154),
Name = "Boreal_Tree",
Variety = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(726,154),
Name = "Boreal_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(748,154),
Name = "Boreal_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(770,154),
Name = "Boreal_Tree",
Variety = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(792,154),
Name = "Boreal_Tree",
Variety = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(836,154),
Name = "Boreal_Tree",
Variety = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(858,154),
Name = "Boreal_Tree",
Variety = "Top_Huge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,176),
Name = "Boreal_Tree",
Variety = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 5,
Origin = new(726,176),
Name = "Boreal_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(748,176),
Name = "Boreal_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(770,176),
Name = "Boreal_Tree",
Variety = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 5,
Origin = new(792,176),
Name = "Boreal_Tree",
Variety = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 5,
Origin = new(836,176),
Name = "Boreal_Tree",
Variety = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(858,176),
Name = "Boreal_Tree",
Variety = "Top_Huge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,198),
Name = "Boreal_Tree",
Variety = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,220),
Name = "Boreal_Tree",
Variety = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(704,242),
Name = "Boreal_Tree",
Variety = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,0),
Name = "Crimson_Tree",
Variety = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(902,0),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(924,0),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(946,0),
Name = "Crimson_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(968,0),
Name = "Crimson_Tree",
Variety = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(990,0),
Name = "Crimson_Tree",
Variety = "Top_Medium_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1012,0),
Name = "Crimson_Tree",
Variety = "Top_Small_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1034,0),
Name = "Crimson_Tree",
Variety = "Top_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,22),
Name = "Crimson_Tree",
Variety = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(902,22),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(924,22),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(946,22),
Name = "Crimson_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(968,22),
Name = "Crimson_Tree",
Variety = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(990,22),
Name = "Crimson_Tree",
Variety = "Top_Medium_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1012,22),
Name = "Crimson_Tree",
Variety = "Top_Small_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1034,22),
Name = "Crimson_Tree",
Variety = "Top_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,44),
Name = "Crimson_Tree",
Variety = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(902,44),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(924,44),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(946,44),
Name = "Crimson_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(968,44),
Name = "Crimson_Tree",
Variety = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(990,44),
Name = "Crimson_Tree",
Variety = "Top_Medium_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1012,44),
Name = "Crimson_Tree",
Variety = "Top_Small_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1034,44),
Name = "Crimson_Tree",
Variety = "Top_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,66),
Name = "Crimson_Tree",
Variety = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(902,66),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(924,66),
Name = "Crimson_Tree",
Variety = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(946,66),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(968,66),
Name = "Crimson_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(990,66),
Name = "Crimson_Tree",
Variety = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1012,66),
Name = "Crimson_Tree",
Variety = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1034,66),
Name = "Crimson_Tree",
Variety = "Top_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,88),
Name = "Crimson_Tree",
Variety = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(902,88),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(924,88),
Name = "Crimson_Tree",
Variety = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(946,88),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(968,88),
Name = "Crimson_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(990,88),
Name = "Crimson_Tree",
Variety = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1012,88),
Name = "Crimson_Tree",
Variety = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1034,88),
Name = "Crimson_Tree",
Variety = "Top_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,110),
Name = "Crimson_Tree",
Variety = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(902,110),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(924,110),
Name = "Crimson_Tree",
Variety = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(946,110),
Name = "Crimson_Tree",
Variety = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(968,110),
Name = "Crimson_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(990,110),
Name = "Crimson_Tree",
Variety = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1012,110),
Name = "Crimson_Tree",
Variety = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1034,110),
Name = "Crimson_Tree",
Variety = "Top_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,132),
Name = "Crimson_Tree",
Variety = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(902,132),
Name = "Crimson_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(924,132),
Name = "Crimson_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(946,132),
Name = "Crimson_Tree",
Variety = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(968,132),
Name = "Crimson_Tree",
Variety = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1012,132),
Name = "Crimson_Tree",
Variety = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1034,132),
Name = "Crimson_Tree",
Variety = "Top_Huge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,154),
Name = "Crimson_Tree",
Variety = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(902,154),
Name = "Crimson_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(924,154),
Name = "Crimson_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(946,154),
Name = "Crimson_Tree",
Variety = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(968,154),
Name = "Crimson_Tree",
Variety = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(1012,154),
Name = "Crimson_Tree",
Variety = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1034,154),
Name = "Crimson_Tree",
Variety = "Top_Huge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,176),
Name = "Crimson_Tree",
Variety = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 5,
Origin = new(902,176),
Name = "Crimson_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(924,176),
Name = "Crimson_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(946,176),
Name = "Crimson_Tree",
Variety = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 5,
Origin = new(968,176),
Name = "Crimson_Tree",
Variety = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 5,
Origin = new(1012,176),
Name = "Crimson_Tree",
Variety = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1034,176),
Name = "Crimson_Tree",
Variety = "Top_Huge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,198),
Name = "Crimson_Tree",
Variety = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,220),
Name = "Crimson_Tree",
Variety = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(880,242),
Name = "Crimson_Tree",
Variety = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,0),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1078,0),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1100,0),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1122,0),
Name = "Underground_Jungle_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1144,0),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1166,0),
Name = "Underground_Jungle_Tree",
Variety = "Top_Medium_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1188,0),
Name = "Underground_Jungle_Tree",
Variety = "Top_Small_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1210,0),
Name = "Underground_Jungle_Tree",
Variety = "Top_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,22),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1078,22),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1100,22),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1122,22),
Name = "Underground_Jungle_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1144,22),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1166,22),
Name = "Underground_Jungle_Tree",
Variety = "Top_Medium_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1188,22),
Name = "Underground_Jungle_Tree",
Variety = "Top_Small_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1210,22),
Name = "Underground_Jungle_Tree",
Variety = "Top_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,44),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1078,44),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1100,44),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1122,44),
Name = "Underground_Jungle_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1144,44),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1166,44),
Name = "Underground_Jungle_Tree",
Variety = "Top_Medium_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1188,44),
Name = "Underground_Jungle_Tree",
Variety = "Top_Small_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1210,44),
Name = "Underground_Jungle_Tree",
Variety = "Top_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,66),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1078,66),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1100,66),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1122,66),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(1144,66),
Name = "Underground_Jungle_Tree",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1166,66),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1188,66),
Name = "Underground_Jungle_Tree",
Variety = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1210,66),
Name = "Underground_Jungle_Tree",
Variety = "Top_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,88),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1078,88),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1100,88),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1122,88),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(1144,88),
Name = "Underground_Jungle_Tree",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1166,88),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1188,88),
Name = "Underground_Jungle_Tree",
Variety = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1210,88),
Name = "Underground_Jungle_Tree",
Variety = "Top_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,110),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1078,110),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1100,110),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1122,110),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(1144,110),
Name = "Underground_Jungle_Tree",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1166,110),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1188,110),
Name = "Underground_Jungle_Tree",
Variety = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1210,110),
Name = "Underground_Jungle_Tree",
Variety = "Top_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,132),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1078,132),
Name = "Underground_Jungle_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1100,132),
Name = "Underground_Jungle_Tree",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1122,132),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1144,132),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1188,132),
Name = "Underground_Jungle_Tree",
Variety = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1210,132),
Name = "Underground_Jungle_Tree",
Variety = "Top_Huge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,154),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(1078,154),
Name = "Underground_Jungle_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1100,154),
Name = "Underground_Jungle_Tree",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1122,154),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(1144,154),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(1188,154),
Name = "Underground_Jungle_Tree",
Variety = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1210,154),
Name = "Underground_Jungle_Tree",
Variety = "Top_Huge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,176),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 5,
Origin = new(1078,176),
Name = "Underground_Jungle_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1100,176),
Name = "Underground_Jungle_Tree",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1122,176),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 5,
Origin = new(1144,176),
Name = "Underground_Jungle_Tree",
Variety = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 5,
Origin = new(1188,176),
Name = "Underground_Jungle_Tree",
Variety = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1210,176),
Name = "Underground_Jungle_Tree",
Variety = "Top_Huge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,198),
Name = "Underground_Jungle_Tree",
Variety = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,220),
Name = "Underground_Jungle_Tree",
Variety = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1056,242),
Name = "Underground_Jungle_Tree",
Variety = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,0),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1254,0),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1276,0),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1298,0),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1320,0),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1342,0),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Medium_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1364,0),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Small_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1386,0),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,22),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1254,22),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1276,22),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1298,22),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1320,22),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1342,22),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Medium_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1364,22),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Small_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1386,22),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,44),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1254,44),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1276,44),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1298,44),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1320,44),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1342,44),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Medium_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1364,44),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Small_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1386,44),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,66),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1254,66),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1276,66),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1298,66),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(1320,66),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1342,66),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1364,66),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1386,66),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,88),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1254,88),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1276,88),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1298,88),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(1320,88),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1342,88),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1364,88),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1386,88),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,110),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1254,110),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1276,110),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1298,110),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(1320,110),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1342,110),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1364,110),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1386,110),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,132),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1254,132),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1276,132),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Base_Plain_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1298,132),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1320,132),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1364,132),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1386,132),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Huge_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,154),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 5,
Origin = new(1254,154),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1276,154),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Base_Plain_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1298,154),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 5,
Origin = new(1320,154),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 5,
Origin = new(1364,154),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1386,154),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Huge_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,176),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 5,
Origin = new(1254,176),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1276,176),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Base_Plain_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1298,176),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 5,
Origin = new(1320,176),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 5,
Origin = new(1364,176),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1386,176),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Huge_C",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,198),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,220),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 5,
Origin = new(1232,242),
Name = "Giant_Glowing_Mushroom_(Surface)",
Variety = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Name = "Wooden_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,0),
Name = "Wooden_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,0),
Name = "Wooden_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,54),
Name = "Ebonwood_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,54),
Name = "Ebonwood_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,54),
Name = "Ebonwood_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,108),
Name = "Rich_Mahogany_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,108),
Name = "Rich_Mahogany_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,108),
Name = "Rich_Mahogany_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,162),
Name = "Pearlwood_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,162),
Name = "Pearlwood_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,162),
Name = "Pearlwood_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,216),
Name = "Cactus_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,216),
Name = "Cactus_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,216),
Name = "Cactus_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,270),
Name = "Flesh_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,270),
Name = "Flesh_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,270),
Name = "Flesh_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,324),
Name = "Mushroom_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,324),
Name = "Mushroom_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,324),
Name = "Mushroom_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,378),
Name = "Living_Wood_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,378),
Name = "Living_Wood_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,378),
Name = "Living_Wood_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,432),
Name = "Bone_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,432),
Name = "Bone_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,432),
Name = "Bone_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,486),
Name = "Skyware_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,486),
Name = "Skyware_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,486),
Name = "Skyware_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,540),
Name = "Shadewood_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,540),
Name = "Shadewood_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,540),
Name = "Shadewood_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,594),
Name = "Lihzahrd_Locked_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,594),
Name = "Lihzahrd_Locked_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,594),
Name = "Lihzahrd_Locked_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,648),
Name = "Lihzahrd_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,648),
Name = "Lihzahrd_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,648),
Name = "Lihzahrd_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,702),
Name = "Dungeon_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,702),
Name = "Dungeon_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,702),
Name = "Dungeon_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,756),
Name = "Lead_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,756),
Name = "Lead_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,756),
Name = "Lead_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,810),
Name = "Iron_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,810),
Name = "Iron_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,810),
Name = "Iron_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,864),
Name = "Blue_Dungeon_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,864),
Name = "Blue_Dungeon_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,864),
Name = "Blue_Dungeon_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,918),
Name = "Green_Dungeon_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,918),
Name = "Green_Dungeon_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,918),
Name = "Green_Dungeon_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,972),
Name = "Pink_Dungeon_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,972),
Name = "Pink_Dungeon_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,972),
Name = "Pink_Dungeon_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1026),
Name = "Obsidian_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1026),
Name = "Obsidian_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1026),
Name = "Obsidian_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1080),
Name = "Glass_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1080),
Name = "Glass_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1080),
Name = "Glass_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1134),
Name = "Golden_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1134),
Name = "Golden_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1134),
Name = "Golden_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1188),
Name = "Honey_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1188),
Name = "Honey_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1188),
Name = "Honey_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1242),
Name = "Steampunk_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1242),
Name = "Steampunk_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1242),
Name = "Steampunk_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1296),
Name = "Pumpkin_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1296),
Name = "Pumpkin_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1296),
Name = "Pumpkin_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1350),
Name = "Spooky_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1350),
Name = "Spooky_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1350),
Name = "Spooky_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1404),
Name = "Pine_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1404),
Name = "Pine_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1404),
Name = "Pine_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1458),
Name = "Frozen_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1458),
Name = "Frozen_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1458),
Name = "Frozen_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1512),
Name = "Dynasty_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1512),
Name = "Dynasty_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1512),
Name = "Dynasty_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1566),
Name = "Palm_Wood_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1566),
Name = "Palm_Wood_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1566),
Name = "Palm_Wood_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1620),
Name = "Boreal_Wood_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1620),
Name = "Boreal_Wood_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1620),
Name = "Boreal_Wood_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1674),
Name = "Slime_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1674),
Name = "Slime_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1674),
Name = "Slime_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1728),
Name = "Martian_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1728),
Name = "Martian_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1728),
Name = "Martian_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1782),
Name = "Meteorite_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1782),
Name = "Meteorite_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1782),
Name = "Meteorite_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1836),
Name = "Granite_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1836),
Name = "Granite_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1836),
Name = "Granite_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(0,1890),
Name = "Marble_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(18,1890),
Name = "Marble_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(36,1890),
Name = "Marble_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,0),
Name = "Crystal_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,0),
Name = "Crystal_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,0),
Name = "Crystal_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,54),
Name = "Spider_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,54),
Name = "Spider_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,54),
Name = "Spider_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,108),
Name = "Lesion_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,108),
Name = "Lesion_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,108),
Name = "Lesion_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,162),
Name = "Solar_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,162),
Name = "Solar_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,162),
Name = "Solar_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,216),
Name = "Vortex_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,216),
Name = "Vortex_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,216),
Name = "Vortex_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,270),
Name = "Nebula_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,270),
Name = "Nebula_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,270),
Name = "Nebula_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,324),
Name = "Stardust_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,324),
Name = "Stardust_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,324),
Name = "Stardust_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,378),
Name = "Sandstone_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,378),
Name = "Sandstone_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,378),
Name = "Sandstone_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,432),
Name = "Stone_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,432),
Name = "Stone_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,432),
Name = "Stone_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,486),
Name = "Bamboo_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,486),
Name = "Bamboo_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,486),
Name = "Bamboo_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,540),
Name = "Reef_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,540),
Name = "Reef_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,540),
Name = "Reef_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,594),
Name = "Balloon_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,594),
Name = "Balloon_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,594),
Name = "Balloon_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(54,648),
Name = "Ash_Wood_Door",
Variety = "A",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(72,648),
Name = "Ash_Wood_Door",
Variety = "B",
},

new SpriteData()
{
TileType = 10,
Size = new(1,3),
Origin = new(90,648),
Name = "Ash_Wood_Door",
Variety = "C",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Name = "Wooden_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,0),
Name = "Wooden_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,54),
Name = "Ebonwood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,54),
Name = "Ebonwood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,108),
Name = "Rich_Mahogany_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,108),
Name = "Rich_Mahogany_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,162),
Name = "Pearlwood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,162),
Name = "Pearlwood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,216),
Name = "Cactus_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,216),
Name = "Cactus_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,270),
Name = "Flesh_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,270),
Name = "Flesh_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,324),
Name = "Mushroom_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,324),
Name = "Mushroom_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,378),
Name = "Living_Wood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,378),
Name = "Living_Wood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,432),
Name = "Bone_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,432),
Name = "Bone_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,486),
Name = "Skyware_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,486),
Name = "Skyware_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,540),
Name = "Shadewood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,540),
Name = "Shadewood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,648),
Name = "Lihzahrd_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,648),
Name = "Lihzahrd_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,702),
Name = "Dungeon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,702),
Name = "Dungeon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,756),
Name = "Lead_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,756),
Name = "Lead_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,810),
Name = "Iron_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,810),
Name = "Iron_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,864),
Name = "Blue_Dungeon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,864),
Name = "Blue_Dungeon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,918),
Name = "Green_Dungeon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,918),
Name = "Green_Dungeon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,972),
Name = "Pink_Dungeon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,972),
Name = "Pink_Dungeon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1026),
Name = "Obsidian_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1026),
Name = "Obsidian_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1080),
Name = "Glass_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1080),
Name = "Glass_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1134),
Name = "Golden_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1134),
Name = "Golden_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1188),
Name = "Honey_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1188),
Name = "Honey_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1242),
Name = "Steampunk_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1242),
Name = "Steampunk_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1296),
Name = "Pumpkin_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1296),
Name = "Pumpkin_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1350),
Name = "Spooky_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1350),
Name = "Spooky_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1404),
Name = "Pine_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1404),
Name = "Pine_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1458),
Name = "Frozen_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1458),
Name = "Frozen_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1512),
Name = "Dynasty_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1512),
Name = "Dynasty_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1566),
Name = "Palm_Wood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1566),
Name = "Palm_Wood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1620),
Name = "Boreal_Wood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1620),
Name = "Boreal_Wood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1674),
Name = "Slime_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1674),
Name = "Slime_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1728),
Name = "Martian_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1728),
Name = "Martian_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1782),
Name = "Meteorite_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1782),
Name = "Meteorite_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1836),
Name = "Granite_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1836),
Name = "Granite_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,1890),
Name = "Marble_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,1890),
Name = "Marble_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,0),
Name = "Crystal_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,0),
Name = "Crystal_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,54),
Name = "Spider_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,54),
Name = "Spider_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,108),
Name = "Lesion_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,108),
Name = "Lesion_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,162),
Name = "Solar_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,162),
Name = "Solar_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,216),
Name = "Vortex_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,216),
Name = "Vortex_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,270),
Name = "Nebula_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,270),
Name = "Nebula_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,324),
Name = "Stardust_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,324),
Name = "Stardust_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,378),
Name = "Sandstone_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,378),
Name = "Sandstone_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,432),
Name = "Stone_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,432),
Name = "Stone_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,486),
Name = "Bamboo_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,486),
Name = "Bamboo_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,540),
Name = "Reef_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,540),
Name = "Reef_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,594),
Name = "Lihzahrd_Locked_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,594),
Name = "Lihzahrd_Locked_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,594),
Name = "Balloon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,594),
Name = "Balloon_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,648),
Name = "Lihzahrd_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,648),
Name = "Lihzahrd_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(72,648),
Name = "Ash_Wood_Door",
},

new SpriteData()
{
TileType = 11,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(108,648),
Name = "Ash_Wood_Door",
},

new SpriteData()
{
TileType = 12,
Size = new(2,2),
},

new SpriteData()
{
TileType = 13,
Name = "Bottle",
},

new SpriteData()
{
TileType = 13,
Origin = new(18,0),
Name = "Healing_Potion",
},

new SpriteData()
{
TileType = 13,
Origin = new(36,0),
Name = "Mana_Potion",
},

new SpriteData()
{
TileType = 13,
Origin = new(54,0),
Name = "Pink_Vase",
},

new SpriteData()
{
TileType = 13,
Origin = new(72,0),
Name = "Mug",
},

new SpriteData()
{
TileType = 13,
Origin = new(90,0),
Name = "Dynasty_Cup",
},

new SpriteData()
{
TileType = 13,
Origin = new(108,0),
Name = "Wine_Glass",
},

new SpriteData()
{
TileType = 13,
Origin = new(126,0),
Name = "Honey_Cup",
},

new SpriteData()
{
TileType = 13,
Origin = new(144,0),
Name = "Chalice",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Name = "Wooden_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(54,0),
Name = "Ebonwood_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(108,0),
Name = "Rich_Mahogany_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(162,0),
Name = "Pearlwood_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(216,0),
Name = "Bone_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(270,0),
Name = "Flesh_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(324,0),
Name = "Living_Wood_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(378,0),
Name = "Skyware_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(432,0),
Name = "Shadewood_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(486,0),
Name = "Lihzahrd_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(540,0),
Name = "Blue_Dungeon_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(594,0),
Name = "Green_Dungeon_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(648,0),
Name = "Pink_Dungeon_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(702,0),
Name = "Obsidian_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(756,0),
Name = "Gothic_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(810,0),
Name = "Glass_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(864,0),
Name = "Banquet_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(918,0),
Name = "Bar",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(972,0),
Name = "Golden_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1026,0),
Name = "Honey_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1080,0),
Name = "Steampunk_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1134,0),
Name = "Pumpkin_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1188,0),
Name = "Spooky_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1242,0),
Name = "Pine_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1296,0),
Name = "Frozen_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,1),
Origin = new(1350,0),
Name = "Dynasty_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1404,0),
Name = "Palm_Wood_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1458,0),
Name = "Mushroom_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1512,0),
Name = "Boreal_Wood_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1566,0),
Name = "Slime_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1620,0),
Name = "Cactus_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1674,0),
Name = "Martian_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1728,0),
Name = "Meteorite_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1782,0),
Name = "Granite_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(1836,0),
Name = "Marble_Table",
},

new SpriteData()
{
TileType = 14,
Size = new(3,2),
Origin = new(0,36),
Name = "Crystal_Table",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Name = "Wooden_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,0),
Name = "Wooden_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,40),
Name = "Toilet",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,40),
Name = "Toilet",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,80),
Name = "Ebonwood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,80),
Name = "Ebonwood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,120),
Name = "Rich_Mahogany_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,120),
Name = "Rich_Mahogany_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,160),
Name = "Pearlwood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,160),
Name = "Pearlwood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,200),
Name = "Living_Wood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,200),
Name = "Living_Wood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,240),
Name = "Cactus_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,240),
Name = "Cactus_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,280),
Name = "Bone_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,280),
Name = "Bone_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,320),
Name = "Flesh_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,320),
Name = "Flesh_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,360),
Name = "Mushroom_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,360),
Name = "Mushroom_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,400),
Name = "Skyware_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,400),
Name = "Skyware_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,440),
Name = "Shadewood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,440),
Name = "Shadewood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,480),
Name = "Lihzahrd_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,480),
Name = "Lihzahrd_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,520),
Name = "Blue_Dungeon_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,520),
Name = "Blue_Dungeon_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,560),
Name = "Green_Dungeon_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,560),
Name = "Green_Dungeon_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,600),
Name = "Pink_Dungeon_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,600),
Name = "Pink_Dungeon_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,640),
Name = "Obsidian_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,640),
Name = "Obsidian_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,680),
Name = "Gothic_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,680),
Name = "Gothic_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,720),
Name = "Glass_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,720),
Name = "Glass_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,760),
Name = "Golden_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,760),
Name = "Golden_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,800),
Name = "Golden_Toilet",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,800),
Name = "Golden_Toilet",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,840),
Name = "Barstool",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,840),
Name = "Barstool",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,880),
Name = "Honey_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,880),
Name = "Honey_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,920),
Name = "Steampunk_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,920),
Name = "Steampunk_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,960),
Name = "Pumpkin_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,960),
Name = "Pumpkin_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1000),
Name = "Spooky_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1000),
Name = "Spooky_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1040),
Name = "Pine_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1040),
Name = "Pine_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1080),
Name = "Dynasty_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1080),
Name = "Dynasty_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1120),
Name = "Frozen_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1120),
Name = "Frozen_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1160),
Name = "Palm_Wood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1160),
Name = "Palm_Wood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1200),
Name = "Boreal_Wood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1200),
Name = "Boreal_Wood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1240),
Name = "Slime_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1240),
Name = "Slime_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1280),
Name = "Martian_Hover_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1280),
Name = "Martian_Hover_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1320),
Name = "Meteorite_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1320),
Name = "Meteorite_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1360),
Name = "Granite_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1360),
Name = "Granite_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1400),
Name = "Marble_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1400),
Name = "Marble_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1440),
Name = "Crystal_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1440),
Name = "Crystal_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1480),
Name = "Spider_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1480),
Name = "Spider_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1520),
Name = "Lesion_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1520),
Name = "Lesion_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1560),
Name = "Solar_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1560),
Name = "Solar_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1600),
Name = "Vortex_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1600),
Name = "Vortex_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1640),
Name = "Nebula_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1640),
Name = "Nebula_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1680),
Name = "Stardust_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1680),
Name = "Stardust_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1720),
Name = "Sandstone_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1720),
Name = "Sandstone_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1760),
Name = "Bamboo_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1760),
Name = "Bamboo_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1800),
Name = "Reef_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1800),
Name = "Reef_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1840),
Name = "Balloon_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1840),
Name = "Balloon_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1880),
Name = "Ash_Wood_Chair",
},

new SpriteData()
{
TileType = 15,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1880),
Name = "Ash_Wood_Chair",
},

new SpriteData()
{
TileType = 16,
Size = new(2,1),
Name = "Iron_Anvil",
},

new SpriteData()
{
TileType = 16,
Size = new(2,1),
Origin = new(36,0),
Name = "Lead_Anvil",
},

new SpriteData()
{
TileType = 17,
Size = new(3,2),
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Name = "Wooden_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(36,0),
Name = "Ebonwood_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(72,0),
Name = "Rich_Mahogany_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(108,0),
Name = "Pearlwood_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(144,0),
Name = "Bone_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(180,0),
Name = "Cactus_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(216,0),
Name = "Flesh_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(252,0),
Name = "Mushroom_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(288,0),
Name = "Slime_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(324,0),
Name = "Shadewood_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(360,0),
Name = "Lihzahrd_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(396,0),
Name = "Blue_Dungeon_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(432,0),
Name = "Green_Dungeon_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(468,0),
Name = "Pink_Dungeon_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(504,0),
Name = "Obsidian_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(540,0),
Name = "Gothic_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(576,0),
Name = "Pumpkin_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(612,0),
Name = "Spooky_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(648,0),
Name = "Dynasty_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(684,0),
Name = "Honey_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(720,0),
Name = "Frozen_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(756,0),
Name = "Steampunk_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(792,0),
Name = "Palm_Wood_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(828,0),
Name = "Boreal_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(864,0),
Name = "Skyware_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(900,0),
Name = "Glass_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(936,0),
Name = "Living_Wood_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(972,0),
Name = "Martian_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1008,0),
Name = "Meteorite_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1044,0),
Name = "Granite_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1080,0),
Name = "Marble_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1116,0),
Name = "Crystal_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1152,0),
Name = "Golden_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1188,0),
Name = "Spider_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1224,0),
Name = "Lesion_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1260,0),
Name = "Solar_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1296,0),
Name = "Vortex_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1332,0),
Name = "Nebula_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1368,0),
Name = "Stardust_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1404,0),
Name = "Sandstone_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1440,0),
Name = "Bamboo_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1476,0),
Name = "Reef_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1512,0),
Name = "Balloon_Work_Bench",
},

new SpriteData()
{
TileType = 18,
Size = new(2,1),
Origin = new(1548,0),
Name = "Ash_Wood_Work_Bench",
},

new SpriteData()
{
TileType = 19,
Name = "Wood_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,0),
Name = "Wood_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,0),
Name = "Wood_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,0),
Name = "Wood_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,0),
Name = "Wood_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,0),
Name = "Wood_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,0),
Name = "Wood_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,0),
Name = "Wood_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,0),
Name = "Wood_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,0),
Name = "Wood_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,0),
Name = "Wood_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,0),
Name = "Wood_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,0),
Name = "Wood_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,0),
Name = "Wood_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,0),
Name = "Wood_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,0),
Name = "Wood_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,0),
Name = "Wood_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,0),
Name = "Wood_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,0),
Name = "Wood_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,0),
Name = "Wood_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,0),
Name = "Wood_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,0),
Name = "Wood_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,0),
Name = "Wood_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,0),
Name = "Wood_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,0),
Name = "Wood_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,0),
Name = "Wood_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,0),
Name = "Wood_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,18),
Name = "Ebonwood_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,18),
Name = "Ebonwood_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,18),
Name = "Ebonwood_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,18),
Name = "Ebonwood_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,18),
Name = "Ebonwood_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,18),
Name = "Ebonwood_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,18),
Name = "Ebonwood_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,18),
Name = "Ebonwood_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,18),
Name = "Ebonwood_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,36),
Name = "Rich_Mahogany_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,36),
Name = "Rich_Mahogany_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,36),
Name = "Rich_Mahogany_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,36),
Name = "Rich_Mahogany_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,36),
Name = "Rich_Mahogany_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,36),
Name = "Rich_Mahogany_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,36),
Name = "Rich_Mahogany_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,36),
Name = "Rich_Mahogany_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,36),
Name = "Rich_Mahogany_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,54),
Name = "Pearlwood_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,54),
Name = "Pearlwood_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,54),
Name = "Pearlwood_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,54),
Name = "Pearlwood_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,54),
Name = "Pearlwood_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,54),
Name = "Pearlwood_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,54),
Name = "Pearlwood_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,54),
Name = "Pearlwood_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,54),
Name = "Pearlwood_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,72),
Name = "Bone_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,72),
Name = "Bone_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,72),
Name = "Bone_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,72),
Name = "Bone_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,72),
Name = "Bone_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,72),
Name = "Bone_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,72),
Name = "Bone_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,72),
Name = "Bone_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,72),
Name = "Bone_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,72),
Name = "Bone_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,72),
Name = "Bone_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,72),
Name = "Bone_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,72),
Name = "Bone_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,72),
Name = "Bone_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,72),
Name = "Bone_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,72),
Name = "Bone_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,72),
Name = "Bone_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,72),
Name = "Bone_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,72),
Name = "Bone_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,72),
Name = "Bone_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,72),
Name = "Bone_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,72),
Name = "Bone_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,72),
Name = "Bone_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,72),
Name = "Bone_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,72),
Name = "Bone_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,72),
Name = "Bone_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,72),
Name = "Bone_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,90),
Name = "Shadewood_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,90),
Name = "Shadewood_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,90),
Name = "Shadewood_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,90),
Name = "Shadewood_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,90),
Name = "Shadewood_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,90),
Name = "Shadewood_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,90),
Name = "Shadewood_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,90),
Name = "Shadewood_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,90),
Name = "Shadewood_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,90),
Name = "Shadewood_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,90),
Name = "Shadewood_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,90),
Name = "Shadewood_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,90),
Name = "Shadewood_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,90),
Name = "Shadewood_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,90),
Name = "Shadewood_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,90),
Name = "Shadewood_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,90),
Name = "Shadewood_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,90),
Name = "Shadewood_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,90),
Name = "Shadewood_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,90),
Name = "Shadewood_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,90),
Name = "Shadewood_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,90),
Name = "Shadewood_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,90),
Name = "Shadewood_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,90),
Name = "Shadewood_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,90),
Name = "Shadewood_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,90),
Name = "Shadewood_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,90),
Name = "Shadewood_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,108),
Name = "Blue_Brick_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,108),
Name = "Blue_Brick_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,108),
Name = "Blue_Brick_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,108),
Name = "Blue_Brick_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,108),
Name = "Blue_Brick_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,108),
Name = "Blue_Brick_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,108),
Name = "Blue_Brick_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,108),
Name = "Blue_Brick_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,108),
Name = "Blue_Brick_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,126),
Name = "Pink_Brick_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,126),
Name = "Pink_Brick_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,126),
Name = "Pink_Brick_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,126),
Name = "Pink_Brick_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,126),
Name = "Pink_Brick_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,126),
Name = "Pink_Brick_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,126),
Name = "Pink_Brick_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,126),
Name = "Pink_Brick_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,126),
Name = "Pink_Brick_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,144),
Name = "Green_Brick_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,144),
Name = "Green_Brick_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,144),
Name = "Green_Brick_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,144),
Name = "Green_Brick_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,144),
Name = "Green_Brick_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,144),
Name = "Green_Brick_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,144),
Name = "Green_Brick_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,144),
Name = "Green_Brick_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,144),
Name = "Green_Brick_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,162),
Name = "Metal_Shelf",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,162),
Name = "Metal_Shelf",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,162),
Name = "Metal_Shelf",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,162),
Name = "Metal_Shelf",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,162),
Name = "Metal_Shelf",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,162),
Name = "Metal_Shelf",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,162),
Name = "Metal_Shelf",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,162),
Name = "Metal_Shelf",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,162),
Name = "Metal_Shelf",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,162),
Name = "Metal_Shelf",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,162),
Name = "Metal_Shelf",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,162),
Name = "Metal_Shelf",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,162),
Name = "Metal_Shelf",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,162),
Name = "Metal_Shelf",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,162),
Name = "Metal_Shelf",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,162),
Name = "Metal_Shelf",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,162),
Name = "Metal_Shelf",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,162),
Name = "Metal_Shelf",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,162),
Name = "Metal_Shelf",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,162),
Name = "Metal_Shelf",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,162),
Name = "Metal_Shelf",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,162),
Name = "Metal_Shelf",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,162),
Name = "Metal_Shelf",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,162),
Name = "Metal_Shelf",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,162),
Name = "Metal_Shelf",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,162),
Name = "Metal_Shelf",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,162),
Name = "Metal_Shelf",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,180),
Name = "Brass_Shelf",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,180),
Name = "Brass_Shelf",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,180),
Name = "Brass_Shelf",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,180),
Name = "Brass_Shelf",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,180),
Name = "Brass_Shelf",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,180),
Name = "Brass_Shelf",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,180),
Name = "Brass_Shelf",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,180),
Name = "Brass_Shelf",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,180),
Name = "Brass_Shelf",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,180),
Name = "Brass_Shelf",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,180),
Name = "Brass_Shelf",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,180),
Name = "Brass_Shelf",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,180),
Name = "Brass_Shelf",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,180),
Name = "Brass_Shelf",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,180),
Name = "Brass_Shelf",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,180),
Name = "Brass_Shelf",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,180),
Name = "Brass_Shelf",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,180),
Name = "Brass_Shelf",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,180),
Name = "Brass_Shelf",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,180),
Name = "Brass_Shelf",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,180),
Name = "Brass_Shelf",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,180),
Name = "Brass_Shelf",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,180),
Name = "Brass_Shelf",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,180),
Name = "Brass_Shelf",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,180),
Name = "Brass_Shelf",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,180),
Name = "Brass_Shelf",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,180),
Name = "Brass_Shelf",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,198),
Name = "Wood_Shelf",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,198),
Name = "Wood_Shelf",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,198),
Name = "Wood_Shelf",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,198),
Name = "Wood_Shelf",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,198),
Name = "Wood_Shelf",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,198),
Name = "Wood_Shelf",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,198),
Name = "Wood_Shelf",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,198),
Name = "Wood_Shelf",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,198),
Name = "Wood_Shelf",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,198),
Name = "Wood_Shelf",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,198),
Name = "Wood_Shelf",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,198),
Name = "Wood_Shelf",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,198),
Name = "Wood_Shelf",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,198),
Name = "Wood_Shelf",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,198),
Name = "Wood_Shelf",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,198),
Name = "Wood_Shelf",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,198),
Name = "Wood_Shelf",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,198),
Name = "Wood_Shelf",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,198),
Name = "Wood_Shelf",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,198),
Name = "Wood_Shelf",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,198),
Name = "Wood_Shelf",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,198),
Name = "Wood_Shelf",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,198),
Name = "Wood_Shelf",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,198),
Name = "Wood_Shelf",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,198),
Name = "Wood_Shelf",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,198),
Name = "Wood_Shelf",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,198),
Name = "Wood_Shelf",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,218),
Name = "Dungeon_Shelf",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,216),
Name = "Dungeon_Shelf",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,216),
Name = "Dungeon_Shelf",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,216),
Name = "Dungeon_Shelf",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,216),
Name = "Dungeon_Shelf",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,216),
Name = "Dungeon_Shelf",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,216),
Name = "Dungeon_Shelf",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,216),
Name = "Dungeon_Shelf",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,216),
Name = "Dungeon_Shelf",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,234),
Name = "Obsidian_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,234),
Name = "Obsidian_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,234),
Name = "Obsidian_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,234),
Name = "Obsidian_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,234),
Name = "Obsidian_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,234),
Name = "Obsidian_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,234),
Name = "Obsidian_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,234),
Name = "Obsidian_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,234),
Name = "Obsidian_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,234),
Name = "Obsidian_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,234),
Name = "Obsidian_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,234),
Name = "Obsidian_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,234),
Name = "Obsidian_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,234),
Name = "Obsidian_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,234),
Name = "Obsidian_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,234),
Name = "Obsidian_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,234),
Name = "Obsidian_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,234),
Name = "Obsidian_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,234),
Name = "Obsidian_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,234),
Name = "Obsidian_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,234),
Name = "Obsidian_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,234),
Name = "Obsidian_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,234),
Name = "Obsidian_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,234),
Name = "Obsidian_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,234),
Name = "Obsidian_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,234),
Name = "Obsidian_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,234),
Name = "Obsidian_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,252),
Name = "Glass_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,252),
Name = "Glass_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,252),
Name = "Glass_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,252),
Name = "Glass_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,252),
Name = "Glass_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,252),
Name = "Glass_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,252),
Name = "Glass_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,252),
Name = "Glass_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,252),
Name = "Glass_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,252),
Name = "Glass_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,252),
Name = "Glass_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,252),
Name = "Glass_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,252),
Name = "Glass_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,252),
Name = "Glass_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,252),
Name = "Glass_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,252),
Name = "Glass_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,252),
Name = "Glass_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,252),
Name = "Glass_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,252),
Name = "Glass_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,252),
Name = "Glass_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,252),
Name = "Glass_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,252),
Name = "Glass_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,252),
Name = "Glass_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,252),
Name = "Glass_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,252),
Name = "Glass_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,252),
Name = "Glass_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,252),
Name = "Glass_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,270),
Name = "Pumpkin_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,270),
Name = "Pumpkin_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,270),
Name = "Pumpkin_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,270),
Name = "Pumpkin_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,270),
Name = "Pumpkin_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,270),
Name = "Pumpkin_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,270),
Name = "Pumpkin_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,270),
Name = "Pumpkin_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,270),
Name = "Pumpkin_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,288),
Name = "Spooky_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,288),
Name = "Spooky_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,288),
Name = "Spooky_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,288),
Name = "Spooky_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,288),
Name = "Spooky_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,288),
Name = "Spooky_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,288),
Name = "Spooky_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,288),
Name = "Spooky_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,288),
Name = "Spooky_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,288),
Name = "Spooky_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,288),
Name = "Spooky_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,288),
Name = "Spooky_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,288),
Name = "Spooky_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,288),
Name = "Spooky_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,288),
Name = "Spooky_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,288),
Name = "Spooky_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,288),
Name = "Spooky_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,288),
Name = "Spooky_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,288),
Name = "Spooky_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,288),
Name = "Spooky_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,288),
Name = "Spooky_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,288),
Name = "Spooky_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,288),
Name = "Spooky_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,288),
Name = "Spooky_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,288),
Name = "Spooky_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,288),
Name = "Spooky_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,288),
Name = "Spooky_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,306),
Name = "Palm_Wood_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,306),
Name = "Palm_Wood_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,306),
Name = "Palm_Wood_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,306),
Name = "Palm_Wood_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,306),
Name = "Palm_Wood_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,306),
Name = "Palm_Wood_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,306),
Name = "Palm_Wood_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,306),
Name = "Palm_Wood_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,306),
Name = "Palm_Wood_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,324),
Name = "Mushroom_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,324),
Name = "Mushroom_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,324),
Name = "Mushroom_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,324),
Name = "Mushroom_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,324),
Name = "Mushroom_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,324),
Name = "Mushroom_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,324),
Name = "Mushroom_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,324),
Name = "Mushroom_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,324),
Name = "Mushroom_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,324),
Name = "Mushroom_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,324),
Name = "Mushroom_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,324),
Name = "Mushroom_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,324),
Name = "Mushroom_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,324),
Name = "Mushroom_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,324),
Name = "Mushroom_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,324),
Name = "Mushroom_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,324),
Name = "Mushroom_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,324),
Name = "Mushroom_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,324),
Name = "Mushroom_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,324),
Name = "Mushroom_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,324),
Name = "Mushroom_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,324),
Name = "Mushroom_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,324),
Name = "Mushroom_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,324),
Name = "Mushroom_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,324),
Name = "Mushroom_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,324),
Name = "Mushroom_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,324),
Name = "Mushroom_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,342),
Name = "Boreal_Wood_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,342),
Name = "Boreal_Wood_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,342),
Name = "Boreal_Wood_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,342),
Name = "Boreal_Wood_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,342),
Name = "Boreal_Wood_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,342),
Name = "Boreal_Wood_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,342),
Name = "Boreal_Wood_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,342),
Name = "Boreal_Wood_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,342),
Name = "Boreal_Wood_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,360),
Name = "Slime_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,360),
Name = "Slime_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,360),
Name = "Slime_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,360),
Name = "Slime_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,360),
Name = "Slime_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,360),
Name = "Slime_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,360),
Name = "Slime_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,360),
Name = "Slime_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,360),
Name = "Slime_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,360),
Name = "Slime_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,360),
Name = "Slime_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,360),
Name = "Slime_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,360),
Name = "Slime_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,360),
Name = "Slime_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,360),
Name = "Slime_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,360),
Name = "Slime_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,360),
Name = "Slime_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,360),
Name = "Slime_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,360),
Name = "Slime_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,360),
Name = "Slime_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,360),
Name = "Slime_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,360),
Name = "Slime_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,360),
Name = "Slime_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,360),
Name = "Slime_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,360),
Name = "Slime_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,360),
Name = "Slime_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,360),
Name = "Slime_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,378),
Name = "Steampunk_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,378),
Name = "Steampunk_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,378),
Name = "Steampunk_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,378),
Name = "Steampunk_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,378),
Name = "Steampunk_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,378),
Name = "Steampunk_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,378),
Name = "Steampunk_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,378),
Name = "Steampunk_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,378),
Name = "Steampunk_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,378),
Name = "Steampunk_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,378),
Name = "Steampunk_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,378),
Name = "Steampunk_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,378),
Name = "Steampunk_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,378),
Name = "Steampunk_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,378),
Name = "Steampunk_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,378),
Name = "Steampunk_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,378),
Name = "Steampunk_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,378),
Name = "Steampunk_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,378),
Name = "Steampunk_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,378),
Name = "Steampunk_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,378),
Name = "Steampunk_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,378),
Name = "Steampunk_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,378),
Name = "Steampunk_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,378),
Name = "Steampunk_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,378),
Name = "Steampunk_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,378),
Name = "Steampunk_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,378),
Name = "Steampunk_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,396),
Name = "Skyware_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,396),
Name = "Skyware_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,396),
Name = "Skyware_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,396),
Name = "Skyware_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,396),
Name = "Skyware_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,396),
Name = "Skyware_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,396),
Name = "Skyware_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,396),
Name = "Skyware_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,396),
Name = "Skyware_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,396),
Name = "Skyware_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,396),
Name = "Skyware_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,396),
Name = "Skyware_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,396),
Name = "Skyware_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,396),
Name = "Skyware_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,396),
Name = "Skyware_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,396),
Name = "Skyware_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,396),
Name = "Skyware_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,396),
Name = "Skyware_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,396),
Name = "Skyware_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,396),
Name = "Skyware_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,396),
Name = "Skyware_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,396),
Name = "Skyware_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,396),
Name = "Skyware_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,396),
Name = "Skyware_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,396),
Name = "Skyware_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,396),
Name = "Skyware_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,396),
Name = "Skyware_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,414),
Name = "Living_Wood_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,414),
Name = "Living_Wood_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,414),
Name = "Living_Wood_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,414),
Name = "Living_Wood_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,414),
Name = "Living_Wood_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,414),
Name = "Living_Wood_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,414),
Name = "Living_Wood_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,414),
Name = "Living_Wood_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,414),
Name = "Living_Wood_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,432),
Name = "Honey_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,432),
Name = "Honey_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,432),
Name = "Honey_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,432),
Name = "Honey_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,432),
Name = "Honey_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,432),
Name = "Honey_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,432),
Name = "Honey_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,432),
Name = "Honey_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,432),
Name = "Honey_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,432),
Name = "Honey_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,432),
Name = "Honey_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,432),
Name = "Honey_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,432),
Name = "Honey_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,432),
Name = "Honey_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,432),
Name = "Honey_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,432),
Name = "Honey_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,432),
Name = "Honey_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,432),
Name = "Honey_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,432),
Name = "Honey_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,432),
Name = "Honey_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,432),
Name = "Honey_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,432),
Name = "Honey_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,432),
Name = "Honey_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,432),
Name = "Honey_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,432),
Name = "Honey_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,432),
Name = "Honey_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,432),
Name = "Honey_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,450),
Name = "Cactus_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,450),
Name = "Cactus_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,450),
Name = "Cactus_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,450),
Name = "Cactus_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,450),
Name = "Cactus_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,450),
Name = "Cactus_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,450),
Name = "Cactus_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,450),
Name = "Cactus_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,450),
Name = "Cactus_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,450),
Name = "Cactus_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,450),
Name = "Cactus_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,450),
Name = "Cactus_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,450),
Name = "Cactus_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,450),
Name = "Cactus_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,450),
Name = "Cactus_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,450),
Name = "Cactus_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,450),
Name = "Cactus_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,450),
Name = "Cactus_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,450),
Name = "Cactus_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,450),
Name = "Cactus_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,450),
Name = "Cactus_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,450),
Name = "Cactus_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,450),
Name = "Cactus_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,450),
Name = "Cactus_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,450),
Name = "Cactus_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,450),
Name = "Cactus_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,450),
Name = "Cactus_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,468),
Name = "Martian_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,468),
Name = "Martian_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,468),
Name = "Martian_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,468),
Name = "Martian_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,468),
Name = "Martian_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,468),
Name = "Martian_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,468),
Name = "Martian_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,468),
Name = "Martian_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,468),
Name = "Martian_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,468),
Name = "Martian_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,468),
Name = "Martian_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,468),
Name = "Martian_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,468),
Name = "Martian_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,468),
Name = "Martian_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,468),
Name = "Martian_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,468),
Name = "Martian_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,468),
Name = "Martian_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,468),
Name = "Martian_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,468),
Name = "Martian_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,468),
Name = "Martian_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,468),
Name = "Martian_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,468),
Name = "Martian_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,468),
Name = "Martian_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,468),
Name = "Martian_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,468),
Name = "Martian_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,468),
Name = "Martian_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,468),
Name = "Martian_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,486),
Name = "Meteorite_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,486),
Name = "Meteorite_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,486),
Name = "Meteorite_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,486),
Name = "Meteorite_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,486),
Name = "Meteorite_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,486),
Name = "Meteorite_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,486),
Name = "Meteorite_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,486),
Name = "Meteorite_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,486),
Name = "Meteorite_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,486),
Name = "Meteorite_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,486),
Name = "Meteorite_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,486),
Name = "Meteorite_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,486),
Name = "Meteorite_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,486),
Name = "Meteorite_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,486),
Name = "Meteorite_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,486),
Name = "Meteorite_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,486),
Name = "Meteorite_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,486),
Name = "Meteorite_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,486),
Name = "Meteorite_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,486),
Name = "Meteorite_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,486),
Name = "Meteorite_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,486),
Name = "Meteorite_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,486),
Name = "Meteorite_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,486),
Name = "Meteorite_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,486),
Name = "Meteorite_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,486),
Name = "Meteorite_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,486),
Name = "Meteorite_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,504),
Name = "Granite_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,504),
Name = "Granite_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,504),
Name = "Granite_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,504),
Name = "Granite_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,504),
Name = "Granite_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,504),
Name = "Granite_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,504),
Name = "Granite_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,504),
Name = "Granite_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,504),
Name = "Granite_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,504),
Name = "Granite_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,504),
Name = "Granite_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,504),
Name = "Granite_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,504),
Name = "Granite_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,504),
Name = "Granite_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,504),
Name = "Granite_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,504),
Name = "Granite_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,504),
Name = "Granite_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,504),
Name = "Granite_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,504),
Name = "Granite_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,504),
Name = "Granite_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,504),
Name = "Granite_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,504),
Name = "Granite_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,504),
Name = "Granite_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,504),
Name = "Granite_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,504),
Name = "Granite_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,504),
Name = "Granite_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,504),
Name = "Granite_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,522),
Name = "Marble_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,522),
Name = "Marble_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,522),
Name = "Marble_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,522),
Name = "Marble_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,522),
Name = "Marble_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,522),
Name = "Marble_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,522),
Name = "Marble_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,522),
Name = "Marble_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,522),
Name = "Marble_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,522),
Name = "Marble_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,522),
Name = "Marble_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,522),
Name = "Marble_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,522),
Name = "Marble_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,522),
Name = "Marble_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,522),
Name = "Marble_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,522),
Name = "Marble_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,522),
Name = "Marble_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,522),
Name = "Marble_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,522),
Name = "Marble_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,522),
Name = "Marble_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,522),
Name = "Marble_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,522),
Name = "Marble_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,522),
Name = "Marble_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,522),
Name = "Marble_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,522),
Name = "Marble_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,522),
Name = "Marble_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,522),
Name = "Marble_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,540),
Name = "Crystal_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,540),
Name = "Crystal_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,540),
Name = "Crystal_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,540),
Name = "Crystal_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,540),
Name = "Crystal_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,540),
Name = "Crystal_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,540),
Name = "Crystal_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,540),
Name = "Crystal_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,540),
Name = "Crystal_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,540),
Name = "Crystal_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,540),
Name = "Crystal_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,540),
Name = "Crystal_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,540),
Name = "Crystal_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,540),
Name = "Crystal_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,540),
Name = "Crystal_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,540),
Name = "Crystal_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,540),
Name = "Crystal_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,540),
Name = "Crystal_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,540),
Name = "Crystal_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,540),
Name = "Crystal_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,540),
Name = "Crystal_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,540),
Name = "Crystal_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,540),
Name = "Crystal_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,540),
Name = "Crystal_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,540),
Name = "Crystal_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,540),
Name = "Crystal_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,540),
Name = "Crystal_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,558),
Name = "Golden_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,558),
Name = "Golden_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,558),
Name = "Golden_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,558),
Name = "Golden_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,558),
Name = "Golden_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,558),
Name = "Golden_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,558),
Name = "Golden_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,558),
Name = "Golden_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,558),
Name = "Golden_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,558),
Name = "Golden_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,558),
Name = "Golden_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,558),
Name = "Golden_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,558),
Name = "Golden_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,558),
Name = "Golden_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,558),
Name = "Golden_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,558),
Name = "Golden_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,558),
Name = "Golden_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,558),
Name = "Golden_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,558),
Name = "Golden_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,558),
Name = "Golden_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,558),
Name = "Golden_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,558),
Name = "Golden_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,558),
Name = "Golden_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,558),
Name = "Golden_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,558),
Name = "Golden_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,558),
Name = "Golden_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,558),
Name = "Golden_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,576),
Name = "Dynasty_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,576),
Name = "Dynasty_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,576),
Name = "Dynasty_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,576),
Name = "Dynasty_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,576),
Name = "Dynasty_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,576),
Name = "Dynasty_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,576),
Name = "Dynasty_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,576),
Name = "Dynasty_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,576),
Name = "Dynasty_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,576),
Name = "Dynasty_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,576),
Name = "Dynasty_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,576),
Name = "Dynasty_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,576),
Name = "Dynasty_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,576),
Name = "Dynasty_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,576),
Name = "Dynasty_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,576),
Name = "Dynasty_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,576),
Name = "Dynasty_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,576),
Name = "Dynasty_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,576),
Name = "Dynasty_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,576),
Name = "Dynasty_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,576),
Name = "Dynasty_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,576),
Name = "Dynasty_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,576),
Name = "Dynasty_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,576),
Name = "Dynasty_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,576),
Name = "Dynasty_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,576),
Name = "Dynasty_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,576),
Name = "Dynasty_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,594),
Name = "Lihzahrd_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,594),
Name = "Lihzahrd_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,594),
Name = "Lihzahrd_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,594),
Name = "Lihzahrd_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,594),
Name = "Lihzahrd_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,594),
Name = "Lihzahrd_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,594),
Name = "Lihzahrd_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,594),
Name = "Lihzahrd_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,594),
Name = "Lihzahrd_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,612),
Name = "Flesh_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,612),
Name = "Flesh_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,612),
Name = "Flesh_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,612),
Name = "Flesh_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,612),
Name = "Flesh_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,612),
Name = "Flesh_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,612),
Name = "Flesh_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,612),
Name = "Flesh_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,612),
Name = "Flesh_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,612),
Name = "Flesh_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,612),
Name = "Flesh_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,612),
Name = "Flesh_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,612),
Name = "Flesh_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,612),
Name = "Flesh_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,612),
Name = "Flesh_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,612),
Name = "Flesh_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,612),
Name = "Flesh_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,612),
Name = "Flesh_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,612),
Name = "Flesh_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,612),
Name = "Flesh_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,612),
Name = "Flesh_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,612),
Name = "Flesh_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,612),
Name = "Flesh_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,612),
Name = "Flesh_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,612),
Name = "Flesh_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,612),
Name = "Flesh_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,612),
Name = "Flesh_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,630),
Name = "Frozen_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,630),
Name = "Frozen_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,630),
Name = "Frozen_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,630),
Name = "Frozen_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,630),
Name = "Frozen_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,630),
Name = "Frozen_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,630),
Name = "Frozen_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,630),
Name = "Frozen_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,630),
Name = "Frozen_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,630),
Name = "Frozen_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,630),
Name = "Frozen_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,630),
Name = "Frozen_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,630),
Name = "Frozen_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,630),
Name = "Frozen_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,630),
Name = "Frozen_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,630),
Name = "Frozen_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,630),
Name = "Frozen_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,630),
Name = "Frozen_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,630),
Name = "Frozen_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,630),
Name = "Frozen_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,630),
Name = "Frozen_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,630),
Name = "Frozen_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,630),
Name = "Frozen_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,630),
Name = "Frozen_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,630),
Name = "Frozen_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,630),
Name = "Frozen_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,630),
Name = "Frozen_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,648),
Name = "Spider_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,648),
Name = "Spider_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,648),
Name = "Spider_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,648),
Name = "Spider_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,648),
Name = "Spider_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,648),
Name = "Spider_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,648),
Name = "Spider_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,648),
Name = "Spider_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,648),
Name = "Spider_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,648),
Name = "Spider_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,648),
Name = "Spider_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,648),
Name = "Spider_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,648),
Name = "Spider_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,648),
Name = "Spider_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,648),
Name = "Spider_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,648),
Name = "Spider_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,648),
Name = "Spider_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,648),
Name = "Spider_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,648),
Name = "Spider_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,648),
Name = "Spider_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,648),
Name = "Spider_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,648),
Name = "Spider_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,648),
Name = "Spider_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,648),
Name = "Spider_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,648),
Name = "Spider_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,648),
Name = "Spider_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,648),
Name = "Spider_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,666),
Name = "Lesion_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,666),
Name = "Lesion_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,666),
Name = "Lesion_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,666),
Name = "Lesion_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,666),
Name = "Lesion_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,666),
Name = "Lesion_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,666),
Name = "Lesion_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,666),
Name = "Lesion_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,666),
Name = "Lesion_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,666),
Name = "Lesion_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,666),
Name = "Lesion_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,666),
Name = "Lesion_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,666),
Name = "Lesion_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,666),
Name = "Lesion_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,666),
Name = "Lesion_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,666),
Name = "Lesion_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,666),
Name = "Lesion_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,666),
Name = "Lesion_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,666),
Name = "Lesion_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,666),
Name = "Lesion_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,666),
Name = "Lesion_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,666),
Name = "Lesion_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,666),
Name = "Lesion_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,666),
Name = "Lesion_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,666),
Name = "Lesion_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,666),
Name = "Lesion_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,666),
Name = "Lesion_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,684),
Name = "Solar_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,684),
Name = "Solar_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,684),
Name = "Solar_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,684),
Name = "Solar_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,684),
Name = "Solar_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,684),
Name = "Solar_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,684),
Name = "Solar_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,684),
Name = "Solar_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,684),
Name = "Solar_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,684),
Name = "Solar_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,684),
Name = "Solar_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,684),
Name = "Solar_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,684),
Name = "Solar_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,684),
Name = "Solar_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,684),
Name = "Solar_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,684),
Name = "Solar_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,684),
Name = "Solar_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,684),
Name = "Solar_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,684),
Name = "Solar_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,684),
Name = "Solar_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,684),
Name = "Solar_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,684),
Name = "Solar_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,684),
Name = "Solar_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,684),
Name = "Solar_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,684),
Name = "Solar_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,684),
Name = "Solar_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,684),
Name = "Solar_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,702),
Name = "Vortex_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,702),
Name = "Vortex_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,702),
Name = "Vortex_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,702),
Name = "Vortex_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,702),
Name = "Vortex_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,702),
Name = "Vortex_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,702),
Name = "Vortex_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,702),
Name = "Vortex_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,702),
Name = "Vortex_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,702),
Name = "Vortex_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,702),
Name = "Vortex_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,702),
Name = "Vortex_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,702),
Name = "Vortex_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,702),
Name = "Vortex_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,702),
Name = "Vortex_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,702),
Name = "Vortex_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,702),
Name = "Vortex_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,702),
Name = "Vortex_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,702),
Name = "Vortex_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,702),
Name = "Vortex_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,702),
Name = "Vortex_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,702),
Name = "Vortex_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,702),
Name = "Vortex_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,702),
Name = "Vortex_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,702),
Name = "Vortex_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,702),
Name = "Vortex_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,702),
Name = "Vortex_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,720),
Name = "Nebula_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,720),
Name = "Nebula_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,720),
Name = "Nebula_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,720),
Name = "Nebula_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,720),
Name = "Nebula_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,720),
Name = "Nebula_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,720),
Name = "Nebula_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,720),
Name = "Nebula_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,720),
Name = "Nebula_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,720),
Name = "Nebula_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,720),
Name = "Nebula_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,720),
Name = "Nebula_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,720),
Name = "Nebula_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,720),
Name = "Nebula_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,720),
Name = "Nebula_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,720),
Name = "Nebula_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,720),
Name = "Nebula_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,720),
Name = "Nebula_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,720),
Name = "Nebula_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,720),
Name = "Nebula_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,720),
Name = "Nebula_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,720),
Name = "Nebula_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,720),
Name = "Nebula_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,720),
Name = "Nebula_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,720),
Name = "Nebula_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,720),
Name = "Nebula_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,720),
Name = "Nebula_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,738),
Name = "Stardust_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,738),
Name = "Stardust_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,738),
Name = "Stardust_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,738),
Name = "Stardust_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,738),
Name = "Stardust_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,738),
Name = "Stardust_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,738),
Name = "Stardust_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,738),
Name = "Stardust_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,738),
Name = "Stardust_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,738),
Name = "Stardust_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,738),
Name = "Stardust_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,738),
Name = "Stardust_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,738),
Name = "Stardust_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,738),
Name = "Stardust_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,738),
Name = "Stardust_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,738),
Name = "Stardust_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,738),
Name = "Stardust_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,738),
Name = "Stardust_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,738),
Name = "Stardust_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,738),
Name = "Stardust_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,738),
Name = "Stardust_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,738),
Name = "Stardust_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,738),
Name = "Stardust_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,738),
Name = "Stardust_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,738),
Name = "Stardust_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,738),
Name = "Stardust_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,738),
Name = "Stardust_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,756),
Name = "Sandstone_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,756),
Name = "Sandstone_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,756),
Name = "Sandstone_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,756),
Name = "Sandstone_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,756),
Name = "Sandstone_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,756),
Name = "Sandstone_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,756),
Name = "Sandstone_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,756),
Name = "Sandstone_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,756),
Name = "Sandstone_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,756),
Name = "Sandstone_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,756),
Name = "Sandstone_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,756),
Name = "Sandstone_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,756),
Name = "Sandstone_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,756),
Name = "Sandstone_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,756),
Name = "Sandstone_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,756),
Name = "Sandstone_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,756),
Name = "Sandstone_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,756),
Name = "Sandstone_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,756),
Name = "Sandstone_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,756),
Name = "Sandstone_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,756),
Name = "Sandstone_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,756),
Name = "Sandstone_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,756),
Name = "Sandstone_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,756),
Name = "Sandstone_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,756),
Name = "Sandstone_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,756),
Name = "Sandstone_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,756),
Name = "Sandstone_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,774),
Name = "Stone_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,774),
Name = "Stone_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,774),
Name = "Stone_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,774),
Name = "Stone_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,774),
Name = "Stone_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,774),
Name = "Stone_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,774),
Name = "Stone_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,774),
Name = "Stone_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,774),
Name = "Stone_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,774),
Name = "Stone_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,774),
Name = "Stone_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,774),
Name = "Stone_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,774),
Name = "Stone_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,774),
Name = "Stone_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,774),
Name = "Stone_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,774),
Name = "Stone_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,774),
Name = "Stone_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,774),
Name = "Stone_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,774),
Name = "Stone_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,774),
Name = "Stone_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,774),
Name = "Stone_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,774),
Name = "Stone_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,774),
Name = "Stone_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,774),
Name = "Stone_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,774),
Name = "Stone_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,774),
Name = "Stone_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,774),
Name = "Stone_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,792),
Name = "Bamboo_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,792),
Name = "Bamboo_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,792),
Name = "Bamboo_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,792),
Name = "Bamboo_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,792),
Name = "Bamboo_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,792),
Name = "Bamboo_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,792),
Name = "Bamboo_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,792),
Name = "Bamboo_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,792),
Name = "Bamboo_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,792),
Name = "Bamboo_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,792),
Name = "Bamboo_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,792),
Name = "Bamboo_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,792),
Name = "Bamboo_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,792),
Name = "Bamboo_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,792),
Name = "Bamboo_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,792),
Name = "Bamboo_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,792),
Name = "Bamboo_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,792),
Name = "Bamboo_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,792),
Name = "Bamboo_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,792),
Name = "Bamboo_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,792),
Name = "Bamboo_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,792),
Name = "Bamboo_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,792),
Name = "Bamboo_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,792),
Name = "Bamboo_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,792),
Name = "Bamboo_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,792),
Name = "Bamboo_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,792),
Name = "Bamboo_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,810),
Name = "Reef_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,810),
Name = "Reef_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,810),
Name = "Reef_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,810),
Name = "Reef_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,810),
Name = "Reef_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,810),
Name = "Reef_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,810),
Name = "Reef_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,810),
Name = "Reef_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,810),
Name = "Reef_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,810),
Name = "Reef_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,810),
Name = "Reef_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,810),
Name = "Reef_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,810),
Name = "Reef_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,810),
Name = "Reef_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,810),
Name = "Reef_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,810),
Name = "Reef_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,810),
Name = "Reef_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,810),
Name = "Reef_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,810),
Name = "Reef_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,810),
Name = "Reef_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,810),
Name = "Reef_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,810),
Name = "Reef_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,810),
Name = "Reef_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,810),
Name = "Reef_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,810),
Name = "Reef_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,810),
Name = "Reef_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,810),
Name = "Reef_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,828),
Name = "Balloon_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,828),
Name = "Balloon_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,828),
Name = "Balloon_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,828),
Name = "Balloon_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,828),
Name = "Balloon_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,828),
Name = "Balloon_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,828),
Name = "Balloon_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,828),
Name = "Balloon_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,828),
Name = "Balloon_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,828),
Name = "Balloon_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,828),
Name = "Balloon_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,828),
Name = "Balloon_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,828),
Name = "Balloon_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,828),
Name = "Balloon_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,828),
Name = "Balloon_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,828),
Name = "Balloon_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,828),
Name = "Balloon_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,828),
Name = "Balloon_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,828),
Name = "Balloon_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,828),
Name = "Balloon_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,828),
Name = "Balloon_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,828),
Name = "Balloon_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,828),
Name = "Balloon_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,828),
Name = "Balloon_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,828),
Name = "Balloon_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,828),
Name = "Balloon_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,828),
Name = "Balloon_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,846),
Name = "Ash_Wood_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,846),
Name = "Ash_Wood_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,846),
Name = "Ash_Wood_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,846),
Name = "Ash_Wood_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,846),
Name = "Ash_Wood_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,846),
Name = "Ash_Wood_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,846),
Name = "Ash_Wood_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,846),
Name = "Ash_Wood_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,846),
Name = "Ash_Wood_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(0,864),
Name = "Echo_Platform",
Variety = "Flat",
},

new SpriteData()
{
TileType = 19,
Origin = new(18,864),
Name = "Echo_Platform",
Variety = "Endcap_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(36,864),
Name = "Echo_Platform",
Variety = "Endcap_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(54,864),
Name = "Echo_Platform",
Variety = "Attach_Left",
},

new SpriteData()
{
TileType = 19,
Origin = new(72,864),
Name = "Echo_Platform",
Variety = "Attach_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(90,864),
Name = "Echo_Platform",
Variety = "Single",
},

new SpriteData()
{
TileType = 19,
Origin = new(108,864),
Name = "Echo_Platform",
Variety = "Attach_Left_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(126,864),
Name = "Echo_Platform",
Variety = "Attach_Right_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(144,864),
Name = "Echo_Platform",
Variety = "Stair_Up-Right_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(162,864),
Name = "Echo_Platform",
Variety = "Stair_Up-Right_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(180,864),
Name = "Echo_Platform",
Variety = "Stair_Up-Left_Riser",
},

new SpriteData()
{
TileType = 19,
Origin = new(198,864),
Name = "Echo_Platform",
Variety = "Stair_Up-Left_Stringer",
},

new SpriteData()
{
TileType = 19,
Origin = new(216,864),
Name = "Echo_Platform",
Variety = "Stair_Top_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(234,864),
Name = "Echo_Platform",
Variety = "Stair_Top_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(252,864),
Name = "Echo_Platform",
Variety = "Stair_Top_Landing_L-R",
},

new SpriteData()
{
TileType = 19,
Origin = new(270,864),
Name = "Echo_Platform",
Variety = "Stair_Top_Landing_R_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(288,864),
Name = "Echo_Platform",
Variety = "Stair_Top_Landing_L_Endcap",
},

new SpriteData()
{
TileType = 19,
Origin = new(306,864),
Name = "Echo_Platform",
Variety = "Stair_Bottom_Landing_R",
},

new SpriteData()
{
TileType = 19,
Origin = new(324,864),
Name = "Echo_Platform",
Variety = "Stair_Bottom_Landing_L",
},

new SpriteData()
{
TileType = 19,
Origin = new(342,864),
Name = "Echo_Platform",
Variety = "Stair_Inset_Up-Right_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(360,864),
Name = "Echo_Platform",
Variety = "Stair_Inset_Up-Left_1",
},

new SpriteData()
{
TileType = 19,
Origin = new(378,864),
Name = "Echo_Platform",
Variety = "Stair_Inset_Up-Right_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(396,864),
Name = "Echo_Platform",
Variety = "Stair_Inset_Up-Left_2",
},

new SpriteData()
{
TileType = 19,
Origin = new(414,864),
Name = "Echo_Platform",
Variety = "Stair_Inset_Up-Right_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(432,864),
Name = "Echo_Platform",
Variety = "Stair_Inset_Up-Left_3",
},

new SpriteData()
{
TileType = 19,
Origin = new(450,864),
Name = "Echo_Platform",
Variety = "Stair_Inverted_Right",
},

new SpriteData()
{
TileType = 19,
Origin = new(468,864),
Name = "Echo_Platform",
Variety = "Stair_Inverted_Left",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Name = "Forest_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(18,0),
Name = "Forest_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(36,0),
Name = "Forest_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(54,0),
Name = "Boreal_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(72,0),
Name = "Boreal_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(90,0),
Name = "Boreal_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(108,0),
Name = "Jungle_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(126,0),
Name = "Jungle_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(144,0),
Name = "Jungle_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(162,0),
Name = "Corrupt_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(180,0),
Name = "Corrupt_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(198,0),
Name = "Corrupt_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(216,0),
Name = "Crimson_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(234,0),
Name = "Crimson_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(252,0),
Name = "Crimson_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(270,0),
Name = "Hallowed_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(288,0),
Name = "Hallowed_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(306,0),
Name = "Hallowed_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(324,0),
Name = "Palm_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(342,0),
Name = "Palm_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(360,0),
Name = "Palm_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(378,0),
Name = "Hallowed_Palm_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(396,0),
Name = "Hallowed_Palm_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(414,0),
Name = "Hallowed_Palm_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(432,0),
Name = "Crimson_Palm_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(450,0),
Name = "Crimson_Palm_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(468,0),
Name = "Crimson_Palm_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(486,0),
Name = "Corrupt_Palm_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(504,0),
Name = "Corrupt_Palm_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(522,0),
Name = "Corrupt_Palm_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(540,0),
Name = "Ash_Tree_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(558,0),
Name = "Ash_Tree_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 20,
Size = new(1,2),
Origin = new(576,0),
Name = "Ash_Tree_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Name = "Wooden_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(36,0),
Name = "Gold_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(72,0),
Name = "Gold_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(108,0),
Name = "Shadow_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(144,0),
Name = "Shadow_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(180,0),
Name = "Barrel",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(216,0),
Name = "Trash_Can",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(252,0),
Name = "Ebonwood_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(288,0),
Name = "Rich_Mahogany_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(324,0),
Name = "Pearlwood_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(360,0),
Name = "Ivy_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(396,0),
Name = "Ice_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(432,0),
Name = "Living_Wood_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(468,0),
Name = "Skyware_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(504,0),
Name = "Shadewood_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(540,0),
Name = "Web_Coverd_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(576,0),
Name = "Lihzahrd_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(612,0),
Name = "Water_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(648,0),
Name = "Jungle_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(684,0),
Name = "Corruption_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(720,0),
Name = "Crimson_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(756,0),
Name = "Hallowed_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(792,0),
Name = "Frozen_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(828,0),
Name = "Jungle_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(864,0),
Name = "Corruption_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(900,0),
Name = "Crimson_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(936,0),
Name = "Hallowed_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(972,0),
Name = "Frozen_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1008,0),
Name = "Dynasty_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1044,0),
Name = "Honey_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1080,0),
Name = "Steampunk_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1116,0),
Name = "Palm_Wood_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1152,0),
Name = "Mushroom_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1188,0),
Name = "Boreal_Wood_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1224,0),
Name = "Slime_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1260,0),
Name = "Green_Dungeon_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1296,0),
Name = "Green_Dungeon_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1332,0),
Name = "Pink_Dungeon_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1368,0),
Name = "Pink_Dungeon_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1404,0),
Name = "Blue_Dungeon_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1440,0),
Name = "Blue_Dungeon_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1476,0),
Name = "Bone_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1512,0),
Name = "Cactus_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1548,0),
Name = "Flesh_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1584,0),
Name = "Obsidian_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1620,0),
Name = "Pumpkin_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1656,0),
Name = "Spooky_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1692,0),
Name = "Glass_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1728,0),
Name = "Martian_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1764,0),
Name = "Meteorite_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1800,0),
Name = "Granite_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1836,0),
Name = "Marble_Chest",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1872,0),
Name = "Crystal_Chest_(unused_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 21,
Size = new(2,2),
Origin = new(1908,0),
Name = "Golden_Chest_(unused_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 24,
Name = "Grass_Single_Blade",
},

new SpriteData()
{
TileType = 24,
Origin = new(18,0),
Name = "Grass_Double_Blade",
},

new SpriteData()
{
TileType = 24,
Origin = new(36,0),
Name = "Grass_Small_Y",
},

new SpriteData()
{
TileType = 24,
Origin = new(54,0),
Name = "Grass_Three_Small",
},

new SpriteData()
{
TileType = 24,
Origin = new(72,0),
Name = "Grass_Single_Blade",
},

new SpriteData()
{
TileType = 24,
Origin = new(90,0),
Name = "Grass_Three_Large",
},

new SpriteData()
{
TileType = 24,
Origin = new(144,0),
Name = "Vile_Mushroom",
},

new SpriteData()
{
TileType = 24,
Origin = new(108,0),
Name = "Flower_A",
},

new SpriteData()
{
TileType = 24,
Origin = new(126,0),
Name = "Flower_B",
},

new SpriteData()
{
TileType = 24,
Origin = new(162,0),
Name = "Flower_C",
},

new SpriteData()
{
TileType = 24,
Origin = new(180,0),
Name = "Flower_D",
},

new SpriteData()
{
TileType = 24,
Origin = new(198,0),
Name = "Flower_E",
},

new SpriteData()
{
TileType = 24,
Origin = new(216,0),
Name = "Flower_F",
},

new SpriteData()
{
TileType = 24,
Origin = new(234,0),
Name = "Flower_G",
},

new SpriteData()
{
TileType = 24,
Origin = new(252,0),
Name = "Flower_H",
},

new SpriteData()
{
TileType = 24,
Origin = new(270,0),
Name = "Flower_I",
},

new SpriteData()
{
TileType = 24,
Origin = new(288,0),
Name = "Flower_J",
},

new SpriteData()
{
TileType = 24,
Origin = new(306,0),
Name = "Flower_K",
},

new SpriteData()
{
TileType = 24,
Origin = new(324,0),
Name = "Flower_L",
},

new SpriteData()
{
TileType = 24,
Origin = new(342,0),
Name = "Flower_M",
},

new SpriteData()
{
TileType = 24,
Origin = new(360,0),
Name = "Flower_N",
},

new SpriteData()
{
TileType = 24,
Origin = new(378,0),
Name = "Flower_O",
},

new SpriteData()
{
TileType = 24,
Origin = new(396,0),
Name = "Flower_P",
},

new SpriteData()
{
TileType = 26,
Size = new(3,2),
Name = "Demon_Altar",
},

new SpriteData()
{
TileType = 26,
Size = new(3,2),
Origin = new(54,0),
Name = "Crimson_Altar",
},

new SpriteData()
{
TileType = 27,
Size = new(2,4),
Name = "A",
},

new SpriteData()
{
TileType = 27,
Size = new(2,4),
Origin = new(36,0),
Name = "B",
},

new SpriteData()
{
TileType = 27,
Size = new(2,4),
Origin = new(72,0),
Name = "C",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Name = "Forest_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,0),
Name = "Forest_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,0),
Name = "Forest_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,36),
Name = "Forest_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,36),
Name = "Forest_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,36),
Name = "Forest_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,72),
Name = "Forest_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,72),
Name = "Forest_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,72),
Name = "Forest_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,108),
Name = "Forest_Pot",
Variety = "D1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,108),
Name = "Forest_Pot",
Variety = "D2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,108),
Name = "Forest_Pot",
Variety = "D3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,144),
Name = "Tundra_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,144),
Name = "Tundra_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,144),
Name = "Tundra_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,180),
Name = "Tundra_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,180),
Name = "Tundra_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,180),
Name = "Tundra_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,216),
Name = "Tundra_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,216),
Name = "Tundra_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,216),
Name = "Tundra_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,252),
Name = "Jungle_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,252),
Name = "Jungle_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,252),
Name = "Jungle_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,288),
Name = "Jungle_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,288),
Name = "Jungle_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,288),
Name = "Jungle_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,324),
Name = "Jungle_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,324),
Name = "Jungle_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,324),
Name = "Jungle_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,360),
Name = "Dungeon_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,360),
Name = "Dungeon_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,360),
Name = "Dungeon_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,396),
Name = "Dungeon_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,396),
Name = "Dungeon_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,396),
Name = "Dungeon_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,432),
Name = "Dungeon_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,432),
Name = "Dungeon_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,432),
Name = "Dungeon_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,468),
Name = "Underworld_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,468),
Name = "Underworld_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,468),
Name = "Underworld_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,504),
Name = "Underworld_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,504),
Name = "Underworld_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,504),
Name = "Underworld_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,540),
Name = "Underworld_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,540),
Name = "Underworld_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,540),
Name = "Underworld_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,576),
Name = "Corruption_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,576),
Name = "Corruption_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,576),
Name = "Corruption_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,612),
Name = "Corruption_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,612),
Name = "Corruption_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,612),
Name = "Corruption_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,648),
Name = "Corruption_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,648),
Name = "Corruption_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,648),
Name = "Corruption_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,648),
Name = "Corruption_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,684),
Name = "Spider_Cave_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,684),
Name = "Spider_Cave_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,684),
Name = "Spider_Cave_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,720),
Name = "Spider_Cave_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,720),
Name = "Spider_Cave_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,720),
Name = "Spider_Cave_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,756),
Name = "Spider_Cave_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,756),
Name = "Spider_Cave_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,756),
Name = "Spider_Cave_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,792),
Name = "Crimson_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,792),
Name = "Crimson_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,792),
Name = "Crimson_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,828),
Name = "Crimson_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,828),
Name = "Crimson_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,828),
Name = "Crimson_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,864),
Name = "Crimson_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,864),
Name = "Crimson_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,864),
Name = "Crimson_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,900),
Name = "Pyramid_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,900),
Name = "Pyramid_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,900),
Name = "Pyramid_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,936),
Name = "Pyramid_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,936),
Name = "Pyramid_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,936),
Name = "Pyramid_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,972),
Name = "Pyramid_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,972),
Name = "Pyramid_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,972),
Name = "Pyramid_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,1008),
Name = "Lihzahrd_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,1008),
Name = "Lihzahrd_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,1008),
Name = "Lihzahrd_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,1044),
Name = "Lihzahrd_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,1044),
Name = "Lihzahrd_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,1044),
Name = "Lihzahrd_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,1080),
Name = "Lihzahrd_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,1080),
Name = "Lihzahrd_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,1080),
Name = "Lihzahrd_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,1116),
Name = "Marble_Cave_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,1116),
Name = "Marble_Cave_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,1116),
Name = "Marble_Cave_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,1152),
Name = "Marble_Cave_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,1152),
Name = "Marble_Cave_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,1152),
Name = "Marble_Cave_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,1188),
Name = "Marble_Cave_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,1188),
Name = "Marble_Cave_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,1188),
Name = "Marble_Cave_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,1224),
Name = "Underground_Desert_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,1224),
Name = "Underground_Desert_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,1224),
Name = "Underground_Desert_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,1260),
Name = "Underground_Desert_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,1260),
Name = "Underground_Desert_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,1260),
Name = "Underground_Desert_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(0,1296),
Name = "Underground_Desert_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(36,1296),
Name = "Underground_Desert_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 28,
Size = new(2,2),
Origin = new(72,1296),
Name = "Underground_Desert_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 29,
Size = new(2,1),
},

new SpriteData()
{
TileType = 31,
Size = new(2,2),
Name = "Shadow_Orb",
},

new SpriteData()
{
TileType = 31,
Size = new(2,2),
Origin = new(36,0),
Name = "Demon_Heart",
},

new SpriteData()
{
TileType = 33,
Name = "Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,0),
Name = "Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,22),
Name = "Blue_Dungeon_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,22),
Name = "Blue_Dungeon_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,44),
Name = "Green_Dungeon_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,44),
Name = "Green_Dungeon_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,66),
Name = "Pink_Dungeon_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,66),
Name = "Pink_Dungeon_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,88),
Name = "Cactus_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,88),
Name = "Cactus_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,110),
Name = "Ebonwood_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,110),
Name = "Ebonwood_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,132),
Name = "Flesh_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,132),
Name = "Flesh_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,154),
Name = "Glass_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,154),
Name = "Glass_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,176),
Name = "Frozen_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,176),
Name = "Frozen_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,198),
Name = "Rich_Mahogany_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,198),
Name = "Rich_Mahogany_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,220),
Name = "Pearlwood_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,220),
Name = "Pearlwood_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,242),
Name = "Lihzahrd_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,242),
Name = "Lihzahrd_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,264),
Name = "Skyware_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,264),
Name = "Skyware_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,286),
Name = "Pumpkin_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,286),
Name = "Pumpkin_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,308),
Name = "Living_Wood_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,308),
Name = "Living_Wood_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,330),
Name = "Shadewood_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,330),
Name = "Shadewood_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,352),
Name = "Golden_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,352),
Name = "Golden_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,374),
Name = "Dynasty_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,374),
Name = "Dynasty_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,396),
Name = "Palm_Wood_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,396),
Name = "Palm_Wood_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,418),
Name = "Mushroom_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,418),
Name = "Mushroom_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,440),
Name = "Boreal_Wood_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,440),
Name = "Boreal_Wood_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,462),
Name = "Slime_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,462),
Name = "Slime_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,484),
Name = "Honey_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,484),
Name = "Honey_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,506),
Name = "Steampunk_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,506),
Name = "Steampunk_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,528),
Name = "Spooky_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,528),
Name = "Spooky_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,550),
Name = "Obsidian_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,550),
Name = "Obsidian_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,572),
Name = "Martian_Hover_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,572),
Name = "Martian_Hover_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,594),
Name = "Meteorite_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,594),
Name = "Meteorite_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,616),
Name = "Granite_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,616),
Name = "Granite_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,638),
Name = "Marble_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,638),
Name = "Marble_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,660),
Name = "Crystal_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,660),
Name = "Crystal_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,682),
Name = "Spider_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,682),
Name = "Spider_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,704),
Name = "Lesion_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,704),
Name = "Lesion_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,726),
Name = "Solar_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,726),
Name = "Solar_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,748),
Name = "Vortex_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,748),
Name = "Vortex_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,770),
Name = "Nebula_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,770),
Name = "Nebula_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,792),
Name = "Stardust_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,792),
Name = "Stardust_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,814),
Name = "Sandstone_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,814),
Name = "Sandstone_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,836),
Name = "Bamboo_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,836),
Name = "Bamboo_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,858),
Name = "Reef_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,858),
Name = "Reef_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,880),
Name = "Balloon_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,880),
Name = "Balloon_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 33,
Origin = new(0,902),
Name = "Ash_Wood_Candle",
Variety = "On",
},

new SpriteData()
{
TileType = 33,
Origin = new(18,902),
Name = "Ash_Wood_Candle",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Name = "Copper_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,0),
Name = "Copper_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,54),
Name = "Silver_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,54),
Name = "Silver_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,108),
Name = "Gold_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,108),
Name = "Gold_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,162),
Name = "Tin_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,162),
Name = "Tin_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,216),
Name = "Tungsten_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,216),
Name = "Tungsten_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,270),
Name = "Platinum_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,270),
Name = "Platinum_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,324),
Name = "Jackelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,324),
Name = "Jackelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,378),
Name = "Cactus_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,378),
Name = "Cactus_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,432),
Name = "Ebonwood_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,432),
Name = "Ebonwood_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,486),
Name = "Flesh_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,486),
Name = "Flesh_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,540),
Name = "Honey_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,540),
Name = "Honey_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,594),
Name = "Frozen_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,594),
Name = "Frozen_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,648),
Name = "Rich_Mahogany_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,648),
Name = "Rich_Mahogany_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,702),
Name = "Pearlwood_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,702),
Name = "Pearlwood_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,756),
Name = "Lihzahrd_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,756),
Name = "Lihzahrd_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,810),
Name = "Skyware_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,810),
Name = "Skyware_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,864),
Name = "Spooky_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,864),
Name = "Spooky_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,918),
Name = "Glass_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,918),
Name = "Glass_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,972),
Name = "Living_Wood_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,972),
Name = "Living_Wood_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1026),
Name = "Shadewood_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1026),
Name = "Shadewood_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1080),
Name = "Golden_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1080),
Name = "Golden_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1134),
Name = "Bone_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1134),
Name = "Bone_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1188),
Name = "Large_Dynasty_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1188),
Name = "Large_Dynasty_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1242),
Name = "Palm_Wood_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1242),
Name = "Palm_Wood_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1296),
Name = "Mushroom_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1296),
Name = "Mushroom_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1350),
Name = "Boreal_Wood_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1350),
Name = "Boreal_Wood_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1404),
Name = "Slime_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1404),
Name = "Slime_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1458),
Name = "Blue_Dungeon_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1458),
Name = "Blue_Dungeon_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1512),
Name = "Green_Dungeon_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1512),
Name = "Green_Dungeon_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1566),
Name = "Pink_Dungeon_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1566),
Name = "Pink_Dungeon_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1620),
Name = "Steampunk_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1620),
Name = "Steampunk_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1674),
Name = "Pumpkin_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1674),
Name = "Pumpkin_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1728),
Name = "Obsidian_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1728),
Name = "Obsidian_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1782),
Name = "Martian_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1782),
Name = "Martian_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1836),
Name = "Meteorite_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1836),
Name = "Meteorite_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1890),
Name = "Granite_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1890),
Name = "Granite_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(0,1944),
Name = "Marble_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(54,1944),
Name = "Marble_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,0),
Name = "Crystal_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,0),
Name = "Crystal_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,54),
Name = "Spider_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,54),
Name = "Spider_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,108),
Name = "Lesion_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,108),
Name = "Lesion_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,162),
Name = "Solar_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,162),
Name = "Solar_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,216),
Name = "Vortex_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,216),
Name = "Vortex_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,270),
Name = "Nebula_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,270),
Name = "Nebula_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,324),
Name = "Stardust_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,324),
Name = "Stardust_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,378),
Name = "Sandstone_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,378),
Name = "Sandstone_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,432),
Name = "Bamboo_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,432),
Name = "Bamboo_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,486),
Name = "Reef_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,486),
Name = "Reef_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,540),
Name = "Balloon_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,540),
Name = "Balloon_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(108,594),
Name = "Ash_Wood_Chandelier",
Variety = "On",
},

new SpriteData()
{
TileType = 34,
Size = new(3,3),
Origin = new(162,594),
Name = "Ash_Wood_Chandelier",
Variety = "Off",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Name = "A_On",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(36,0),
Name = "A_Off",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(0,36),
Name = "B_On",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(36,36),
Name = "B_Off",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(0,72),
Name = "C_On",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(36,72),
Name = "C_Off",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(0,108),
Name = "D_On",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(36,108),
Name = "D_Off",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(0,144),
Name = "E_On",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(36,144),
Name = "E_Off",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(0,180),
Name = "F_On",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(36,180),
Name = "F_Off",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(0,216),
Name = "G_On",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(36,216),
Name = "G_Off",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(0,252),
Name = "H_On",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(36,252),
Name = "H_Off",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(0,288),
Name = "I_On",
},

new SpriteData()
{
TileType = 35,
Size = new(2,2),
Origin = new(36,288),
Name = "I_Off",
},

new SpriteData()
{
TileType = 36,
Name = "Red_with_White_Ribbon",
},

new SpriteData()
{
TileType = 36,
Origin = new(18,0),
Name = "Red_with_Blue_Ribbon",
},

new SpriteData()
{
TileType = 36,
Origin = new(36,0),
Name = "Green_with_White_Ribbon",
},

new SpriteData()
{
TileType = 36,
Origin = new(54,0),
Name = "Green_with_Red_Ribbon",
},

new SpriteData()
{
TileType = 36,
Origin = new(72,0),
Name = "Yellow_with_White_Ribbon",
},

new SpriteData()
{
TileType = 36,
Origin = new(90,0),
Name = "Yellow_with_Green_Ribbon",
},

new SpriteData()
{
TileType = 36,
Origin = new(108,0),
Name = "Blue_with_White_Ribbon",
},

new SpriteData()
{
TileType = 36,
Origin = new(126,0),
Name = "Blue_with_Yellow_Ribbon",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Name = "Chain_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,0),
Name = "Chain_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,36),
Name = "Brass_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,36),
Name = "Brass_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,72),
Name = "Caged_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,72),
Name = "Caged_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,108),
Name = "Carriage_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,108),
Name = "Carriage_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,144),
Name = "Alchemy_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,144),
Name = "Alchemy_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,180),
Name = "Diablost_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,180),
Name = "Diablost_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,216),
Name = "Oil_Rag_Sconse",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,216),
Name = "Oil_Rag_Sconse",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,252),
Name = "Star_in_a_Bottle",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,252),
Name = "Star_in_a_Bottle",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,288),
Name = "Hanging_Jack_'O_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,288),
Name = "Hanging_Jack_'O_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,324),
Name = "Heart_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,324),
Name = "Heart_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,360),
Name = "Cactus_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,360),
Name = "Cactus_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,396),
Name = "Ebonwood_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,396),
Name = "Ebonwood_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,432),
Name = "Flesh_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,432),
Name = "Flesh_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,468),
Name = "Honey_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,468),
Name = "Honey_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,504),
Name = "Steampunk_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,504),
Name = "Steampunk_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,540),
Name = "Glass_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,540),
Name = "Glass_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,576),
Name = "Rich_Mahogany_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,576),
Name = "Rich_Mahogany_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,612),
Name = "Pearlwood_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,612),
Name = "Pearlwood_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,648),
Name = "Frozen_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,648),
Name = "Frozen_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,684),
Name = "Lihzahrd_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,684),
Name = "Lihzahrd_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,720),
Name = "Skyware_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,720),
Name = "Skyware_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,756),
Name = "Spooky_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,756),
Name = "Spooky_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,792),
Name = "Living_Wood_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,792),
Name = "Living_Wood_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,828),
Name = "Shadewood_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,828),
Name = "Shadewood_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,864),
Name = "Golden_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,864),
Name = "Golden_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,900),
Name = "Bone_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,900),
Name = "Bone_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,936),
Name = "Dynasty_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,936),
Name = "Dynasty_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,972),
Name = "Palm_Wood_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,972),
Name = "Palm_Wood_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1008),
Name = "Mushroom_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1008),
Name = "Mushroom_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1044),
Name = "Boreal_Wood_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1044),
Name = "Boreal_Wood_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1080),
Name = "Slime_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1080),
Name = "Slime_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1116),
Name = "Pumpkin_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1116),
Name = "Pumpkin_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1152),
Name = "Obsidian_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1152),
Name = "Obsidian_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1188),
Name = "Martian_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1188),
Name = "Martian_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1224),
Name = "Meteorite_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1224),
Name = "Meteorite_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1260),
Name = "Granite_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1260),
Name = "Granite_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1296),
Name = "Marble_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1296),
Name = "Marble_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1332),
Name = "Crystal_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1332),
Name = "Crystal_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1368),
Name = "Spider_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1368),
Name = "Spider_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1404),
Name = "Lesion_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1404),
Name = "Lesion_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1440),
Name = "Solar_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1440),
Name = "Solar_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1476),
Name = "Vortex_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1476),
Name = "Vortex_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1512),
Name = "Nebula_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1512),
Name = "Nebula_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1548),
Name = "Stardust_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1548),
Name = "Stardust_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1584),
Name = "Sandstone_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1584),
Name = "Sandstone_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1620),
Name = "Bamboo_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1620),
Name = "Bamboo_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1656),
Name = "Reef_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1656),
Name = "Reef_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1692),
Name = "Balloon_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1692),
Name = "Balloon_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(0,1728),
Name = "Ash_Wood_Lantern",
Variety = "On",
},

new SpriteData()
{
TileType = 42,
Size = new(1,2),
Origin = new(18,1728),
Name = "Ash_Wood_Lantern",
Variety = "Off",
},

new SpriteData()
{
TileType = 49,
Name = "On",
},

new SpriteData()
{
TileType = 49,
Origin = new(18,0),
Name = "Off",
},

new SpriteData()
{
TileType = 50,
Name = "Blue_Red_Brown",
},

new SpriteData()
{
TileType = 50,
Origin = new(18,0),
Name = "Yellow_Pink",
},

new SpriteData()
{
TileType = 50,
Origin = new(36,0),
Name = "Teal_Brown",
},

new SpriteData()
{
TileType = 50,
Origin = new(54,0),
Name = "Purple_Blue",
},

new SpriteData()
{
TileType = 50,
Origin = new(72,0),
Name = "Green_Orange",
},

new SpriteData()
{
TileType = 50,
Origin = new(90,0),
Name = "Brown_Water_Bolt_Gray",
},

new SpriteData()
{
TileType = 55,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Name = "Ground",
},

new SpriteData()
{
TileType = 55,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(36,0),
Name = "Hanging",
},

new SpriteData()
{
TileType = 55,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,0),
Name = "Left_Side",
},

new SpriteData()
{
TileType = 55,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,0),
Name = "Right_Side",
},

new SpriteData()
{
TileType = 55,
Size = new(2,2),
Origin = new(144,0),
Name = "Wall",
},

new SpriteData()
{
TileType = 61,
Name = "Grass_Single_Blade",
},

new SpriteData()
{
TileType = 61,
Origin = new(18,0),
Name = "Grass_Double_Blade",
},

new SpriteData()
{
TileType = 61,
Origin = new(36,0),
Name = "Grass_Small_Y",
},

new SpriteData()
{
TileType = 61,
Origin = new(54,0),
Name = "Grass_Three_Small",
},

new SpriteData()
{
TileType = 61,
Origin = new(72,0),
Name = "Grass_Single_Blade",
},

new SpriteData()
{
TileType = 61,
Origin = new(90,0),
Name = "Grass_Three_Large",
},

new SpriteData()
{
TileType = 61,
Origin = new(108,0),
Name = "Flower_A",
},

new SpriteData()
{
TileType = 61,
Origin = new(126,0),
Name = "Flower_B",
},

new SpriteData()
{
TileType = 61,
Origin = new(144,0),
Name = "Jungle_Spore",
},

new SpriteData()
{
TileType = 61,
Origin = new(162,0),
Name = "Nature's_Gift",
},

new SpriteData()
{
TileType = 61,
Origin = new(180,0),
Name = "Flower_C",
},

new SpriteData()
{
TileType = 61,
Origin = new(198,0),
Name = "Flower_D",
},

new SpriteData()
{
TileType = 61,
Origin = new(216,0),
Name = "Flower_E",
},

new SpriteData()
{
TileType = 61,
Origin = new(234,0),
Name = "Flower_F",
},

new SpriteData()
{
TileType = 61,
Origin = new(252,0),
Name = "Flower_G",
},

new SpriteData()
{
TileType = 61,
Origin = new(270,0),
Name = "Flower_H",
},

new SpriteData()
{
TileType = 61,
Origin = new(288,0),
Name = "Flower_I",
},

new SpriteData()
{
TileType = 61,
Origin = new(306,0),
Name = "Flower_J",
},

new SpriteData()
{
TileType = 61,
Origin = new(324,0),
Name = "Flower_K",
},

new SpriteData()
{
TileType = 61,
Origin = new(342,0),
Name = "Flower_L",
},

new SpriteData()
{
TileType = 61,
Origin = new(360,0),
Name = "Flower_M",
},

new SpriteData()
{
TileType = 61,
Origin = new(378,0),
Name = "Flower_N",
},

new SpriteData()
{
TileType = 61,
Origin = new(396,0),
Name = "Flower_O",
},

new SpriteData()
{
TileType = 71,
Name = "Double_Small",
},

new SpriteData()
{
TileType = 71,
Origin = new(18,0),
Name = "Small",
},

new SpriteData()
{
TileType = 71,
Origin = new(36,0),
Name = "Malformed",
},

new SpriteData()
{
TileType = 71,
Origin = new(54,0),
Name = "Thin",
},

new SpriteData()
{
TileType = 71,
Origin = new(72,0),
Name = "Standard",
},

new SpriteData()
{
TileType = 72,
Name = "Trunk_A",
},

new SpriteData()
{
TileType = 72,
Origin = new(18,0),
Name = "Top_Plain",
},

new SpriteData()
{
TileType = 72,
Origin = new(0,18),
Name = "Trunk_B",
},

new SpriteData()
{
TileType = 72,
Origin = new(18,18),
Name = "Top_Left_Indent",
},

new SpriteData()
{
TileType = 72,
Origin = new(0,36),
Name = "Trunk_C",
},

new SpriteData()
{
TileType = 72,
Origin = new(18,36),
Name = "Top_Right_Indent",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Name = "Grass_A",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(18,0),
Name = "Grass_B",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(36,0),
Name = "Grass_C",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(54,0),
Name = "Grass_D",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(72,0),
Name = "Grass_E",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(90,0),
Name = "Grass_F",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(108,0),
Name = "Magenta_Flower_A",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(540,0),
Name = "Magenta_Flower_B",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(558,0),
Name = "Magenta_Flower_C",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(576,0),
Name = "Magenta_Flower_D",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(126,0),
Name = "Pink_Flower_A",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(306,0),
Name = "Pink_Flower_B",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(594,0),
Name = "Pink_Flower_C",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(612,0),
Name = "Pink_Flower_D",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(630,0),
Name = "Pink_Flower_E",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(162,0),
Name = "Blue_Flower_A",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(288,0),
Name = "Blue_Flower_B",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(360,0),
Name = "Blue_Flower_C",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(180,0),
Name = "Yellow_Flower_A",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(198,0),
Name = "Yellow_Flower_B",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(234,0),
Name = "Yellow_Flower_C",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(324,0),
Name = "Yellow_Flower_D",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(432,0),
Name = "Yellow_Flower_E",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(450,0),
Name = "Yellow_Flower_F",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(468,0),
Name = "Yellow_Flower_G",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(216,0),
Name = "Violet_Flower_A",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(756,0),
Name = "Violet_Flower_B",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(774,0),
Name = "Violet_Flower_C",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(792,0),
Name = "Violet_Flower_D",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(252,0),
Name = "White_Flower_A",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(270,0),
Name = "White_Flower_B",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(486,0),
Name = "White_Flower_C",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(504,0),
Name = "White_Flower_D",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(522,0),
Name = "White_Flower_E",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(648,0),
Name = "White_Flower_F",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(666,0),
Name = "White_Flower_G",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(684,0),
Name = "White_Flower_H",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(342,0),
Name = "Red_Flower_A",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(378,0),
Name = "Red_Flower_B",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(396,0),
Name = "Red_Flower_C",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(414,0),
Name = "Red_Flower_D",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(702,0),
Name = "Red_Flower_E",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(720,0),
Name = "Red_Flower_F",
},

new SpriteData()
{
TileType = 73,
Anchor = FrameAnchor.Bottom,
Origin = new(738,0),
Name = "Red_Flower_G",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Name = "A",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(18,0),
Name = "B",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(36,0),
Name = "C",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(54,0),
Name = "D",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(72,0),
Name = "E",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(90,0),
Name = "F",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(108,0),
Name = "Flower_A",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(126,0),
Name = "Flower_B",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(162,0),
Name = "Flower_C",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(180,0),
Name = "Flower_D",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(198,0),
Name = "Flower_E",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(216,0),
Name = "Flower_F",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(234,0),
Name = "Flower_G",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(252,0),
Name = "Flower_H",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(270,0),
Name = "Flower_I",
},

new SpriteData()
{
TileType = 74,
Anchor = FrameAnchor.Bottom,
Origin = new(288,0),
Name = "Flower_J",
},

new SpriteData()
{
TileType = 77,
Size = new(3,2),
},

new SpriteData()
{
TileType = 78,
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Name = "Wooden_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,0),
Name = "Wooden_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,36),
Name = "Ebonwood_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,36),
Name = "Ebonwood_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,72),
Name = "Rich_Mahogany_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,72),
Name = "Rich_Mahogany_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,108),
Name = "Pearlwood_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,108),
Name = "Pearlwood_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,144),
Name = "Shadewood_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,144),
Name = "Shadewood_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,180),
Name = "Blue_Dungeon_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,180),
Name = "Blue_Dungeon_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,216),
Name = "Green_Dungeon_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,216),
Name = "Green_Dungeon_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,252),
Name = "Pink_Dungeon_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,252),
Name = "Pink_Dungeon_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,288),
Name = "Obsidian_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,288),
Name = "Obsidian_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,324),
Name = "Glass_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,324),
Name = "Glass_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,360),
Name = "Golden_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,360),
Name = "Golden_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,396),
Name = "Honey_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,396),
Name = "Honey_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,432),
Name = "Steampunk_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,432),
Name = "Steampunk_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,468),
Name = "Cactus_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,468),
Name = "Cactus_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,504),
Name = "Flesh_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,504),
Name = "Flesh_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,540),
Name = "Frozen_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,540),
Name = "Frozen_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,576),
Name = "Lihzahrd_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,576),
Name = "Lihzahrd_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,612),
Name = "Skyware_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,612),
Name = "Skyware_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,648),
Name = "Spooky_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,648),
Name = "Spooky_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,684),
Name = "Living_Wood_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,684),
Name = "Living_Wood_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,720),
Name = "Bone_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,720),
Name = "Bone_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,756),
Name = "Dynasty_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,756),
Name = "Dynasty_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,792),
Name = "Palm_Wood_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,792),
Name = "Palm_Wood_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,828),
Name = "Mushroom_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,828),
Name = "Mushroom_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,864),
Name = "Boreal_Wood_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,864),
Name = "Boreal_Wood_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,900),
Name = "Slime_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,900),
Name = "Slime_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,936),
Name = "Pumpkin_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,936),
Name = "Pumpkin_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,972),
Name = "Martian_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,972),
Name = "Martian_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1008),
Name = "Meteorite_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1008),
Name = "Meteorite_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1044),
Name = "Granite_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1044),
Name = "Granite_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1080),
Name = "Marble_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1080),
Name = "Marble_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1116),
Name = "Crystal_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1116),
Name = "Crystal_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1152),
Name = "Spider_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1152),
Name = "Spider_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1188),
Name = "Lesion_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1188),
Name = "Lesion_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1224),
Name = "Solar_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1224),
Name = "Solar_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1260),
Name = "Vortex_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1260),
Name = "Vortex_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1296),
Name = "Nebula_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1296),
Name = "Nebula_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1332),
Name = "Stardust_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1332),
Name = "Stardust_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1368),
Name = "Sandstone_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1368),
Name = "Sandstone_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1404),
Name = "Bamboo_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1404),
Name = "Bamboo_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1440),
Name = "Reef_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1440),
Name = "Reef_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1476),
Name = "Balloon_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1476),
Name = "Balloon_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(0,1512),
Name = "Ash_Wood_Bed",
Variety = "Left",
},

new SpriteData()
{
TileType = 79,
Size = new(4,2),
Origin = new(72,1512),
Name = "Ash_Wood_Bed",
Variety = "Right",
},

new SpriteData()
{
TileType = 81,
Anchor = FrameAnchor.Bottom,
Name = "Red",
},

new SpriteData()
{
TileType = 81,
Anchor = FrameAnchor.Bottom,
Origin = new(26,0),
Name = "Pink",
},

new SpriteData()
{
TileType = 81,
Anchor = FrameAnchor.Bottom,
Origin = new(52,0),
Name = "Yellow",
},

new SpriteData()
{
TileType = 81,
Anchor = FrameAnchor.Bottom,
Origin = new(78,0),
Name = "Green",
},

new SpriteData()
{
TileType = 81,
Anchor = FrameAnchor.Bottom,
Origin = new(104,0),
Name = "Blue",
},

new SpriteData()
{
TileType = 81,
Anchor = FrameAnchor.Bottom,
Origin = new(130,0),
Name = "Sponge",
},

new SpriteData()
{
TileType = 82,
Name = "Daybloom",
},

new SpriteData()
{
TileType = 82,
Origin = new(18,0),
Name = "Moonglow",
},

new SpriteData()
{
TileType = 82,
Origin = new(36,0),
Name = "Blinkroot",
},

new SpriteData()
{
TileType = 82,
Origin = new(54,0),
Name = "Deathweed",
},

new SpriteData()
{
TileType = 82,
Origin = new(72,0),
Name = "Waterleaf",
},

new SpriteData()
{
TileType = 82,
Origin = new(90,0),
Name = "Fireblossom",
},

new SpriteData()
{
TileType = 82,
Origin = new(108,0),
Name = "Shiverthorn",
},

new SpriteData()
{
TileType = 83,
Name = "Daybloom",
},

new SpriteData()
{
TileType = 83,
Origin = new(18,0),
Name = "Moonglow",
},

new SpriteData()
{
TileType = 83,
Origin = new(36,0),
Name = "Blinkroot",
},

new SpriteData()
{
TileType = 83,
Origin = new(54,0),
Name = "Deathweed",
},

new SpriteData()
{
TileType = 83,
Origin = new(72,0),
Name = "Waterleaf",
},

new SpriteData()
{
TileType = 83,
Origin = new(90,0),
Name = "Fireblossom",
},

new SpriteData()
{
TileType = 83,
Origin = new(108,0),
Name = "Shiverthorn",
},

new SpriteData()
{
TileType = 84,
Name = "Daybloom",
},

new SpriteData()
{
TileType = 84,
Origin = new(18,0),
Name = "Moonglow",
},

new SpriteData()
{
TileType = 84,
Origin = new(36,0),
Name = "Blinkroot",
},

new SpriteData()
{
TileType = 84,
Origin = new(54,0),
Name = "Deathweed",
},

new SpriteData()
{
TileType = 84,
Origin = new(72,0),
Name = "Waterleaf",
},

new SpriteData()
{
TileType = 84,
Origin = new(90,0),
Name = "Fireblossom",
},

new SpriteData()
{
TileType = 84,
Origin = new(108,0),
Name = "Shiverthorn",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Name = "Tombstone",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(36,0),
Name = "Grave_Marker",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(72,0),
Name = "Cross_Grave_Marker",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(108,0),
Name = "Headstone",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(144,0),
Name = "Gravestone",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(180,0),
Name = "Obelisk",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(216,0),
Name = "Golden_Cross_Grave_Marker",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(252,0),
Name = "Golden_Tombstone",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(288,0),
Name = "Golden_Grave_Marker",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(324,0),
Name = "Golden_Gravestone",
},

new SpriteData()
{
TileType = 85,
Size = new(2,2),
Origin = new(360,0),
Name = "Golden_Headstone",
},

new SpriteData()
{
TileType = 86,
Size = new(3,2),
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Name = "Wooden_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(54,0),
Name = "Ebonwood_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(108,0),
Name = "Rich_Mahogany_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(162,0),
Name = "Pearlwood_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(216,0),
Name = "Shadewood_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(270,0),
Name = "Living_Wood_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(324,0),
Name = "Flesh_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(378,0),
Name = "Frozen_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(432,0),
Name = "Glass_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(486,0),
Name = "Honey_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(540,0),
Name = "Steampunk_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(594,0),
Name = "Blue_Dungeon_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(648,0),
Name = "Green_Dungeon_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(702,0),
Name = "Pink_Dungeon_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(756,0),
Name = "Golden_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(810,0),
Name = "Obsidian_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(864,0),
Name = "Bone_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(918,0),
Name = "Cactus_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(972,0),
Name = "Spooky_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1026,0),
Name = "Skyware_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1080,0),
Name = "Lihzahrd_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1134,0),
Name = "Palm_Wood_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1188,0),
Name = "Mushroom_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1242,0),
Name = "Boreal_Wood_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1296,0),
Name = "Slime_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1350,0),
Name = "Pumpkin_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1404,0),
Name = "Martian_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1458,0),
Name = "Meteorite_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1512,0),
Name = "Granite_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1566,0),
Name = "Marble_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1620,0),
Name = "Crystal_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1674,0),
Name = "Dynasty_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1728,0),
Name = "Spider_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1782,0),
Name = "Lesion_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1836,0),
Name = "Solar_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1890,0),
Name = "Vortex_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1944,0),
Name = "Nebula_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(1998,0),
Name = "Stardust_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(2052,0),
Name = "Sandstone_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(2106,0),
Name = "Bamboo_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(2160,0),
Name = "Reef_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(2214,0),
Name = "Balloon_Piano",
},

new SpriteData()
{
TileType = 87,
Size = new(3,2),
Origin = new(2268,0),
Name = "Ash_Wood_Piano",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Name = "Wooden_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(54,0),
Name = "Ebonwood_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(108,0),
Name = "Rich_Mahogany_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(162,0),
Name = "Pearlwood_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(216,0),
Name = "Shadewood_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(270,0),
Name = "Blue_Dungeon_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(324,0),
Name = "Green_Dungeon_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(378,0),
Name = "Pink_Dungeon_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(432,0),
Name = "Golden_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(486,0),
Name = "Obsidian_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(540,0),
Name = "Bone_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(594,0),
Name = "Cactus_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(648,0),
Name = "Spooky_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(702,0),
Name = "Skyware_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(756,0),
Name = "Honey_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(810,0),
Name = "Lihzahrd_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(864,0),
Name = "Palm_Wood_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(918,0),
Name = "Mushroom_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(972,0),
Name = "Boreal_Wood_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1026,0),
Name = "Slime_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1080,0),
Name = "Pumpkin_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1134,0),
Name = "Steampunk_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1188,0),
Name = "Glass_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1242,0),
Name = "Flesh_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1296,0),
Name = "Martian_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1350,0),
Name = "Meteorite_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1404,0),
Name = "Granite_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1458,0),
Name = "Marble_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1512,0),
Name = "Crystal_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1566,0),
Name = "Dynasty_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1620,0),
Name = "Frozen_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1674,0),
Name = "Living_Wood_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1728,0),
Name = "Spider_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1782,0),
Name = "Lesion_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1836,0),
Name = "Solar_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1890,0),
Name = "Vortex_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1944,0),
Name = "Nebula_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(1998,0),
Name = "Stardust_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(2052,0),
Name = "Sandstone_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(2106,0),
Name = "Bamboo_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(2160,0),
Name = "Reef_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(2214,0),
Name = "Balloon_Dresser",
},

new SpriteData()
{
TileType = 88,
Size = new(3,2),
Origin = new(2268,0),
Name = "Ash_Wood_Dresser",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Name = "Wooden_Bench",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(54,0),
Name = "Wooden_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(108,0),
Name = "Ebonwood_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(162,0),
Name = "Rich_Mahogany_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(216,0),
Name = "Pearlwood_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(270,0),
Name = "Shadewood_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(324,0),
Name = "Blue_Dungeon_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(378,0),
Name = "Green_Dungeon_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(432,0),
Name = "Pink_Dungeon_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(486,0),
Name = "Golden_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(540,0),
Name = "Obsidian_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(594,0),
Name = "Bone_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(648,0),
Name = "Cactus_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(702,0),
Name = "Spooky_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(756,0),
Name = "Skyware_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(810,0),
Name = "Honey_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(864,0),
Name = "Steampunk_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(918,0),
Name = "Mushroom_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(972,0),
Name = "Glass_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1026,0),
Name = "Pumpkin_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1080,0),
Name = "Lihzahrd_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1134,0),
Name = "Palm_Wood_Bench",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1188,0),
Name = "Palm_Wood_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1242,0),
Name = "Mushroom_Bench",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1296,0),
Name = "Boreal_Wood_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1350,0),
Name = "Slime_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1404,0),
Name = "Flesh_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1458,0),
Name = "Frozen_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1512,0),
Name = "Living_Wood_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1566,0),
Name = "Martian_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1620,0),
Name = "Meteorite_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1674,0),
Name = "Granite_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1728,0),
Name = "Marble_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1782,0),
Name = "Crystal_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1836,0),
Name = "Dynasty_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1890,0),
Name = "Spider_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1944,0),
Name = "Lesion_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(1998,0),
Name = "Solar_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(2052,0),
Name = "Vortex_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(2106,0),
Name = "Nebula_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(2160,0),
Name = "Stardust_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(2214,0),
Name = "Sandstone_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(2268,0),
Name = "Bamboo_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(2322,0),
Name = "Chippy's_Couch",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(2376,0),
Name = "Reef_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(2430,0),
Name = "Balloon_Sofa",
},

new SpriteData()
{
TileType = 89,
Size = new(3,2),
Origin = new(2484,0),
Name = "Ash_Wood_Sofa",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Name = "Metal_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,0),
Name = "Metal_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,36),
Name = "Cactus_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,36),
Name = "Cactus_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,72),
Name = "Ebonwood_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,72),
Name = "Ebonwood_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,108),
Name = "Flesh_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,108),
Name = "Flesh_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,144),
Name = "Glass_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,144),
Name = "Glass_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,180),
Name = "Frozen_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,180),
Name = "Frozen_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,216),
Name = "Rich_Mahogany_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,216),
Name = "Rich_Mahogany_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,252),
Name = "Pearlwood_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,252),
Name = "Pearlwood_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,288),
Name = "Lihzahrd_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,288),
Name = "Lihzahrd_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,324),
Name = "Skyware_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,324),
Name = "Skyware_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,360),
Name = "Spooky_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,360),
Name = "Spooky_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,396),
Name = "Honey_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,396),
Name = "Honey_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,432),
Name = "Steampunk_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,432),
Name = "Steampunk_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,468),
Name = "Living_Wood_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,468),
Name = "Living_Wood_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,504),
Name = "Shadewood_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,504),
Name = "Shadewood_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,540),
Name = "Bone_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,540),
Name = "Bone_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,576),
Name = "Dynasty_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,576),
Name = "Dynasty_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,612),
Name = "Palm_Wood_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,612),
Name = "Palm_Wood_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,648),
Name = "Mushroom_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,648),
Name = "Mushroom_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,684),
Name = "Boreal_Wood_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,684),
Name = "Boreal_Wood_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,720),
Name = "Slime_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,720),
Name = "Slime_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,756),
Name = "Blue_Dungeon_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,756),
Name = "Blue_Dungeon_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,792),
Name = "Green_Dungeon_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,792),
Name = "Green_Dungeon_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,828),
Name = "Pink_Dungeon_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,828),
Name = "Pink_Dungeon_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,864),
Name = "Pumpkin_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,864),
Name = "Pumpkin_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,900),
Name = "Obsidian_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,900),
Name = "Obsidian_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,936),
Name = "Golden_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,936),
Name = "Golden_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,972),
Name = "Martian_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,972),
Name = "Martian_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1008),
Name = "Meteorite_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1008),
Name = "Meteorite_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1044),
Name = "Granite_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1044),
Name = "Granite_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1080),
Name = "Marble_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1080),
Name = "Marble_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1116),
Name = "Crystal_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1116),
Name = "Crystal_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1152),
Name = "Spider_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1152),
Name = "Spider_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1188),
Name = "Lesion_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1188),
Name = "Lesion_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1224),
Name = "Solar_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1224),
Name = "Solar_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1260),
Name = "Vortex_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1260),
Name = "Vortex_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1296),
Name = "Nebula_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1296),
Name = "Nebula_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1332),
Name = "Stardust_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1332),
Name = "Stardust_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1368),
Name = "Sandstone_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1368),
Name = "Sandstone_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1404),
Name = "Bamboo_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1404),
Name = "Bamboo_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1440),
Name = "Reef_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1440),
Name = "Reef_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1476),
Name = "Balloon_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1476),
Name = "Balloon_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(72,1512),
Name = "Ash_Wood_Bathtub",
Variety = "Left",
},

new SpriteData()
{
TileType = 90,
Size = new(4,2),
Origin = new(0,1512),
Name = "Ash_Wood_Bathtub",
Variety = "Right",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Name = "Craftable_Banner",
Variety = "Red_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(18,0),
Name = "Craftable_Banner",
Variety = "Green_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(36,0),
Name = "Craftable_Banner",
Variety = "Blue_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(54,0),
Name = "Craftable_Banner",
Variety = "Yellow_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(72,0),
Name = "Pyramid_Banner",
Variety = "Ankh_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(90,0),
Name = "Pyramid_Banner",
Variety = "Snake_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(108,0),
Name = "Pyramid_Banner",
Variety = "Omega_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(126,0),
Name = "Sky_Banner",
Variety = "World_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(144,0),
Name = "Sky_Banner",
Variety = "Sun_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(162,0),
Name = "Sky_Banner",
Variety = "Gravity_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(180,0),
Name = "Faction_Banner",
Variety = "Marching_Bones_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(198,0),
Name = "Faction_Banner",
Variety = "Necromantic_Sign",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(216,0),
Name = "Faction_Banner",
Variety = "Rusted_Company_Standard",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(234,0),
Name = "Faction_Banner",
Variety = "Ragged_Brotherhood_Sigil",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(252,0),
Name = "Faction_Banner",
Variety = "Molten_Legion_Flag",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(270,0),
Name = "Faction_Banner",
Variety = "Diabolic_Sigil",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(288,0),
Name = "Underworld_Banner",
Variety = "Hellbound_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(306,0),
Name = "Underworld_Banner",
Variety = "Hell_Hammer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(324,0),
Name = "Underworld_Banner",
Variety = "Helltower_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(342,0),
Name = "Underworld_Banner",
Variety = "Lost_Hopes_of_Man_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(360,0),
Name = "Underworld_Banner",
Variety = "Obsidian_Watcher_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(378,0),
Name = "Underworld_Banner",
Variety = "Lava_Erupts_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(396,0),
Name = "Monster_Banner",
Variety = "Angler_Fish_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(414,0),
Name = "Monster_Banner",
Variety = "Angry_Nimbus_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(432,0),
Name = "Monster_Banner",
Variety = "Anomura_Fungus_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(450,0),
Name = "Monster_Banner",
Variety = "Antlion_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(468,0),
Name = "Monster_Banner",
Variety = "Arapaima_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(486,0),
Name = "Monster_Banner",
Variety = "Armored_Skeleton_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(504,0),
Name = "Monster_Banner",
Variety = "Cave_Bat_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(522,0),
Name = "Monster_Banner",
Variety = "Bird_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(540,0),
Name = "Monster_Banner",
Variety = "Black_Recluse_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(558,0),
Name = "Monster_Banner",
Variety = "Blood_Feeder_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(576,0),
Name = "Monster_Banner",
Variety = "Blood_Jelly_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(594,0),
Name = "Monster_Banner",
Variety = "Blood_Crawler_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(612,0),
Name = "Monster_Banner",
Variety = "Bone_Serpent_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(630,0),
Name = "Monster_Banner",
Variety = "Bunny_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(648,0),
Name = "Monster_Banner",
Variety = "Chaos_Elemental_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(666,0),
Name = "Monster_Banner",
Variety = "Mimic_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(684,0),
Name = "Monster_Banner",
Variety = "Clown_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(702,0),
Name = "Monster_Banner",
Variety = "Corrupt_Bunny_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(720,0),
Name = "Monster_Banner",
Variety = "Corrupt_Goldfish_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(738,0),
Name = "Monster_Banner",
Variety = "Crab_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(756,0),
Name = "Monster_Banner",
Variety = "Crimera_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(774,0),
Name = "Monster_Banner",
Variety = "Crimson_Axe_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(792,0),
Name = "Monster_Banner",
Variety = "Cursed_Hammer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(810,0),
Name = "Monster_Banner",
Variety = "Demon_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(828,0),
Name = "Monster_Banner",
Variety = "Demon_Eye_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(846,0),
Name = "Monster_Banner",
Variety = "Derpling_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(864,0),
Name = "Monster_Banner",
Variety = "Eater_of_Souls_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(882,0),
Name = "Monster_Banner",
Variety = "Enchanted_Sword_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(900,0),
Name = "Monster_Banner",
Variety = "Zombie_Eskimo_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(918,0),
Name = "Monster_Banner",
Variety = "Face_Monster_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(936,0),
Name = "Monster_Banner",
Variety = "Floaty_Gross_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(954,0),
Name = "Monster_Banner",
Variety = "Flying_Fish_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(972,0),
Name = "Monster_Banner",
Variety = "Flying_Snake_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(990,0),
Name = "Monster_Banner",
Variety = "Frankenstein_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1008,0),
Name = "Monster_Banner",
Variety = "Fungi_Bulb_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1026,0),
Name = "Monster_Banner",
Variety = "Fungo_Fish_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1044,0),
Name = "Monster_Banner",
Variety = "Gastropod_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1062,0),
Name = "Monster_Banner",
Variety = "Goblin_Thief_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1080,0),
Name = "Monster_Banner",
Variety = "Goblin_Sorcerer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1098,0),
Name = "Monster_Banner",
Variety = "Goblin_Peon_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1116,0),
Name = "Monster_Banner",
Variety = "Goblin_Scout_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1134,0),
Name = "Monster_Banner",
Variety = "Goblin_Warrior_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1152,0),
Name = "Monster_Banner",
Variety = "Goldfish_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1170,0),
Name = "Monster_Banner",
Variety = "Harpy_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1188,0),
Name = "Monster_Banner",
Variety = "Hellbat_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1206,0),
Name = "Monster_Banner",
Variety = "Herpling_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1224,0),
Name = "Monster_Banner",
Variety = "Hornet_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1242,0),
Name = "Monster_Banner",
Variety = "Ice_Elemental_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1260,0),
Name = "Monster_Banner",
Variety = "Icy_Merman_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1278,0),
Name = "Monster_Banner",
Variety = "Fire_Imp_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1296,0),
Name = "Monster_Banner",
Variety = "Blue_Jellyfish_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1314,0),
Name = "Monster_Banner",
Variety = "Jungle_Creeper_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1332,0),
Name = "Monster_Banner",
Variety = "Lihzahrd_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1350,0),
Name = "Monster_Banner",
Variety = "Man_Eater_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1368,0),
Name = "Monster_Banner",
Variety = "Meteor_Head_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1386,0),
Name = "Monster_Banner",
Variety = "Moth_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1404,0),
Name = "Monster_Banner",
Variety = "Mummy_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1422,0),
Name = "Monster_Banner",
Variety = "Mushi_Ladybug_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1440,0),
Name = "Monster_Banner",
Variety = "Parrot_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1458,0),
Name = "Monster_Banner",
Variety = "Pigron_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1476,0),
Name = "Monster_Banner",
Variety = "Piranha_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1494,0),
Name = "Monster_Banner",
Variety = "Pirate_Deckhand_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1512,0),
Name = "Monster_Banner",
Variety = "Pixie_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1530,0),
Name = "Monster_Banner",
Variety = "Raincoat_Zombie_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1548,0),
Name = "Monster_Banner",
Variety = "Reaper_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1566,0),
Name = "Monster_Banner",
Variety = "Shark_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1584,0),
Name = "Monster_Banner",
Variety = "Skeleton_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1602,0),
Name = "Monster_Banner",
Variety = "Skeleton_Mage_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1620,0),
Name = "Monster_Banner",
Variety = "Blue_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1638,0),
Name = "Monster_Banner",
Variety = "Snow_Flinx_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1656,0),
Name = "Monster_Banner",
Variety = "Wall_Creeper_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1674,0),
Name = "Monster_Banner",
Variety = "Spore_Zombie_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1692,0),
Name = "Monster_Banner",
Variety = "Swamp_Thing_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1710,0),
Name = "Monster_Banner",
Variety = "Giant_Tortoise_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1728,0),
Name = "Monster_Banner",
Variety = "Toxic_Sludge_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1746,0),
Name = "Monster_Banner",
Variety = "Umbrella_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1764,0),
Name = "Monster_Banner",
Variety = "Unicorn_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1782,0),
Name = "Monster_Banner",
Variety = "Vampire_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1800,0),
Name = "Monster_Banner",
Variety = "Vulture_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1818,0),
Name = "Monster_Banner",
Variety = "Nypmh_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1836,0),
Name = "Monster_Banner",
Variety = "Werewolf_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1854,0),
Name = "Monster_Banner",
Variety = "Wolf_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1872,0),
Name = "Monster_Banner",
Variety = "World_Feeder_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1890,0),
Name = "Monster_Banner",
Variety = "Worm_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1908,0),
Name = "Monster_Banner",
Variety = "Wraith_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1926,0),
Name = "Monster_Banner",
Variety = "Wyvern_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1944,0),
Name = "Monster_Banner",
Variety = "Zombie_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1962,0),
Name = "Monster_Banner",
Variety = "Angry_Trapper_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1980,0),
Name = "Monster_Banner",
Variety = "Armored_Viking_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(0,54),
Name = "Monster_Banner",
Variety = "Black_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(18,54),
Name = "Monster_Banner",
Variety = "Blue_Armored_Bones_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(36,54),
Name = "Monster_Banner",
Variety = "Blue_Cultist_Archer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(54,54),
Name = "Monster_Banner",
Variety = "Blue_Cultist_Caster_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(72,54),
Name = "Monster_Banner",
Variety = "Blue_Cultist_Fighter_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(90,54),
Name = "Monster_Banner",
Variety = "Bone_Lee_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(108,54),
Name = "Monster_Banner",
Variety = "Clinger_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(126,54),
Name = "Monster_Banner",
Variety = "Cochineal_Beetle_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(144,54),
Name = "Monster_Banner",
Variety = "Corrupt_Penguin_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(162,54),
Name = "Monster_Banner",
Variety = "Corrupt_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(180,54),
Name = "Monster_Banner",
Variety = "Corruptor_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(198,54),
Name = "Monster_Banner",
Variety = "Crimslime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(216,54),
Name = "Monster_Banner",
Variety = "Cursed_Skull_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(234,54),
Name = "Monster_Banner",
Variety = "Cyan_Beetle_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(252,54),
Name = "Monster_Banner",
Variety = "Devourer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(270,54),
Name = "Monster_Banner",
Variety = "Diabolist_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(288,54),
Name = "Monster_Banner",
Variety = "Doctor_Bones_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(306,54),
Name = "Monster_Banner",
Variety = "Dungeon_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(324,54),
Name = "Monster_Banner",
Variety = "Dungeon_Spirit_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(342,54),
Name = "Monster_Banner",
Variety = "Elf_Archer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(360,54),
Name = "Monster_Banner",
Variety = "Elf_Copter_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(378,54),
Name = "Monster_Banner",
Variety = "Eyezor_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(396,54),
Name = "Monster_Banner",
Variety = "Flocko_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(414,54),
Name = "Monster_Banner",
Variety = "Ghost_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(432,54),
Name = "Monster_Banner",
Variety = "Giant_Bat_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(450,54),
Name = "Monster_Banner",
Variety = "Giant_Cursed_Skull_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(468,54),
Name = "Monster_Banner",
Variety = "Giant_Flying_Fox_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(486,54),
Name = "Monster_Banner",
Variety = "Gingerbread_Man_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(504,54),
Name = "Monster_Banner",
Variety = "Goblin_Archer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(522,54),
Name = "Monster_Banner",
Variety = "Green_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(540,54),
Name = "Monster_Banner",
Variety = "Headless_Horseman_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(558,54),
Name = "Monster_Banner",
Variety = "Hell_Armored_Bones_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(576,54),
Name = "Monster_Banner",
Variety = "Hellhound_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(594,54),
Name = "Monster_Banner",
Variety = "Hoppin'_Jack_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(612,54),
Name = "Monster_Banner",
Variety = "Ice_Bat_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(630,54),
Name = "Monster_Banner",
Variety = "Ice_Golem_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(648,54),
Name = "Monster_Banner",
Variety = "Ice_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(666,54),
Name = "Monster_Banner",
Variety = "Ichor_Sticker_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(684,54),
Name = "Monster_Banner",
Variety = "Illuminant_Bat_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(702,54),
Name = "Monster_Banner",
Variety = "Illuminant_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(720,54),
Name = "Monster_Banner",
Variety = "Jungle_Bat_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(738,54),
Name = "Monster_Banner",
Variety = "Jungle_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(756,54),
Name = "Monster_Banner",
Variety = "Krampus_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(774,54),
Name = "Monster_Banner",
Variety = "Lac_Beetle_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(792,54),
Name = "Monster_Banner",
Variety = "Lava_Bat_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(810,54),
Name = "Monster_Banner",
Variety = "Lava_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(828,54),
Name = "Monster_Banner",
Variety = "Martian_Brainscrambler_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(846,54),
Name = "Monster_Banner",
Variety = "Martian_Drone_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(864,54),
Name = "Monster_Banner",
Variety = "Martian_Engineer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(882,54),
Name = "Monster_Banner",
Variety = "Martian_Gigazapper_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(900,54),
Name = "Monster_Banner",
Variety = "Martian_Gray_Grunt_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(918,54),
Name = "Monster_Banner",
Variety = "Martian_Officer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(936,54),
Name = "Monster_Banner",
Variety = "Martian_Ray_Gunner_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(954,54),
Name = "Monster_Banner",
Variety = "Martian_Scutlix_Gunner_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(972,54),
Name = "Monster_Banner",
Variety = "Martian_Tesla_Turret_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(990,54),
Name = "Monster_Banner",
Variety = "Mister_Stabby_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1008,54),
Name = "Monster_Banner",
Variety = "Mother_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1026,54),
Name = "Monster_Banner",
Variety = "Necromancer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1044,54),
Name = "Monster_Banner",
Variety = "Nutcracker_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1062,54),
Name = "Monster_Banner",
Variety = "Paladin_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1080,54),
Name = "Monster_Banner",
Variety = "Penguin_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1098,54),
Name = "Monster_Banner",
Variety = "Pinky_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1116,54),
Name = "Monster_Banner",
Variety = "Poltergeist_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1134,54),
Name = "Monster_Banner",
Variety = "Possessed_Armor_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1152,54),
Name = "Monster_Banner",
Variety = "Present_Mimic_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1170,54),
Name = "Monster_Banner",
Variety = "Purple_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1188,54),
Name = "Monster_Banner",
Variety = "Ragged_Caster_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1206,54),
Name = "Monster_Banner",
Variety = "Rainbow_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1224,54),
Name = "Monster_Banner",
Variety = "Raven_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1242,54),
Name = "Monster_Banner",
Variety = "Red_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1260,54),
Name = "Monster_Banner",
Variety = "Rune_Wizard_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1278,54),
Name = "Monster_Banner",
Variety = "Rusty_Armored_Bones_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1296,54),
Name = "Monster_Banner",
Variety = "Scarecrow_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1314,54),
Name = "Monster_Banner",
Variety = "Scutlix_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1332,54),
Name = "Monster_Banner",
Variety = "Skeleton_Archer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1350,54),
Name = "Monster_Banner",
Variety = "Skeleton_Commando_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1368,54),
Name = "Monster_Banner",
Variety = "Skeleton_Sniper_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1386,54),
Name = "Monster_Banner",
Variety = "Slimer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1404,54),
Name = "Monster_Banner",
Variety = "Snatcher_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1422,54),
Name = "Monster_Banner",
Variety = "Snow_Balla_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1440,54),
Name = "Monster_Banner",
Variety = "Snowman_Gangsta_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1458,54),
Name = "Monster_Banner",
Variety = "Spiked_Ice_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1476,54),
Name = "Monster_Banner",
Variety = "Spiked_Jungle_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1494,54),
Name = "Monster_Banner",
Variety = "Splinterling_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1512,54),
Name = "Monster_Banner",
Variety = "Squid_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1530,54),
Name = "Monster_Banner",
Variety = "Tactical_Skeleton_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1548,54),
Name = "Monster_Banner",
Variety = "The_Groom_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1566,54),
Name = "Monster_Banner",
Variety = "Tim_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1584,54),
Name = "Monster_Banner",
Variety = "Undead_Miner_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1602,54),
Name = "Monster_Banner",
Variety = "Undead_Viking_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1620,54),
Name = "Monster_Banner",
Variety = "White_Cultist_Archer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1638,54),
Name = "Monster_Banner",
Variety = "White_Cultist_Caster_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1656,54),
Name = "Monster_Banner",
Variety = "White_Cultist_Fighter_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1674,54),
Name = "Monster_Banner",
Variety = "Yellow_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1692,54),
Name = "Monster_Banner",
Variety = "Yeti_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1710,54),
Name = "Monster_Banner",
Variety = "Zombie_Elf_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1728,54),
Name = "Monster_Banner",
Variety = "Goblin_Summoner_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1746,54),
Name = "Monster_Banner",
Variety = "Salamander_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1764,54),
Name = "Monster_Banner",
Variety = "Giant_Shelly_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1782,54),
Name = "Monster_Banner",
Variety = "Crawdad_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1800,54),
Name = "Monster_Banner",
Variety = "Fritz_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1818,54),
Name = "Monster_Banner",
Variety = "Creature_From_The_Deep_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1836,54),
Name = "Monster_Banner",
Variety = "Dr._Man_Fly_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1854,54),
Name = "Monster_Banner",
Variety = "Mothron_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1872,54),
Name = "Monster_Banner",
Variety = "Severed_Hand_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1890,54),
Name = "Monster_Banner",
Variety = "The_Possessed_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1908,54),
Name = "Monster_Banner",
Variety = "Butcher_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1926,54),
Name = "Monster_Banner",
Variety = "Psycho_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1944,54),
Name = "Monster_Banner",
Variety = "Deadly_Sphere_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1962,54),
Name = "Monster_Banner",
Variety = "Nailhead_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1980,54),
Name = "Monster_Banner",
Variety = "Poisonous_Spore_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(0,108),
Name = "Monster_Banner",
Variety = "Medusa_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(18,108),
Name = "Monster_Banner",
Variety = "Hoplite_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(36,108),
Name = "Monster_Banner",
Variety = "Granite_Elemental_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(54,108),
Name = "Monster_Banner",
Variety = "Grolem_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(72,108),
Name = "Monster_Banner",
Variety = "Blood_Zombie_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(90,108),
Name = "Monster_Banner",
Variety = "Drippler_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(108,108),
Name = "Monster_Banner",
Variety = "Tomb_Crawler_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(126,108),
Name = "Monster_Banner",
Variety = "Dune_Splicer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(144,108),
Name = "Monster_Banner",
Variety = "Antlion_Swarmer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(162,108),
Name = "Monster_Banner",
Variety = "Antlion_Charger_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(180,108),
Name = "Monster_Banner",
Variety = "Ghoul_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(198,108),
Name = "Monster_Banner",
Variety = "Lamia_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(216,108),
Name = "Monster_Banner",
Variety = "Desert_Spirit_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(234,108),
Name = "Monster_Banner",
Variety = "Basilisk_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(252,108),
Name = "Monster_Banner",
Variety = "Ravager_Scorpion_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(270,108),
Name = "Monster_Banner",
Variety = "Stargazer_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(288,108),
Name = "Monster_Banner",
Variety = "Milkyway_Weaver_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(306,108),
Name = "Monster_Banner",
Variety = "Flow_Invader_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(324,108),
Name = "Monster_Banner",
Variety = "Twinkle_Popper_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(342,108),
Name = "Monster_Banner",
Variety = "Small_Star_Cell_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(360,108),
Name = "Monster_Banner",
Variety = "Star_Cell_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(378,108),
Name = "Monster_Banner",
Variety = "Corite_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(396,108),
Name = "Monster_Banner",
Variety = "Sroller_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(414,108),
Name = "Monster_Banner",
Variety = "Crawltipede_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(432,108),
Name = "Monster_Banner",
Variety = "Drakomire_Rider_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(450,108),
Name = "Monster_Banner",
Variety = "Drakomire_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(468,108),
Name = "Monster_Banner",
Variety = "Selenian_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(486,108),
Name = "Monster_Banner",
Variety = "Predictor_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(504,108),
Name = "Monster_Banner",
Variety = "Brain_Suckler_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(522,108),
Name = "Monster_Banner",
Variety = "Nebula_Floater_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(540,108),
Name = "Monster_Banner",
Variety = "Evolution_Beast_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(558,108),
Name = "Monster_Banner",
Variety = "Alien_Larva_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(576,108),
Name = "Monster_Banner",
Variety = "Alien_Queen_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(594,108),
Name = "Monster_Banner",
Variety = "Alien_Hornet_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(612,108),
Name = "Monster_Banner",
Variety = "Vortexian_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(630,108),
Name = "Monster_Banner",
Variety = "Storm_Diver_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(648,108),
Name = "Monster_Banner",
Variety = "Pirate_Captain_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(666,108),
Name = "Monster_Banner",
Variety = "Pirate_Deadeye_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(684,108),
Name = "Monster_Banner",
Variety = "Pirate_Corsair_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(702,108),
Name = "Monster_Banner",
Variety = "Pirate_Crossbower_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(720,108),
Name = "Monster_Banner",
Variety = "Martian_Walker_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(738,108),
Name = "Monster_Banner",
Variety = "Red_Devil_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(756,108),
Name = "Monster_Banner",
Variety = "Pink_Jellyfish_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(774,108),
Name = "Monster_Banner",
Variety = "Green_Jellyfish_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(792,108),
Name = "Monster_Banner",
Variety = "Dark_Mummy_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(810,108),
Name = "Monster_Banner",
Variety = "Light_Mummy_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(828,108),
Name = "Monster_Banner",
Variety = "Angry_Bones_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(846,108),
Name = "Monster_Banner",
Variety = "Ice_Tortoise_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(864,108),
Name = "Monster_Banner",
Variety = "Sand_Slime_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(882,108),
Name = "Monster_Banner",
Variety = "Sea_Snail_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(900,108),
Name = "Monster_Banner",
Variety = "Sand_Elemental_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(918,108),
Name = "Monster_Banner",
Variety = "Sand_Shark_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(936,108),
Name = "Monster_Banner",
Variety = "Bone_Biter_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(954,108),
Name = "Monster_Banner",
Variety = "Flesh_Reaver_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(972,108),
Name = "Monster_Banner",
Variety = "Crystal_Thresher_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(990,108),
Name = "Monster_Banner",
Variety = "Angry_Tumbler_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1008,108),
Name = "Monster_Banner",
Variety = "Etherian_Goblin_Bomber_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1026,108),
Name = "Monster_Banner",
Variety = "Etherian_Goblin_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1044,108),
Name = "Monster_Banner",
Variety = "Old_One's_Skeleton_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1062,108),
Name = "Monster_Banner",
Variety = "Drakin_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1080,108),
Name = "Monster_Banner",
Variety = "Kobold_Glider_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1098,108),
Name = "Monster_Banner",
Variety = "Kobold_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1116,108),
Name = "Monster_Banner",
Variety = "Wither_Beast_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1134,108),
Name = "Monster_Banner",
Variety = "Etherian_Wyvern_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1152,108),
Name = "Monster_Banner",
Variety = "Etherian_Javelin_Thrower_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1170,108),
Name = "Monster_Banner",
Variety = "Etherian_Lightning_Bug_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1188,108),
Name = "Monster_Banner",
Variety = "The_Bride_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1206,108),
Name = "Monster_Banner",
Variety = "Zombie_Merman_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1224,108),
Name = "Monster_Banner",
Variety = "Wandering_Eye_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1242,108),
Name = "Monster_Banner",
Variety = "Blood_Squid_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1260,108),
Name = "Monster_Banner",
Variety = "Blood_Eel_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1278,108),
Name = "Monster_Banner",
Variety = "Hemoglobin_Shark_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1296,108),
Name = "Monster_Banner",
Variety = "Dreadnautilus_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1314,108),
Name = "Monster_Banner",
Variety = "Angry_Dandelion_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1332,108),
Name = "Monster_Banner",
Variety = "Gnome_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1350,108),
Name = "Monster_Banner",
Variety = "Rock_Golem_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1368,108),
Name = "Monster_Banner",
Variety = "Blood_Mummy_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1386,108),
Name = "Monster_Banner",
Variety = "Spore_Skeleton_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1404,108),
Name = "Monster_Banner",
Variety = "Spore_Bat_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1422,108),
Name = "Monster_Banner",
Variety = "Antlion_Larva_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1440,108),
Name = "Monster_Banner",
Variety = "Vicious_Bunny_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1458,108),
Name = "Monster_Banner",
Variety = "Vicious_Goldfish_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1476,108),
Name = "Monster_Banner",
Variety = "Vicious_Penguin_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1494,108),
Name = "Monster_Banner",
Variety = "Corrupt_Mimic_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1512,108),
Name = "Monster_Banner",
Variety = "Crimson_Mimic_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1530,108),
Name = "Monster_Banner",
Variety = "Hallowed_Mimic_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1548,108),
Name = "Monster_Banner",
Variety = "Moss_Hornet_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1566,108),
Name = "Monster_Banner",
Variety = "Wandering_Eye_Banner",
},

new SpriteData()
{
TileType = 91,
Size = new(1,3),
Origin = new(1584,108),
Name = "Monster_Banner",
Variety = "Shimmer_Slime_Banner",
},

new SpriteData()
{
TileType = 92,
Size = new(1,6),
Name = "On",
},

new SpriteData()
{
TileType = 92,
Size = new(1,6),
Origin = new(18,0),
Name = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Name = "Tiki_Torch",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,0),
Name = "Tiki_Torch",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,54),
Name = "Cactus_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,54),
Name = "Cactus_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,108),
Name = "Ebonwood_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,108),
Name = "Ebonwood_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,162),
Name = "Flesh_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,162),
Name = "Flesh_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,216),
Name = "Glass_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,216),
Name = "Glass_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,270),
Name = "Frozen_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,270),
Name = "Frozen_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,324),
Name = "Rich_Mahogany_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,324),
Name = "Rich_Mahogany_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,378),
Name = "Pearlwood_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,378),
Name = "Pearlwood_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,432),
Name = "Lihzahrd_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,432),
Name = "Lihzahrd_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,486),
Name = "Skyware_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,486),
Name = "Skyware_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,540),
Name = "Spooky_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,540),
Name = "Spooky_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,594),
Name = "Honey_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,594),
Name = "Honey_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,648),
Name = "Steampunk_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,648),
Name = "Steampunk_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,702),
Name = "Living_Wood_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,702),
Name = "Living_Wood_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,756),
Name = "Shadewood_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,756),
Name = "Shadewood_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,810),
Name = "Golden_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,810),
Name = "Golden_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,864),
Name = "Bone_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,864),
Name = "Bone_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,918),
Name = "Dynasty_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,918),
Name = "Dynasty_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,972),
Name = "Palm_Wood_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,972),
Name = "Palm_Wood_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1026),
Name = "Mushroom_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1026),
Name = "Mushroom_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1080),
Name = "Boreal_Wood_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1080),
Name = "Boreal_Wood_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1134),
Name = "Slime_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1134),
Name = "Slime_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1188),
Name = "Pumpkin_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1188),
Name = "Pumpkin_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1242),
Name = "Obsidian_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1242),
Name = "Obsidian_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1296),
Name = "Blue_Dungeon_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1296),
Name = "Blue_Dungeon_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1350),
Name = "Green_Dungeon_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1350),
Name = "Green_Dungeon_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1404),
Name = "Pink_Dungeon_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1404),
Name = "Pink_Dungeon_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1458),
Name = "Martian_Lamppost",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1458),
Name = "Martian_Lamppost",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1512),
Name = "Meteorite_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1512),
Name = "Meteorite_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1566),
Name = "Granite_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1566),
Name = "Granite_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1620),
Name = "Marble_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1620),
Name = "Marble_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1674),
Name = "Crystal_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1674),
Name = "Crystal_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1728),
Name = "Spider_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1728),
Name = "Spider_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1782),
Name = "Lesion_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1782),
Name = "Lesion_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1836),
Name = "Solar_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1836),
Name = "Solar_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1890),
Name = "Vortex_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1890),
Name = "Vortex_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1944),
Name = "Nebula_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1944),
Name = "Nebula_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,1998),
Name = "Stardust_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,1998),
Name = "Stardust_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,2052),
Name = "Sandstone_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,2052),
Name = "Sandstone_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,2106),
Name = "Bamboo_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,2106),
Name = "Bamboo_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,2160),
Name = "Reef_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,2160),
Name = "Reef_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,2214),
Name = "Balloon_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,2214),
Name = "Balloon_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(0,2268),
Name = "Ash_Wood_Lamp",
Variety = "On",
},

new SpriteData()
{
TileType = 93,
Size = new(1,3),
Origin = new(18,2268),
Name = "Ash_Wood_Lamp",
Variety = "Off",
},

new SpriteData()
{
TileType = 94,
Size = new(2,2),
},

new SpriteData()
{
TileType = 95,
Size = new(2,2),
Name = "On",
},

new SpriteData()
{
TileType = 95,
Size = new(2,2),
Origin = new(36,0),
Name = "Off",
},

new SpriteData()
{
TileType = 96,
Size = new(2,2),
Name = "Cooking_Pot",
},

new SpriteData()
{
TileType = 96,
Size = new(2,2),
Origin = new(36,0),
Name = "Cauldron",
},

new SpriteData()
{
TileType = 97,
Size = new(2,2),
},

new SpriteData()
{
TileType = 98,
Size = new(2,2),
},

new SpriteData()
{
TileType = 99,
Size = new(2,2),
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Name = "Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,0),
Name = "Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,36),
Name = "Cactus_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,36),
Name = "Cactus_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,72),
Name = "Ebonwood_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,72),
Name = "Ebonwood_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,108),
Name = "Flesh_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,108),
Name = "Flesh_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,144),
Name = "Honey_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,144),
Name = "Honey_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,180),
Name = "Steampunk_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,180),
Name = "Steampunk_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,216),
Name = "Glass_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,216),
Name = "Glass_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,252),
Name = "Rich_Mahogany_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,252),
Name = "Rich_Mahogany_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,288),
Name = "Pearlwood_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,288),
Name = "Pearlwood_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,324),
Name = "Frozen_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,324),
Name = "Frozen_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,360),
Name = "Lihzahrd_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,360),
Name = "Lihzahrd_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,396),
Name = "Skyware_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,396),
Name = "Skyware_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,432),
Name = "Spooky_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,432),
Name = "Spooky_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,468),
Name = "Living_Wood_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,468),
Name = "Living_Wood_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,504),
Name = "Shadewood_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,504),
Name = "Shadewood_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,540),
Name = "Golden_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,540),
Name = "Golden_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,576),
Name = "Bone_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,576),
Name = "Bone_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,612),
Name = "Large_Dynasty_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,612),
Name = "Large_Dynasty_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,648),
Name = "Palm_Wood_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,648),
Name = "Palm_Wood_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,684),
Name = "Mushroom_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,684),
Name = "Mushroom_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,720),
Name = "Boreal_Wood_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,720),
Name = "Boreal_Wood_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,756),
Name = "Slime_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,756),
Name = "Slime_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,792),
Name = "Blue_Dungeon_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,792),
Name = "Blue_Dungeon_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,828),
Name = "Green_Dungeon_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,828),
Name = "Green_Dungeon_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,864),
Name = "Pink_Dungeon_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,864),
Name = "Pink_Dungeon_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,900),
Name = "Obsidian_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,900),
Name = "Obsidian_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,936),
Name = "Pumpkin_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,936),
Name = "Pumpkin_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,972),
Name = "Martian_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,972),
Name = "Martian_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1008),
Name = "Meteorite_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1008),
Name = "Meteorite_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1044),
Name = "Granite_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1044),
Name = "Granite_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1080),
Name = "Marble_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1080),
Name = "Marble_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1116),
Name = "Crystal_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1116),
Name = "Crystal_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1152),
Name = "Spider_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1152),
Name = "Spider_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1188),
Name = "Lesion_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1188),
Name = "Lesion_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1224),
Name = "Solar_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1224),
Name = "Solar_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1260),
Name = "Vortex_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1260),
Name = "Vortex_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1296),
Name = "Nebula_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1296),
Name = "Nebula_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1332),
Name = "Stardust_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1332),
Name = "Stardust_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1368),
Name = "Sandstone_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1368),
Name = "Sandstone_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1404),
Name = "Bamboo_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1404),
Name = "Bamboo_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1440),
Name = "Reef_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1440),
Name = "Reef_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1476),
Name = "Balloon_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1476),
Name = "Balloon_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(0,1512),
Name = "Ash_Wood_Candelabra",
Variety = "On",
},

new SpriteData()
{
TileType = 100,
Size = new(2,2),
Origin = new(36,1512),
Name = "Ash_Wood_Candelabra",
Variety = "Off",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Name = "Wooden_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(54,0),
Name = "Blue_Dungeon_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(108,0),
Name = "Green_Dungeon_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(162,0),
Name = "Pink_Dungeon_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(216,0),
Name = "Obsidian_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(270,0),
Name = "Gothic_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(324,0),
Name = "Cactus_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(378,0),
Name = "Ebonwood_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(432,0),
Name = "Flesh_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(486,0),
Name = "Honey_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(540,0),
Name = "Steampunk_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(594,0),
Name = "Glass_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(648,0),
Name = "Rich_Mahogany_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(702,0),
Name = "Pearlwood_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(756,0),
Name = "Spooky_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(810,0),
Name = "Skyware_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(864,0),
Name = "Lihzahrd_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(918,0),
Name = "Frozen_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(972,0),
Name = "Living_Wood_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1026,0),
Name = "Shadewood_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1080,0),
Name = "Golden_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1134,0),
Name = "Bone_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1188,0),
Name = "Dynasty_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1242,0),
Name = "Palm_Wood_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1296,0),
Name = "Mushroom_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1350,0),
Name = "Boreal_Wood_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1404,0),
Name = "Slime_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1458,0),
Name = "Pumpkin_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1512,0),
Name = "Martian_Holobookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1566,0),
Name = "Meteorite_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1620,0),
Name = "Granite_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1674,0),
Name = "Marble_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1728,0),
Name = "Crystal_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1782,0),
Name = "Spider_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1836,0),
Name = "Lesion_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1890,0),
Name = "Solar_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1944,0),
Name = "Vortex_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(1998,0),
Name = "Nebula_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(2052,0),
Name = "Stardust_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(2106,0),
Name = "Sandstone_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(2160,0),
Name = "Bamboo_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(2214,0),
Name = "Reef_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(2268,0),
Name = "Balloon_Bookcase",
},

new SpriteData()
{
TileType = 101,
Size = new(3,4),
Origin = new(2322,0),
Name = "Ash_Wood_Bookcase",
},

new SpriteData()
{
TileType = 102,
Size = new(3,4),
},

new SpriteData()
{
TileType = 103,
Size = new(2,1),
Name = "Bowl",
},

new SpriteData()
{
TileType = 103,
Size = new(2,1),
Origin = new(36,0),
Name = "Dynasty_Bowl",
},

new SpriteData()
{
TileType = 103,
Size = new(2,1),
Origin = new(72,0),
Name = "Fancy_Dishes",
},

new SpriteData()
{
TileType = 103,
Size = new(2,1),
Origin = new(108,0),
Name = "Glass_Bowl",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Name = "Grandfather_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(36,0),
Name = "Dynasty_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(72,0),
Name = "Golden_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(108,0),
Name = "Glass_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(144,0),
Name = "Honey_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(180,0),
Name = "Steampunk_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(216,0),
Name = "Boreal_Wood_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(252,0),
Name = "Slime_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(288,0),
Name = "Bone_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(324,0),
Name = "Cactus_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(360,0),
Name = "Ebonwood_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(396,0),
Name = "Frozen_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(432,0),
Name = "Lihzahrd_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(468,0),
Name = "Living_Wood_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(504,0),
Name = "Rich_Mahogany_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(540,0),
Name = "Flesh_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(576,0),
Name = "Mushroom_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(612,0),
Name = "Obsidian_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(648,0),
Name = "Palm_Wood_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(684,0),
Name = "Pearlwood_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(720,0),
Name = "Pumpkin_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(756,0),
Name = "Shadewood_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(792,0),
Name = "Spooky_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(828,0),
Name = "Sunplate_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(864,0),
Name = "Martian_Astro_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(900,0),
Name = "Meteorite_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(936,0),
Name = "Granite_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(972,0),
Name = "Marble_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1008,0),
Name = "Crystal_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1044,0),
Name = "Sunplate_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1080,0),
Name = "Blue_Dungeon_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1116,0),
Name = "Green_Dungeon_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1152,0),
Name = "Pink_Dungeon_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1188,0),
Name = "Spider_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1224,0),
Name = "Lesion_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1260,0),
Name = "Solar_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1296,0),
Name = "Vortex_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1332,0),
Name = "Nebula_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1368,0),
Name = "Stardust_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1404,0),
Name = "Sandstone_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1440,0),
Name = "Bamboo_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1476,0),
Name = "Reef_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1512,0),
Name = "Balloon_Clock",
},

new SpriteData()
{
TileType = 104,
Size = new(2,5),
Origin = new(1548,0),
Name = "Ash_Wood_Clock",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Name = "Armor_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(0,162),
Name = "Armor_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(36,0),
Name = "Angel_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(36,162),
Name = "Angel_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(72,0),
Name = "Star_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(72,162),
Name = "Star_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(108,0),
Name = "Sword_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(108,162),
Name = "Sword_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(144,0),
Name = "Slime_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(144,162),
Name = "Slime_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(180,0),
Name = "Goblin_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(180,162),
Name = "Goblin_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(216,0),
Name = "Shield_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(216,162),
Name = "Shield_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(252,0),
Name = "Bat_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(252,162),
Name = "Bat_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(288,0),
Name = "Fish_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(288,162),
Name = "Fish_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(324,0),
Name = "Bunny_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(324,162),
Name = "Bunny_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(360,0),
Name = "Skeleton_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(360,162),
Name = "Skeleton_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(396,0),
Name = "Reaper_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(396,162),
Name = "Reaper_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(432,0),
Name = "Woman_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(432,162),
Name = "Woman_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(468,0),
Name = "Imp_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(468,162),
Name = "Imp_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(504,0),
Name = "Gargoyle_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(504,162),
Name = "Gargoyle_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(540,0),
Name = "Gloom_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(540,162),
Name = "Gloom_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(576,0),
Name = "Hornet_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(576,162),
Name = "Hornet_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(612,0),
Name = "Bomb_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(612,162),
Name = "Bomb_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(648,0),
Name = "Crab_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(648,162),
Name = "Crab_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(684,0),
Name = "Hammer_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(684,162),
Name = "Hammer_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(720,0),
Name = "Potion_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(720,162),
Name = "Potion_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(756,0),
Name = "Spear_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(756,162),
Name = "Spear_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(792,0),
Name = "Cross_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(792,162),
Name = "Cross_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(828,0),
Name = "Jellyfish_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(828,162),
Name = "Jellyfish_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(864,0),
Name = "Bow_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(864,162),
Name = "Bow_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(900,0),
Name = "Boomerang_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(900,162),
Name = "Boomerang_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(936,0),
Name = "Boot_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(936,162),
Name = "Boot_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(972,0),
Name = "Chest_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(972,162),
Name = "Chest_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1008,0),
Name = "Bird_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1008,162),
Name = "Bird_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1044,0),
Name = "Axe_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1044,162),
Name = "Axe_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1080,0),
Name = "Corrupt_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1080,162),
Name = "Corrupt_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1116,0),
Name = "Tree_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1116,162),
Name = "Tree_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1152,0),
Name = "Anvil_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1152,162),
Name = "Anvil_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1188,0),
Name = "Pickaxe_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1188,162),
Name = "Pickaxe_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1224,0),
Name = "Mushroom_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1224,162),
Name = "Mushroom_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1260,0),
Name = "Eyeball_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1260,162),
Name = "Eyeball_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1296,0),
Name = "Pillar_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1296,162),
Name = "Pillar_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1332,0),
Name = "Heart_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1332,162),
Name = "Heart_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1368,0),
Name = "Pot_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1368,162),
Name = "Pot_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1404,0),
Name = "Sunflower_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1404,162),
Name = "Sunflower_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1440,0),
Name = "King_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1440,162),
Name = "King_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1476,0),
Name = "Queen_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1476,162),
Name = "Queen_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1512,0),
Name = "Pirahna_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1512,162),
Name = "Pirahna_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1548,0),
Name = "Lihzahrd_Statue_A",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1548,162),
Name = "Lihzahrd_Statue_A",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1584,0),
Name = "Lihzahrd_Statue_B",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1584,162),
Name = "Lihzahrd_Statue_B",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1620,0),
Name = "Lihzahrd_Statue_C",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1620,162),
Name = "Lihzahrd_Statue_C",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1656,0),
Name = "Blue_Dungeon_Vase",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1656,162),
Name = "Blue_Dungeon_Vase",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1692,0),
Name = "Green_Dungeon_Vase",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1692,162),
Name = "Green_Dungeon_Vase",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1728,0),
Name = "Pink_Dungeon_Vase",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1728,162),
Name = "Pink_Dungeon_Vase",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1764,0),
Name = "Obsidian_Vase",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1764,162),
Name = "Obsidian_Vase",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1800,0),
Name = "Shark_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1800,162),
Name = "Shark_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1836,0),
Name = "Squirrel_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1836,162),
Name = "Squirrel_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1872,0),
Name = "Butterfly_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1872,162),
Name = "Butterfly_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1908,0),
Name = "Worm_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1908,162),
Name = "Worm_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1944,0),
Name = "Firefly_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(1944,162),
Name = "Firefly_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(0,54),
Name = "Scorpion_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(0,216),
Name = "Scorpion_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(36,54),
Name = "Snail_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(36,216),
Name = "Snail_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(72,54),
Name = "Grasshopper_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(72,216),
Name = "Grasshopper_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(108,54),
Name = "Mouse_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(108,216),
Name = "Mouse_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(144,54),
Name = "Duck_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(144,216),
Name = "Duck_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(180,54),
Name = "Penguin_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(180,216),
Name = "Penguin_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(216,54),
Name = "Frog_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(216,216),
Name = "Frog_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(252,54),
Name = "Buggy_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(252,216),
Name = "Buggy_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(288,54),
Name = "Wall_Creeper_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(288,216),
Name = "Wall_Creeper_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(324,54),
Name = "Unicorn_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(324,216),
Name = "Unicorn_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(360,54),
Name = "Drippler_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(360,216),
Name = "Drippler_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(396,54),
Name = "Wraith_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(396,216),
Name = "Wraith_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(432,54),
Name = "Bone_Skeleton_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(432,216),
Name = "Bone_Skeleton_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(468,54),
Name = "Undead_Viking_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(468,216),
Name = "Undead_Viking_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(504,54),
Name = "Medusa_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(504,216),
Name = "Medusa_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(540,54),
Name = "Harpy_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(540,216),
Name = "Harpy_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(576,54),
Name = "Pigron_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(576,216),
Name = "Pigron_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(612,54),
Name = "Hoplite_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(612,216),
Name = "Hoplite_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(648,54),
Name = "Granite_Golem_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(648,216),
Name = "Granite_Golem_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(684,54),
Name = "Armed_Zombie_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(684,216),
Name = "Armed_Zombie_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(720,54),
Name = "Blood_Zombie_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(720,216),
Name = "Blood_Zombie_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(756,54),
Name = "Owl_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(756,216),
Name = "Owl_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(792,54),
Name = "Seagull_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(792,216),
Name = "Seagull_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(828,54),
Name = "Dragonfly_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(828,216),
Name = "Dragonfly_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(864,54),
Name = "Turtle_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(864,216),
Name = "Turtle_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(900,54),
Name = "Macaw_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(900,216),
Name = "Macaw_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(936,54),
Name = "Toucan_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(936,216),
Name = "Toucan_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(972,54),
Name = "Cockatiel_Statue",
Variety = "Left",
},

new SpriteData()
{
TileType = 105,
Size = new(2,3),
Origin = new(972,216),
Name = "Cockatiel_Statue",
Variety = "Right",
},

new SpriteData()
{
TileType = 106,
Size = new(3,3),
},

new SpriteData()
{
TileType = 110,
Name = "Grass_Single_Blade_A",
},

new SpriteData()
{
TileType = 110,
Origin = new(18,0),
Name = "Grass_Double_Blade",
},

new SpriteData()
{
TileType = 110,
Origin = new(36,0),
Name = "Grass_Single_Blade_B",
},

new SpriteData()
{
TileType = 110,
Origin = new(54,0),
Name = "Grass_Three_Small",
},

new SpriteData()
{
TileType = 110,
Origin = new(90,0),
Name = "Grass_Three_Large",
},

new SpriteData()
{
TileType = 110,
Origin = new(162,0),
Name = "Grass_Small_Y",
},

new SpriteData()
{
TileType = 110,
Origin = new(144,0),
Name = "Mushroom_(growing)",
},

new SpriteData()
{
TileType = 110,
Origin = new(72,0),
Name = "Flower_A",
},

new SpriteData()
{
TileType = 110,
Origin = new(108,0),
Name = "Flower_B",
},

new SpriteData()
{
TileType = 110,
Origin = new(126,0),
Name = "Flower_C",
},

new SpriteData()
{
TileType = 110,
Origin = new(180,0),
Name = "Flower_D",
},

new SpriteData()
{
TileType = 110,
Origin = new(198,0),
Name = "Flower_E",
},

new SpriteData()
{
TileType = 110,
Origin = new(216,0),
Name = "Flower_F",
},

new SpriteData()
{
TileType = 110,
Origin = new(234,0),
Name = "Flower_G",
},

new SpriteData()
{
TileType = 110,
Origin = new(252,0),
Name = "Flower_H",
},

new SpriteData()
{
TileType = 110,
Origin = new(270,0),
Name = "Flower_I",
},

new SpriteData()
{
TileType = 110,
Origin = new(288,0),
Name = "Flower_J",
},

new SpriteData()
{
TileType = 110,
Origin = new(306,0),
Name = "Flower_K",
},

new SpriteData()
{
TileType = 110,
Origin = new(324,0),
Name = "Flower_L",
},

new SpriteData()
{
TileType = 110,
Origin = new(342,0),
Name = "Flower_M",
},

new SpriteData()
{
TileType = 110,
Origin = new(360,0),
Name = "Flower_N",
},

new SpriteData()
{
TileType = 110,
Origin = new(378,0),
Name = "Flower_O",
},

new SpriteData()
{
TileType = 110,
Origin = new(396,0),
Name = "Flower_P",
},

new SpriteData()
{
TileType = 113,
Anchor = FrameAnchor.Bottom,
Name = "Grass_A",
},

new SpriteData()
{
TileType = 113,
Anchor = FrameAnchor.Bottom,
Origin = new(18,0),
Name = "Grass_B",
},

new SpriteData()
{
TileType = 113,
Anchor = FrameAnchor.Bottom,
Origin = new(90,0),
Name = "Grass_C",
},

new SpriteData()
{
TileType = 113,
Anchor = FrameAnchor.Bottom,
Origin = new(36,0),
Name = "Flower_A",
},

new SpriteData()
{
TileType = 113,
Anchor = FrameAnchor.Bottom,
Origin = new(54,0),
Name = "Flower_B",
},

new SpriteData()
{
TileType = 113,
Anchor = FrameAnchor.Bottom,
Origin = new(72,0),
Name = "Flower_C",
},

new SpriteData()
{
TileType = 113,
Anchor = FrameAnchor.Bottom,
Origin = new(108,0),
Name = "Flower_D",
},

new SpriteData()
{
TileType = 113,
Anchor = FrameAnchor.Bottom,
Origin = new(126,0),
Name = "Flower_E",
},

new SpriteData()
{
TileType = 114,
Size = new(3,2),
},

new SpriteData()
{
TileType = 125,
Size = new(2,2),
},

new SpriteData()
{
TileType = 126,
Size = new(2,2),
Name = "On",
},

new SpriteData()
{
TileType = 126,
Size = new(2,2),
Origin = new(36,0),
Name = "Off",
},

new SpriteData()
{
TileType = 128,
Anchor = FrameAnchor.Left,
Size = new(2,3),
},

new SpriteData()
{
TileType = 128,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(36,0),
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Name = "Large_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(0,18),
Name = "Large_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(0,36),
Name = "Large_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(0,54),
Name = "Large_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(108,0),
Name = "Medium_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(108,18),
Name = "Medium_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(108,36),
Name = "Medium_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(108,54),
Name = "Medium_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(54,0),
Name = "Small_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(54,18),
Name = "Small_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(54,36),
Name = "Small_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(54,54),
Name = "Small_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(162,0),
Name = "Medium_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(162,18),
Name = "Medium_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(162,36),
Name = "Medium_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(162,54),
Name = "Medium_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(216,0),
Name = "Small_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(216,18),
Name = "Small_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(216,36),
Name = "Small_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(216,54),
Name = "Small_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(270,0),
Name = "Large_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(270,18),
Name = "Large_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(270,36),
Name = "Large_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(270,54),
Name = "Large_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(18,0),
Name = "Large_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(18,18),
Name = "Large_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(18,36),
Name = "Large_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(18,54),
Name = "Large_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(126,0),
Name = "Medium_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(126,18),
Name = "Medium_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(126,36),
Name = "Medium_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(126,54),
Name = "Medium_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(72,0),
Name = "Small_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(72,18),
Name = "Small_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(72,36),
Name = "Small_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(72,54),
Name = "Small_Pink_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(180,0),
Name = "Medium_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(180,18),
Name = "Medium_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(180,36),
Name = "Medium_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(180,54),
Name = "Medium_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(234,0),
Name = "Small_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(234,18),
Name = "Small_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(234,36),
Name = "Small_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(234,54),
Name = "Small_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(288,0),
Name = "Large_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(288,18),
Name = "Large_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(288,36),
Name = "Large_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(288,54),
Name = "Large_Pink_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(36,0),
Name = "Large_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(36,18),
Name = "Large_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(36,36),
Name = "Large_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(36,54),
Name = "Large_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(144,0),
Name = "Medium_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(144,18),
Name = "Medium_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(144,36),
Name = "Medium_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(144,54),
Name = "Medium_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(90,0),
Name = "Small_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(90,18),
Name = "Small_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(90,36),
Name = "Small_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(90,54),
Name = "Small_Purple_A",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(198,0),
Name = "Medium_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(198,18),
Name = "Medium_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(198,36),
Name = "Medium_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(198,54),
Name = "Medium_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(252,0),
Name = "Small_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(252,18),
Name = "Small_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(252,36),
Name = "Small_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(252,54),
Name = "Small_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(306,0),
Name = "Large_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(306,18),
Name = "Large_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(306,36),
Name = "Large_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(306,54),
Name = "Large_Purple_B",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Bottom,
Origin = new(324,0),
Name = "Gelatin_Crystal",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Top,
Origin = new(324,18),
Name = "Gelatin_Crystal",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Right,
Origin = new(324,36),
Name = "Gelatin_Crystal",
},

new SpriteData()
{
TileType = 129,
Anchor = FrameAnchor.Left,
Origin = new(324,54),
Name = "Gelatin_Crystal",
},

new SpriteData()
{
TileType = 132,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Name = "Right",
},

new SpriteData()
{
TileType = 132,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(36,0),
Name = "Left",
},

new SpriteData()
{
TileType = 132,
Size = new(2,2),
Origin = new(72,0),
Name = "Up",
},

new SpriteData()
{
TileType = 132,
Size = new(2,2),
Origin = new(108,0),
Name = "Down",
},

new SpriteData()
{
TileType = 133,
Size = new(3,2),
Name = "Adamantite_Forge",
},

new SpriteData()
{
TileType = 133,
Size = new(3,2),
Origin = new(54,0),
Name = "Titanium_Forge",
},

new SpriteData()
{
TileType = 134,
Size = new(2,1),
Name = "Mythril_Anvil",
},

new SpriteData()
{
TileType = 134,
Size = new(2,1),
Origin = new(36,0),
Name = "Orichalcum_Anvil",
},

new SpriteData()
{
TileType = 135,
Name = "Red_Pressure_Plate",
},

new SpriteData()
{
TileType = 135,
Origin = new(0,18),
Name = "Green_Pressure_Plate",
},

new SpriteData()
{
TileType = 135,
Origin = new(0,36),
Name = "Gray_Pressure_Plate",
},

new SpriteData()
{
TileType = 135,
Origin = new(0,54),
Name = "Brown_Pressure_Plate",
},

new SpriteData()
{
TileType = 135,
Origin = new(0,72),
Name = "Blue_Pressure_Plate",
},

new SpriteData()
{
TileType = 135,
Origin = new(0,90),
Name = "Yellow_Pressure_Plate",
},

new SpriteData()
{
TileType = 135,
Origin = new(0,108),
Name = "Lihzahrd_Pressure_Plate",
},

new SpriteData()
{
TileType = 135,
Origin = new(0,126),
Name = "Orange_Pressure_Plate",
},

new SpriteData()
{
TileType = 136,
Anchor = FrameAnchor.Bottom,
Name = "Setting_One",
},

new SpriteData()
{
TileType = 136,
Anchor = FrameAnchor.Left,
Origin = new(18,18),
Name = "Setting_One",
},

new SpriteData()
{
TileType = 136,
Anchor = FrameAnchor.Right,
Origin = new(36,0),
Name = "Setting_One",
},

new SpriteData()
{
TileType = 136,
Origin = new(54,0),
Name = "Setting_One",
},

new SpriteData()
{
TileType = 136,
Anchor = FrameAnchor.Bottom,
Origin = new(0,18),
Name = "Setting_Two",
},

new SpriteData()
{
TileType = 136,
Anchor = FrameAnchor.Left,
Origin = new(18,0),
Name = "Setting_Two",
},

new SpriteData()
{
TileType = 136,
Anchor = FrameAnchor.Right,
Origin = new(36,18),
Name = "Setting_Two",
},

new SpriteData()
{
TileType = 136,
Origin = new(54,18),
Name = "Setting_Two",
},

new SpriteData()
{
TileType = 137,
Name = "Dart_Trap",
Variety = "Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(18,0),
Name = "Dart_Trap",
Variety = "Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(36,0),
Name = "Dart_Trap",
Variety = "Up-Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(54,0),
Name = "Dart_Trap",
Variety = "Up-Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(72,0),
Name = "Dart_Trap",
Variety = "Down-Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(90,0),
Name = "Dart_Trap",
Variety = "Down-Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(0,18),
Name = "Super_Dart_Trap",
Variety = "Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(18,18),
Name = "Super_Dart_Trap",
Variety = "Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(36,18),
Name = "Super_Dart_Trap",
Variety = "Up-Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(54,18),
Name = "Super_Dart_Trap",
Variety = "Up-Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(72,18),
Name = "Super_Dart_Trap",
Variety = "Down-Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(90,18),
Name = "Super_Dart_Trap",
Variety = "Down-Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(0,36),
Name = "Flame_Trap",
Variety = "Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(18,36),
Name = "Flame_Trap",
Variety = "Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(36,36),
Name = "Flame_Trap",
Variety = "Up-Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(54,36),
Name = "Flame_Trap",
Variety = "Up-Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(72,36),
Name = "Flame_Trap",
Variety = "Down-Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(90,36),
Name = "Flame_Trap",
Variety = "Down-Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(0,54),
Name = "Spiky_Ball_Trap",
Variety = "Top",
},

new SpriteData()
{
TileType = 137,
Origin = new(18,54),
Name = "Spiky_Ball_Trap",
Variety = "Down",
},

new SpriteData()
{
TileType = 137,
Origin = new(36,54),
Name = "Spiky_Ball_Trap",
Variety = "Up",
},

new SpriteData()
{
TileType = 137,
Origin = new(54,54),
Name = "Spiky_Ball_Trap",
Variety = "Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(72,54),
Name = "Spiky_Ball_Trap",
Variety = "Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(0,72),
Name = "Spear_Trap",
Variety = "Top",
},

new SpriteData()
{
TileType = 137,
Origin = new(18,72),
Name = "Spear_Trap",
Variety = "Down",
},

new SpriteData()
{
TileType = 137,
Origin = new(36,72),
Name = "Spear_Trap",
Variety = "Up",
},

new SpriteData()
{
TileType = 137,
Origin = new(54,72),
Name = "Spear_Trap",
Variety = "Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(72,72),
Name = "Spear_Trap",
Variety = "Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(0,90),
Name = "Venom_Dart_Trap",
Variety = "Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(18,90),
Name = "Venom_Dart_Trap",
Variety = "Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(36,90),
Name = "Venom_Dart_Trap",
Variety = "Up-Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(54,90),
Name = "Venom_Dart_Trap",
Variety = "Up-Right",
},

new SpriteData()
{
TileType = 137,
Origin = new(72,90),
Name = "Venom_Dart_Trap",
Variety = "Down-Left",
},

new SpriteData()
{
TileType = 137,
Origin = new(90,90),
Name = "Venom_Dart_Trap",
Variety = "Down-Right",
},

new SpriteData()
{
TileType = 138,
Size = new(2,2),
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Name = "Music_Box_(Overworld_Day)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,0),
Name = "Music_Box_(Overworld_Day)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(72,0),
Name = "Music_Box_(Alt_Title)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(108,0),
Name = "Music_Box_(Alt_Title)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,36),
Name = "Music_Box_(Eerie)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,36),
Name = "Music_Box_(Eerie)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,72),
Name = "Music_Box_(Night)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,72),
Name = "Music_Box_(Night)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,108),
Name = "Music_Box_(Title)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,108),
Name = "Music_Box_(Title)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,144),
Name = "Music_Box_(Underground)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,144),
Name = "Music_Box_(Underground)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,180),
Name = "Music_Box_(Boss_1)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,180),
Name = "Music_Box_(Boss_1)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,216),
Name = "Music_Box_(Jungle)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,216),
Name = "Music_Box_(Jungle)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,252),
Name = "Music_Box_(Corruption)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,252),
Name = "Music_Box_(Corruption)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,288),
Name = "Music_Box_(Underground_Corruption)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,288),
Name = "Music_Box_(Underground_Corruption)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,324),
Name = "Music_Box_(The_Hallow)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,324),
Name = "Music_Box_(The_Hallow)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,360),
Name = "Music_Box_(Boss_2)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,360),
Name = "Music_Box_(Boss_2)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,396),
Name = "Music_Box_(Underground_Hallow)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,396),
Name = "Music_Box_(Underground_Hallow)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,432),
Name = "Music_Box_(Boss_3)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,432),
Name = "Music_Box_(Boss_3)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,468),
Name = "Music_Box_(Snow)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,468),
Name = "Music_Box_(Snow)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,504),
Name = "Music_Box_(Space)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,504),
Name = "Music_Box_(Space)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,540),
Name = "Music_Box_(Crimson)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,540),
Name = "Music_Box_(Crimson)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,576),
Name = "Music_Box_(Boss_4)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,576),
Name = "Music_Box_(Boss_4)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,612),
Name = "Music_Box_(Alt_Overworld_Day)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,612),
Name = "Music_Box_(Alt_Overworld_Day)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,648),
Name = "Music_Box_(Rain)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,648),
Name = "Music_Box_(Rain)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,684),
Name = "Music_Box_(Ice)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,684),
Name = "Music_Box_(Ice)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,720),
Name = "Music_Box_(Desert)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,720),
Name = "Music_Box_(Desert)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,756),
Name = "Music_Box_(Ocean)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,756),
Name = "Music_Box_(Ocean)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,792),
Name = "Music_Box_(Dungeon)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,792),
Name = "Music_Box_(Dungeon)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,828),
Name = "Music_Box_(Plantera)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,828),
Name = "Music_Box_(Plantera)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,864),
Name = "Music_Box_(Boss_5)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,864),
Name = "Music_Box_(Boss_5)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,900),
Name = "Music_Box_(Temple)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,900),
Name = "Music_Box_(Temple)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,936),
Name = "Music_Box_(Eclipse)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,936),
Name = "Music_Box_(Eclipse)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,972),
Name = "Music_Box_(Mushrooms)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,972),
Name = "Music_Box_(Mushrooms)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1008),
Name = "Music_Box_(Pumpkin_Moon)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1008),
Name = "Music_Box_(Pumpkin_Moon)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1044),
Name = "Music_Box_(Alt_Underground)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1044),
Name = "Music_Box_(Alt_Underground)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1080),
Name = "Music_Box_(Frost_Moon)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1080),
Name = "Music_Box_(Frost_Moon)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1116),
Name = "Music_Box_(Underground_Crimson)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1116),
Name = "Music_Box_(Underground_Crimson)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1152),
Name = "Music_Box_(Lunar_Boss)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1152),
Name = "Music_Box_(Lunar_Boss)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1188),
Name = "Music_Box_(Martian_Madness)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1188),
Name = "Music_Box_(Martian_Madness)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1224),
Name = "Music_Box_(Pirate_Invasion)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1224),
Name = "Music_Box_(Pirate_Invasion)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1260),
Name = "Music_Box_(Hell)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1260),
Name = "Music_Box_(Hell)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1296),
Name = "Music_Box_(The_Towers)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1296),
Name = "Music_Box_(The_Towers)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1332),
Name = "Music_Box_(Goblin_Invasion)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1332),
Name = "Music_Box_(Goblin_Invasion)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1368),
Name = "Music_Box_(Sandstorm)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1368),
Name = "Music_Box_(Sandstorm)",
Variety = "On",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(0,1404),
Name = "Music_Box_(Old_One's_Army)",
Variety = "Off",
},

new SpriteData()
{
TileType = 139,
Size = new(2,2),
Origin = new(36,1404),
Name = "Music_Box_(Old_One's_Army)",
Variety = "On",
},

new SpriteData()
{
TileType = 141,
Name = "Single",
},

new SpriteData()
{
TileType = 141,
Origin = new(0,18),
Name = "Multi",
},

new SpriteData()
{
TileType = 142,
Size = new(2,2),
},

new SpriteData()
{
TileType = 143,
Size = new(2,2),
},

new SpriteData()
{
TileType = 144,
Name = "1_Second_Timer",
Variety = "Inactive",
},

new SpriteData()
{
TileType = 144,
Origin = new(0,18),
Name = "1_Second_Timer",
Variety = "Active",
},

new SpriteData()
{
TileType = 144,
Origin = new(18,0),
Name = "3_Second_Timer",
Variety = "Inactive",
},

new SpriteData()
{
TileType = 144,
Origin = new(18,18),
Name = "3_Second_Timer",
Variety = "Active",
},

new SpriteData()
{
TileType = 144,
Origin = new(36,0),
Name = "5_Second_Timer",
Variety = "Inactive",
},

new SpriteData()
{
TileType = 144,
Origin = new(36,18),
Name = "5_Second_Timer",
Variety = "Active",
},

new SpriteData()
{
TileType = 144,
Origin = new(54,0),
Name = "1/2_Second_Timer",
Variety = "Inactive",
},

new SpriteData()
{
TileType = 144,
Origin = new(54,18),
Name = "1/2_Second_Timer",
Variety = "Active",
},

new SpriteData()
{
TileType = 144,
Origin = new(72,0),
Name = "1/4_Second_Timer",
Variety = "Inactive",
},

new SpriteData()
{
TileType = 144,
Origin = new(72,18),
Name = "1/4_Second_Timer",
Variety = "Active",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Bottom,
Name = "Blue_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Top,
Origin = new(0,18),
Name = "Blue_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Right,
Origin = new(0,36),
Name = "Blue_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Left,
Origin = new(0,54),
Name = "Blue_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Bottom,
Origin = new(54,0),
Name = "Blue_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Top,
Origin = new(54,18),
Name = "Blue_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Right,
Origin = new(54,36),
Name = "Blue_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Left,
Origin = new(54,54),
Name = "Blue_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Bottom,
Origin = new(18,0),
Name = "Red_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Top,
Origin = new(18,18),
Name = "Red_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Right,
Origin = new(18,36),
Name = "Red_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Left,
Origin = new(18,54),
Name = "Red_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Bottom,
Origin = new(72,0),
Name = "Red_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Top,
Origin = new(72,18),
Name = "Red_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Right,
Origin = new(72,36),
Name = "Red_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Left,
Origin = new(72,54),
Name = "Red_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Bottom,
Origin = new(36,0),
Name = "Green_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Top,
Origin = new(36,18),
Name = "Green_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Right,
Origin = new(36,36),
Name = "Green_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Left,
Origin = new(36,54),
Name = "Green_Light",
Variety = "On",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Bottom,
Origin = new(90,0),
Name = "Green_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Top,
Origin = new(90,18),
Name = "Green_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Right,
Origin = new(90,36),
Name = "Green_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 149,
Anchor = FrameAnchor.Left,
Origin = new(90,54),
Name = "Green_Light",
Variety = "Off",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Name = "Icicle_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(18,0),
Name = "Icicle_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(36,0),
Name = "Icicle_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(54,0),
Name = "Stone_Stalactite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(72,0),
Name = "Stone_Stalactite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(90,0),
Name = "Stone_Stalactite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(54,36),
Name = "Stone_Stalagmite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(72,36),
Name = "Stone_Stalagmite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(90,36),
Name = "Stone_Stalagmite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(108,0),
Name = "Spider_Web_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(126,0),
Name = "Spider_Web_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(144,0),
Name = "Spider_Web_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(216,0),
Name = "Pearlstone_Stalactite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(234,0),
Name = "Pearlstone_Stalactite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(252,0),
Name = "Pearlstone_Stalactite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(216,36),
Name = "Pearlstone_Stalagmite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(234,36),
Name = "Pearlstone_Stalagmite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(252,36),
Name = "Pearlstone_Stalagmite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(270,0),
Name = "Ebonstone_Stalactite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(288,0),
Name = "Ebonstone_Stalactite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(306,0),
Name = "Ebonstone_Stalactite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(270,36),
Name = "Ebonstone_Stalagmite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(288,36),
Name = "Ebonstone_Stalagmite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(306,36),
Name = "Ebonstone_Stalagmite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(324,0),
Name = "Crimstone_Stalactite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(342,0),
Name = "Crimstone_Stalactite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(360,0),
Name = "Crimstone_Stalactite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(324,36),
Name = "Crimstone_Stalagmite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(342,36),
Name = "Crimstone_Stalagmite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(360,36),
Name = "Crimstone_Stalagmite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(378,0),
Name = "Sandstone_Stalactite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(396,0),
Name = "Sandstone_Stalactite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(414,0),
Name = "Sandstone_Stalactite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(378,36),
Name = "Sandstone_Stalagmite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(396,36),
Name = "Sandstone_Stalagmite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(414,36),
Name = "Sandstone_Stalagmite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(432,0),
Name = "Granite_Stalactite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(450,0),
Name = "Granite_Stalactite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(468,0),
Name = "Granite_Stalactite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(432,36),
Name = "Granite_Stalagmite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(450,36),
Name = "Granite_Stalagmite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(468,36),
Name = "Granite_Stalagmite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(486,0),
Name = "Marble_Stalactite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(504,0),
Name = "Marble_Stalactite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(522,0),
Name = "Marble_Stalactite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(486,36),
Name = "Marble_Stalagmite_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(504,36),
Name = "Marble_Stalagmite_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(522,36),
Name = "Marble_Stalagmite_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(540,0),
Name = "Pink_Icicle_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(558,0),
Name = "Pink_Icicle_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(576,0),
Name = "Pink_Icicle_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(594,0),
Name = "Purple_Icicle_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(612,0),
Name = "Purple_Icicle_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(630,0),
Name = "Purple_Icicle_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(648,0),
Name = "Red_Icicle_1x2",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(666,0),
Name = "Red_Icicle_1x2",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(684,0),
Name = "Red_Icicle_1x2",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(0,72),
Name = "Icicle_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(18,72),
Name = "Icicle_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(36,72),
Name = "Icicle_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(54,72),
Name = "Stone_Stalactite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(72,72),
Name = "Stone_Stalactite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(90,72),
Name = "Stone_Stalactite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(54,90),
Name = "Stone_Stalagmite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(72,90),
Name = "Stone_Stalagmite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(90,90),
Name = "Stone_Stalagmite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(162,72),
Name = "Hive_Stalactite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(180,72),
Name = "Hive_Stalactite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(198,72),
Name = "Hive_Stalactite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(162,90),
Name = "Hive_Stalagmite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(180,90),
Name = "Hive_Stalagmite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(198,90),
Name = "Hive_Stalagmite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(216,72),
Name = "Pearlstone_Stalactite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(234,72),
Name = "Pearlstone_Stalactite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(252,72),
Name = "Pearlstone_Stalactite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(216,90),
Name = "Pearlstone_Stalagmite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(234,90),
Name = "Pearlstone_Stalagmite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(252,90),
Name = "Pearlstone_Stalagmite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(270,72),
Name = "Ebonstone_Stalactite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(288,72),
Name = "Ebonstone_Stalactite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(306,72),
Name = "Ebonstone_Stalactite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(270,90),
Name = "Ebonstone_Stalagmite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(288,90),
Name = "Ebonstone_Stalagmite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(306,90),
Name = "Ebonstone_Stalagmite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(324,72),
Name = "Crimstone_Stalactite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(342,72),
Name = "Crimstone_Stalactite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(360,72),
Name = "Crimstone_Stalactite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(324,90),
Name = "Crimstone_Stalagmite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(342,90),
Name = "Crimstone_Stalagmite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(360,90),
Name = "Crimstone_Stalagmite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(378,72),
Name = "Sandstone_Stalactite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(396,72),
Name = "Sandstone_Stalactite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(414,72),
Name = "Sandstone_Stalactite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(378,90),
Name = "Sandstone_Stalagmite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(396,90),
Name = "Sandstone_Stalagmite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(414,90),
Name = "Sandstone_Stalagmite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(432,72),
Name = "Granite_Stalactite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(450,72),
Name = "Granite_Stalactite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(468,72),
Name = "Granite_Stalactite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(432,90),
Name = "Granite_Stalagmite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(450,90),
Name = "Granite_Stalagmite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(468,90),
Name = "Granite_Stalagmite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(486,72),
Name = "Marble_Stalactite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(504,72),
Name = "Marble_Stalactite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(522,72),
Name = "Marble_Stalactite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(486,90),
Name = "Marble_Stalagmite_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(504,90),
Name = "Marble_Stalagmite_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(522,90),
Name = "Marble_Stalagmite_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(540,72),
Name = "Pink_Icicle_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(558,72),
Name = "Pink_Icicle_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(576,72),
Name = "Pink_Icicle_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(594,72),
Name = "Purple_Icicle_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(612,72),
Name = "Purple_Icicle_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(630,72),
Name = "Purple_Icicle_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(648,72),
Name = "Red_Icicle_1x1",
Variety = "A",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(666,72),
Name = "Red_Icicle_1x1",
Variety = "B",
},

new SpriteData()
{
TileType = 165,
Size = new(1,2),
Origin = new(684,72),
Name = "Red_Icicle_1x1",
Variety = "C",
},

new SpriteData()
{
TileType = 171,
Size = new(4,8),
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Name = "Wooden_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,38),
Name = "Ebonwood_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,76),
Name = "Rich_Mahogany_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,114),
Name = "Pearlwood_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,152),
Name = "Bone_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,190),
Name = "Flesh_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,228),
Name = "Living_Wood_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,266),
Name = "Skyware_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,304),
Name = "Shadewood_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,342),
Name = "Lihzahrd_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,380),
Name = "Blue_Dungeon_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,418),
Name = "Green_Dungeon_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,456),
Name = "Pink_Dungeon_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,494),
Name = "Obsidian_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,532),
Name = "Metal_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,570),
Name = "Glass_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,608),
Name = "Golden_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,646),
Name = "Honey_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,684),
Name = "Steampunk_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,722),
Name = "Pumpkin_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,760),
Name = "Spooky_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,798),
Name = "Frozen_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,836),
Name = "Dynasty_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,874),
Name = "Palm_Wood_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,912),
Name = "Mushroom_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,950),
Name = "Boreal_Wood_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,988),
Name = "Slime_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1026),
Name = "Cactus_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1064),
Name = "Martian_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1102),
Name = "Meteorite_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1140),
Name = "Granite_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1178),
Name = "Marble_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1216),
Name = "Crystal_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1254),
Name = "Spider_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1292),
Name = "Lesion_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1330),
Name = "Solar_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1368),
Name = "Vortex_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1406),
Name = "Nebula_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1444),
Name = "Stardust_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1482),
Name = "Sandstone_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1520),
Name = "Bamboo_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1558),
Name = "Reef_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1596),
Name = "Balloon_Sink",
},

new SpriteData()
{
TileType = 172,
Size = new(2,2),
Origin = new(0,1634),
Name = "Ash_Wood_Sink",
},

new SpriteData()
{
TileType = 173,
Size = new(2,2),
Name = "On",
},

new SpriteData()
{
TileType = 173,
Size = new(2,2),
Origin = new(36,0),
Name = "Off",
},

new SpriteData()
{
TileType = 174,
Name = "On",
},

new SpriteData()
{
TileType = 174,
Origin = new(18,0),
Name = "Off",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Name = "Amethyst",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(0,18),
Name = "Amethyst",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(0,36),
Name = "Amethyst",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(0,54),
Name = "Amethyst",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(0,72),
Name = "Amethyst",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(0,90),
Name = "Amethyst",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(0,108),
Name = "Amethyst",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(0,126),
Name = "Amethyst",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(0,144),
Name = "Amethyst",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(0,162),
Name = "Amethyst",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(0,180),
Name = "Amethyst",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(0,198),
Name = "Amethyst",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(18,0),
Name = "Topaz",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(18,18),
Name = "Topaz",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(18,36),
Name = "Topaz",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(18,54),
Name = "Topaz",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(18,72),
Name = "Topaz",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(18,90),
Name = "Topaz",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(18,108),
Name = "Topaz",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(18,126),
Name = "Topaz",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(18,144),
Name = "Topaz",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(18,162),
Name = "Topaz",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(18,180),
Name = "Topaz",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(18,198),
Name = "Topaz",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(36,0),
Name = "Sapphire",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(36,18),
Name = "Sapphire",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(36,36),
Name = "Sapphire",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(36,54),
Name = "Sapphire",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(36,72),
Name = "Sapphire",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(36,90),
Name = "Sapphire",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(36,108),
Name = "Sapphire",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(36,126),
Name = "Sapphire",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(36,144),
Name = "Sapphire",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(36,162),
Name = "Sapphire",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(36,180),
Name = "Sapphire",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(36,198),
Name = "Sapphire",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(54,0),
Name = "Emerald",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(54,18),
Name = "Emerald",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(54,36),
Name = "Emerald",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(54,54),
Name = "Emerald",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(54,72),
Name = "Emerald",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(54,90),
Name = "Emerald",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(54,108),
Name = "Emerald",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(54,126),
Name = "Emerald",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(54,144),
Name = "Emerald",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(54,162),
Name = "Emerald",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(54,180),
Name = "Emerald",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(54,198),
Name = "Emerald",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(72,0),
Name = "Ruby",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(72,18),
Name = "Ruby",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(72,36),
Name = "Ruby",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(72,54),
Name = "Ruby",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(72,72),
Name = "Ruby",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(72,90),
Name = "Ruby",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(72,108),
Name = "Ruby",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(72,126),
Name = "Ruby",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(72,144),
Name = "Ruby",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(72,162),
Name = "Ruby",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(72,180),
Name = "Ruby",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(72,198),
Name = "Ruby",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(90,0),
Name = "Diamond",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(90,18),
Name = "Diamond",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(90,36),
Name = "Diamond",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(90,54),
Name = "Diamond",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(90,72),
Name = "Diamond",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(90,90),
Name = "Diamond",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(90,108),
Name = "Diamond",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(90,126),
Name = "Diamond",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(90,144),
Name = "Diamond",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(90,162),
Name = "Diamond",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(90,180),
Name = "Diamond",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(90,198),
Name = "Diamond",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(108,0),
Name = "Amber",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(108,18),
Name = "Amber",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Bottom,
Origin = new(108,36),
Name = "Amber",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(108,54),
Name = "Amber",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(108,72),
Name = "Amber",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Top,
Origin = new(108,90),
Name = "Amber",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(108,108),
Name = "Amber",
Variety = "C",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(108,126),
Name = "Amber",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Left,
Origin = new(108,144),
Name = "Amber",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(108,162),
Name = "Amber",
Variety = "A",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(108,180),
Name = "Amber",
Variety = "B",
},

new SpriteData()
{
TileType = 178,
Anchor = FrameAnchor.Right,
Origin = new(108,198),
Name = "Amber",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Name = "Green_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(0,18),
Name = "Green_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(0,36),
Name = "Green_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(0,54),
Name = "Green_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(0,72),
Name = "Green_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(0,90),
Name = "Green_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(0,108),
Name = "Green_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(0,126),
Name = "Green_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(0,144),
Name = "Green_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(0,162),
Name = "Green_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(0,180),
Name = "Green_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(0,198),
Name = "Green_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(22,0),
Name = "Brown_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(22,18),
Name = "Brown_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(22,36),
Name = "Brown_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(22,54),
Name = "Brown_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(22,72),
Name = "Brown_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(22,90),
Name = "Brown_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(22,108),
Name = "Brown_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(22,126),
Name = "Brown_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(22,144),
Name = "Brown_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(22,162),
Name = "Brown_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(22,180),
Name = "Brown_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(22,198),
Name = "Brown_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(44,0),
Name = "Red_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(44,18),
Name = "Red_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(44,36),
Name = "Red_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(44,54),
Name = "Red_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(44,72),
Name = "Red_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(44,90),
Name = "Red_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(44,108),
Name = "Red_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(44,126),
Name = "Red_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(44,144),
Name = "Red_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(44,162),
Name = "Red_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(44,180),
Name = "Red_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(44,198),
Name = "Red_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(66,0),
Name = "Blue_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(66,18),
Name = "Blue_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(66,36),
Name = "Blue_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(66,54),
Name = "Blue_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(66,72),
Name = "Blue_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(66,90),
Name = "Blue_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(66,108),
Name = "Blue_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(66,126),
Name = "Blue_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(66,144),
Name = "Blue_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(66,162),
Name = "Blue_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(66,180),
Name = "Blue_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(66,198),
Name = "Blue_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(88,0),
Name = "Purple_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(88,18),
Name = "Purple_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(88,36),
Name = "Purple_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(88,54),
Name = "Purple_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(88,72),
Name = "Purple_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(88,90),
Name = "Purple_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(88,108),
Name = "Purple_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(88,126),
Name = "Purple_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(88,144),
Name = "Purple_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(88,162),
Name = "Purple_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(88,180),
Name = "Purple_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(88,198),
Name = "Purple_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(110,0),
Name = "Lava_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(110,18),
Name = "Lava_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(110,36),
Name = "Lava_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(110,54),
Name = "Lava_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(110,72),
Name = "Lava_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(110,90),
Name = "Lava_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(110,108),
Name = "Lava_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(110,126),
Name = "Lava_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(110,144),
Name = "Lava_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(110,162),
Name = "Lava_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(110,180),
Name = "Lava_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(110,198),
Name = "Lava_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(132,0),
Name = "Krypton_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(132,18),
Name = "Krypton_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(132,36),
Name = "Krypton_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(132,54),
Name = "Krypton_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(132,72),
Name = "Krypton_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(132,90),
Name = "Krypton_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(132,108),
Name = "Krypton_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(132,126),
Name = "Krypton_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(132,144),
Name = "Krypton_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(132,162),
Name = "Krypton_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(132,180),
Name = "Krypton_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(132,198),
Name = "Krypton_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(154,0),
Name = "Xenon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(154,18),
Name = "Xenon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(154,36),
Name = "Xenon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(154,54),
Name = "Xenon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(154,72),
Name = "Xenon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(154,90),
Name = "Xenon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(154,108),
Name = "Xenon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(154,126),
Name = "Xenon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(154,144),
Name = "Xenon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(154,162),
Name = "Xenon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(154,180),
Name = "Xenon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(154,198),
Name = "Xenon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(176,0),
Name = "Argon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(176,18),
Name = "Argon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(176,36),
Name = "Argon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(176,54),
Name = "Argon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(176,72),
Name = "Argon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(176,90),
Name = "Argon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(176,108),
Name = "Argon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(176,126),
Name = "Argon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(176,144),
Name = "Argon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(176,162),
Name = "Argon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(176,180),
Name = "Argon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(176,198),
Name = "Argon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(198,0),
Name = "Neon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(198,18),
Name = "Neon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(198,36),
Name = "Neon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(198,54),
Name = "Neon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(198,72),
Name = "Neon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(198,90),
Name = "Neon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(198,108),
Name = "Neon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(198,126),
Name = "Neon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(198,144),
Name = "Neon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(198,162),
Name = "Neon_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(198,180),
Name = "Neon_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(198,198),
Name = "Neon_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(220,0),
Name = "Helium_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(220,18),
Name = "Helium_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Bottom,
Origin = new(220,36),
Name = "Helium_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(220,54),
Name = "Helium_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(220,72),
Name = "Helium_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Top,
Origin = new(220,90),
Name = "Helium_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(220,108),
Name = "Helium_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(220,126),
Name = "Helium_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Left,
Origin = new(220,144),
Name = "Helium_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(220,162),
Name = "Helium_Moss",
Variety = "A",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(220,180),
Name = "Helium_Moss",
Variety = "B",
},

new SpriteData()
{
TileType = 184,
Anchor = FrameAnchor.Right,
Origin = new(220,198),
Name = "Helium_Moss",
Variety = "C",
},

new SpriteData()
{
TileType = 185,
Name = "Small_Stone_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(18,0),
Name = "Small_Stone_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(36,0),
Name = "Small_Stone_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(54,0),
Name = "Small_Stone_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(72,0),
Name = "Small_Stone_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(90,0),
Name = "Small_Stone_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(108,0),
Name = "Small_Dirt_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(126,0),
Name = "Small_Dirt_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(144,0),
Name = "Small_Dirt_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(162,0),
Name = "Small_Dirt_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(180,0),
Name = "Small_Dirt_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(198,0),
Name = "Small_Dirt_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(216,0),
Name = "Skull_Right",
},

new SpriteData()
{
TileType = 185,
Origin = new(234,0),
Name = "Skull_Down",
},

new SpriteData()
{
TileType = 185,
Origin = new(252,0),
Name = "Skull_Up",
},

new SpriteData()
{
TileType = 185,
Origin = new(270,0),
Name = "Skull_Crushed",
},

new SpriteData()
{
TileType = 185,
Origin = new(288,0),
Name = "Bone_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(306,0),
Name = "Bone_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(324,0),
Name = "Bone_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(342,0),
Name = "Bone_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(360,0),
Name = "Gore_Skull_Up",
},

new SpriteData()
{
TileType = 185,
Origin = new(378,0),
Name = "Gore_Skull_Down",
},

new SpriteData()
{
TileType = 185,
Origin = new(396,0),
Name = "Gore_Skull_left",
},

new SpriteData()
{
TileType = 185,
Origin = new(414,0),
Name = "Gore_Skull_Crushed",
},

new SpriteData()
{
TileType = 185,
Origin = new(432,0),
Name = "Gore_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(450,0),
Name = "Gore_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(468,0),
Name = "Gore_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(486,0),
Name = "Gore_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(504,0),
Name = "Broken_Tool_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(522,0),
Name = "Broken_Tool_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(540,0),
Name = "Broken_Tool_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(558,0),
Name = "Broken_Tool_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(576,0),
Name = "Broken_Tool_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(594,0),
Name = "Broken_Tool_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(612,0),
Name = "Broken_Tool_G",
},

new SpriteData()
{
TileType = 185,
Origin = new(630,0),
Name = "Broken_Tool_H",
},

new SpriteData()
{
TileType = 185,
Origin = new(648,0),
Name = "Snowy_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(666,0),
Name = "Snowy_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(684,0),
Name = "Snowy_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(702,0),
Name = "Snowy_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(720,0),
Name = "Snowy_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(738,0),
Name = "Snowy_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(756,0),
Name = "Icy_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(774,0),
Name = "Icy_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(792,0),
Name = "Icy_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(810,0),
Name = "Icy_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(828,0),
Name = "Icy_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(846,0),
Name = "Icy_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(864,0),
Name = "Spider_Eggs_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(882,0),
Name = "Spider_Eggs_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(900,0),
Name = "Spider_Eggs_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(918,0),
Name = "Spider_Eggs_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(936,0),
Name = "Spider_Eggs_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(954,0),
Name = "Spider_Eggs_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(972,0),
Name = "Sandstone_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(990,0),
Name = "Sandstone_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(1008,0),
Name = "Sandstone_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(1026,0),
Name = "Sandstone_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(1044,0),
Name = "Sandstone_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(1062,0),
Name = "Sandstone_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(1080,0),
Name = "Granite_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(1098,0),
Name = "Granite_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(1116,0),
Name = "Granite_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(1134,0),
Name = "Granite_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(1152,0),
Name = "Granite_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(1170,0),
Name = "Granite_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(1188,0),
Name = "Marble_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(1206,0),
Name = "Marble_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(1224,0),
Name = "Marble_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(1242,0),
Name = "Marble_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(1260,0),
Name = "Marble_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(1278,0),
Name = "Marble_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(0,18),
Name = "Stone_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(36,18),
Name = "Stone_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(72,18),
Name = "Stone_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(108,18),
Name = "Stone_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(144,18),
Name = "Stone_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(180,18),
Name = "Stone_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(216,18),
Name = "Skeleton_Left",
},

new SpriteData()
{
TileType = 185,
Origin = new(252,18),
Name = "Skeleton_Right",
},

new SpriteData()
{
TileType = 185,
Origin = new(288,18),
Name = "Bone_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(324,18),
Name = "Bone_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(360,18),
Name = "Bone_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(396,18),
Name = "Gore_Skeleton_Left",
},

new SpriteData()
{
TileType = 185,
Origin = new(432,18),
Name = "Gore_Skeleton_Right",
},

new SpriteData()
{
TileType = 185,
Origin = new(468,18),
Name = "Gore_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(504,18),
Name = "Gore_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(540,18),
Name = "Gore_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(576,18),
Name = "Copper_Pile",
},

new SpriteData()
{
TileType = 185,
Origin = new(612,18),
Name = "Sliver_Pile",
},

new SpriteData()
{
TileType = 185,
Origin = new(648,18),
Name = "Gold_Pile",
},

new SpriteData()
{
TileType = 185,
Origin = new(684,18),
Name = "Amethyst_Pile",
},

new SpriteData()
{
TileType = 185,
Origin = new(720,18),
Name = "Topaz_Pile",
},

new SpriteData()
{
TileType = 185,
Origin = new(756,18),
Name = "Sapphire_Pile",
},

new SpriteData()
{
TileType = 185,
Origin = new(792,18),
Name = "Emerald_Pile",
},

new SpriteData()
{
TileType = 185,
Origin = new(828,18),
Name = "Ruby_Pile",
},

new SpriteData()
{
TileType = 185,
Origin = new(864,18),
Name = "Diamond_Pile",
},

new SpriteData()
{
TileType = 185,
Origin = new(900,18),
Name = "Ice_Junk_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(936,18),
Name = "Ice_Junk_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(972,18),
Name = "Ice_Junk_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(1008,18),
Name = "Ice_Junk_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(1044,18),
Name = "Ice_Junk_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(1080,18),
Name = "Ice_Junk_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(1116,18),
Name = "Debris_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(1152,18),
Name = "Debris_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(1188,18),
Name = "Debris_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(1224,18),
Name = "Spider_Egg_Pile_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(1260,18),
Name = "Spider_Egg_Pile_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(1296,18),
Name = "Spider_Egg_Pile_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(1332,18),
Name = "Spider_Egg_Pile_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(1368,18),
Name = "Stony_Moss_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(1404,18),
Name = "Stony_Moss_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(1440,18),
Name = "Stony_Moss_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(1476,18),
Name = "Sandstone_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(1512,18),
Name = "Sandstone_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(1548,18),
Name = "Sandstone_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(1584,18),
Name = "Sandstone_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(1620,18),
Name = "Sandstone_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(1656,18),
Name = "Sandstone_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(1692,18),
Name = "Granite_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(1728,18),
Name = "Granite_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(1764,18),
Name = "Granite_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(1800,18),
Name = "Granite_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(1836,18),
Name = "Granite_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(1872,18),
Name = "Granite_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(1908,18),
Name = "Marble_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(1944,18),
Name = "Marble_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(1980,18),
Name = "Marble_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(2016,18),
Name = "Marble_D",
},

new SpriteData()
{
TileType = 185,
Origin = new(2052,18),
Name = "Marble_E",
},

new SpriteData()
{
TileType = 185,
Origin = new(2088,18),
Name = "Marble_F",
},

new SpriteData()
{
TileType = 185,
Origin = new(2124,18),
Name = "Living_Wood_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(2160,18),
Name = "Living_Wood_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(2196,18),
Name = "Living_Wood_C",
},

new SpriteData()
{
TileType = 185,
Origin = new(2232,18),
Name = "Sand_A",
},

new SpriteData()
{
TileType = 185,
Origin = new(2268,18),
Name = "Sand_B",
},

new SpriteData()
{
TileType = 185,
Origin = new(2304,18),
Name = "Sand_C",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Name = "Bones_A",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(54,0),
Name = "Bones_B",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(108,0),
Name = "Bones_C",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(162,0),
Name = "Bones_D",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(216,0),
Name = "Bones_E",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(270,0),
Name = "Bones_F",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(324,0),
Name = "Sword_Bones",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(378,0),
Name = "Rocks_A",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(432,0),
Name = "Rocks_B",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(486,0),
Name = "Rocks_C",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(540,0),
Name = "Rocks_D",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(594,0),
Name = "Rocks_E",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(648,0),
Name = "Rocks_F",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(702,0),
Name = "Rocks_G",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(756,0),
Name = "Rocks_Pick",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(810,0),
Name = "Rocks_Sword",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(864,0),
Name = "Copper_Pile_A",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(918,0),
Name = "Copper_Pile_B",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(972,0),
Name = "Silver_Pile_A",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1026,0),
Name = "Silver_Pile_B",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1080,0),
Name = "Gold_Pile_A",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1134,0),
Name = "Gold_Pile_B",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1188,0),
Name = "Broken_Machine_A",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1242,0),
Name = "Broken_Machine_B",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1296,0),
Name = "Broken_Chest",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1350,0),
Name = "Broken_Candelabra",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1404,0),
Name = "Frozen_A",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1458,0),
Name = "Frozen_B",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1512,0),
Name = "Frozen_C",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1566,0),
Name = "Frozen_D",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1620,0),
Name = "Frozen_E",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1674,0),
Name = "Frozen_F",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1728,0),
Name = "Mushroom_A",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1782,0),
Name = "Mushroom_B",
},

new SpriteData()
{
TileType = 186,
Size = new(3,2),
Origin = new(1836,0),
Name = "Mushroom_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Name = "Jungle_Stone_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(54,0),
Name = "Jungle_Stone_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(108,0),
Name = "Jungle_Stone_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(162,0),
Name = "Jungle_Stone_D",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(216,0),
Name = "Jungle_Stone_E",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(270,0),
Name = "Jungle_Stone_F",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(324,0),
Name = "Corrupt_Stone_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(378,0),
Name = "Corrupt_Stone_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(432,0),
Name = "Corrupt_Stone_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(486,0),
Name = "Webbed_Stone_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(540,0),
Name = "Webbed_Stone_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(594,0),
Name = "Webbed_Stone_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(648,0),
Name = "Cocoon_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(702,0),
Name = "Cocoon_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(756,0),
Name = "Mossy_Stone_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(810,0),
Name = "Mossy_Stone_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(864,0),
Name = "Mossy_Stone_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(918,0),
Name = "Enchanted_Sword",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(972,0),
Name = "Lihzahrd_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1026,0),
Name = "Lihzahrd_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1080,0),
Name = "Lihzahrd_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1134,0),
Name = "Cage_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1188,0),
Name = "Cage_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1242,0),
Name = "Minecart",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1296,0),
Name = "Cave_In",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1350,0),
Name = "Dirt_Pile",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1404,0),
Name = "Abandoned_Tent",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1458,0),
Name = "Wheelbarrow",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1512,0),
Name = "Peg",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1566,0),
Name = "Sandstone_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1620,0),
Name = "Sandstone_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1674,0),
Name = "Sandstone_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1728,0),
Name = "Sandstone_D",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1782,0),
Name = "Sandstone_E",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1836,0),
Name = "Sandstone_F",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1890,0),
Name = "Granite_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1944,0),
Name = "Granite_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(1998,0),
Name = "Granite_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2052,0),
Name = "Granite_D",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2106,0),
Name = "Granite_E",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2160,0),
Name = "Granite_F",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2214,0),
Name = "Marble_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2268,0),
Name = "Marble_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2322,0),
Name = "Marble_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2376,0),
Name = "Marble_D",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2430,0),
Name = "Marble_E",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2484,0),
Name = "Marble_F",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2538,0),
Name = "Living_Wood_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2592,0),
Name = "Living_Wood_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2646,0),
Name = "Living_Wood_C",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2700,0),
Name = "Living_Leaf_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2754,0),
Name = "Living_Leaf_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2808,0),
Name = "Animal_Skull_A",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2862,0),
Name = "Animal_Skull_B",
},

new SpriteData()
{
TileType = 187,
Size = new(3,2),
Origin = new(2916,0),
Name = "Animal_Skull_C",
},

new SpriteData()
{
TileType = 201,
Name = "Grass_Three_Blades",
},

new SpriteData()
{
TileType = 201,
Origin = new(18,0),
Name = "Grass_Two_Blades",
},

new SpriteData()
{
TileType = 201,
Origin = new(36,0),
Name = "Grass_Hooked",
},

new SpriteData()
{
TileType = 201,
Origin = new(54,0),
Name = "Grass_Short",
},

new SpriteData()
{
TileType = 201,
Origin = new(72,0),
Name = "Grass_Thick_A",
},

new SpriteData()
{
TileType = 201,
Origin = new(90,0),
Name = "Grass_Fleshy_A",
},

new SpriteData()
{
TileType = 201,
Origin = new(108,0),
Name = "Grass_Sparse",
},

new SpriteData()
{
TileType = 201,
Origin = new(126,0),
Name = "Grass_Fleshy_B",
},

new SpriteData()
{
TileType = 201,
Origin = new(144,0),
Name = "Grass_Thick_B",
},

new SpriteData()
{
TileType = 201,
Origin = new(162,0),
Name = "Grass_Thick_C",
},

new SpriteData()
{
TileType = 201,
Origin = new(180,0),
Name = "Grass_Fleshy_C",
},

new SpriteData()
{
TileType = 201,
Origin = new(198,0),
Name = "Grass_Thick_D",
},

new SpriteData()
{
TileType = 201,
Origin = new(216,0),
Name = "Grass_Thick_E",
},

new SpriteData()
{
TileType = 201,
Origin = new(234,0),
Name = "Grass_Thick_F",
},

new SpriteData()
{
TileType = 201,
Origin = new(252,0),
Name = "Grass_Thick_G",
},

new SpriteData()
{
TileType = 201,
Origin = new(270,0),
Name = "Vile_Mushroom",
},

new SpriteData()
{
TileType = 201,
Origin = new(288,0),
Name = "Flower_A",
},

new SpriteData()
{
TileType = 201,
Origin = new(306,0),
Name = "Flower_B",
},

new SpriteData()
{
TileType = 201,
Origin = new(324,0),
Name = "Flower_C",
},

new SpriteData()
{
TileType = 201,
Origin = new(342,0),
Name = "Flower_D",
},

new SpriteData()
{
TileType = 201,
Origin = new(360,0),
Name = "Flower_E",
},

new SpriteData()
{
TileType = 201,
Origin = new(378,0),
Name = "Flower_F",
},

new SpriteData()
{
TileType = 201,
Origin = new(396,0),
Name = "Flower_G",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Name = "Pure_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(0,72),
Name = "Pure_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(36,0),
Name = "Desert_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(36,72),
Name = "Desert_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(72,0),
Name = "Jungle_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(72,72),
Name = "Jungle_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(108,0),
Name = "Icy_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(108,72),
Name = "Icy_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(144,0),
Name = "Corrupt_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(144,72),
Name = "Corrupt_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(180,0),
Name = "Crimson_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(180,72),
Name = "Crimson_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(216,0),
Name = "Hallowed_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(216,72),
Name = "Hallowed_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(252,0),
Name = "Blood_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(252,72),
Name = "Blood_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(288,0),
Name = "Cavern_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(288,72),
Name = "Cavern_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(324,0),
Name = "Oasis_Water_Fountain",
Variety = "Off",
},

new SpriteData()
{
TileType = 207,
Size = new(2,4),
Origin = new(324,72),
Name = "Oasis_Water_Fountain",
Variety = "On",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Name = "Cannon",
Variety = "0_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(0,54),
Name = "Cannon",
Variety = "22.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(0,108),
Name = "Cannon",
Variety = "45_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(0,162),
Name = "Cannon",
Variety = "67.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(0,216),
Name = "Cannon",
Variety = "90_deg_Elevation",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(0,270),
Name = "Cannon",
Variety = "67.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(0,324),
Name = "Cannon",
Variety = "45_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(0,378),
Name = "Cannon",
Variety = "22.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(0,432),
Name = "Cannon",
Variety = "0_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(72,0),
Name = "Bunny_Cannon",
Variety = "0_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(72,54),
Name = "Bunny_Cannon",
Variety = "22.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(72,108),
Name = "Bunny_Cannon",
Variety = "45_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(72,162),
Name = "Bunny_Cannon",
Variety = "67.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(72,216),
Name = "Bunny_Cannon",
Variety = "90_deg_Elevation",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(72,270),
Name = "Bunny_Cannon",
Variety = "67.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(72,324),
Name = "Bunny_Cannon",
Variety = "45_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(72,378),
Name = "Bunny_Cannon",
Variety = "22.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(72,432),
Name = "Bunny_Cannon",
Variety = "0_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(144,0),
Name = "Confetti_Cannon",
Variety = "0_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(144,54),
Name = "Confetti_Cannon",
Variety = "22.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(144,108),
Name = "Confetti_Cannon",
Variety = "45_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(144,162),
Name = "Confetti_Cannon",
Variety = "67.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(144,216),
Name = "Confetti_Cannon",
Variety = "90_deg_Elevation",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(144,270),
Name = "Confetti_Cannon",
Variety = "67.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(144,324),
Name = "Confetti_Cannon",
Variety = "45_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(144,378),
Name = "Confetti_Cannon",
Variety = "22.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(144,432),
Name = "Confetti_Cannon",
Variety = "0_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(216,0),
Name = "Portal_Gun_Station",
Variety = "Blue_Portal_0_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(216,54),
Name = "Portal_Gun_Station",
Variety = "Blue_Portal_22.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(216,108),
Name = "Portal_Gun_Station",
Variety = "Blue_Portal_45_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(216,162),
Name = "Portal_Gun_Station",
Variety = "Blue_Portal_67.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(216,216),
Name = "Portal_Gun_Station",
Variety = "Blue_Portal_90_deg_Elevation",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(216,270),
Name = "Portal_Gun_Station",
Variety = "Blue_Portal_67.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(216,324),
Name = "Portal_Gun_Station",
Variety = "Blue_Portal_45_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(216,378),
Name = "Portal_Gun_Station",
Variety = "Blue_Portal_22.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(216,432),
Name = "Portal_Gun_Station",
Variety = "Blue_Portal_0_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(288,0),
Name = "Portal_Gun_Station",
Variety = "Orange_Portal_0_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(288,54),
Name = "Portal_Gun_Station",
Variety = "Orange_Portal_22.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(288,108),
Name = "Portal_Gun_Station",
Variety = "Orange_Portal_45_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(288,162),
Name = "Portal_Gun_Station",
Variety = "Orange_Portal_67.5_deg_Right",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(288,216),
Name = "Portal_Gun_Station",
Variety = "Orange_Portal_90_deg_Elevation",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(288,270),
Name = "Portal_Gun_Station",
Variety = "Orange_Portal_67.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(288,324),
Name = "Portal_Gun_Station",
Variety = "Orange_Portal_45_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(288,378),
Name = "Portal_Gun_Station",
Variety = "Orange_Portal_22.5_deg_Left",
},

new SpriteData()
{
TileType = 209,
Size = new(4,3),
Origin = new(288,432),
Name = "Portal_Gun_Station",
Variety = "Orange_Portal_0_deg_Left",
},

new SpriteData()
{
TileType = 210,
},

new SpriteData()
{
TileType = 212,
Anchor = FrameAnchor.Left,
Size = new(3,3),
},

new SpriteData()
{
TileType = 212,
Anchor = FrameAnchor.Right,
Size = new(3,3),
Origin = new(54,0),
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Name = "Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(0,288),
Name = "Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(54,0),
Name = "Cursed_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(54,288),
Name = "Cursed_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(108,0),
Name = "Demon_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(108,288),
Name = "Demon_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(162,0),
Name = "Frozen_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(162,288),
Name = "Frozen_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(216,0),
Name = "Ichor_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(216,288),
Name = "Ichor_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(270,0),
Name = "Rainbow_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(270,288),
Name = "Rainbow_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(324,0),
Name = "Ultrabright_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(324,288),
Name = "Ultrabright_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(378,0),
Name = "Bone_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(378,288),
Name = "Bone_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(432,0),
Name = "Desert_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(432,288),
Name = "Desert_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(486,0),
Name = "Coral_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(486,288),
Name = "Coral_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(540,0),
Name = "Corrupt_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(540,288),
Name = "Corrupt_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(594,0),
Name = "Crimson_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(594,288),
Name = "Crimson_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(648,0),
Name = "Hallowed_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(648,288),
Name = "Hallowed_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(702,0),
Name = "Jungle_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(702,288),
Name = "Jungle_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(756,0),
Name = "Mushroom_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(756,288),
Name = "Mushroom_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(810,0),
Name = "Aether_Campfire",
Variety = "Lit",
},

new SpriteData()
{
TileType = 215,
Size = new(3,2),
Origin = new(810,288),
Name = "Aether_Campfire",
Variety = "Unlit",
},

new SpriteData()
{
TileType = 216,
Size = new(1,2),
Name = "Rocket",
Variety = "Red_Rocket",
},

new SpriteData()
{
TileType = 216,
Size = new(1,2),
Origin = new(0,40),
Name = "Rocket",
Variety = "Green_Rocket",
},

new SpriteData()
{
TileType = 216,
Size = new(1,2),
Origin = new(0,80),
Name = "Rocket",
Variety = "Blue_Rocket",
},

new SpriteData()
{
TileType = 216,
Size = new(1,2),
Origin = new(0,120),
Name = "Rocket",
Variety = "Yellow_Rocket",
},

new SpriteData()
{
TileType = 217,
Size = new(3,2),
},

new SpriteData()
{
TileType = 218,
Size = new(3,2),
},

new SpriteData()
{
TileType = 219,
Size = new(3,3),
},

new SpriteData()
{
TileType = 220,
Size = new(3,3),
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Name = "Teal_Mushroom",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(34,0),
Name = "Green_Mushroom",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(68,0),
Name = "Sky_Blue_Flower",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(102,0),
Name = "Yellow_Marigold",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(136,0),
Name = "Blue_Berries",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(170,0),
Name = "Lime_Kelp",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(204,0),
Name = "Pink_Prickly_Pear",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Top,
Origin = new(238,0),
Name = "Orange_Bloodroot",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(272,0),
Name = "Strange_Plant",
Variety = "A",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(306,0),
Name = "Strange_Plant",
Variety = "B",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(340,0),
Name = "Strange_Plant",
Variety = "C",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(374,0),
Name = "Strange_Plant",
Variety = "D",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(408,0),
Name = "Corrupt_Pink_Prickly_Pear_(USE_PURE_PEAR_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(442,0),
Name = "Crimson_Pink_Prickly_Pear_(USE_PURE_PEAR_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 227,
Anchor = FrameAnchor.Bottom,
Origin = new(476,0),
Name = "Hallow_Pink_Prickly_Pear_(USE_PURE_PEAR_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 228,
Size = new(3,3),
},

new SpriteData()
{
TileType = 231,
Size = new(3,3),
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Name = "3x2_A",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(54,0),
Name = "3x2_B",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(108,0),
Name = "3x2_C",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(162,0),
Name = "3x2_D",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(216,0),
Name = "3x2_E",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(270,0),
Name = "3x2_F",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(324,0),
Name = "3x2_G",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(378,0),
Name = "3x2_H",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(432,0),
Name = "3x2_I",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(0,36),
Name = "2x2_A",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(36,36),
Name = "2x2_B",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(72,36),
Name = "2x2_C",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(108,36),
Name = "2x2_D",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(144,36),
Name = "2x2_E",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(180,36),
Name = "2x2_F",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(216,36),
Name = "2x2_G",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(252,36),
Name = "2x2_H",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(288,36),
Name = "2x2_I",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(324,36),
Name = "2x2_J",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(360,36),
Name = "2x2_K",
},

new SpriteData()
{
TileType = 233,
Size = new(3,2),
Origin = new(396,36),
Name = "2x2_L",
},

new SpriteData()
{
TileType = 235,
Size = new(3,1),
},

new SpriteData()
{
TileType = 236,
Size = new(2,2),
Name = "A",
},

new SpriteData()
{
TileType = 236,
Size = new(2,2),
Origin = new(36,0),
Name = "B",
},

new SpriteData()
{
TileType = 236,
Size = new(2,2),
Origin = new(72,0),
Name = "C",
},

new SpriteData()
{
TileType = 237,
Size = new(3,2),
},

new SpriteData()
{
TileType = 238,
Size = new(2,2),
},

new SpriteData()
{
TileType = 239,
Name = "Copper_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(18,0),
Name = "Tin_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(36,0),
Name = "Iron_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(54,0),
Name = "Lead_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(72,0),
Name = "Silver_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(90,0),
Name = "Tungsten_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(108,0),
Name = "Gold_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(126,0),
Name = "Platinum_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(144,0),
Name = "Demonite_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(162,0),
Name = "Meteorite_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(180,0),
Name = "Hellstone_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(198,0),
Name = "Cobalt_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(216,0),
Name = "Palladium_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(234,0),
Name = "Mythril_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(252,0),
Name = "Orichalcum_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(270,0),
Name = "Adamantite_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(288,0),
Name = "Titanium_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(306,0),
Name = "Chlorophyte_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(324,0),
Name = "Hallowed_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(342,0),
Name = "Crimtane_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(360,0),
Name = "Shroomite_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(378,0),
Name = "Spectre_Bar",
},

new SpriteData()
{
TileType = 239,
Origin = new(396,0),
Name = "Luminite_Bar",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Name = "Boss_Trophy",
Variety = "Eye_of_Cthulhu",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(54,0),
Name = "Boss_Trophy",
Variety = "Eater_of_Worlds",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(108,0),
Name = "Boss_Trophy",
Variety = "Brain_of_Cthulhu",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(162,0),
Name = "Boss_Trophy",
Variety = "Skeletron",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(216,0),
Name = "Boss_Trophy",
Variety = "Queen_Bee",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(270,0),
Name = "Boss_Trophy",
Variety = "Wall_of_Flesh",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(324,0),
Name = "Boss_Trophy",
Variety = "Destroyer",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(378,0),
Name = "Boss_Trophy",
Variety = "Skeletron_Prime",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(432,0),
Name = "Boss_Trophy",
Variety = "Retinazer",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(486,0),
Name = "Boss_Trophy",
Variety = "Spazmatism",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(540,0),
Name = "Boss_Trophy",
Variety = "Plantera",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(594,0),
Name = "Boss_Trophy",
Variety = "Golem",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(648,0),
Name = "Painting",
Variety = "Blood_Moon_Rising",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(702,0),
Name = "Painting",
Variety = "The_Hanged_Man",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(756,0),
Name = "Painting",
Variety = "Glory_of_the_Fire",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(810,0),
Name = "Painting",
Variety = "Bone_Warp",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(864,0),
Name = "Hanging",
Variety = "Wall_Skeleton",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(918,0),
Name = "Hanging",
Variety = "Hanging_Skeleton",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(972,0),
Name = "Painting",
Variety = "Skellington_J_Skellingsworth",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1026,0),
Name = "Painting",
Variety = "The_Cursed_Man",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1080,0),
Name = "Painting",
Variety = "Sunflowers",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1134,0),
Name = "Painting",
Variety = "Terrarian_Gothic",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1188,0),
Name = "Painting",
Variety = "Guide_Picasso",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1242,0),
Name = "Painting",
Variety = "The_Guardian's_Gaze",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1296,0),
Name = "Painting",
Variety = "Father_of_Someone",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1350,0),
Name = "Painting",
Variety = "Nurse_Lisa",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1404,0),
Name = "Painting",
Variety = "Discover",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1458,0),
Name = "Painting",
Variety = "Hand_Earth",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1512,0),
Name = "Painting",
Variety = "Old_Miner",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1566,0),
Name = "Painting",
Variety = "Skelehead",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1620,0),
Name = "Painting",
Variety = "Imp_Face",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1674,0),
Name = "Painting",
Variety = "Ominous_Presence",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1728,0),
Name = "Painting",
Variety = "Shining_Moon",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1782,0),
Name = "Painting",
Variety = "The_Merchant",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1836,0),
Name = "Painting",
Variety = "Crowno_Devours_His_Lunch",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1890,0),
Name = "Painting",
Variety = "Rare_Enchantment",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(0,54),
Name = "Boss_Trophy",
Variety = "Mourning_Wood_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(54,54),
Name = "Boss_Trophy",
Variety = "Pumpking_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(108,54),
Name = "Boss_Trophy",
Variety = "Ice_Queen_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(162,54),
Name = "Boss_Trophy",
Variety = "Santa-NK1_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(216,54),
Name = "Boss_Trophy",
Variety = "Everscream_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(270,54),
Name = "Rack",
Variety = "Blacksmith_Rack",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(324,54),
Name = "Rack",
Variety = "Carpentry_Rack",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(378,54),
Name = "Rack",
Variety = "Helmet_Rack",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(432,54),
Name = "Rack",
Variety = "Spear_Rack",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(486,54),
Name = "Rack",
Variety = "Sword_Rack",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(540,54),
Name = "Hanging",
Variety = "Life_Preserver",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(594,54),
Name = "Hanging",
Variety = "Ship's_Wheel",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(648,54),
Name = "Hanging",
Variety = "Compass_Rose",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(702,54),
Name = "Hanging",
Variety = "Wall_Anchor",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(756,54),
Name = "Fishing_Trophy",
Variety = "Goldfish_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(810,54),
Name = "Fishing_Trophy",
Variety = "Bunnyfish_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(864,54),
Name = "Fishing_Trophy",
Variety = "Swordfish_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(918,54),
Name = "Fishing_Trophy",
Variety = "Sharkteeth_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(972,54),
Name = "Boss_Trophy",
Variety = "King_Slime_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1026,54),
Name = "Boss_Trophy",
Variety = "Duke_Fishron_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1080,54),
Name = "Boss_Trophy",
Variety = "Ancient_Cultist_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1134,54),
Name = "Boss_Trophy",
Variety = "Martian_Saucer_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1188,54),
Name = "Boss_Trophy",
Variety = "Flying_Dutchman_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1242,54),
Name = "Boss_Trophy",
Variety = "Moon_Lord_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1295,54),
Name = "Boss_Trophy",
Variety = "Betsy_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1350,54),
Name = "Boss_Trophy",
Variety = "Dark_Mage_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1404,54),
Name = "Boss_Trophy",
Variety = "Ogre_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1458,54),
Name = "Painting",
Variety = "Andrew_Sphinx",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1512,54),
Name = "Painting",
Variety = "Watchful_Antlion",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1566,54),
Name = "Painting",
Variety = "Burning_Spirit",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1620,54),
Name = "Painting",
Variety = "Jaws_of_Death",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1674,54),
Name = "Painting",
Variety = "The_Sands_of_Slime",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1728,54),
Name = "Painting",
Variety = "Snakes,_I_Hate_Snakes",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1782,54),
Name = "Painting",
Variety = "Fore!",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1836,54),
Name = "Painting",
Variety = "Nevermore",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1890,54),
Name = "Painting",
Variety = "Reborn",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(0,108),
Name = "Boss_Trophy",
Variety = "Empress_of_Light_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(54,108),
Name = "Boss_Trophy",
Variety = "Queen_Slime_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(108,108),
Name = "Painting",
Variety = "Dark_Side_of_the_Hallow",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(162,108),
Name = "Boss_Trophy",
Variety = "Deerclops_Trophy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(216,108),
Name = "Painting",
Variety = "Outcast",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(270,108),
Name = "Painting",
Variety = "Fairy_Guides",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(324,108),
Name = "Painting",
Variety = "A_Horrible_Night_for_Alchemy",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(378,108),
Name = "Painting",
Variety = "Morning_Hunt",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(432,108),
Name = "Painting",
Variety = "Suspiciously_Sparkly",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(486,108),
Name = "Painting",
Variety = "Requiem",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(540,108),
Name = "Painting",
Variety = "Cat_Sword",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(594,108),
Name = "Painting",
Variety = "Kargoh's_Summon",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(648,108),
Name = "Painting",
Variety = "High_Pitch",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(702,108),
Name = "Painting",
Variety = "A_Machine_for_Terrarians",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(756,108),
Name = "Painting",
Variety = "Terra_Blade_Chronicles",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(810,108),
Name = "Painting",
Variety = "Benny_Warhol",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(864,108),
Name = "Painting",
Variety = "Lizard_King",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(918,108),
Name = "Painting",
Variety = "My_Son",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(972,108),
Name = "Painting",
Variety = "Duality",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1026,108),
Name = "Painting",
Variety = "Parsec_Pals",
},

new SpriteData()
{
TileType = 240,
Size = new(3,3),
Origin = new(1080,108),
Name = "Painting",
Variety = "Eye_of_the_Sun",
},

new SpriteData()
{
TileType = 241,
Size = new(4,3),
Name = "A",
},

new SpriteData()
{
TileType = 241,
Size = new(4,3),
Origin = new(0,54),
Name = "B",
},

new SpriteData()
{
TileType = 241,
Size = new(4,3),
Origin = new(0,108),
Name = "C",
},

new SpriteData()
{
TileType = 241,
Size = new(4,3),
Origin = new(0,162),
Name = "D",
},

new SpriteData()
{
TileType = 241,
Size = new(4,3),
Origin = new(0,216),
Name = "E",
},

new SpriteData()
{
TileType = 241,
Size = new(4,3),
Origin = new(0,270),
Name = "F",
},

new SpriteData()
{
TileType = 241,
Size = new(4,3),
Origin = new(0,324),
Name = "G",
},

new SpriteData()
{
TileType = 241,
Size = new(4,3),
Origin = new(0,378),
Name = "H",
},

new SpriteData()
{
TileType = 241,
Size = new(4,3),
Origin = new(0,432),
Name = "I",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Name = "Painting",
Variety = "The_Eye_Sees_the_End",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,72),
Name = "Painting",
Variety = "Something_Evil_is_Watching_You",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,144),
Name = "Painting",
Variety = "The_Twins_Have_Awoken",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,216),
Name = "Painting",
Variety = "The_Screamer",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,288),
Name = "Painting",
Variety = "Goblins_Playing_Poker",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,360),
Name = "Painting",
Variety = "Dryadisque",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,432),
Name = "Painting",
Variety = "Impact",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,504),
Name = "Painting",
Variety = "Powered_by_Birds",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,576),
Name = "Painting",
Variety = "The_Destroyer",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,648),
Name = "Painting",
Variety = "The_Persistency_of_Eyes",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,720),
Name = "Painting",
Variety = "Unicorn_Crossing_the_Hallows",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,792),
Name = "Painting",
Variety = "Great_Wave",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,864),
Name = "Painting",
Variety = "Starry_Night",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,936),
Name = "Painting",
Variety = "Facing_the_Cerebral_Mastermind",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1008),
Name = "Painting",
Variety = "Lake_of_Fire",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1080),
Name = "Painting",
Variety = "Trio_Super_Heroes",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1152),
Name = "Painting",
Variety = "The_Creation_of_the_Guide",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1224),
Name = "Painting",
Variety = "Jacking_Skeletron",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1296),
Name = "Painting",
Variety = "Bitter_Harvest",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1368),
Name = "Painting",
Variety = "Blood_Moon_Countess",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1440),
Name = "Painting",
Variety = "Hallow's_Eve",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1512),
Name = "Painting",
Variety = "Morbid_Curiosity",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1584),
Name = "Hanging",
Variety = "Tiger_Skin",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1656),
Name = "Hanging",
Variety = "Leopard_Skin",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1728),
Name = "Hanging",
Variety = "Zebra_Skin",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1800),
Name = "Hanging",
Variety = "Treasure_Map",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(0,1872),
Name = "Painting",
Variety = "Pillagin_Me_Pixels",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,0),
Name = "Painting",
Variety = "Castle_Marsberg",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,72),
Name = "Painting",
Variety = "Martia_Lisa",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,144),
Name = "Painting",
Variety = "The_Truth_Is_Up_There",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,216),
Name = "Painting",
Variety = "Sparky",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,288),
Name = "Painting",
Variety = "Acorns",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,360),
Name = "Painting",
Variety = "Cold_Snap",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,432),
Name = "Painting",
Variety = "Cursed_Saint",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,504),
Name = "Painting",
Variety = "Snowfellas",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,576),
Name = "Painting",
Variety = "The_Season",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,648),
Name = "Painting",
Variety = "Not_a_Kid,_nor_a_Squid",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,720),
Name = "Painting",
Variety = "Life_Above_the_Sand",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,792),
Name = "Painting",
Variety = "Oasis",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,864),
Name = "Painting",
Variety = "Prehistory_Preserved",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,936),
Name = "Painting",
Variety = "Ancient_Tablet",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1008),
Name = "Painting",
Variety = "Uluru",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1080),
Name = "Painting",
Variety = "Visiting_the_Pyramids",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1152),
Name = "Painting",
Variety = "The_Rolling_Greens",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1224),
Name = "Painting",
Variety = "Graveyard",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1296),
Name = "Painting",
Variety = "Princess_64",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1368),
Name = "Painting",
Variety = "The_Gentleman_Scientist",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1440),
Name = "Painting",
Variety = "The_Firestarter",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1512),
Name = "Painting",
Variety = "The_Bereaved",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1584),
Name = "Hanging",
Variety = "The_Strongman",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1656),
Name = "Hanging",
Variety = "Remnants_of_Devotion",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1728),
Name = "Hanging",
Variety = "Not_So_Lost_In_Paradise",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1800),
Name = "Hanging",
Variety = "Ocular_Resonance",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(108,1872),
Name = "Painting",
Variety = "Wings_of_Evil",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,0),
Name = "Painting",
Variety = "Constellation",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,72),
Name = "Painting",
Variety = "Eyezorhead",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,144),
Name = "Painting",
Variety = "Dread_of_the_Red_Sea",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,216),
Name = "Painting",
Variety = "Do_Not_Eat_the_Vile_Mushroom!",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,288),
Name = "Painting",
Variety = "Yuuma,_The_Blue_Tiger",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,360),
Name = "Painting",
Variety = "Moonman_&_Company",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,432),
Name = "Painting",
Variety = "Sunshine_of_Israpony",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,504),
Name = "Painting",
Variety = "Purity",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,576),
Name = "Painting",
Variety = "Lady_Of_The_Lake",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,648),
Name = "Painting",
Variety = "r/Terraria",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,720),
Name = "Painting",
Variety = "Princess_Style",
},

new SpriteData()
{
TileType = 242,
Size = new(6,4),
Origin = new(216,792),
Name = "Painting",
Variety = "Cheesy_Pizza_Poster",
},

new SpriteData()
{
TileType = 243,
Size = new(3,3),
},

new SpriteData()
{
TileType = 244,
Size = new(3,2),
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Name = "Painting",
Variety = "Waldo",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(36,0),
Name = "Painting",
Variety = "Darkness",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(72,0),
Name = "Painting",
Variety = "Dark_Soul_Reaper",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(108,0),
Name = "Painting",
Variety = "Land",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(144,0),
Name = "Painting",
Variety = "Trapped_Ghost",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(180,0),
Name = "Painting",
Variety = "American_Explosive",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(216,0),
Name = "Painting",
Variety = "Glorious_Night",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(252,0),
Name = "Painting",
Variety = "Bandage_Boy",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(288,0),
Name = "Painting",
Variety = "Divine_Eye",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(324,0),
Name = "Painting",
Variety = "Study_of_a_Ball_at_Rest",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(360,0),
Name = "Painting",
Variety = "Ghost_Manifestation",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(396,0),
Name = "Painting",
Variety = "Wicked_Undead",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(432,0),
Name = "Painting",
Variety = "Bloody_Goblet",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(468,0),
Name = "Painting",
Variety = "Painting_of_a_Lass",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(504,0),
Name = "Painting",
Variety = "Sufficiently_Advanced",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(540,0),
Name = "Painting",
Variety = "Strange_Growth_A",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(576,0),
Name = "Painting",
Variety = "Strange_Growth_B",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(612,0),
Name = "Painting",
Variety = "Strange_Growth_C",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(648,0),
Name = "Painting",
Variety = "Strange_Growth_D",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(684,0),
Name = "Painting",
Variety = "Happy_Little_Tree",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(720,0),
Name = "Painting",
Variety = "Strange_Dead_Fellows",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(756,0),
Name = "Painting",
Variety = "Secrets",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(792,0),
Name = "Painting",
Variety = "Thunderbolt",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(828,0),
Name = "Painting",
Variety = "Crustography",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(864,0),
Name = "Painting",
Variety = "The_Werewolf",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(900,0),
Name = "Painting",
Variety = "Blessing_from_the_Heavens",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(936,0),
Name = "Painting",
Variety = "Love_is_in_the_Trash_Slot",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(972,0),
Name = "Painting",
Variety = "Fangs",
},

new SpriteData()
{
TileType = 245,
Size = new(2,3),
Origin = new(1008,0),
Name = "Painting",
Variety = "Hail_to_the_King",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Name = "Painting",
Variety = "Demon's_Eye",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,36),
Name = "Painting",
Variety = "Finding_Gold",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,72),
Name = "Painting",
Variety = "First_Encounter",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,108),
Name = "Painting",
Variety = "Good_Morning",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,144),
Name = "Painting",
Variety = "Underground_Reward",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,180),
Name = "Painting",
Variety = "Through_the_Window",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,216),
Name = "Painting",
Variety = "Place_Above_the_Clouds",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,252),
Name = "Painting",
Variety = "Do_Not_Step_on_the_Grass",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,288),
Name = "Painting",
Variety = "Cold_Waters_in_the_White_Land",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,324),
Name = "Painting",
Variety = "Lightless_Chasms",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,360),
Name = "Painting",
Variety = "The_Land_of_Deceiving_Looks",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,396),
Name = "Painting",
Variety = "Daylight",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,432),
Name = "Painting",
Variety = "Secret_of_the_Sands",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,468),
Name = "Painting",
Variety = "Deadland_Comes_Alive",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,504),
Name = "Painting",
Variety = "Evil_Presence",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,540),
Name = "Painting",
Variety = "Sky_Guardian",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,576),
Name = "Painting",
Variety = "Living_Gore",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,612),
Name = "Painting",
Variety = "Flowing_Magma",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,648),
Name = "Hanging",
Variety = "Holly",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,684),
Name = "Painting",
Variety = "The_Duplicity_of_Reflections",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,720),
Name = "Painting",
Variety = "Still_Life",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,756),
Name = "Painting",
Variety = "See_The_World_For_What_It_Is",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,792),
Name = "Painting",
Variety = "What_Lurks_Below",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,828),
Name = "Painting",
Variety = "This_Is_Getting_Out_Of_Hand",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,864),
Name = "Painting",
Variety = "Buddies",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,900),
Name = "Painting",
Variety = "Midnight_Sun",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,936),
Name = "Painting",
Variety = "Couch_Gag",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,972),
Name = "Painting",
Variety = "Silent_Fish",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,1008),
Name = "Painting",
Variety = "The_Duke",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,1044),
Name = "Painting",
Variety = "Royal_Romance",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,1080),
Name = "Painting",
Variety = "Bioluminescence",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,1116),
Name = "Painting",
Variety = "Wildflowers",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,1152),
Name = "Painting",
Variety = "Viking_Voyage",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,1188),
Name = "Painting",
Variety = "Bifrost",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,1224),
Name = "Painting",
Variety = "Heartlands",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,1260),
Name = "Painting",
Variety = "Forest_Troll",
},

new SpriteData()
{
TileType = 246,
Size = new(3,2),
Origin = new(0,1296),
Name = "Painting",
Variety = "Aurora_Borealis",
},

new SpriteData()
{
TileType = 247,
Size = new(3,3),
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Name = "Sprout_A1",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(0,36),
Name = "Sprout_A2",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(0,72),
Name = "Sprout_A3",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(0,108),
Name = "Sprout_A4",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(0,144),
Name = "Sprout_A5",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(0,180),
Name = "Sprout_A6",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(36,0),
Name = "Sprout_B1",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(36,36),
Name = "Sprout_B2",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(36,72),
Name = "Sprout_B3",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(36,108),
Name = "Sprout_B4",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(36,144),
Name = "Sprout_B5",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(36,180),
Name = "Sprout_B6",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(72,0),
Name = "Immature_A1",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(72,36),
Name = "Immature_A2",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(72,72),
Name = "Immature_A3",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(72,108),
Name = "Immature_A4",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(72,144),
Name = "Immature_A5",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(72,180),
Name = "Immature_A6",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(108,0),
Name = "Immature_B1",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(108,36),
Name = "Immature_B2",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(108,72),
Name = "Immature_B3",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(108,108),
Name = "Immature_B4",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(108,144),
Name = "Immature_B5",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(108,180),
Name = "Immature_B6",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(144,0),
Name = "Mature_A",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(144,36),
Name = "Mature_B",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(144,72),
Name = "Mature_C",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(144,108),
Name = "Mature_D",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(144,144),
Name = "Mature_E",
},

new SpriteData()
{
TileType = 254,
Size = new(2,2),
Origin = new(144,180),
Name = "Mature_F",
},

new SpriteData()
{
TileType = 269,
Anchor = FrameAnchor.Left,
Size = new(2,3),
},

new SpriteData()
{
TileType = 269,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(36,0),
},

new SpriteData()
{
TileType = 270,
Size = new(1,2),
},

new SpriteData()
{
TileType = 271,
Size = new(1,2),
},

new SpriteData()
{
TileType = 275,
Size = new(6,3),
},

new SpriteData()
{
TileType = 276,
Size = new(6,3),
},

new SpriteData()
{
TileType = 277,
Size = new(6,3),
},

new SpriteData()
{
TileType = 278,
Size = new(6,3),
},

new SpriteData()
{
TileType = 279,
Size = new(6,3),
},

new SpriteData()
{
TileType = 280,
Size = new(6,3),
},

new SpriteData()
{
TileType = 281,
Size = new(6,3),
},

new SpriteData()
{
TileType = 282,
Size = new(2,2),
},

new SpriteData()
{
TileType = 283,
Size = new(3,3),
},

new SpriteData()
{
TileType = 285,
Size = new(3,2),
},

new SpriteData()
{
TileType = 286,
Size = new(3,2),
},

new SpriteData()
{
TileType = 287,
Size = new(2,2),
},

new SpriteData()
{
TileType = 288,
Size = new(2,2),
},

new SpriteData()
{
TileType = 289,
Size = new(2,2),
},

new SpriteData()
{
TileType = 290,
Size = new(2,2),
},

new SpriteData()
{
TileType = 291,
Size = new(2,2),
},

new SpriteData()
{
TileType = 292,
Size = new(2,2),
},

new SpriteData()
{
TileType = 293,
Size = new(2,2),
},

new SpriteData()
{
TileType = 294,
Size = new(2,2),
},

new SpriteData()
{
TileType = 295,
Size = new(2,2),
},

new SpriteData()
{
TileType = 296,
Size = new(6,3),
},

new SpriteData()
{
TileType = 297,
Size = new(6,3),
},

new SpriteData()
{
TileType = 298,
Size = new(3,2),
},

new SpriteData()
{
TileType = 299,
Size = new(3,2),
},

new SpriteData()
{
TileType = 300,
Size = new(3,3),
},

new SpriteData()
{
TileType = 301,
Size = new(3,3),
},

new SpriteData()
{
TileType = 302,
Size = new(3,3),
},

new SpriteData()
{
TileType = 303,
Size = new(3,3),
},

new SpriteData()
{
TileType = 304,
Size = new(3,3),
},

new SpriteData()
{
TileType = 305,
Size = new(3,3),
},

new SpriteData()
{
TileType = 306,
Size = new(3,3),
},

new SpriteData()
{
TileType = 307,
Size = new(3,3),
},

new SpriteData()
{
TileType = 308,
Size = new(3,3),
},

new SpriteData()
{
TileType = 309,
Size = new(6,3),
},

new SpriteData()
{
TileType = 310,
Size = new(3,2),
},

new SpriteData()
{
TileType = 314,
},

new SpriteData()
{
TileType = 316,
Size = new(2,2),
},

new SpriteData()
{
TileType = 317,
Size = new(2,2),
},

new SpriteData()
{
TileType = 318,
Size = new(2,2),
},

new SpriteData()
{
TileType = 319,
Size = new(2,2),
},

new SpriteData()
{
TileType = 320,
Size = new(2,3),
},

new SpriteData()
{
TileType = 323,
Origin = new(0,22),
Name = "Palm_Tree",
Variety = "Trunk_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(22,22),
Name = "Palm_Tree",
Variety = "Trunk_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(44,22),
Name = "Palm_Tree",
Variety = "Trunk_C",
},

new SpriteData()
{
TileType = 323,
Origin = new(66,22),
Name = "Palm_Tree",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(88,22),
Name = "Palm_Tree",
Variety = "Top_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(110,22),
Name = "Palm_Tree",
Variety = "Top_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(132,22),
Name = "Palm_Tree",
Variety = "Top_C",
},

new SpriteData()
{
TileType = 323,
Origin = new(154,22),
Name = "Palm_Tree",
Variety = "Top_A_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(176,22),
Name = "Palm_Tree",
Variety = "Top_B_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(198,22),
Name = "Palm_Tree",
Variety = "Top_C_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(220,22),
Name = "Palm_Tree",
Variety = "Base_Only_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(0,22),
Name = "Hallowed_Palm_Tree",
Variety = "Trunk_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(22,22),
Name = "Hallowed_Palm_Tree",
Variety = "Trunk_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(44,22),
Name = "Hallowed_Palm_Tree",
Variety = "Trunk_C",
},

new SpriteData()
{
TileType = 323,
Origin = new(66,22),
Name = "Hallowed_Palm_Tree",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(88,22),
Name = "Hallowed_Palm_Tree",
Variety = "Top_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(110,22),
Name = "Hallowed_Palm_Tree",
Variety = "Top_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(132,22),
Name = "Hallowed_Palm_Tree",
Variety = "Top_C",
},

new SpriteData()
{
TileType = 323,
Origin = new(154,22),
Name = "Hallowed_Palm_Tree",
Variety = "Top_A_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(176,22),
Name = "Hallowed_Palm_Tree",
Variety = "Top_B_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(198,22),
Name = "Hallowed_Palm_Tree",
Variety = "Top_C_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(220,22),
Name = "Hallowed_Palm_Tree",
Variety = "Base_Only_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(0,44),
Name = "Crimson_Palm_Tree",
Variety = "Trunk_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(22,44),
Name = "Crimson_Palm_Tree",
Variety = "Trunk_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(44,44),
Name = "Crimson_Palm_Tree",
Variety = "Trunk_C",
},

new SpriteData()
{
TileType = 323,
Origin = new(66,44),
Name = "Crimson_Palm_Tree",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(88,44),
Name = "Crimson_Palm_Tree",
Variety = "Top_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(110,44),
Name = "Crimson_Palm_Tree",
Variety = "Top_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(132,44),
Name = "Crimson_Palm_Tree",
Variety = "Top_C",
},

new SpriteData()
{
TileType = 323,
Origin = new(154,44),
Name = "Crimson_Palm_Tree",
Variety = "Top_A_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(176,44),
Name = "Crimson_Palm_Tree",
Variety = "Top_B_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(198,44),
Name = "Crimson_Palm_Tree",
Variety = "Top_C_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(220,44),
Name = "Crimson_Palm_Tree",
Variety = "Base_Only_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(0,66),
Name = "Corrupt_Palm_Tree",
Variety = "Trunk_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(22,66),
Name = "Corrupt_Palm_Tree",
Variety = "Trunk_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(44,66),
Name = "Corrupt_Palm_Tree",
Variety = "Trunk_C",
},

new SpriteData()
{
TileType = 323,
Origin = new(66,66),
Name = "Corrupt_Palm_Tree",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(88,66),
Name = "Corrupt_Palm_Tree",
Variety = "Top_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(110,66),
Name = "Corrupt_Palm_Tree",
Variety = "Top_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(132,66),
Name = "Corrupt_Palm_Tree",
Variety = "Top_C",
},

new SpriteData()
{
TileType = 323,
Origin = new(154,66),
Name = "Corrupt_Palm_Tree",
Variety = "Top_A_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(176,66),
Name = "Corrupt_Palm_Tree",
Variety = "Top_B_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(198,66),
Name = "Corrupt_Palm_Tree",
Variety = "Top_C_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(220,66),
Name = "Corrupt_Palm_Tree",
Variety = "Base_Only_A",
},

new SpriteData()
{
TileType = 323,
Origin = new(0,88),
Name = "Palm_Tree",
Variety = "Trunk_D",
},

new SpriteData()
{
TileType = 323,
Origin = new(22,88),
Name = "Palm_Tree",
Variety = "Trunk_E",
},

new SpriteData()
{
TileType = 323,
Origin = new(44,88),
Name = "Palm_Tree",
Variety = "Trunk_F",
},

new SpriteData()
{
TileType = 323,
Origin = new(66,88),
Name = "Palm_Tree",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(88,88),
Name = "Palm_Tree",
Variety = "Top_D",
},

new SpriteData()
{
TileType = 323,
Origin = new(110,88),
Name = "Palm_Tree",
Variety = "Top_E",
},

new SpriteData()
{
TileType = 323,
Origin = new(132,88),
Name = "Palm_Tree",
Variety = "Top_F",
},

new SpriteData()
{
TileType = 323,
Origin = new(154,88),
Name = "Palm_Tree",
Variety = "Top_D_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(176,88),
Name = "Palm_Tree",
Variety = "Top_E_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(198,88),
Name = "Palm_Tree",
Variety = "Top_F_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(220,88),
Name = "Palm_Tree",
Variety = "Base_Only_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(0,110),
Name = "Hallowed_Palm_Tree",
Variety = "Trunk_D",
},

new SpriteData()
{
TileType = 323,
Origin = new(22,110),
Name = "Hallowed_Palm_Tree",
Variety = "Trunk_E",
},

new SpriteData()
{
TileType = 323,
Origin = new(44,110),
Name = "Hallowed_Palm_Tree",
Variety = "Trunk_F",
},

new SpriteData()
{
TileType = 323,
Origin = new(66,110),
Name = "Hallowed_Palm_Tree",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(88,110),
Name = "Hallowed_Palm_Tree",
Variety = "Top_D",
},

new SpriteData()
{
TileType = 323,
Origin = new(110,110),
Name = "Hallowed_Palm_Tree",
Variety = "Top_E",
},

new SpriteData()
{
TileType = 323,
Origin = new(132,110),
Name = "Hallowed_Palm_Tree",
Variety = "Top_F",
},

new SpriteData()
{
TileType = 323,
Origin = new(154,110),
Name = "Hallowed_Palm_Tree",
Variety = "Top_D_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(176,110),
Name = "Hallowed_Palm_Tree",
Variety = "Top_E_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(198,110),
Name = "Hallowed_Palm_Tree",
Variety = "Top_F_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(220,110),
Name = "Hallowed_Palm_Tree",
Variety = "Base_Only_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(0,132),
Name = "Crimson_Palm_Tree",
Variety = "Trunk_D",
},

new SpriteData()
{
TileType = 323,
Origin = new(22,132),
Name = "Crimson_Palm_Tree",
Variety = "Trunk_E",
},

new SpriteData()
{
TileType = 323,
Origin = new(44,132),
Name = "Crimson_Palm_Tree",
Variety = "Trunk_F",
},

new SpriteData()
{
TileType = 323,
Origin = new(66,132),
Name = "Crimson_Palm_Tree",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(88,132),
Name = "Crimson_Palm_Tree",
Variety = "Top_D",
},

new SpriteData()
{
TileType = 323,
Origin = new(110,132),
Name = "Crimson_Palm_Tree",
Variety = "Top_E",
},

new SpriteData()
{
TileType = 323,
Origin = new(132,132),
Name = "Crimson_Palm_Tree",
Variety = "Top_F",
},

new SpriteData()
{
TileType = 323,
Origin = new(154,132),
Name = "Crimson_Palm_Tree",
Variety = "Top_D_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(176,132),
Name = "Crimson_Palm_Tree",
Variety = "Top_E_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(198,132),
Name = "Crimson_Palm_Tree",
Variety = "Top_F_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(220,132),
Name = "Crimson_Palm_Tree",
Variety = "Base_Only_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(0,154),
Name = "Corrupt_Palm_Tree",
Variety = "Trunk_D",
},

new SpriteData()
{
TileType = 323,
Origin = new(22,154),
Name = "Corrupt_Palm_Tree",
Variety = "Trunk_E",
},

new SpriteData()
{
TileType = 323,
Origin = new(44,154),
Name = "Corrupt_Palm_Tree",
Variety = "Trunk_F",
},

new SpriteData()
{
TileType = 323,
Origin = new(66,154),
Name = "Corrupt_Palm_Tree",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 323,
Origin = new(88,154),
Name = "Corrupt_Palm_Tree",
Variety = "Top_D",
},

new SpriteData()
{
TileType = 323,
Origin = new(110,154),
Name = "Corrupt_Palm_Tree",
Variety = "Top_E",
},

new SpriteData()
{
TileType = 323,
Origin = new(132,154),
Name = "Corrupt_Palm_Tree",
Variety = "Top_F",
},

new SpriteData()
{
TileType = 323,
Origin = new(154,154),
Name = "Corrupt_Palm_Tree",
Variety = "Top_D_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(176,154),
Name = "Corrupt_Palm_Tree",
Variety = "Top_E_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(198,154),
Name = "Corrupt_Palm_Tree",
Variety = "Top_F_No_Leaves",
},

new SpriteData()
{
TileType = 323,
Origin = new(220,154),
Name = "Corrupt_Palm_Tree",
Variety = "Base_Only_B",
},

new SpriteData()
{
TileType = 324,
Name = "Seashell",
Variety = "A",
},

new SpriteData()
{
TileType = 324,
Origin = new(22,0),
Name = "Seashell",
Variety = "B",
},

new SpriteData()
{
TileType = 324,
Origin = new(44,0),
Name = "Seashell",
Variety = "C",
},

new SpriteData()
{
TileType = 324,
Origin = new(0,22),
Name = "Starfish",
Variety = "A",
},

new SpriteData()
{
TileType = 324,
Origin = new(22,22),
Name = "Starfish",
Variety = "B",
},

new SpriteData()
{
TileType = 324,
Origin = new(44,22),
Name = "Starfish",
Variety = "C",
},

new SpriteData()
{
TileType = 324,
Origin = new(0,44),
Name = "Lightning_Whelk_Shell",
Variety = "A",
},

new SpriteData()
{
TileType = 324,
Origin = new(22,44),
Name = "Lightning_Whelk_Shell",
Variety = "B",
},

new SpriteData()
{
TileType = 324,
Origin = new(44,44),
Name = "Lightning_Whelk_Shell",
Variety = "C",
},

new SpriteData()
{
TileType = 324,
Origin = new(0,66),
Name = "Tulip_Shell",
Variety = "A",
},

new SpriteData()
{
TileType = 324,
Origin = new(22,66),
Name = "Tulip_Shell",
Variety = "B",
},

new SpriteData()
{
TileType = 324,
Origin = new(44,66),
Name = "Tulip_Shell",
Variety = "C",
},

new SpriteData()
{
TileType = 324,
Origin = new(0,88),
Name = "Junonia_Shell",
Variety = "A",
},

new SpriteData()
{
TileType = 324,
Origin = new(22,88),
Name = "Junonia_Shell",
Variety = "B",
},

new SpriteData()
{
TileType = 324,
Origin = new(44,88),
Name = "Junonia_Shell",
Variety = "C",
},

new SpriteData()
{
TileType = 334,
Size = new(3,3),
},

new SpriteData()
{
TileType = 334,
Size = new(3,3),
Origin = new(54,0),
Name = "Flipped",
},

new SpriteData()
{
TileType = 335,
Size = new(2,2),
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Name = "0_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(36,0),
Name = "1_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(72,0),
Name = "2_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(108,0),
Name = "3_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(144,0),
Name = "4_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(180,0),
Name = "5_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(216,0),
Name = "6_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(252,0),
Name = "7_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(288,0),
Name = "8_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(324,0),
Name = "9_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(360,0),
Name = "A_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(396,0),
Name = "B_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(432,0),
Name = "C_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(468,0),
Name = "D_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(504,0),
Name = "E_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(540,0),
Name = "F_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(576,0),
Name = "G_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(612,0),
Name = "H_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(648,0),
Name = "I_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(684,0),
Name = "J_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(720,0),
Name = "K_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(756,0),
Name = "L_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(792,0),
Name = "M_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(828,0),
Name = "N_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(864,0),
Name = "O_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(900,0),
Name = "P_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(936,0),
Name = "Q_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(972,0),
Name = "R_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(1008,0),
Name = "S_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(1044,0),
Name = "T_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(1080,0),
Name = "U_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(1116,0),
Name = "V_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(1152,0),
Name = "W_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(1188,0),
Name = "X_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(1224,0),
Name = "Y_Statue",
},

new SpriteData()
{
TileType = 337,
Size = new(2,3),
Origin = new(1260,0),
Name = "Z_Statue",
},

new SpriteData()
{
TileType = 338,
Size = new(1,2),
},

new SpriteData()
{
TileType = 339,
Size = new(3,2),
},

new SpriteData()
{
TileType = 349,
Size = new(2,3),
Name = "Left_Off",
},

new SpriteData()
{
TileType = 349,
Size = new(2,3),
Origin = new(216,0),
Name = "Left_On",
},

new SpriteData()
{
TileType = 349,
Size = new(2,3),
Origin = new(0,54),
Name = "Right_Off",
},

new SpriteData()
{
TileType = 349,
Size = new(2,3),
Origin = new(216,54),
Name = "Right_On",
},

new SpriteData()
{
TileType = 354,
Size = new(3,3),
},

new SpriteData()
{
TileType = 355,
Size = new(3,3),
},

new SpriteData()
{
TileType = 356,
Size = new(2,3),
},

new SpriteData()
{
TileType = 358,
Size = new(6,3),
},

new SpriteData()
{
TileType = 359,
Size = new(6,3),
},

new SpriteData()
{
TileType = 360,
Size = new(2,2),
},

new SpriteData()
{
TileType = 361,
Size = new(3,2),
},

new SpriteData()
{
TileType = 362,
Size = new(3,2),
},

new SpriteData()
{
TileType = 363,
Size = new(3,2),
},

new SpriteData()
{
TileType = 364,
Size = new(3,2),
},

new SpriteData()
{
TileType = 372,
Name = "On",
},

new SpriteData()
{
TileType = 372,
Origin = new(18,0),
Name = "Off",
},

new SpriteData()
{
TileType = 373,
},

new SpriteData()
{
TileType = 374,
},

new SpriteData()
{
TileType = 375,
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Name = "Wooden_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(36,0),
Name = "Iron_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(72,0),
Name = "Gold_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(108,0),
Name = "Corrupt_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(144,0),
Name = "Crimson_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(180,0),
Name = "Dungeon_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(216,0),
Name = "Sky_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(252,0),
Name = "Hallowed_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(288,0),
Name = "Jungle_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(324,0),
Name = "Pearlwood_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(360,0),
Name = "Mythril_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(396,0),
Name = "Titanium_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(432,0),
Name = "Defiled_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(468,0),
Name = "Hematic_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(504,0),
Name = "Stockade_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(540,0),
Name = "Azure_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(576,0),
Name = "Divine_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(612,0),
Name = "Bramble_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(648,0),
Name = "Frozen_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(684,0),
Name = "Boreal_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(720,0),
Name = "Oasis_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(756,0),
Name = "Mirage_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(792,0),
Name = "Obsidian_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(828,0),
Name = "Hellstone_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(864,0),
Name = "Ocean_Crate",
},

new SpriteData()
{
TileType = 376,
Size = new(2,2),
Origin = new(900,0),
Name = "Seaside_Crate",
},

new SpriteData()
{
TileType = 377,
Size = new(3,2),
Name = "Left",
},

new SpriteData()
{
TileType = 377,
Size = new(3,2),
Origin = new(54,0),
Name = "Right",
},

new SpriteData()
{
TileType = 378,
Size = new(2,3),
Name = "Left",
},

new SpriteData()
{
TileType = 378,
Size = new(2,3),
Origin = new(36,0),
Name = "Right",
},

new SpriteData()
{
TileType = 380,
Name = "Daybloom_Planter",
Variety = "Left",
},

new SpriteData()
{
TileType = 380,
Origin = new(18,0),
Name = "Daybloom_Planter",
Variety = "Middle",
},

new SpriteData()
{
TileType = 380,
Origin = new(36,0),
Name = "Daybloom_Planter",
Variety = "Right",
},

new SpriteData()
{
TileType = 380,
Origin = new(54,0),
Name = "Daybloom_Planter",
Variety = "Single",
},

new SpriteData()
{
TileType = 380,
Origin = new(0,18),
Name = "Moonglow_Planter",
Variety = "Left",
},

new SpriteData()
{
TileType = 380,
Origin = new(18,18),
Name = "Moonglow_Planter",
Variety = "Middle",
},

new SpriteData()
{
TileType = 380,
Origin = new(36,18),
Name = "Moonglow_Planter",
Variety = "Right",
},

new SpriteData()
{
TileType = 380,
Origin = new(54,18),
Name = "Moonglow_Planter",
Variety = "Single",
},

new SpriteData()
{
TileType = 380,
Origin = new(0,36),
Name = "Deathweed_Planter",
Variety = "Left",
},

new SpriteData()
{
TileType = 380,
Origin = new(18,36),
Name = "Deathweed_Planter",
Variety = "Middle",
},

new SpriteData()
{
TileType = 380,
Origin = new(36,36),
Name = "Deathweed_Planter",
Variety = "Right",
},

new SpriteData()
{
TileType = 380,
Origin = new(54,36),
Name = "Deathweed_Planter",
Variety = "Single",
},

new SpriteData()
{
TileType = 380,
Origin = new(0,54),
Name = "Crimsonweed_Planter",
Variety = "Left",
},

new SpriteData()
{
TileType = 380,
Origin = new(18,54),
Name = "Crimsonweed_Planter",
Variety = "Middle",
},

new SpriteData()
{
TileType = 380,
Origin = new(36,54),
Name = "Crimsonweed_Planter",
Variety = "Right",
},

new SpriteData()
{
TileType = 380,
Origin = new(54,54),
Name = "Crimsonweed_Planter",
Variety = "Single",
},

new SpriteData()
{
TileType = 380,
Origin = new(0,72),
Name = "Blinkroot_Planter",
Variety = "Left",
},

new SpriteData()
{
TileType = 380,
Origin = new(18,72),
Name = "Blinkroot_Planter",
Variety = "Middle",
},

new SpriteData()
{
TileType = 380,
Origin = new(36,72),
Name = "Blinkroot_Planter",
Variety = "Right",
},

new SpriteData()
{
TileType = 380,
Origin = new(54,72),
Name = "Blinkroot_Planter",
Variety = "Single",
},

new SpriteData()
{
TileType = 380,
Origin = new(0,90),
Name = "Waterleaf_Planter",
Variety = "Left",
},

new SpriteData()
{
TileType = 380,
Origin = new(18,90),
Name = "Waterleaf_Planter",
Variety = "Middle",
},

new SpriteData()
{
TileType = 380,
Origin = new(36,90),
Name = "Waterleaf_Planter",
Variety = "Right",
},

new SpriteData()
{
TileType = 380,
Origin = new(54,90),
Name = "Waterleaf_Planter",
Variety = "Single",
},

new SpriteData()
{
TileType = 380,
Origin = new(0,108),
Name = "Shiverthorn_Planter",
Variety = "Left",
},

new SpriteData()
{
TileType = 380,
Origin = new(18,108),
Name = "Shiverthorn_Planter",
Variety = "Middle",
},

new SpriteData()
{
TileType = 380,
Origin = new(36,108),
Name = "Shiverthorn_Planter",
Variety = "Right",
},

new SpriteData()
{
TileType = 380,
Origin = new(54,108),
Name = "Shiverthorn_Planter",
Variety = "Single",
},

new SpriteData()
{
TileType = 380,
Origin = new(0,126),
Name = "Fireblossom_Planter",
Variety = "Left",
},

new SpriteData()
{
TileType = 380,
Origin = new(18,126),
Name = "Fireblossom_Planter",
Variety = "Middle",
},

new SpriteData()
{
TileType = 380,
Origin = new(36,126),
Name = "Fireblossom_Planter",
Variety = "Right",
},

new SpriteData()
{
TileType = 380,
Origin = new(54,126),
Name = "Fireblossom_Planter",
Variety = "Single",
},

new SpriteData()
{
TileType = 386,
Size = new(2,2),
Name = "Up",
},

new SpriteData()
{
TileType = 386,
Size = new(2,2),
Origin = new(36,0),
Name = "Down",
},

new SpriteData()
{
TileType = 387,
Size = new(2,1),
},

new SpriteData()
{
TileType = 388,
Size = new(1,5),
Name = "Right",
},

new SpriteData()
{
TileType = 388,
Size = new(1,5),
Origin = new(0,100),
Name = "Left",
},

new SpriteData()
{
TileType = 389,
Size = new(1,5),
Name = "Right",
},

new SpriteData()
{
TileType = 389,
Size = new(1,5),
Origin = new(0,100),
Name = "Left",
},

new SpriteData()
{
TileType = 390,
Size = new(1,2),
},

new SpriteData()
{
TileType = 391,
Size = new(3,2),
},

new SpriteData()
{
TileType = 392,
Size = new(3,2),
},

new SpriteData()
{
TileType = 393,
Size = new(3,2),
},

new SpriteData()
{
TileType = 394,
Size = new(3,2),
},

new SpriteData()
{
TileType = 395,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Name = "Ground",
},

new SpriteData()
{
TileType = 395,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(36,0),
Name = "Hanging",
},

new SpriteData()
{
TileType = 395,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,0),
Name = "Left_Side",
},

new SpriteData()
{
TileType = 395,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,0),
Name = "Right_Side",
},

new SpriteData()
{
TileType = 395,
Size = new(2,2),
Origin = new(144,0),
Name = "Wall",
},

new SpriteData()
{
TileType = 405,
Size = new(3,2),
Name = "Lit",
},

new SpriteData()
{
TileType = 405,
Size = new(3,2),
Origin = new(54,0),
Name = "Unlit",
},

new SpriteData()
{
TileType = 406,
Size = new(3,3),
},

new SpriteData()
{
TileType = 410,
Size = new(2,3),
Name = "Vortex_Monolith",
Variety = "Off",
},

new SpriteData()
{
TileType = 410,
Size = new(2,3),
Origin = new(0,56),
Name = "Vortex_Monolith",
Variety = "On",
},

new SpriteData()
{
TileType = 410,
Size = new(2,3),
Origin = new(36,0),
Name = "Nebula_Monolith",
Variety = "Off",
},

new SpriteData()
{
TileType = 410,
Size = new(2,3),
Origin = new(36,56),
Name = "Nebula_Monolith",
Variety = "On",
},

new SpriteData()
{
TileType = 410,
Size = new(2,3),
Origin = new(72,0),
Name = "Stardust_Monolith",
Variety = "Off",
},

new SpriteData()
{
TileType = 410,
Size = new(2,3),
Origin = new(72,56),
Name = "Stardust_Monolith",
Variety = "On",
},

new SpriteData()
{
TileType = 410,
Size = new(2,3),
Origin = new(108,0),
Name = "Solar_Monolith",
Variety = "Off",
},

new SpriteData()
{
TileType = 410,
Size = new(2,3),
Origin = new(108,56),
Name = "Solar_Monolith",
Variety = "On",
},

new SpriteData()
{
TileType = 411,
Size = new(2,2),
Name = "Trigger_Up",
},

new SpriteData()
{
TileType = 411,
Size = new(2,2),
Origin = new(36,0),
Name = "Trigger_Down",
},

new SpriteData()
{
TileType = 412,
Size = new(3,3),
},

new SpriteData()
{
TileType = 413,
Size = new(6,3),
},

new SpriteData()
{
TileType = 414,
Size = new(6,3),
},

new SpriteData()
{
TileType = 419,
Name = "Off",
},

new SpriteData()
{
TileType = 419,
Origin = new(18,0),
Name = "On",
},

new SpriteData()
{
TileType = 419,
Origin = new(36,0),
Name = "Faulty",
},

new SpriteData()
{
TileType = 420,
Name = "Logic_Gate_(AND)",
Variety = "Off",
},

new SpriteData()
{
TileType = 420,
Origin = new(18,0),
Name = "Logic_Gate_(AND)",
Variety = "On",
},

new SpriteData()
{
TileType = 420,
Origin = new(36,0),
Name = "Logic_Gate_(AND)",
Variety = "Faulty",
},

new SpriteData()
{
TileType = 420,
Origin = new(0,18),
Name = "Logic_Gate_(OR)",
Variety = "Off",
},

new SpriteData()
{
TileType = 420,
Origin = new(18,18),
Name = "Logic_Gate_(OR)",
Variety = "On",
},

new SpriteData()
{
TileType = 420,
Origin = new(36,18),
Name = "Logic_Gate_(OR)",
Variety = "Faulty",
},

new SpriteData()
{
TileType = 420,
Origin = new(0,36),
Name = "Logic_Gate_(NAND)",
Variety = "Off",
},

new SpriteData()
{
TileType = 420,
Origin = new(18,36),
Name = "Logic_Gate_(NAND)",
Variety = "On",
},

new SpriteData()
{
TileType = 420,
Origin = new(36,36),
Name = "Logic_Gate_(NAND)",
Variety = "Faulty",
},

new SpriteData()
{
TileType = 420,
Origin = new(0,54),
Name = "Logic_Gate_(NOR)",
Variety = "Off",
},

new SpriteData()
{
TileType = 420,
Origin = new(18,54),
Name = "Logic_Gate_(NOR)",
Variety = "On",
},

new SpriteData()
{
TileType = 420,
Origin = new(36,54),
Name = "Logic_Gate_(NOR)",
Variety = "Faulty",
},

new SpriteData()
{
TileType = 420,
Origin = new(0,72),
Name = "Logic_Gate_(XOR)",
Variety = "Off",
},

new SpriteData()
{
TileType = 420,
Origin = new(18,72),
Name = "Logic_Gate_(XOR)",
Variety = "On",
},

new SpriteData()
{
TileType = 420,
Origin = new(36,72),
Name = "Logic_Gate_(XOR)",
Variety = "Faulty",
},

new SpriteData()
{
TileType = 420,
Origin = new(0,90),
Name = "Logic_Gate_(NXOR)",
Variety = "Off",
},

new SpriteData()
{
TileType = 420,
Origin = new(18,90),
Name = "Logic_Gate_(NXOR)",
Variety = "On",
},

new SpriteData()
{
TileType = 420,
Origin = new(36,90),
Name = "Logic_Gate_(NXOR)",
Variety = "Faulty",
},

new SpriteData()
{
TileType = 423,
Name = "Logic_Sensor_(Day)",
Variety = "Off",
},

new SpriteData()
{
TileType = 423,
Origin = new(18,0),
Name = "Logic_Sensor_(Day)",
Variety = "On",
},

new SpriteData()
{
TileType = 423,
Origin = new(0,18),
Name = "Logic_Sensor_(Night)",
Variety = "Off",
},

new SpriteData()
{
TileType = 423,
Origin = new(18,18),
Name = "Logic_Sensor_(Night)",
Variety = "On",
},

new SpriteData()
{
TileType = 423,
Origin = new(0,36),
Name = "Logic_Sensor_(Player_Above)",
Variety = "Off",
},

new SpriteData()
{
TileType = 423,
Origin = new(18,36),
Name = "Logic_Sensor_(Player_Above)",
Variety = "On",
},

new SpriteData()
{
TileType = 423,
Origin = new(0,54),
Name = "Liquid_Sensor_(Water)",
Variety = "Off",
},

new SpriteData()
{
TileType = 423,
Origin = new(18,54),
Name = "Liquid_Sensor_(Water)",
Variety = "On",
},

new SpriteData()
{
TileType = 423,
Origin = new(0,72),
Name = "Liquid_Sensor_(Lava)",
Variety = "Off",
},

new SpriteData()
{
TileType = 423,
Origin = new(18,72),
Name = "Liquid_Sensor_(Lava)",
Variety = "On",
},

new SpriteData()
{
TileType = 423,
Origin = new(0,90),
Name = "Liquid_Sensor_(Honey)",
Variety = "Off",
},

new SpriteData()
{
TileType = 423,
Origin = new(18,90),
Name = "Liquid_Sensor_(Honey)",
Variety = "On",
},

new SpriteData()
{
TileType = 423,
Origin = new(0,108),
Name = "Liquid_Sensor_(Any)",
Variety = "Off",
},

new SpriteData()
{
TileType = 423,
Origin = new(18,108),
Name = "Liquid_Sensor_(Any)",
Variety = "On",
},

new SpriteData()
{
TileType = 424,
Name = "Top_to_Bottom,_Left_to_Right",
},

new SpriteData()
{
TileType = 424,
Origin = new(18,0),
Name = "Top_to_Left,_Bottom_to_Right",
},

new SpriteData()
{
TileType = 424,
Origin = new(36,0),
Name = "Top_to_Right,_Bottom_to_Left",
},

new SpriteData()
{
TileType = 425,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Name = "Ground",
},

new SpriteData()
{
TileType = 425,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(36,0),
Name = "Hanging",
},

new SpriteData()
{
TileType = 425,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,0),
Name = "Left_Side",
},

new SpriteData()
{
TileType = 425,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,0),
Name = "Right_Side",
},

new SpriteData()
{
TileType = 425,
Size = new(2,2),
Origin = new(144,0),
Name = "Wall",
},

new SpriteData()
{
TileType = 427,
Name = "Flat_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(18,0),
Name = "Endcap_Right_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(36,0),
Name = "Endcap_Left_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(54,0),
Name = "Attach_Left_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(72,0),
Name = "Attach_Right_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(90,0),
Name = "Single_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(108,0),
Name = "Attach_Left_Endcap_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(126,0),
Name = "Attach_Right_Endcap_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(144,0),
Name = "Stair_Up-Right_Riser_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(162,0),
Name = "Stair_Up-Right_Stringer_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(180,0),
Name = "Stair_Up-Left_Riser_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(198,0),
Name = "Stair_Up-Left_Stringer_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(216,0),
Name = "Stair_Top_Landing_R_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(234,0),
Name = "Stair_Top_Landing_L_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(252,0),
Name = "Stair_Top_Landing_L-R_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(270,0),
Name = "Stair_Top_Landing_R_Endcap_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(288,0),
Name = "Stair_Top_Landing_L_Endcap_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(306,0),
Name = "Stair_Bottom_Landing_R_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(324,0),
Name = "Stair_Bottom_Landing_L_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(342,0),
Name = "Stair_Inset_Up-Right_1_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(360,0),
Name = "Stair_Inset_Up-Left_1_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(378,0),
Name = "Stair_Inset_Up-Right_2_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(396,0),
Name = "Stair_Inset_Up-Left_2_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(414,0),
Name = "Stair_Inset_Up-Right_3_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(432,0),
Name = "Stair_Inset_Up-Left_3_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(450,0),
Name = "Stair_Inverted_Right_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(468,0),
Name = "Stair_Inverted_Left_A",
},

new SpriteData()
{
TileType = 427,
Origin = new(0,18),
Name = "Flat_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(18,18),
Name = "Endcap_Right_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(36,18),
Name = "Endcap_Left_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(54,18),
Name = "Attach_Left_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(72,18),
Name = "Attach_Right_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(90,18),
Name = "Single_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(108,18),
Name = "Attach_Left_Endcap_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(126,18),
Name = "Attach_Right_Endcap_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(144,18),
Name = "Stair_Up-Right_Riser_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(162,18),
Name = "Stair_Up-Right_Stringer_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(180,18),
Name = "Stair_Up-Left_Riser_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(198,18),
Name = "Stair_Up-Left_Stringer_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(216,18),
Name = "Stair_Top_Landing_R_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(234,18),
Name = "Stair_Top_Landing_L_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(252,18),
Name = "Stair_Top_Landing_L-R_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(270,18),
Name = "Stair_Top_Landing_R_Endcap_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(288,18),
Name = "Stair_Top_Landing_L_Endcap_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(306,18),
Name = "Stair_Bottom_Landing_R_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(324,18),
Name = "Stair_Bottom_Landing_L_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(342,18),
Name = "Stair_Inset_Up-Right_1_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(360,18),
Name = "Stair_Inset_Up-Left_1_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(378,18),
Name = "Stair_Inset_Up-Right_2_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(396,18),
Name = "Stair_Inset_Up-Left_2_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(414,18),
Name = "Stair_Inset_Up-Right_3_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(432,18),
Name = "Stair_Inset_Up-Left_3_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(450,18),
Name = "Stair_Inverted_Right_B",
},

new SpriteData()
{
TileType = 427,
Origin = new(468,18),
Name = "Stair_Inverted_Left_B",
},

new SpriteData()
{
TileType = 428,
Name = "Orange_Off",
},

new SpriteData()
{
TileType = 428,
Origin = new(0,18),
Name = "Cyan_Off",
},

new SpriteData()
{
TileType = 428,
Origin = new(0,36),
Name = "Purple_Off",
},

new SpriteData()
{
TileType = 428,
Origin = new(0,54),
Name = "Pink_Off",
},

new SpriteData()
{
TileType = 428,
Origin = new(18,0),
Name = "Orange_On",
},

new SpriteData()
{
TileType = 428,
Origin = new(18,18),
Name = "Cyan_On",
},

new SpriteData()
{
TileType = 428,
Origin = new(18,36),
Name = "Purple_On",
},

new SpriteData()
{
TileType = 428,
Origin = new(18,54),
Name = "Pink_On",
},

new SpriteData()
{
TileType = 429,
Name = "Off",
},

new SpriteData()
{
TileType = 429,
Origin = new(18,0),
Name = "Red_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(36,0),
Name = "Green_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(54,0),
Name = "Red,_Green_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(72,0),
Name = "Blue_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(90,0),
Name = "Red,_Blue_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(108,0),
Name = "Green,_Blue_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(126,0),
Name = "Red,_Green,_Blue_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(144,0),
Name = "Yellow_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(162,0),
Name = "Red,_Yellow_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(180,0),
Name = "Green,_Yellow_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(198,0),
Name = "Red,_Green,_Yellow_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(216,0),
Name = "Blue,_Yellow_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(234,0),
Name = "Red,_Blue,_Yellow_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(252,0),
Name = "Green,_Blue,_Yellow_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(270,0),
Name = "Red,_Green,_Blue,_Yellow_A",
},

new SpriteData()
{
TileType = 429,
Origin = new(18,18),
Name = "Red_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(36,18),
Name = "Green_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(54,18),
Name = "Red,_Green_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(72,18),
Name = "Blue_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(90,18),
Name = "Red,_Blue_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(108,18),
Name = "Green,_Blue_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(126,18),
Name = "Red,_Green,_Blue_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(144,18),
Name = "Yellow_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(162,18),
Name = "Red,_Yellow_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(180,18),
Name = "Green,_Yellow_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(198,18),
Name = "Red,_Green,_Yellow_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(216,18),
Name = "Blue,_Yellow_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(234,18),
Name = "Red,_Blue,_Yellow_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(252,18),
Name = "Green,_Blue,_Yellow_B",
},

new SpriteData()
{
TileType = 429,
Origin = new(270,18),
Name = "Red,_Green,_Blue,_Yellow_B",
},

new SpriteData()
{
TileType = 435,
Name = "Flat_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(18,0),
Name = "Endcap_Right_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(36,0),
Name = "Endcap_Left_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(54,0),
Name = "Attach_Left_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(72,0),
Name = "Attach_Right_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(90,0),
Name = "Single_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(108,0),
Name = "Attach_Left_Endcap_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(126,0),
Name = "Attach_Right_Endcap_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(144,0),
Name = "Stair_Up-Right_Riser_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(162,0),
Name = "Stair_Up-Right_Stringer_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(180,0),
Name = "Stair_Up-Left_Riser_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(198,0),
Name = "Stair_Up-Left_Stringer_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(216,0),
Name = "Stair_Top_Landing_R_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(234,0),
Name = "Stair_Top_Landing_L_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(252,0),
Name = "Stair_Top_Landing_L-R_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(270,0),
Name = "Stair_Top_Landing_R_Endcap_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(288,0),
Name = "Stair_Top_Landing_L_Endcap_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(306,0),
Name = "Stair_Bottom_Landing_R_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(324,0),
Name = "Stair_Bottom_Landing_L_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(342,0),
Name = "Stair_Inset_Up-Right_1_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(360,0),
Name = "Stair_Inset_Up-Left_1_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(378,0),
Name = "Stair_Inset_Up-Right_2_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(396,0),
Name = "Stair_Inset_Up-Left_2_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(414,0),
Name = "Stair_Inset_Up-Right_3_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(432,0),
Name = "Stair_Inset_Up-Left_3_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(450,0),
Name = "Stair_Inverted_Right_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(468,0),
Name = "Stair_Inverted_Left_A",
},

new SpriteData()
{
TileType = 435,
Origin = new(0,18),
Name = "Flat_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(18,18),
Name = "Endcap_Right_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(36,18),
Name = "Endcap_Left_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(54,18),
Name = "Attach_Left_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(72,18),
Name = "Attach_Right_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(90,18),
Name = "Single_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(108,18),
Name = "Attach_Left_Endcap_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(126,18),
Name = "Attach_Right_Endcap_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(144,18),
Name = "Stair_Up-Right_Riser_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(162,18),
Name = "Stair_Up-Right_Stringer_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(180,18),
Name = "Stair_Up-Left_Riser_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(198,18),
Name = "Stair_Up-Left_Stringer_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(216,18),
Name = "Stair_Top_Landing_R_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(234,18),
Name = "Stair_Top_Landing_L_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(252,18),
Name = "Stair_Top_Landing_L-R_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(270,18),
Name = "Stair_Top_Landing_R_Endcap_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(288,18),
Name = "Stair_Top_Landing_L_Endcap_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(306,18),
Name = "Stair_Bottom_Landing_R_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(324,18),
Name = "Stair_Bottom_Landing_L_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(342,18),
Name = "Stair_Inset_Up-Right_1_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(360,18),
Name = "Stair_Inset_Up-Left_1_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(378,18),
Name = "Stair_Inset_Up-Right_2_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(396,18),
Name = "Stair_Inset_Up-Left_2_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(414,18),
Name = "Stair_Inset_Up-Right_3_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(432,18),
Name = "Stair_Inset_Up-Left_3_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(450,18),
Name = "Stair_Inverted_Right_B",
},

new SpriteData()
{
TileType = 435,
Origin = new(468,18),
Name = "Stair_Inverted_Left_B",
},

new SpriteData()
{
TileType = 436,
Name = "Flat_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(18,0),
Name = "Endcap_Right_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(36,0),
Name = "Endcap_Left_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(54,0),
Name = "Attach_Left_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(72,0),
Name = "Attach_Right_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(90,0),
Name = "Single_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(108,0),
Name = "Attach_Left_Endcap_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(126,0),
Name = "Attach_Right_Endcap_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(144,0),
Name = "Stair_Up-Right_Riser_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(162,0),
Name = "Stair_Up-Right_Stringer_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(180,0),
Name = "Stair_Up-Left_Riser_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(198,0),
Name = "Stair_Up-Left_Stringer_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(216,0),
Name = "Stair_Top_Landing_R_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(234,0),
Name = "Stair_Top_Landing_L_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(252,0),
Name = "Stair_Top_Landing_L-R_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(270,0),
Name = "Stair_Top_Landing_R_Endcap_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(288,0),
Name = "Stair_Top_Landing_L_Endcap_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(306,0),
Name = "Stair_Bottom_Landing_R_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(324,0),
Name = "Stair_Bottom_Landing_L_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(342,0),
Name = "Stair_Inset_Up-Right_1_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(360,0),
Name = "Stair_Inset_Up-Left_1_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(378,0),
Name = "Stair_Inset_Up-Right_2_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(396,0),
Name = "Stair_Inset_Up-Left_2_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(414,0),
Name = "Stair_Inset_Up-Right_3_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(432,0),
Name = "Stair_Inset_Up-Left_3_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(450,0),
Name = "Stair_Inverted_Right_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(468,0),
Name = "Stair_Inverted_Left_A",
},

new SpriteData()
{
TileType = 436,
Origin = new(0,18),
Name = "Flat_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(18,18),
Name = "Endcap_Right_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(36,18),
Name = "Endcap_Left_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(54,18),
Name = "Attach_Left_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(72,18),
Name = "Attach_Right_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(90,18),
Name = "Single_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(108,18),
Name = "Attach_Left_Endcap_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(126,18),
Name = "Attach_Right_Endcap_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(144,18),
Name = "Stair_Up-Right_Riser_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(162,18),
Name = "Stair_Up-Right_Stringer_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(180,18),
Name = "Stair_Up-Left_Riser_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(198,18),
Name = "Stair_Up-Left_Stringer_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(216,18),
Name = "Stair_Top_Landing_R_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(234,18),
Name = "Stair_Top_Landing_L_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(252,18),
Name = "Stair_Top_Landing_L-R_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(270,18),
Name = "Stair_Top_Landing_R_Endcap_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(288,18),
Name = "Stair_Top_Landing_L_Endcap_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(306,18),
Name = "Stair_Bottom_Landing_R_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(324,18),
Name = "Stair_Bottom_Landing_L_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(342,18),
Name = "Stair_Inset_Up-Right_1_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(360,18),
Name = "Stair_Inset_Up-Left_1_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(378,18),
Name = "Stair_Inset_Up-Right_2_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(396,18),
Name = "Stair_Inset_Up-Left_2_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(414,18),
Name = "Stair_Inset_Up-Right_3_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(432,18),
Name = "Stair_Inset_Up-Left_3_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(450,18),
Name = "Stair_Inverted_Right_B",
},

new SpriteData()
{
TileType = 436,
Origin = new(468,18),
Name = "Stair_Inverted_Left_B",
},

new SpriteData()
{
TileType = 437,
Name = "Flat_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(18,0),
Name = "Endcap_Right_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(36,0),
Name = "Endcap_Left_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(54,0),
Name = "Attach_Left_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(72,0),
Name = "Attach_Right_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(90,0),
Name = "Single_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(108,0),
Name = "Attach_Left_Endcap_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(126,0),
Name = "Attach_Right_Endcap_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(144,0),
Name = "Stair_Up-Right_Riser_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(162,0),
Name = "Stair_Up-Right_Stringer_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(180,0),
Name = "Stair_Up-Left_Riser_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(198,0),
Name = "Stair_Up-Left_Stringer_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(216,0),
Name = "Stair_Top_Landing_R_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(234,0),
Name = "Stair_Top_Landing_L_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(252,0),
Name = "Stair_Top_Landing_L-R_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(270,0),
Name = "Stair_Top_Landing_R_Endcap_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(288,0),
Name = "Stair_Top_Landing_L_Endcap_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(306,0),
Name = "Stair_Bottom_Landing_R_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(324,0),
Name = "Stair_Bottom_Landing_L_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(342,0),
Name = "Stair_Inset_Up-Right_1_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(360,0),
Name = "Stair_Inset_Up-Left_1_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(378,0),
Name = "Stair_Inset_Up-Right_2_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(396,0),
Name = "Stair_Inset_Up-Left_2_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(414,0),
Name = "Stair_Inset_Up-Right_3_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(432,0),
Name = "Stair_Inset_Up-Left_3_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(450,0),
Name = "Stair_Inverted_Right_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(468,0),
Name = "Stair_Inverted_Left_A",
},

new SpriteData()
{
TileType = 437,
Origin = new(0,18),
Name = "Flat_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(18,18),
Name = "Endcap_Right_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(36,18),
Name = "Endcap_Left_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(54,18),
Name = "Attach_Left_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(72,18),
Name = "Attach_Right_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(90,18),
Name = "Single_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(108,18),
Name = "Attach_Left_Endcap_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(126,18),
Name = "Attach_Right_Endcap_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(144,18),
Name = "Stair_Up-Right_Riser_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(162,18),
Name = "Stair_Up-Right_Stringer_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(180,18),
Name = "Stair_Up-Left_Riser_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(198,18),
Name = "Stair_Up-Left_Stringer_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(216,18),
Name = "Stair_Top_Landing_R_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(234,18),
Name = "Stair_Top_Landing_L_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(252,18),
Name = "Stair_Top_Landing_L-R_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(270,18),
Name = "Stair_Top_Landing_R_Endcap_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(288,18),
Name = "Stair_Top_Landing_L_Endcap_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(306,18),
Name = "Stair_Bottom_Landing_R_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(324,18),
Name = "Stair_Bottom_Landing_L_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(342,18),
Name = "Stair_Inset_Up-Right_1_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(360,18),
Name = "Stair_Inset_Up-Left_1_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(378,18),
Name = "Stair_Inset_Up-Right_2_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(396,18),
Name = "Stair_Inset_Up-Left_2_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(414,18),
Name = "Stair_Inset_Up-Right_3_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(432,18),
Name = "Stair_Inset_Up-Left_3_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(450,18),
Name = "Stair_Inverted_Right_B",
},

new SpriteData()
{
TileType = 437,
Origin = new(468,18),
Name = "Stair_Inverted_Left_B",
},

new SpriteData()
{
TileType = 438,
Name = "Flat_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(18,0),
Name = "Endcap_Right_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(36,0),
Name = "Endcap_Left_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(54,0),
Name = "Attach_Left_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(72,0),
Name = "Attach_Right_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(90,0),
Name = "Single_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(108,0),
Name = "Attach_Left_Endcap_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(126,0),
Name = "Attach_Right_Endcap_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(144,0),
Name = "Stair_Up-Right_Riser_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(162,0),
Name = "Stair_Up-Right_Stringer_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(180,0),
Name = "Stair_Up-Left_Riser_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(198,0),
Name = "Stair_Up-Left_Stringer_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(216,0),
Name = "Stair_Top_Landing_R_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(234,0),
Name = "Stair_Top_Landing_L_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(252,0),
Name = "Stair_Top_Landing_L-R_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(270,0),
Name = "Stair_Top_Landing_R_Endcap_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(288,0),
Name = "Stair_Top_Landing_L_Endcap_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(306,0),
Name = "Stair_Bottom_Landing_R_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(324,0),
Name = "Stair_Bottom_Landing_L_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(342,0),
Name = "Stair_Inset_Up-Right_1_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(360,0),
Name = "Stair_Inset_Up-Left_1_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(378,0),
Name = "Stair_Inset_Up-Right_2_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(396,0),
Name = "Stair_Inset_Up-Left_2_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(414,0),
Name = "Stair_Inset_Up-Right_3_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(432,0),
Name = "Stair_Inset_Up-Left_3_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(450,0),
Name = "Stair_Inverted_Right_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(468,0),
Name = "Stair_Inverted_Left_A",
},

new SpriteData()
{
TileType = 438,
Origin = new(0,18),
Name = "Flat_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(18,18),
Name = "Endcap_Right_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(36,18),
Name = "Endcap_Left_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(54,18),
Name = "Attach_Left_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(72,18),
Name = "Attach_Right_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(90,18),
Name = "Single_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(108,18),
Name = "Attach_Left_Endcap_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(126,18),
Name = "Attach_Right_Endcap_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(144,18),
Name = "Stair_Up-Right_Riser_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(162,18),
Name = "Stair_Up-Right_Stringer_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(180,18),
Name = "Stair_Up-Left_Riser_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(198,18),
Name = "Stair_Up-Left_Stringer_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(216,18),
Name = "Stair_Top_Landing_R_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(234,18),
Name = "Stair_Top_Landing_L_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(252,18),
Name = "Stair_Top_Landing_L-R_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(270,18),
Name = "Stair_Top_Landing_R_Endcap_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(288,18),
Name = "Stair_Top_Landing_L_Endcap_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(306,18),
Name = "Stair_Bottom_Landing_R_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(324,18),
Name = "Stair_Bottom_Landing_L_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(342,18),
Name = "Stair_Inset_Up-Right_1_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(360,18),
Name = "Stair_Inset_Up-Left_1_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(378,18),
Name = "Stair_Inset_Up-Right_2_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(396,18),
Name = "Stair_Inset_Up-Left_2_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(414,18),
Name = "Stair_Inset_Up-Right_3_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(432,18),
Name = "Stair_Inset_Up-Left_3_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(450,18),
Name = "Stair_Inverted_Right_B",
},

new SpriteData()
{
TileType = 438,
Origin = new(468,18),
Name = "Stair_Inverted_Left_B",
},

new SpriteData()
{
TileType = 439,
Name = "Flat_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(18,0),
Name = "Endcap_Right_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(36,0),
Name = "Endcap_Left_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(54,0),
Name = "Attach_Left_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(72,0),
Name = "Attach_Right_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(90,0),
Name = "Single_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(108,0),
Name = "Attach_Left_Endcap_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(126,0),
Name = "Attach_Right_Endcap_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(144,0),
Name = "Stair_Up-Right_Riser_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(162,0),
Name = "Stair_Up-Right_Stringer_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(180,0),
Name = "Stair_Up-Left_Riser_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(198,0),
Name = "Stair_Up-Left_Stringer_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(216,0),
Name = "Stair_Top_Landing_R_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(234,0),
Name = "Stair_Top_Landing_L_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(252,0),
Name = "Stair_Top_Landing_L-R_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(270,0),
Name = "Stair_Top_Landing_R_Endcap_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(288,0),
Name = "Stair_Top_Landing_L_Endcap_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(306,0),
Name = "Stair_Bottom_Landing_R_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(324,0),
Name = "Stair_Bottom_Landing_L_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(342,0),
Name = "Stair_Inset_Up-Right_1_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(360,0),
Name = "Stair_Inset_Up-Left_1_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(378,0),
Name = "Stair_Inset_Up-Right_2_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(396,0),
Name = "Stair_Inset_Up-Left_2_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(414,0),
Name = "Stair_Inset_Up-Right_3_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(432,0),
Name = "Stair_Inset_Up-Left_3_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(450,0),
Name = "Stair_Inverted_Right_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(468,0),
Name = "Stair_Inverted_Left_A",
},

new SpriteData()
{
TileType = 439,
Origin = new(0,18),
Name = "Flat_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(18,18),
Name = "Endcap_Right_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(36,18),
Name = "Endcap_Left_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(54,18),
Name = "Attach_Left_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(72,18),
Name = "Attach_Right_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(90,18),
Name = "Single_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(108,18),
Name = "Attach_Left_Endcap_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(126,18),
Name = "Attach_Right_Endcap_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(144,18),
Name = "Stair_Up-Right_Riser_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(162,18),
Name = "Stair_Up-Right_Stringer_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(180,18),
Name = "Stair_Up-Left_Riser_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(198,18),
Name = "Stair_Up-Left_Stringer_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(216,18),
Name = "Stair_Top_Landing_R_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(234,18),
Name = "Stair_Top_Landing_L_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(252,18),
Name = "Stair_Top_Landing_L-R_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(270,18),
Name = "Stair_Top_Landing_R_Endcap_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(288,18),
Name = "Stair_Top_Landing_L_Endcap_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(306,18),
Name = "Stair_Bottom_Landing_R_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(324,18),
Name = "Stair_Bottom_Landing_L_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(342,18),
Name = "Stair_Inset_Up-Right_1_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(360,18),
Name = "Stair_Inset_Up-Left_1_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(378,18),
Name = "Stair_Inset_Up-Right_2_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(396,18),
Name = "Stair_Inset_Up-Left_2_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(414,18),
Name = "Stair_Inset_Up-Right_3_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(432,18),
Name = "Stair_Inset_Up-Left_3_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(450,18),
Name = "Stair_Inverted_Right_B",
},

new SpriteData()
{
TileType = 439,
Origin = new(468,18),
Name = "Stair_Inverted_Left_B",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Name = "Ruby_Gem_Lock",
Variety = "Empty",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(0,54),
Name = "Ruby_Gem_Lock",
Variety = "Filled",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(54,0),
Name = "Sapphire_Gem_Lock",
Variety = "Empty",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(54,54),
Name = "Sapphire_Gem_Lock",
Variety = "Filled",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(108,0),
Name = "Emerald_Gem_Lock",
Variety = "Empty",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(108,54),
Name = "Emerald_Gem_Lock",
Variety = "Filled",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(162,0),
Name = "Topaz_Gem_Lock",
Variety = "Empty",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(162,54),
Name = "Topaz_Gem_Lock",
Variety = "Filled",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(216,0),
Name = "Amethyst_Gem_Lock",
Variety = "Empty",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(216,54),
Name = "Amethyst_Gem_Lock",
Variety = "Filled",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(270,0),
Name = "Diamond_Gem_Lock",
Variety = "Empty",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(270,54),
Name = "Diamond_Gem_Lock",
Variety = "Filled",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(324,0),
Name = "Amber_Gem_Lock",
Variety = "Empty",
},

new SpriteData()
{
TileType = 440,
Size = new(3,3),
Origin = new(324,54),
Name = "Amber_Gem_Lock",
Variety = "Filled",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Name = "Trapped_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(36,0),
Name = "Trapped_Gold_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(72,0),
Name = "Trapped_Gold_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(108,0),
Name = "Trapped_Shadow_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(144,0),
Name = "Trapped_Shadow_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(180,0),
Name = "Trapped_Barrel_(unused_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(216,0),
Name = "Trapped_Trash_Can_(unused_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(252,0),
Name = "Trapped_Ebonwood_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(288,0),
Name = "Trapped_Rich_Mahogany_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(324,0),
Name = "Trapped_Pearlwood_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(360,0),
Name = "Trapped_Ivy_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(396,0),
Name = "Trapped_Ice_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(432,0),
Name = "Trapped_Living_Wood_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(468,0),
Name = "Trapped_Skyware_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(504,0),
Name = "Trapped_Shadewood_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(540,0),
Name = "Trapped_Web_Coverd_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(576,0),
Name = "Trapped_Lihzahrd_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(612,0),
Name = "Trapped_Water_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(648,0),
Name = "Trapped_Jungle_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(684,0),
Name = "Trapped_Corruption_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(720,0),
Name = "Trapped_Crimson_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(756,0),
Name = "Trapped_Hallowed_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(792,0),
Name = "Trapped_Frozen_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(828,0),
Name = "Trapped_Jungle_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(864,0),
Name = "Trapped_Corruption_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(900,0),
Name = "Trapped_Crimson_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(936,0),
Name = "Trapped_Hallowed_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(972,0),
Name = "Trapped_Frozen_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1008,0),
Name = "Trapped_Dynasty_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1044,0),
Name = "Trapped_Honey_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1080,0),
Name = "Trapped_Steampunk_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1116,0),
Name = "Trapped_Palm_Wood_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1152,0),
Name = "Trapped_Mushroom_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1188,0),
Name = "Trapped_Boreal_Wood_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1224,0),
Name = "Trapped_Slime_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1260,0),
Name = "Trapped_Green_Dungeon_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1296,0),
Name = "Trapped_Green_Dungeon_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1332,0),
Name = "Trapped_Pink_Dungeon_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1368,0),
Name = "Trapped_Pink_Dungeon_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1404,0),
Name = "Trapped_Blue_Dungeon_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1440,0),
Name = "Trapped_Blue_Dungeon_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1476,0),
Name = "Trapped_Bone_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1512,0),
Name = "Trapped_Cactus_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1548,0),
Name = "Trapped_Flesh_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1584,0),
Name = "Trapped_Obsidian_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1620,0),
Name = "Trapped_Pumpkin_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1656,0),
Name = "Trapped_Spooky_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1692,0),
Name = "Trapped_Glass_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1728,0),
Name = "Trapped_Martian_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1764,0),
Name = "Trapped_Meteorite_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1800,0),
Name = "Trapped_Granite_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1836,0),
Name = "Trapped_Marble_Chest",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1872,0),
Name = "Trapped_Crystal_Chest_(unused_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 441,
Size = new(2,2),
Origin = new(1908,0),
Name = "Trapped_Golden_Chest_(unused_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 442,
Anchor = FrameAnchor.Bottom,
},

new SpriteData()
{
TileType = 442,
Anchor = FrameAnchor.Top,
Origin = new(22,0),
},

new SpriteData()
{
TileType = 442,
Anchor = FrameAnchor.Left,
Origin = new(44,0),
},

new SpriteData()
{
TileType = 442,
Anchor = FrameAnchor.Right,
Origin = new(66,0),
},

new SpriteData()
{
TileType = 443,
Anchor = FrameAnchor.Bottom,
Size = new(2,1),
Name = "A",
},

new SpriteData()
{
TileType = 443,
Anchor = FrameAnchor.Bottom,
Size = new(2,1),
Origin = new(36,0),
Name = "B",
},

new SpriteData()
{
TileType = 443,
Anchor = FrameAnchor.Top,
Size = new(2,1),
Origin = new(72,0),
Name = "A",
},

new SpriteData()
{
TileType = 443,
Anchor = FrameAnchor.Top,
Size = new(2,1),
Origin = new(108,0),
Name = "B",
},

new SpriteData()
{
TileType = 444,
Size = new(2,2),
},

new SpriteData()
{
TileType = 445,
Name = "Off",
},

new SpriteData()
{
TileType = 445,
Origin = new(18,0),
Name = "On",
},

new SpriteData()
{
TileType = 445,
Origin = new(18,18),
Name = "C",
},

new SpriteData()
{
TileType = 452,
Size = new(3,2),
},

new SpriteData()
{
TileType = 453,
Size = new(1,3),
Name = "Purple_Left",
},

new SpriteData()
{
TileType = 453,
Size = new(1,3),
Origin = new(18,0),
Name = "Purple_Right",
},

new SpriteData()
{
TileType = 453,
Size = new(1,3),
Origin = new(36,0),
Name = "Green_Left",
},

new SpriteData()
{
TileType = 453,
Size = new(1,3),
Origin = new(54,0),
Name = "Green_Right",
},

new SpriteData()
{
TileType = 453,
Size = new(1,3),
Origin = new(72,0),
Name = "Pink_Left",
},

new SpriteData()
{
TileType = 453,
Size = new(1,3),
Origin = new(90,0),
Name = "Pink_Right",
},

new SpriteData()
{
TileType = 454,
Size = new(4,3),
},

new SpriteData()
{
TileType = 455,
Size = new(3,3),
},

new SpriteData()
{
TileType = 456,
Size = new(2,3),
},

new SpriteData()
{
TileType = 457,
Size = new(2,2),
Name = "Blue_with_Green_Ribbon",
},

new SpriteData()
{
TileType = 457,
Size = new(2,2),
Origin = new(36,0),
Name = "Pink_with_Blue_Ribbon",
},

new SpriteData()
{
TileType = 457,
Size = new(2,2),
Origin = new(72,0),
Name = "Cyan_with_Pink_Ribbon",
},

new SpriteData()
{
TileType = 457,
Size = new(2,2),
Origin = new(108,0),
Name = "Purple_with_Green_Ribbon",
},

new SpriteData()
{
TileType = 457,
Size = new(2,2),
Origin = new(144,0),
Name = "White_with_Pink_Ribbon",
},

new SpriteData()
{
TileType = 461,
},

new SpriteData()
{
TileType = 462,
Size = new(2,1),
},

new SpriteData()
{
TileType = 463,
Size = new(3,4),
},

new SpriteData()
{
TileType = 464,
Size = new(5,4),
},

new SpriteData()
{
TileType = 465,
Size = new(2,3),
},

new SpriteData()
{
TileType = 466,
Size = new(5,4),
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Name = "Crystal_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(36,0),
Name = "Golden_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(72,0),
Name = "Spider_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(108,0),
Name = "Lesion_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(144,0),
Name = "Dead_Man's_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(180,0),
Name = "Solar_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(216,0),
Name = "Vortex_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(252,0),
Name = "Nebula_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(288,0),
Name = "Stardust_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(324,0),
Name = "Golf_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(360,0),
Name = "Sandstone_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(396,0),
Name = "Bamboo_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(432,0),
Name = "Desert_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(468,0),
Name = "Desert_Chest",
Variety = "Locked",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(504,0),
Name = "Reef_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(540,0),
Name = "Balloon_Chest",
},

new SpriteData()
{
TileType = 467,
Size = new(2,2),
Origin = new(576,0),
Name = "Ash_Wood_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Name = "Trapped_Crystal_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(36,0),
Name = "Trapped_Golden_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(72,0),
Name = "Trapped_Spider_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(108,0),
Name = "Trapped_Lesion_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(144,0),
Name = "Trapped_Dead_Man's_Chest_(unused_-_DO_NOT_USE)",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(180,0),
Name = "Trapped_Solar_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(216,0),
Name = "Trapped_Vortex_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(252,0),
Name = "Trapped_Nebula_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(288,0),
Name = "Trapped_Stardust_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(324,0),
Name = "Trapped_Golf_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(360,0),
Name = "Trapped_Sandstone_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(396,0),
Name = "Trapped_Bamboo_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(432,0),
Name = "Trapped_Desert_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(468,0),
Name = "Trapped_Desert_Chest_(unused_-_DO_NOT_USE)",
Variety = "Locked",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(504,0),
Name = "Trapped_Reef_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(540,0),
Name = "Trapped_Balloon_Chest",
},

new SpriteData()
{
TileType = 468,
Size = new(2,2),
Origin = new(576,0),
Name = "Trapped_Ash_Wood_Chest",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Name = "Crystal_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(54,0),
Name = "Spider_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(108,0),
Name = "Lesion_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(162,0),
Name = "Solar_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(216,0),
Name = "Vortex_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(270,0),
Name = "Nebula_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(324,0),
Name = "Stardust_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(378,0),
Name = "Sandstone_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(432,0),
Name = "Bamboo_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(486,0),
Name = "Reef_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(540,0),
Name = "Balloon_Table",
},

new SpriteData()
{
TileType = 469,
Size = new(3,2),
Origin = new(594,0),
Name = "Ash_Wood_Table",
},

new SpriteData()
{
TileType = 470,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Name = "Mannequin",
Variety = "A",
},

new SpriteData()
{
TileType = 470,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(36,0),
Name = "Womannequin",
Variety = "A",
},

new SpriteData()
{
TileType = 470,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(72,0),
Name = "Mannequin",
Variety = "B",
},

new SpriteData()
{
TileType = 470,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(108,0),
Name = "Womannequin",
Variety = "B",
},

new SpriteData()
{
TileType = 470,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(144,0),
Name = "Mannequin",
Variety = "C",
},

new SpriteData()
{
TileType = 470,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(180,0),
Name = "Womannequin",
Variety = "C",
},

new SpriteData()
{
TileType = 470,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(216,0),
Name = "Mannequin",
Variety = "D",
},

new SpriteData()
{
TileType = 470,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(252,0),
Name = "Womannequin",
Variety = "D",
},

new SpriteData()
{
TileType = 471,
Size = new(3,3),
},

new SpriteData()
{
TileType = 471,
Size = new(3,3),
Origin = new(54,0),
Name = "Flipped",
},

new SpriteData()
{
TileType = 475,
Size = new(3,4),
},

new SpriteData()
{
TileType = 475,
Size = new(3,4),
Origin = new(54,0),
Name = "Flipped",
},

new SpriteData()
{
TileType = 476,
},

new SpriteData()
{
TileType = 480,
Size = new(2,3),
Name = "Off",
},

new SpriteData()
{
TileType = 480,
Size = new(2,3),
Origin = new(0,54),
Name = "On",
},

new SpriteData()
{
TileType = 484,
Size = new(2,2),
},

new SpriteData()
{
TileType = 485,
Size = new(2,2),
},

new SpriteData()
{
TileType = 486,
Size = new(3,2),
},

new SpriteData()
{
TileType = 487,
Size = new(4,2),
Name = "Picnic_Table",
},

new SpriteData()
{
TileType = 487,
Size = new(4,2),
Origin = new(72,0),
Name = "Fancy_Picnic_Table",
},

new SpriteData()
{
TileType = 488,
Size = new(3,2),
},

new SpriteData()
{
TileType = 489,
Size = new(2,3),
},

new SpriteData()
{
TileType = 490,
Size = new(2,2),
},

new SpriteData()
{
TileType = 491,
Size = new(3,3),
},

new SpriteData()
{
TileType = 493,
Size = new(1,2),
Name = "White_Pin_Flag",
},

new SpriteData()
{
TileType = 493,
Size = new(1,2),
Origin = new(18,0),
Name = "Red_Pin_Flag",
},

new SpriteData()
{
TileType = 493,
Size = new(1,2),
Origin = new(36,0),
Name = "Green_Pin_Flag",
},

new SpriteData()
{
TileType = 493,
Size = new(1,2),
Origin = new(54,0),
Name = "Blue_Pin_Flag",
},

new SpriteData()
{
TileType = 493,
Size = new(1,2),
Origin = new(72,0),
Name = "Yellow_Pin_Flag",
},

new SpriteData()
{
TileType = 493,
Size = new(1,2),
Origin = new(90,0),
Name = "Purple_Pin_Flag",
},

new SpriteData()
{
TileType = 494,
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Name = "Ebonwood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,0),
Name = "Ebonwood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,40),
Name = "Rich_Mahogany_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,40),
Name = "Rich_Mahogany_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,80),
Name = "Pearlwood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,80),
Name = "Pearlwood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,120),
Name = "Living_Wood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,120),
Name = "Living_Wood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,160),
Name = "Cactus_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,160),
Name = "Cactus_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,200),
Name = "Bone_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,200),
Name = "Bone_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,240),
Name = "Flesh_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,240),
Name = "Flesh_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,280),
Name = "Mushroom_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,280),
Name = "Mushroom_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,320),
Name = "Skyware_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,320),
Name = "Skyware_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,360),
Name = "Shadewood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,360),
Name = "Shadewood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,400),
Name = "Lihzahrd_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,400),
Name = "Lihzahrd_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,440),
Name = "Blue_Dungeon_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,440),
Name = "Blue_Dungeon_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,480),
Name = "Green_Dungeon_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,480),
Name = "Green_Dungeon_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,520),
Name = "Pink_Dungeon_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,520),
Name = "Pink_Dungeon_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,560),
Name = "Obsidian_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,560),
Name = "Obsidian_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,600),
Name = "Frozen_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,600),
Name = "Frozen_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,640),
Name = "Glass_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,640),
Name = "Glass_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,680),
Name = "Honey_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,680),
Name = "Honey_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,720),
Name = "Steampunk_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,720),
Name = "Steampunk_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,760),
Name = "Pumpkin_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,760),
Name = "Pumpkin_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,800),
Name = "Spooky_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,800),
Name = "Spooky_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,840),
Name = "Dynasty_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,840),
Name = "Dynasty_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,880),
Name = "Palm_Wood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,880),
Name = "Palm_Wood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,920),
Name = "Boreal_Wood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,920),
Name = "Boreal_Wood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,960),
Name = "Slime_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,960),
Name = "Slime_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1000),
Name = "Martian_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1000),
Name = "Martian_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1040),
Name = "Granite_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1040),
Name = "Granite_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1080),
Name = "Marble_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1080),
Name = "Marble_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1120),
Name = "Crystal_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1120),
Name = "Crystal_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1160),
Name = "Spider_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1160),
Name = "Spider_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1200),
Name = "Lesion_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1200),
Name = "Lesion_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1240),
Name = "Diamond_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1240),
Name = "Diamond_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1280),
Name = "Meteor_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1280),
Name = "Meteor_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1320),
Name = "Solar_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1320),
Name = "Solar_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1360),
Name = "Vortex_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1360),
Name = "Vortex_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1400),
Name = "Nebula_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1400),
Name = "Nebula_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1440),
Name = "Stardust_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1440),
Name = "Stardust_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1480),
Name = "Sandstone_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1480),
Name = "Sandstone_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1520),
Name = "Bamboo_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1520),
Name = "Bamboo_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1560),
Name = "Terra_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1560),
Name = "Terra_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1600),
Name = "Reef_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1600),
Name = "Reef_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1640),
Name = "Balloon_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1640),
Name = "Balloon_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Left,
Size = new(1,2),
Origin = new(0,1680),
Name = "Ash_Wood_Toilet",
},

new SpriteData()
{
TileType = 497,
Anchor = FrameAnchor.Right,
Size = new(1,2),
Origin = new(18,1680),
Name = "Ash_Wood_Toilet",
},

new SpriteData()
{
TileType = 499,
Size = new(3,3),
},

new SpriteData()
{
TileType = 505,
Size = new(2,2),
},

new SpriteData()
{
TileType = 506,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Name = "On",
},

new SpriteData()
{
TileType = 506,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(36,0),
Name = "On",
},

new SpriteData()
{
TileType = 506,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(72,0),
Name = "Off",
},

new SpriteData()
{
TileType = 506,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(108,0),
Name = "Off",
},

new SpriteData()
{
TileType = 509,
Size = new(2,3),
Name = "Off",
},

new SpriteData()
{
TileType = 509,
Size = new(2,3),
Origin = new(0,54),
Name = "On",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Name = "Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,0),
Name = "Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,0),
Name = "Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,0),
Name = "Right",
},

new SpriteData()
{
TileType = 510,
Size = new(2,2),
Origin = new(144,0),
Name = "Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 510,
Size = new(2,2),
Origin = new(144,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,72),
Name = "Down",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,72),
Name = "Down",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,72),
Name = "Down",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,72),
Name = "Down",
},

new SpriteData()
{
TileType = 510,
Size = new(2,2),
Origin = new(144,72),
Name = "Down",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 510,
Size = new(2,2),
Origin = new(144,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,144),
Name = "Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,144),
Name = "Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,144),
Name = "Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,144),
Name = "Left",
},

new SpriteData()
{
TileType = 510,
Size = new(2,2),
Origin = new(144,144),
Name = "Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 510,
Size = new(2,2),
Origin = new(144,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,216),
Name = "Up",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,216),
Name = "Up",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,216),
Name = "Up",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,216),
Name = "Up",
},

new SpriteData()
{
TileType = 510,
Size = new(2,2),
Origin = new(144,216),
Name = "Up",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 510,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 510,
Size = new(2,2),
Origin = new(144,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Name = "Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,0),
Name = "Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,0),
Name = "Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,0),
Name = "Right",
},

new SpriteData()
{
TileType = 511,
Size = new(2,2),
Origin = new(144,0),
Name = "Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 511,
Size = new(2,2),
Origin = new(144,36),
Name = "Down-Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,72),
Name = "Down",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,72),
Name = "Down",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,72),
Name = "Down",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,72),
Name = "Down",
},

new SpriteData()
{
TileType = 511,
Size = new(2,2),
Origin = new(144,72),
Name = "Down",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 511,
Size = new(2,2),
Origin = new(144,108),
Name = "Down-Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,144),
Name = "Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,144),
Name = "Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,144),
Name = "Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,144),
Name = "Left",
},

new SpriteData()
{
TileType = 511,
Size = new(2,2),
Origin = new(144,144),
Name = "Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 511,
Size = new(2,2),
Origin = new(144,180),
Name = "Up-Left",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,216),
Name = "Up",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,216),
Name = "Up",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,216),
Name = "Up",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,216),
Name = "Up",
},

new SpriteData()
{
TileType = 511,
Size = new(2,2),
Origin = new(144,216),
Name = "Up",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(0,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Origin = new(36,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 511,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 511,
Size = new(2,2),
Origin = new(144,252),
Name = "Up-Right",
},

new SpriteData()
{
TileType = 518,
Name = "Forest_Lily_Pad",
Variety = "A",
},

new SpriteData()
{
TileType = 518,
Origin = new(18,0),
Name = "Forest_Lily_Pad",
Variety = "B",
},

new SpriteData()
{
TileType = 518,
Origin = new(36,0),
Name = "Forest_Lily_Pad",
Variety = "C",
},

new SpriteData()
{
TileType = 518,
Origin = new(54,0),
Name = "Forest_Lily_Pad",
Variety = "D",
},

new SpriteData()
{
TileType = 518,
Origin = new(72,0),
Name = "Forest_Lily_Pad",
Variety = "E",
},

new SpriteData()
{
TileType = 518,
Origin = new(90,0),
Name = "Forest_Lily_Pad",
Variety = "F",
},

new SpriteData()
{
TileType = 518,
Origin = new(108,0),
Name = "Forest_Lily_Pad",
Variety = "G",
},

new SpriteData()
{
TileType = 518,
Origin = new(126,0),
Name = "Forest_Lily_Pad",
Variety = "H",
},

new SpriteData()
{
TileType = 518,
Origin = new(144,0),
Name = "Forest_Lily_Pad",
Variety = "I",
},

new SpriteData()
{
TileType = 518,
Origin = new(162,0),
Name = "Forest_Lily_Pad",
Variety = "J",
},

new SpriteData()
{
TileType = 518,
Origin = new(180,0),
Name = "Forest_Lily_Pad",
Variety = "K",
},

new SpriteData()
{
TileType = 518,
Origin = new(198,0),
Name = "Forest_Lily_Pad",
Variety = "L",
},

new SpriteData()
{
TileType = 518,
Origin = new(216,0),
Name = "Forest_Lily_Pad",
Variety = "M",
},

new SpriteData()
{
TileType = 518,
Origin = new(234,0),
Name = "Forest_Lily_Pad",
Variety = "N",
},

new SpriteData()
{
TileType = 518,
Origin = new(252,0),
Name = "Forest_Lily_Pad",
Variety = "O",
},

new SpriteData()
{
TileType = 518,
Origin = new(270,0),
Name = "Forest_Lily_Pad",
Variety = "P",
},

new SpriteData()
{
TileType = 518,
Origin = new(288,0),
Name = "Forest_Lily_Pad",
Variety = "Q",
},

new SpriteData()
{
TileType = 518,
Origin = new(306,0),
Name = "Forest_Lily_Pad",
Variety = "R",
},

new SpriteData()
{
TileType = 518,
Origin = new(0,18),
Name = "Hallowed_Lily_Pad",
Variety = "A",
},

new SpriteData()
{
TileType = 518,
Origin = new(18,18),
Name = "Hallowed_Lily_Pad",
Variety = "B",
},

new SpriteData()
{
TileType = 518,
Origin = new(36,18),
Name = "Hallowed_Lily_Pad",
Variety = "C",
},

new SpriteData()
{
TileType = 518,
Origin = new(54,18),
Name = "Hallowed_Lily_Pad",
Variety = "D",
},

new SpriteData()
{
TileType = 518,
Origin = new(72,18),
Name = "Hallowed_Lily_Pad",
Variety = "E",
},

new SpriteData()
{
TileType = 518,
Origin = new(90,18),
Name = "Hallowed_Lily_Pad",
Variety = "F",
},

new SpriteData()
{
TileType = 518,
Origin = new(108,18),
Name = "Hallowed_Lily_Pad",
Variety = "G",
},

new SpriteData()
{
TileType = 518,
Origin = new(126,18),
Name = "Hallowed_Lily_Pad",
Variety = "H",
},

new SpriteData()
{
TileType = 518,
Origin = new(144,18),
Name = "Hallowed_Lily_Pad",
Variety = "I",
},

new SpriteData()
{
TileType = 518,
Origin = new(162,18),
Name = "Hallowed_Lily_Pad",
Variety = "J",
},

new SpriteData()
{
TileType = 518,
Origin = new(180,18),
Name = "Hallowed_Lily_Pad",
Variety = "K",
},

new SpriteData()
{
TileType = 518,
Origin = new(198,18),
Name = "Hallowed_Lily_Pad",
Variety = "L",
},

new SpriteData()
{
TileType = 518,
Origin = new(216,18),
Name = "Hallowed_Lily_Pad",
Variety = "M",
},

new SpriteData()
{
TileType = 518,
Origin = new(234,18),
Name = "Hallowed_Lily_Pad",
Variety = "N",
},

new SpriteData()
{
TileType = 518,
Origin = new(252,18),
Name = "Hallowed_Lily_Pad",
Variety = "O",
},

new SpriteData()
{
TileType = 518,
Origin = new(270,18),
Name = "Hallowed_Lily_Pad",
Variety = "P",
},

new SpriteData()
{
TileType = 518,
Origin = new(288,18),
Name = "Hallowed_Lily_Pad",
Variety = "Q",
},

new SpriteData()
{
TileType = 518,
Origin = new(306,18),
Name = "Hallowed_Lily_Pad",
Variety = "R",
},

new SpriteData()
{
TileType = 518,
Origin = new(0,36),
Name = "Jungle_Lily_Pad",
Variety = "A",
},

new SpriteData()
{
TileType = 518,
Origin = new(18,36),
Name = "Jungle_Lily_Pad",
Variety = "B",
},

new SpriteData()
{
TileType = 518,
Origin = new(36,36),
Name = "Jungle_Lily_Pad",
Variety = "C",
},

new SpriteData()
{
TileType = 518,
Origin = new(54,36),
Name = "Jungle_Lily_Pad",
Variety = "D",
},

new SpriteData()
{
TileType = 518,
Origin = new(72,36),
Name = "Jungle_Lily_Pad",
Variety = "E",
},

new SpriteData()
{
TileType = 518,
Origin = new(90,36),
Name = "Jungle_Lily_Pad",
Variety = "F",
},

new SpriteData()
{
TileType = 518,
Origin = new(108,36),
Name = "Jungle_Lily_Pad",
Variety = "G",
},

new SpriteData()
{
TileType = 518,
Origin = new(126,36),
Name = "Jungle_Lily_Pad",
Variety = "H",
},

new SpriteData()
{
TileType = 518,
Origin = new(144,36),
Name = "Jungle_Lily_Pad",
Variety = "I",
},

new SpriteData()
{
TileType = 518,
Origin = new(162,36),
Name = "Jungle_Lily_Pad",
Variety = "J",
},

new SpriteData()
{
TileType = 518,
Origin = new(180,36),
Name = "Jungle_Lily_Pad",
Variety = "K",
},

new SpriteData()
{
TileType = 518,
Origin = new(198,36),
Name = "Jungle_Lily_Pad",
Variety = "L",
},

new SpriteData()
{
TileType = 518,
Origin = new(216,36),
Name = "Jungle_Lily_Pad",
Variety = "M",
},

new SpriteData()
{
TileType = 518,
Origin = new(234,36),
Name = "Jungle_Lily_Pad",
Variety = "N",
},

new SpriteData()
{
TileType = 518,
Origin = new(252,36),
Name = "Jungle_Lily_Pad",
Variety = "O",
},

new SpriteData()
{
TileType = 518,
Origin = new(270,36),
Name = "Jungle_Lily_Pad",
Variety = "P",
},

new SpriteData()
{
TileType = 518,
Origin = new(288,36),
Name = "Jungle_Lily_Pad",
Variety = "Q",
},

new SpriteData()
{
TileType = 518,
Origin = new(306,36),
Name = "Jungle_Lily_Pad",
Variety = "R",
},

new SpriteData()
{
TileType = 518,
Origin = new(0,54),
Name = "Crimson_Lily_Pad",
Variety = "A",
},

new SpriteData()
{
TileType = 518,
Origin = new(18,54),
Name = "Crimson_Lily_Pad",
Variety = "B",
},

new SpriteData()
{
TileType = 518,
Origin = new(36,54),
Name = "Crimson_Lily_Pad",
Variety = "C",
},

new SpriteData()
{
TileType = 518,
Origin = new(54,54),
Name = "Crimson_Lily_Pad",
Variety = "D",
},

new SpriteData()
{
TileType = 518,
Origin = new(72,54),
Name = "Crimson_Lily_Pad",
Variety = "E",
},

new SpriteData()
{
TileType = 518,
Origin = new(90,54),
Name = "Crimson_Lily_Pad",
Variety = "F",
},

new SpriteData()
{
TileType = 518,
Origin = new(108,54),
Name = "Crimson_Lily_Pad",
Variety = "G",
},

new SpriteData()
{
TileType = 518,
Origin = new(126,54),
Name = "Crimson_Lily_Pad",
Variety = "H",
},

new SpriteData()
{
TileType = 518,
Origin = new(144,54),
Name = "Crimson_Lily_Pad",
Variety = "I",
},

new SpriteData()
{
TileType = 518,
Origin = new(162,54),
Name = "Crimson_Lily_Pad",
Variety = "J",
},

new SpriteData()
{
TileType = 518,
Origin = new(180,54),
Name = "Crimson_Lily_Pad",
Variety = "K",
},

new SpriteData()
{
TileType = 518,
Origin = new(198,54),
Name = "Crimson_Lily_Pad",
Variety = "L",
},

new SpriteData()
{
TileType = 518,
Origin = new(216,54),
Name = "Crimson_Lily_Pad",
Variety = "M",
},

new SpriteData()
{
TileType = 518,
Origin = new(234,54),
Name = "Crimson_Lily_Pad",
Variety = "N",
},

new SpriteData()
{
TileType = 518,
Origin = new(252,54),
Name = "Crimson_Lily_Pad",
Variety = "O",
},

new SpriteData()
{
TileType = 518,
Origin = new(270,54),
Name = "Crimson_Lily_Pad",
Variety = "P",
},

new SpriteData()
{
TileType = 518,
Origin = new(288,54),
Name = "Crimson_Lily_Pad",
Variety = "Q",
},

new SpriteData()
{
TileType = 518,
Origin = new(306,54),
Name = "Crimson_Lily_Pad",
Variety = "R",
},

new SpriteData()
{
TileType = 518,
Origin = new(0,72),
Name = "Corruption_Lily_Pad",
Variety = "A",
},

new SpriteData()
{
TileType = 518,
Origin = new(18,72),
Name = "Corruption_Lily_Pad",
Variety = "B",
},

new SpriteData()
{
TileType = 518,
Origin = new(36,72),
Name = "Corruption_Lily_Pad",
Variety = "C",
},

new SpriteData()
{
TileType = 518,
Origin = new(54,72),
Name = "Corruption_Lily_Pad",
Variety = "D",
},

new SpriteData()
{
TileType = 518,
Origin = new(72,72),
Name = "Corruption_Lily_Pad",
Variety = "E",
},

new SpriteData()
{
TileType = 518,
Origin = new(90,72),
Name = "Corruption_Lily_Pad",
Variety = "F",
},

new SpriteData()
{
TileType = 518,
Origin = new(108,72),
Name = "Corruption_Lily_Pad",
Variety = "G",
},

new SpriteData()
{
TileType = 518,
Origin = new(126,72),
Name = "Corruption_Lily_Pad",
Variety = "H",
},

new SpriteData()
{
TileType = 518,
Origin = new(144,72),
Name = "Corruption_Lily_Pad",
Variety = "I",
},

new SpriteData()
{
TileType = 518,
Origin = new(162,72),
Name = "Corruption_Lily_Pad",
Variety = "J",
},

new SpriteData()
{
TileType = 518,
Origin = new(180,72),
Name = "Corruption_Lily_Pad",
Variety = "K",
},

new SpriteData()
{
TileType = 518,
Origin = new(198,72),
Name = "Corruption_Lily_Pad",
Variety = "L",
},

new SpriteData()
{
TileType = 518,
Origin = new(216,72),
Name = "Corruption_Lily_Pad",
Variety = "M",
},

new SpriteData()
{
TileType = 518,
Origin = new(234,72),
Name = "Corruption_Lily_Pad",
Variety = "N",
},

new SpriteData()
{
TileType = 518,
Origin = new(252,72),
Name = "Corruption_Lily_Pad",
Variety = "O",
},

new SpriteData()
{
TileType = 518,
Origin = new(270,72),
Name = "Corruption_Lily_Pad",
Variety = "P",
},

new SpriteData()
{
TileType = 518,
Origin = new(288,72),
Name = "Corruption_Lily_Pad",
Variety = "Q",
},

new SpriteData()
{
TileType = 518,
Origin = new(306,72),
Name = "Corruption_Lily_Pad",
Variety = "R",
},

new SpriteData()
{
TileType = 519,
Name = "Forest_Cattail",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(18,0),
Name = "Forest_Cattail",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(36,0),
Name = "Forest_Cattail",
Variety = "Base_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(54,0),
Name = "Forest_Cattail",
Variety = "Base_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(72,0),
Name = "Forest_Cattail",
Variety = "Base_E",
},

new SpriteData()
{
TileType = 519,
Origin = new(90,0),
Name = "Forest_Cattail",
Variety = "Flower_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(108,0),
Name = "Forest_Cattail",
Variety = "Stem_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(126,0),
Name = "Forest_Cattail",
Variety = "Stem_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(144,0),
Name = "Forest_Cattail",
Variety = "Stem_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(162,0),
Name = "Forest_Cattail",
Variety = "Stem_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(180,0),
Name = "Forest_Cattail",
Variety = "Flower_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(198,0),
Name = "Forest_Cattail",
Variety = "Flower_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(216,0),
Name = "Forest_Cattail",
Variety = "Flower_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(0,18),
Name = "Jungle_Cattail",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(18,18),
Name = "Jungle_Cattail",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(36,18),
Name = "Jungle_Cattail",
Variety = "Base_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(54,18),
Name = "Jungle_Cattail",
Variety = "Base_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(72,18),
Name = "Jungle_Cattail",
Variety = "Base_E",
},

new SpriteData()
{
TileType = 519,
Origin = new(90,18),
Name = "Jungle_Cattail",
Variety = "Flower_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(108,18),
Name = "Jungle_Cattail",
Variety = "Stem_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(126,18),
Name = "Jungle_Cattail",
Variety = "Stem_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(144,18),
Name = "Jungle_Cattail",
Variety = "Stem_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(162,18),
Name = "Jungle_Cattail",
Variety = "Stem_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(180,18),
Name = "Jungle_Cattail",
Variety = "Flower_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(198,18),
Name = "Jungle_Cattail",
Variety = "Flower_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(216,18),
Name = "Jungle_Cattail",
Variety = "Flower_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(0,36),
Name = "Hallowed_Cattail",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(18,36),
Name = "Hallowed_Cattail",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(36,36),
Name = "Hallowed_Cattail",
Variety = "Base_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(54,36),
Name = "Hallowed_Cattail",
Variety = "Base_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(72,36),
Name = "Hallowed_Cattail",
Variety = "Base_E",
},

new SpriteData()
{
TileType = 519,
Origin = new(90,36),
Name = "Hallowed_Cattail",
Variety = "Flower_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(108,36),
Name = "Hallowed_Cattail",
Variety = "Stem_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(126,36),
Name = "Hallowed_Cattail",
Variety = "Stem_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(144,36),
Name = "Hallowed_Cattail",
Variety = "Stem_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(162,36),
Name = "Hallowed_Cattail",
Variety = "Stem_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(180,36),
Name = "Hallowed_Cattail",
Variety = "Flower_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(198,36),
Name = "Hallowed_Cattail",
Variety = "Flower_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(216,36),
Name = "Hallowed_Cattail",
Variety = "Flower_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(0,54),
Name = "Crimson_Cattail",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(18,54),
Name = "Crimson_Cattail",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(36,54),
Name = "Crimson_Cattail",
Variety = "Base_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(54,54),
Name = "Crimson_Cattail",
Variety = "Base_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(72,54),
Name = "Crimson_Cattail",
Variety = "Base_E",
},

new SpriteData()
{
TileType = 519,
Origin = new(90,54),
Name = "Crimson_Cattail",
Variety = "Flower_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(108,54),
Name = "Crimson_Cattail",
Variety = "Stem_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(126,54),
Name = "Crimson_Cattail",
Variety = "Stem_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(144,54),
Name = "Crimson_Cattail",
Variety = "Stem_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(162,54),
Name = "Crimson_Cattail",
Variety = "Stem_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(180,54),
Name = "Crimson_Cattail",
Variety = "Flower_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(198,54),
Name = "Crimson_Cattail",
Variety = "Flower_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(216,54),
Name = "Crimson_Cattail",
Variety = "Flower_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(0,72),
Name = "Corruption_Cattail",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(18,72),
Name = "Corruption_Cattail",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(36,72),
Name = "Corruption_Cattail",
Variety = "Base_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(54,72),
Name = "Corruption_Cattail",
Variety = "Base_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(72,72),
Name = "Corruption_Cattail",
Variety = "Base_E",
},

new SpriteData()
{
TileType = 519,
Origin = new(90,72),
Name = "Corruption_Cattail",
Variety = "Flower_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(108,72),
Name = "Corruption_Cattail",
Variety = "Stem_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(126,72),
Name = "Corruption_Cattail",
Variety = "Stem_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(144,72),
Name = "Corruption_Cattail",
Variety = "Stem_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(162,72),
Name = "Corruption_Cattail",
Variety = "Stem_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(180,72),
Name = "Corruption_Cattail",
Variety = "Flower_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(198,72),
Name = "Corruption_Cattail",
Variety = "Flower_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(216,72),
Name = "Corruption_Cattail",
Variety = "Flower_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(0,90),
Name = "Mushroom_Cattail",
Variety = "Base_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(18,90),
Name = "Mushroom_Cattail",
Variety = "Base_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(36,90),
Name = "Mushroom_Cattail",
Variety = "Base_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(54,90),
Name = "Mushroom_Cattail",
Variety = "Base_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(72,90),
Name = "Mushroom_Cattail",
Variety = "Base_E",
},

new SpriteData()
{
TileType = 519,
Origin = new(90,90),
Name = "Mushroom_Cattail",
Variety = "Flower_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(108,90),
Name = "Mushroom_Cattail",
Variety = "Stem_A",
},

new SpriteData()
{
TileType = 519,
Origin = new(126,90),
Name = "Mushroom_Cattail",
Variety = "Stem_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(144,90),
Name = "Mushroom_Cattail",
Variety = "Stem_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(162,90),
Name = "Mushroom_Cattail",
Variety = "Stem_D",
},

new SpriteData()
{
TileType = 519,
Origin = new(180,90),
Name = "Mushroom_Cattail",
Variety = "Flower_B",
},

new SpriteData()
{
TileType = 519,
Origin = new(198,90),
Name = "Mushroom_Cattail",
Variety = "Flower_C",
},

new SpriteData()
{
TileType = 519,
Origin = new(216,90),
Name = "Mushroom_Cattail",
Variety = "Flower_D",
},

new SpriteData()
{
TileType = 520,
Name = "A",
},

new SpriteData()
{
TileType = 520,
Origin = new(18,0),
Name = "B",
},

new SpriteData()
{
TileType = 521,
Size = new(2,2),
},

new SpriteData()
{
TileType = 522,
Size = new(2,2),
},

new SpriteData()
{
TileType = 523,
Size = new(2,2),
},

new SpriteData()
{
TileType = 524,
Size = new(2,2),
},

new SpriteData()
{
TileType = 525,
Size = new(2,2),
},

new SpriteData()
{
TileType = 526,
Size = new(2,2),
},

new SpriteData()
{
TileType = 527,
Size = new(2,2),
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Name = "Oasis_Sea_Oats",
Variety = "A",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(18,0),
Name = "Oasis_Sea_Oats",
Variety = "B",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(36,0),
Name = "Oasis_Sea_Oats",
Variety = "C",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(54,0),
Name = "Oasis_Sea_Oats",
Variety = "D",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(72,0),
Name = "Oasis_Sea_Oats",
Variety = "E",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(90,0),
Name = "Oasis_Sea_Oats",
Variety = "F",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(108,0),
Name = "Oasis_Sea_Oats",
Variety = "G",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(126,0),
Name = "Oasis_Sea_Oats",
Variety = "H",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(144,0),
Name = "Oasis_Sea_Oats",
Variety = "I",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(162,0),
Name = "Oasis_Sea_Oats",
Variety = "J",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(180,0),
Name = "Oasis_Sea_Oats",
Variety = "K",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(198,0),
Name = "Oasis_Sea_Oats",
Variety = "L",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(216,0),
Name = "Oasis_Sea_Oats",
Variety = "M",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(234,0),
Name = "Oasis_Sea_Oats",
Variety = "N",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(252,0),
Name = "Oasis_Sea_Oats",
Variety = "O",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(0,34),
Name = "Ocean_Sea_Oats",
Variety = "A",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(18,34),
Name = "Ocean_Sea_Oats",
Variety = "B",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(36,34),
Name = "Ocean_Sea_Oats",
Variety = "C",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(54,34),
Name = "Ocean_Sea_Oats",
Variety = "D",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(72,34),
Name = "Ocean_Sea_Oats",
Variety = "E",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(90,34),
Name = "Ocean_Sea_Oats",
Variety = "F",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(108,34),
Name = "Ocean_Sea_Oats",
Variety = "G",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(126,34),
Name = "Ocean_Sea_Oats",
Variety = "H",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(144,34),
Name = "Ocean_Sea_Oats",
Variety = "I",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(162,34),
Name = "Ocean_Sea_Oats",
Variety = "J",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(180,34),
Name = "Ocean_Sea_Oats",
Variety = "K",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(198,34),
Name = "Ocean_Sea_Oats",
Variety = "L",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(216,34),
Name = "Ocean_Sea_Oats",
Variety = "M",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(234,34),
Name = "Ocean_Sea_Oats",
Variety = "N",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(252,34),
Name = "Ocean_Sea_Oats",
Variety = "O",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(0,68),
Name = "Hallowed_Sea_Oats",
Variety = "A",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(18,68),
Name = "Hallowed_Sea_Oats",
Variety = "B",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(36,68),
Name = "Hallowed_Sea_Oats",
Variety = "C",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(54,68),
Name = "Hallowed_Sea_Oats",
Variety = "D",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(72,68),
Name = "Hallowed_Sea_Oats",
Variety = "E",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(90,68),
Name = "Hallowed_Sea_Oats",
Variety = "F",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(108,68),
Name = "Hallowed_Sea_Oats",
Variety = "G",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(126,68),
Name = "Hallowed_Sea_Oats",
Variety = "H",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(144,68),
Name = "Hallowed_Sea_Oats",
Variety = "I",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(162,68),
Name = "Hallowed_Sea_Oats",
Variety = "J",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(180,68),
Name = "Hallowed_Sea_Oats",
Variety = "K",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(198,68),
Name = "Hallowed_Sea_Oats",
Variety = "L",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(216,68),
Name = "Hallowed_Sea_Oats",
Variety = "M",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(234,68),
Name = "Hallowed_Sea_Oats",
Variety = "N",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(252,68),
Name = "Hallowed_Sea_Oats",
Variety = "O",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(0,102),
Name = "Crimson_Sea_Oats",
Variety = "A",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(18,102),
Name = "Crimson_Sea_Oats",
Variety = "B",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(36,102),
Name = "Crimson_Sea_Oats",
Variety = "C",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(54,102),
Name = "Crimson_Sea_Oats",
Variety = "D",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(72,102),
Name = "Crimson_Sea_Oats",
Variety = "E",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(90,102),
Name = "Crimson_Sea_Oats",
Variety = "F",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(108,102),
Name = "Crimson_Sea_Oats",
Variety = "G",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(126,102),
Name = "Crimson_Sea_Oats",
Variety = "H",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(144,102),
Name = "Crimson_Sea_Oats",
Variety = "I",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(162,102),
Name = "Crimson_Sea_Oats",
Variety = "J",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(180,102),
Name = "Crimson_Sea_Oats",
Variety = "K",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(198,102),
Name = "Crimson_Sea_Oats",
Variety = "L",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(216,102),
Name = "Crimson_Sea_Oats",
Variety = "M",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(234,102),
Name = "Crimson_Sea_Oats",
Variety = "N",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(252,102),
Name = "Crimson_Sea_Oats",
Variety = "O",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(0,136),
Name = "Corruption_Sea_Oats",
Variety = "A",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(18,136),
Name = "Corruption_Sea_Oats",
Variety = "B",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(36,136),
Name = "Corruption_Sea_Oats",
Variety = "C",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(54,136),
Name = "Corruption_Sea_Oats",
Variety = "D",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(72,136),
Name = "Corruption_Sea_Oats",
Variety = "E",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(90,136),
Name = "Corruption_Sea_Oats",
Variety = "F",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(108,136),
Name = "Corruption_Sea_Oats",
Variety = "G",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(126,136),
Name = "Corruption_Sea_Oats",
Variety = "H",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(144,136),
Name = "Corruption_Sea_Oats",
Variety = "I",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(162,136),
Name = "Corruption_Sea_Oats",
Variety = "J",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(180,136),
Name = "Corruption_Sea_Oats",
Variety = "K",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(198,136),
Name = "Corruption_Sea_Oats",
Variety = "L",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(216,136),
Name = "Corruption_Sea_Oats",
Variety = "M",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(234,136),
Name = "Corruption_Sea_Oats",
Variety = "N",
},

new SpriteData()
{
TileType = 529,
Size = new(1,2),
Origin = new(252,136),
Name = "Corruption_Sea_Oats",
Variety = "O",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Name = "A",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(54,0),
Name = "B",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(108,0),
Name = "C",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(162,0),
Name = "D",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(216,0),
Name = "E",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(270,0),
Name = "F",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(324,0),
Name = "G",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(378,0),
Name = "H",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(432,0),
Name = "I",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(0,36),
Name = "Hallowed_Oasis_Plants",
Variety = "A",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(54,36),
Name = "Hallowed_Oasis_Plants",
Variety = "B",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(108,36),
Name = "Hallowed_Oasis_Plants",
Variety = "C",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(162,36),
Name = "Hallowed_Oasis_Plants",
Variety = "D",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(216,36),
Name = "Hallowed_Oasis_Plants",
Variety = "E",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(270,36),
Name = "Hallowed_Oasis_Plants",
Variety = "F",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(324,36),
Name = "Hallowed_Oasis_Plants",
Variety = "G",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(378,36),
Name = "Hallowed_Oasis_Plants",
Variety = "H",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(432,36),
Name = "Hallowed_Oasis_Plants",
Variety = "I",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(0,72),
Name = "Crimson_Oasis_Plants",
Variety = "A",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(54,72),
Name = "Crimson_Oasis_Plants",
Variety = "B",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(108,72),
Name = "Crimson_Oasis_Plants",
Variety = "C",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(162,72),
Name = "Crimson_Oasis_Plants",
Variety = "D",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(216,72),
Name = "Crimson_Oasis_Plants",
Variety = "E",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(270,72),
Name = "Crimson_Oasis_Plants",
Variety = "F",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(324,72),
Name = "Crimson_Oasis_Plants",
Variety = "G",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(378,72),
Name = "Crimson_Oasis_Plants",
Variety = "H",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(432,72),
Name = "Crimson_Oasis_Plants",
Variety = "I",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(0,108),
Name = "Corruption_Oasis_Plants",
Variety = "A",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(54,108),
Name = "Corruption_Oasis_Plants",
Variety = "B",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(108,108),
Name = "Corruption_Oasis_Plants",
Variety = "C",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(162,108),
Name = "Corruption_Oasis_Plants",
Variety = "D",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(216,108),
Name = "Corruption_Oasis_Plants",
Variety = "E",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(270,108),
Name = "Corruption_Oasis_Plants",
Variety = "F",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(324,108),
Name = "Corruption_Oasis_Plants",
Variety = "G",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(378,108),
Name = "Corruption_Oasis_Plants",
Variety = "H",
},

new SpriteData()
{
TileType = 530,
Size = new(3,2),
Origin = new(432,108),
Name = "Corruption_Oasis_Plants",
Variety = "I",
},

new SpriteData()
{
TileType = 531,
Size = new(2,3),
},

new SpriteData()
{
TileType = 532,
Size = new(3,2),
},

new SpriteData()
{
TileType = 533,
Size = new(3,2),
},

new SpriteData()
{
TileType = 538,
Size = new(3,2),
},

new SpriteData()
{
TileType = 542,
Size = new(6,3),
},

new SpriteData()
{
TileType = 543,
Size = new(2,2),
},

new SpriteData()
{
TileType = 544,
Size = new(3,2),
},

new SpriteData()
{
TileType = 545,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Name = "Leg_Up",
},

new SpriteData()
{
TileType = 545,
Anchor = FrameAnchor.Left,
Size = new(2,3),
Origin = new(36,0),
Name = "Leg_Down",
},

new SpriteData()
{
TileType = 545,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(0,54),
Name = "Leg_Up",
},

new SpriteData()
{
TileType = 545,
Anchor = FrameAnchor.Right,
Size = new(2,3),
Origin = new(36,54),
Name = "Leg_Down",
},

new SpriteData()
{
TileType = 547,
Size = new(2,5),
Name = "Potted_Forest_Cedar",
},

new SpriteData()
{
TileType = 547,
Size = new(2,5),
Origin = new(36,0),
Name = "Potted_Jungle_Cedar",
},

new SpriteData()
{
TileType = 547,
Size = new(2,5),
Origin = new(72,0),
Name = "Potted_Hallow_Cedar",
},

new SpriteData()
{
TileType = 547,
Size = new(2,5),
Origin = new(108,0),
Name = "Potted_Forest_Tree",
},

new SpriteData()
{
TileType = 547,
Size = new(2,5),
Origin = new(144,0),
Name = "Potted_Jungle_Tree",
},

new SpriteData()
{
TileType = 548,
Size = new(3,6),
Name = "Potted_Hallow_Tree",
},

new SpriteData()
{
TileType = 548,
Size = new(3,6),
Origin = new(54,0),
Name = "Potted_Forest_Palm",
},

new SpriteData()
{
TileType = 548,
Size = new(3,6),
Origin = new(108,0),
Name = "Potted_Jungle_Palm",
},

new SpriteData()
{
TileType = 548,
Size = new(3,6),
Origin = new(162,0),
Name = "Potted_Hallow_Palm",
},

new SpriteData()
{
TileType = 548,
Size = new(3,6),
Origin = new(216,0),
Name = "Potted_Forest_Bamboo",
},

new SpriteData()
{
TileType = 548,
Size = new(3,6),
Origin = new(270,0),
Name = "Potted_Jungle_Bamboo",
},

new SpriteData()
{
TileType = 548,
Size = new(3,6),
Origin = new(324,0),
Name = "Potted_Hallow_Bamboo",
},

new SpriteData()
{
TileType = 548,
Size = new(3,6),
Origin = new(378,0),
Name = "Potted_Magma_Palm",
},

new SpriteData()
{
TileType = 548,
Size = new(3,6),
Origin = new(432,0),
Name = "Potted_Brimstone_Bush",
},

new SpriteData()
{
TileType = 549,
Name = "A",
},

new SpriteData()
{
TileType = 549,
Origin = new(18,0),
Name = "B",
},

new SpriteData()
{
TileType = 549,
Origin = new(36,0),
Name = "C",
},

new SpriteData()
{
TileType = 549,
Origin = new(54,0),
Name = "D",
},

new SpriteData()
{
TileType = 549,
Origin = new(72,0),
Name = "E",
},

new SpriteData()
{
TileType = 549,
Origin = new(90,0),
Name = "F",
},

new SpriteData()
{
TileType = 549,
Origin = new(108,0),
Name = "G",
},

new SpriteData()
{
TileType = 549,
Origin = new(126,0),
Name = "H",
},

new SpriteData()
{
TileType = 549,
Origin = new(144,0),
Name = "I",
},

new SpriteData()
{
TileType = 549,
Origin = new(162,0),
Name = "J",
},

new SpriteData()
{
TileType = 549,
Origin = new(180,0),
Name = "K",
},

new SpriteData()
{
TileType = 549,
Origin = new(198,0),
Name = "L",
},

new SpriteData()
{
TileType = 549,
Origin = new(216,0),
Name = "M",
},

new SpriteData()
{
TileType = 550,
Size = new(6,3),
},

new SpriteData()
{
TileType = 551,
Size = new(6,3),
},

new SpriteData()
{
TileType = 552,
Size = new(3,2),
Name = "A",
},

new SpriteData()
{
TileType = 552,
Size = new(3,2),
Origin = new(54,0),
Name = "B",
},

new SpriteData()
{
TileType = 552,
Size = new(3,2),
Origin = new(108,0),
Name = "C",
},

new SpriteData()
{
TileType = 552,
Size = new(3,2),
Origin = new(162,0),
Name = "D",
},

new SpriteData()
{
TileType = 553,
Size = new(6,3),
},

new SpriteData()
{
TileType = 554,
Size = new(6,3),
},

new SpriteData()
{
TileType = 555,
Size = new(3,2),
},

new SpriteData()
{
TileType = 556,
Size = new(3,2),
},

new SpriteData()
{
TileType = 558,
Size = new(6,3),
},

new SpriteData()
{
TileType = 559,
Size = new(6,3),
},

new SpriteData()
{
TileType = 560,
Size = new(2,3),
Name = "Bronze_Golf_Trophy",
},

new SpriteData()
{
TileType = 560,
Size = new(2,3),
Origin = new(36,0),
Name = "Silver_Golf_Trophy",
},

new SpriteData()
{
TileType = 560,
Size = new(2,3),
Origin = new(72,0),
Name = "Gold_Golf_Trophy",
},

new SpriteData()
{
TileType = 564,
Size = new(2,2),
Name = "On",
},

new SpriteData()
{
TileType = 564,
Size = new(2,2),
Origin = new(36,0),
Name = "Off",
},

new SpriteData()
{
TileType = 565,
Size = new(2,2),
Name = "On",
},

new SpriteData()
{
TileType = 565,
Size = new(2,2),
Origin = new(36,0),
Name = "Off",
},

new SpriteData()
{
TileType = 567,
Size = new(1,2),
Name = "A",
},

new SpriteData()
{
TileType = 567,
Size = new(1,2),
Origin = new(28,0),
Name = "B",
},

new SpriteData()
{
TileType = 567,
Size = new(1,2),
Origin = new(56,0),
Name = "C",
},

new SpriteData()
{
TileType = 567,
Size = new(1,2),
Origin = new(84,0),
Name = "D",
},

new SpriteData()
{
TileType = 567,
Size = new(1,2),
Origin = new(112,0),
Name = "E",
},

new SpriteData()
{
TileType = 568,
Size = new(2,2),
},

new SpriteData()
{
TileType = 569,
Size = new(2,2),
},

new SpriteData()
{
TileType = 570,
Size = new(2,2),
},

new SpriteData()
{
TileType = 571,
Name = "Base_A",
},

new SpriteData()
{
TileType = 571,
Origin = new(18,0),
Name = "Base_B",
},

new SpriteData()
{
TileType = 571,
Origin = new(36,0),
Name = "Base_C",
},

new SpriteData()
{
TileType = 571,
Origin = new(54,0),
Name = "Base_D",
},

new SpriteData()
{
TileType = 571,
Origin = new(72,0),
Name = "Base_E",
},

new SpriteData()
{
TileType = 571,
Origin = new(90,0),
Name = "Stem_A",
},

new SpriteData()
{
TileType = 571,
Origin = new(108,0),
Name = "Stem_B",
},

new SpriteData()
{
TileType = 571,
Origin = new(126,0),
Name = "Stem_C",
},

new SpriteData()
{
TileType = 571,
Origin = new(144,0),
Name = "Stem_D",
},

new SpriteData()
{
TileType = 571,
Origin = new(162,0),
Name = "Stem_E",
},

new SpriteData()
{
TileType = 571,
Origin = new(180,0),
Name = "Stem_F",
},

new SpriteData()
{
TileType = 571,
Origin = new(198,0),
Name = "Stem_G",
},

new SpriteData()
{
TileType = 571,
Origin = new(216,0),
Name = "Stem_H",
},

new SpriteData()
{
TileType = 571,
Origin = new(234,0),
Name = "Base_F",
},

new SpriteData()
{
TileType = 571,
Origin = new(252,0),
Name = "Top_A",
},

new SpriteData()
{
TileType = 571,
Origin = new(270,0),
Name = "Top_B",
},

new SpriteData()
{
TileType = 571,
Origin = new(288,0),
Name = "Top_C",
},

new SpriteData()
{
TileType = 571,
Origin = new(306,0),
Name = "Top_D",
},

new SpriteData()
{
TileType = 571,
Origin = new(324,0),
Name = "Top_E",
},

new SpriteData()
{
TileType = 571,
Origin = new(342,0),
Name = "Top_F",
},

new SpriteData()
{
TileType = 572,
Size = new(1,2),
Name = "Soul_of_Light_in_a_Bottle",
},

new SpriteData()
{
TileType = 572,
Size = new(1,2),
Origin = new(0,36),
Name = "Soul_of_Night_in_a_Bottle",
},

new SpriteData()
{
TileType = 572,
Size = new(1,2),
Origin = new(0,72),
Name = "Soul_of_Flight_in_a_Bottle",
},

new SpriteData()
{
TileType = 572,
Size = new(1,2),
Origin = new(0,108),
Name = "Soul_of_Sight_in_a_Bottle",
},

new SpriteData()
{
TileType = 572,
Size = new(1,2),
Origin = new(0,144),
Name = "Soul_of_Might_in_a_Bottle",
},

new SpriteData()
{
TileType = 572,
Size = new(1,2),
Origin = new(0,180),
Name = "Soul_of_Fright_in_a_Bottle",
},

new SpriteData()
{
TileType = 573,
Anchor = FrameAnchor.Top,
Size = new(2,2),
Name = "Ground",
},

new SpriteData()
{
TileType = 573,
Anchor = FrameAnchor.Bottom,
Size = new(2,2),
Origin = new(36,0),
Name = "Hanging",
},

new SpriteData()
{
TileType = 573,
Anchor = FrameAnchor.Left,
Size = new(2,2),
Origin = new(72,0),
Name = "Left_Side",
},

new SpriteData()
{
TileType = 573,
Anchor = FrameAnchor.Right,
Size = new(2,2),
Origin = new(108,0),
Name = "Right_Side",
},

new SpriteData()
{
TileType = 573,
Size = new(2,2),
Origin = new(144,0),
Name = "Wall",
},

new SpriteData()
{
TileType = 579,
Anchor = FrameAnchor.Left,
Name = "A",
},

new SpriteData()
{
TileType = 579,
Anchor = FrameAnchor.Right,
Origin = new(22,0),
Name = "A",
},

new SpriteData()
{
TileType = 579,
Anchor = FrameAnchor.Left,
Origin = new(0,22),
Name = "B",
},

new SpriteData()
{
TileType = 579,
Anchor = FrameAnchor.Right,
Origin = new(22,22),
Name = "B",
},

new SpriteData()
{
TileType = 580,
Size = new(2,2),
},

new SpriteData()
{
TileType = 581,
Size = new(1,2),
},

new SpriteData()
{
TileType = 582,
Size = new(3,2),
},

new SpriteData()
{
TileType = 583,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(22,0),
Name = "Trunk_Ore_Right_Indent_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(22,22),
Name = "Trunk_Ore_Right_Indent_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(22,44),
Name = "Trunk_Ore_Right_Indent_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,66),
Name = "Trunk_Ore_Left_Indent_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 583,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,88),
Name = "Trunk_Ore_Left_Indent_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 583,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,110),
Name = "Trunk_Ore_Left_Indent_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 583,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 583,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 583,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 583,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 583,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 583,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 583,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 583,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 584,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(22,0),
Name = "Trunk_Ore_Right_Indent_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(22,22),
Name = "Trunk_Ore_Right_Indent_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(22,44),
Name = "Trunk_Ore_Right_Indent_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,66),
Name = "Trunk_Ore_Left_Indent_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 584,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,88),
Name = "Trunk_Ore_Left_Indent_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 584,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,110),
Name = "Trunk_Ore_Left_Indent_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 584,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 584,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 584,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 584,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 584,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 584,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 584,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 584,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 585,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(22,0),
Name = "Trunk_Ore_Right_Indent_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(22,22),
Name = "Trunk_Ore_Right_Indent_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(22,44),
Name = "Trunk_Ore_Right_Indent_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,66),
Name = "Trunk_Ore_Left_Indent_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 585,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,88),
Name = "Trunk_Ore_Left_Indent_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 585,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,110),
Name = "Trunk_Ore_Left_Indent_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 585,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 585,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 585,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 585,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 585,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 585,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 585,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 585,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 586,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(22,0),
Name = "Trunk_Ore_Right_Indent_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(22,22),
Name = "Trunk_Ore_Right_Indent_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(22,44),
Name = "Trunk_Ore_Right_Indent_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,66),
Name = "Trunk_Ore_Left_Indent_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 586,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,88),
Name = "Trunk_Ore_Left_Indent_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 586,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,110),
Name = "Trunk_Ore_Left_Indent_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 586,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 586,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 586,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 586,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 586,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 586,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 586,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 586,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 587,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(22,0),
Name = "Trunk_Ore_Right_Indent_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(22,22),
Name = "Trunk_Ore_Right_Indent_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(22,44),
Name = "Trunk_Ore_Right_Indent_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,66),
Name = "Trunk_Ore_Left_Indent_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 587,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,88),
Name = "Trunk_Ore_Left_Indent_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 587,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,110),
Name = "Trunk_Ore_Left_Indent_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 587,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 587,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 587,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 587,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 587,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 587,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 587,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 587,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 588,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(22,0),
Name = "Trunk_Ore_Right_Indent_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(22,22),
Name = "Trunk_Ore_Right_Indent_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(22,44),
Name = "Trunk_Ore_Right_Indent_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,66),
Name = "Trunk_Ore_Left_Indent_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 588,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,88),
Name = "Trunk_Ore_Left_Indent_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 588,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,110),
Name = "Trunk_Ore_Left_Indent_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 588,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 588,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 588,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 588,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 588,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 588,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 588,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 588,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 589,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(22,0),
Name = "Trunk_Ore_Right_Indent_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(22,22),
Name = "Trunk_Ore_Right_Indent_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(22,44),
Name = "Trunk_Ore_Right_Indent_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,66),
Name = "Trunk_Ore_Left_Indent_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 589,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,88),
Name = "Trunk_Ore_Left_Indent_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 589,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,110),
Name = "Trunk_Ore_Left_Indent_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 589,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 589,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 589,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 589,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 589,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 589,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 589,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 589,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Name = "Topaz_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(18,0),
Name = "Topaz_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(36,0),
Name = "Topaz_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(54,0),
Name = "Amethyst_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(72,0),
Name = "Amethyst_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(90,0),
Name = "Amethyst_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(108,0),
Name = "Sapphire_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(126,0),
Name = "Sapphire_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(144,0),
Name = "Sapphire_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(162,0),
Name = "Emerald_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(180,0),
Name = "Emerald_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(198,0),
Name = "Emerald_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(216,0),
Name = "Ruby_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(234,0),
Name = "Ruby_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(252,0),
Name = "Ruby_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(270,0),
Name = "Diamond_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(288,0),
Name = "Diamond_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(306,0),
Name = "Diamond_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(324,0),
Name = "Amber_Sapling",
Variety = "A",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(342,0),
Name = "Amber_Sapling",
Variety = "B",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(360,0),
Name = "Amber_Sapling",
Variety = "C",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(378,0),
Name = "Amber_Sapling",
Variety = "D",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(396,0),
Name = "Amber_Sapling",
Variety = "E",
},

new SpriteData()
{
TileType = 590,
Size = new(1,2),
Origin = new(414,0),
Name = "Amber_Sapling",
Variety = "F",
},

new SpriteData()
{
TileType = 591,
Size = new(2,3),
Name = "Hanging_Pot",
},

new SpriteData()
{
TileType = 591,
Size = new(2,3),
Origin = new(36,0),
Name = "Hanging_Daybloom",
},

new SpriteData()
{
TileType = 591,
Size = new(2,3),
Origin = new(72,0),
Name = "Hanging_Moonglow",
},

new SpriteData()
{
TileType = 591,
Size = new(2,3),
Origin = new(108,0),
Name = "Hanging_Waterleaf",
},

new SpriteData()
{
TileType = 591,
Size = new(2,3),
Origin = new(144,0),
Name = "Hanging_Shiverthorn",
},

new SpriteData()
{
TileType = 591,
Size = new(2,3),
Origin = new(180,0),
Name = "Hanging_Blinkroot",
},

new SpriteData()
{
TileType = 591,
Size = new(2,3),
Origin = new(216,0),
Name = "Hanging_Corrupt_Deathweed",
},

new SpriteData()
{
TileType = 591,
Size = new(2,3),
Origin = new(252,0),
Name = "Hanging_Crimson_Deathweed",
},

new SpriteData()
{
TileType = 591,
Size = new(2,3),
Origin = new(288,0),
Name = "Hanging_Fireblossom",
},

new SpriteData()
{
TileType = 592,
Size = new(2,3),
},

new SpriteData()
{
TileType = 593,
},

new SpriteData()
{
TileType = 594,
Size = new(2,2),
},

new SpriteData()
{
TileType = 595,
Size = new(1,2),
Name = "A",
},

new SpriteData()
{
TileType = 595,
Size = new(1,2),
Origin = new(18,0),
Name = "B",
},

new SpriteData()
{
TileType = 595,
Size = new(1,2),
Origin = new(36,0),
Name = "C",
},

new SpriteData()
{
TileType = 596,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(22,0),
Name = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(22,22),
Name = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(22,44),
Name = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,66),
Name = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 596,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,88),
Name = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 596,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,110),
Name = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 596,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 596,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 596,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 596,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 596,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 596,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 596,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 596,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 597,
Anchor = FrameAnchor.Bottom,
Size = new(3,4),
Name = "Forest_Pylon",
},

new SpriteData()
{
TileType = 597,
Anchor = FrameAnchor.Bottom,
Size = new(3,4),
Origin = new(54,0),
Name = "Jungle_Pylon",
},

new SpriteData()
{
TileType = 597,
Anchor = FrameAnchor.Bottom,
Size = new(3,4),
Origin = new(108,0),
Name = "Hallow_Pylon",
},

new SpriteData()
{
TileType = 597,
Anchor = FrameAnchor.Bottom,
Size = new(3,4),
Origin = new(162,0),
Name = "Cavern_Pylon",
},

new SpriteData()
{
TileType = 597,
Anchor = FrameAnchor.Bottom,
Size = new(3,4),
Origin = new(216,0),
Name = "Ocean_Pylon",
},

new SpriteData()
{
TileType = 597,
Anchor = FrameAnchor.Bottom,
Size = new(3,4),
Origin = new(270,0),
Name = "Desert_Pylon",
},

new SpriteData()
{
TileType = 597,
Anchor = FrameAnchor.Bottom,
Size = new(3,4),
Origin = new(324,0),
Name = "Snow_Pylon",
},

new SpriteData()
{
TileType = 597,
Anchor = FrameAnchor.Bottom,
Size = new(3,4),
Origin = new(378,0),
Name = "Mushroom_Pylon",
},

new SpriteData()
{
TileType = 597,
Anchor = FrameAnchor.Bottom,
Size = new(3,4),
Origin = new(432,0),
Name = "Universal_Pylon",
},

new SpriteData()
{
TileType = 598,
Size = new(2,2),
},

new SpriteData()
{
TileType = 599,
Size = new(6,3),
},

new SpriteData()
{
TileType = 600,
Size = new(6,3),
},

new SpriteData()
{
TileType = 601,
Size = new(6,3),
},

new SpriteData()
{
TileType = 602,
Size = new(6,3),
},

new SpriteData()
{
TileType = 603,
Size = new(6,3),
},

new SpriteData()
{
TileType = 604,
Size = new(6,3),
},

new SpriteData()
{
TileType = 605,
Size = new(6,3),
},

new SpriteData()
{
TileType = 606,
Size = new(6,3),
},

new SpriteData()
{
TileType = 607,
Size = new(6,3),
},

new SpriteData()
{
TileType = 608,
Size = new(6,3),
},

new SpriteData()
{
TileType = 609,
Size = new(6,3),
},

new SpriteData()
{
TileType = 610,
Size = new(6,3),
},

new SpriteData()
{
TileType = 611,
Size = new(6,3),
},

new SpriteData()
{
TileType = 612,
Size = new(6,3),
},

new SpriteData()
{
TileType = 613,
Size = new(3,5),
Name = "Potted_Fire_Brambles",
},

new SpriteData()
{
TileType = 613,
Size = new(3,5),
Origin = new(54,0),
Name = "Potted_Lava_Bulb",
},

new SpriteData()
{
TileType = 614,
Size = new(3,6),
},

new SpriteData()
{
TileType = 615,
Size = new(1,2),
Name = "A",
},

new SpriteData()
{
TileType = 615,
Size = new(1,2),
Origin = new(18,0),
Name = "B",
},

new SpriteData()
{
TileType = 615,
Size = new(1,2),
Origin = new(36,0),
Name = "C",
},

new SpriteData()
{
TileType = 616,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(22,0),
Name = "Trunk_Right_Indent_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(22,22),
Name = "Trunk_Right_Indent_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(22,44),
Name = "Trunk_Right_Indent_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,66),
Name = "Trunk_Left_Indent_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 616,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,88),
Name = "Trunk_Left_Indent_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 616,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,110),
Name = "Trunk_Left_Indent_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 616,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 616,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 616,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 616,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 616,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 616,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 616,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 616,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 617,
Size = new(3,4),
Name = "Left",
},

new SpriteData()
{
TileType = 617,
Size = new(3,4),
Origin = new(0,72),
Name = "Right",
},

new SpriteData()
{
TileType = 619,
Size = new(3,2),
},

new SpriteData()
{
TileType = 620,
Size = new(2,2),
},

new SpriteData()
{
TileType = 621,
Size = new(2,2),
},

new SpriteData()
{
TileType = 622,
Size = new(2,2),
},

new SpriteData()
{
TileType = 623,
Size = new(2,5),
Name = "Potted_Crystal_Fern",
},

new SpriteData()
{
TileType = 623,
Size = new(2,5),
Origin = new(36,0),
Name = "Potted_Crystal_Spiral",
},

new SpriteData()
{
TileType = 623,
Size = new(2,5),
Origin = new(72,0),
Name = "Potted_Crystal_Teardrop",
},

new SpriteData()
{
TileType = 623,
Size = new(2,5),
Origin = new(108,0),
Name = "Potted_Crystal_Tree",
},

new SpriteData()
{
TileType = 624,
},

new SpriteData()
{
TileType = 629,
Size = new(3,2),
},

new SpriteData()
{
TileType = 630,
Anchor = FrameAnchor.Bottom,
},

new SpriteData()
{
TileType = 630,
Anchor = FrameAnchor.Top,
Origin = new(18,0),
},

new SpriteData()
{
TileType = 630,
Anchor = FrameAnchor.Right,
Origin = new(36,0),
},

new SpriteData()
{
TileType = 630,
Anchor = FrameAnchor.Left,
Origin = new(54,0),
},

new SpriteData()
{
TileType = 630,
Origin = new(72,0),
},

new SpriteData()
{
TileType = 631,
Anchor = FrameAnchor.Bottom,
},

new SpriteData()
{
TileType = 631,
Anchor = FrameAnchor.Top,
Origin = new(18,0),
},

new SpriteData()
{
TileType = 631,
Anchor = FrameAnchor.Right,
Origin = new(36,0),
},

new SpriteData()
{
TileType = 631,
Anchor = FrameAnchor.Left,
Origin = new(54,0),
},

new SpriteData()
{
TileType = 631,
Origin = new(72,0),
},

new SpriteData()
{
TileType = 632,
Size = new(6,3),
},

new SpriteData()
{
TileType = 634,
Name = "Trunk_Plain_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(22,0),
Name = "Trunk_Ore_Right_Indent_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(44,0),
Name = "Trunk_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(66,0),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(88,0),
Name = "Trunk_Left_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(110,0),
Name = "Top_Medium_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(132,0),
Name = "Top_Small_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(154,0),
Name = "Top_Large_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,22),
Name = "Trunk_Plain_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(22,22),
Name = "Trunk_Ore_Right_Indent_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(44,22),
Name = "Trunk_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(66,22),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(88,22),
Name = "Trunk_Left_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(110,22),
Name = "Top_Medium_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(132,22),
Name = "Top_Small_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(154,22),
Name = "Top_Large_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,44),
Name = "Trunk_Plain_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(22,44),
Name = "Trunk_Ore_Right_Indent_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(44,44),
Name = "Trunk_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(66,44),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(88,44),
Name = "Trunk_Left_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(110,44),
Name = "Top_Medium_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(132,44),
Name = "Top_Small_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(154,44),
Name = "Top_Large_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,66),
Name = "Trunk_Ore_Left_Indent_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(22,66),
Name = "Trunk_Right_Bulge_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(44,66),
Name = "Trunk_Left_Bulge_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(66,66),
Name = "Trunk_Right_Slight_Bulge_D",
},

new SpriteData()
{
TileType = 634,
Origin = new(88,66),
Name = "Branch_Plain_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(110,66),
Name = "Trunk_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(132,66),
Name = "Top_Small_Right_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(154,66),
Name = "Top_Large_D",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,88),
Name = "Trunk_Ore_Left_Indent_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(22,88),
Name = "Trunk_Right_Bulge_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(44,88),
Name = "Trunk_Left_Bulge_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(66,88),
Name = "Trunk_Right_Slight_Bulge_E",
},

new SpriteData()
{
TileType = 634,
Origin = new(88,88),
Name = "Branch_Plain_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(110,88),
Name = "Trunk_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(132,88),
Name = "Top_Small_Right_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(154,88),
Name = "Top_Large_E",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,110),
Name = "Trunk_Ore_Left_Indent_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(22,110),
Name = "Trunk_Right_Bulge_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(44,110),
Name = "Trunk_Left_Bulge_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(66,110),
Name = "Trunk_Right_Slight_Bulge_F",
},

new SpriteData()
{
TileType = 634,
Origin = new(88,110),
Name = "Branch_Plain_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(110,110),
Name = "Trunk_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(132,110),
Name = "Top_Small_Right_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(154,110),
Name = "Top_Large_F",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,132),
Name = "Trunk_Large_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(22,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(44,132),
Name = "Base_Plain_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(66,132),
Name = "Trunk_Large_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(88,132),
Name = "Trunk_Large_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(132,132),
Name = "Top_Small_Double_Slight_Bulge_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(154,132),
Name = "Top_Huge_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,154),
Name = "Trunk_Large_D",
},

new SpriteData()
{
TileType = 634,
Origin = new(22,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(44,154),
Name = "Base_Plain_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(66,154),
Name = "Trunk_Large_E",
},

new SpriteData()
{
TileType = 634,
Origin = new(88,154),
Name = "Trunk_Large_F",
},

new SpriteData()
{
TileType = 634,
Origin = new(132,154),
Name = "Top_Small_Double_Slight_Bulge_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(154,154),
Name = "Top_Huge_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,176),
Name = "Trunk_Large_G",
},

new SpriteData()
{
TileType = 634,
Origin = new(22,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(44,176),
Name = "Base_Plain_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(66,176),
Name = "Trunk_Large_H",
},

new SpriteData()
{
TileType = 634,
Origin = new(88,176),
Name = "Trunk_Large_I",
},

new SpriteData()
{
TileType = 634,
Origin = new(132,176),
Name = "Top_Small_Double_Slight_Bulge_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(154,176),
Name = "Top_Huge_C",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,198),
Name = "Top_Jagged_A",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,220),
Name = "Top_Jagged_B",
},

new SpriteData()
{
TileType = 634,
Origin = new(0,242),
Name = "Top_Jagged_C",
},

new SpriteData()
{
TileType = 637,
Name = "Grass_A",
},

new SpriteData()
{
TileType = 637,
Origin = new(18,0),
Name = "Grass_B",
},

new SpriteData()
{
TileType = 637,
Origin = new(36,0),
Name = "Grass_C",
},

new SpriteData()
{
TileType = 637,
Origin = new(54,0),
Name = "Grass_D",
},

new SpriteData()
{
TileType = 637,
Origin = new(72,0),
Name = "Grass_E",
},

new SpriteData()
{
TileType = 637,
Origin = new(90,0),
Name = "Grass_F",
},

new SpriteData()
{
TileType = 637,
Origin = new(108,0),
Name = "Flower_A",
},

new SpriteData()
{
TileType = 637,
Origin = new(126,0),
Name = "Flower_B",
},

new SpriteData()
{
TileType = 637,
Origin = new(144,0),
Name = "Flower_C",
},

new SpriteData()
{
TileType = 637,
Origin = new(162,0),
Name = "Flower_D",
},

new SpriteData()
{
TileType = 637,
Origin = new(180,0),
Name = "Flower_E",
},

new SpriteData()
{
TileType = 639,
Size = new(2,2),
},

new SpriteData()
{
TileType = 640,
Size = new(6,3),
},

new SpriteData()
{
TileType = 642,
Size = new(3,3),
},

new SpriteData()
{
TileType = 643,
Size = new(6,3),
},

new SpriteData()
{
TileType = 644,
Size = new(6,3),
},

new SpriteData()
{
TileType = 645,
Size = new(6,3),
},

new SpriteData()
{
TileType = 646,
Name = "On",
},

new SpriteData()
{
TileType = 646,
Origin = new(18,0),
Name = "Off",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Name = "Bone_A",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(54,0),
Name = "Bone_B",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(108,0),
Name = "Bone_C",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(162,0),
Name = "Bone_D",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(216,0),
Name = "Bone_E",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(270,0),
Name = "Bone_F",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(324,0),
Name = "Bone_G",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(378,0),
Name = "Stone_A",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(432,0),
Name = "Stone_B",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(486,0),
Name = "Stone_C",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(540,0),
Name = "Stone_D",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(594,0),
Name = "Stone_E",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(648,0),
Name = "Stone_F",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(702,0),
Name = "Stone_G",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(756,0),
Name = "Stone_H",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(810,0),
Name = "Stone_I",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(864,0),
Name = "Copper_Coin_A",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(918,0),
Name = "Copper_Coin_B",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(972,0),
Name = "Silver_Coin_A",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1026,0),
Name = "Silver_Coin_B",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1080,0),
Name = "Gold_Coin_A",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1134,0),
Name = "Gold_Coin_B",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1188,0),
Name = "Wood_A",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1242,0),
Name = "Wood_B",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1296,0),
Name = "Wood_C",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1350,0),
Name = "Wood_D",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1404,0),
Name = "Snow_A",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1458,0),
Name = "Snow_B",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1512,0),
Name = "Snow_C",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1566,0),
Name = "Snow_D",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1620,0),
Name = "Snow_E",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1674,0),
Name = "Snow_F",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1728,0),
Name = "Mushroom_A",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1782,0),
Name = "Mushroom_B",
},

new SpriteData()
{
TileType = 647,
Size = new(3,2),
Origin = new(1836,0),
Name = "Mushroom_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Name = "Jungle_Seeds_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(54,0),
Name = "Jungle_Seeds_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(108,0),
Name = "Jungle_Seeds_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(162,0),
Name = "Jungle_Seeds_D",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(216,0),
Name = "Jungle_Seeds_E",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(270,0),
Name = "Jungle_Seeds_F",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(324,0),
Name = "Hellstone_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(378,0),
Name = "Hellstone_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(432,0),
Name = "Hellstone_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(486,0),
Name = "Cobweb_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(540,0),
Name = "Cobweb_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(594,0),
Name = "Cobweb_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(648,0),
Name = "Cobweb_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(702,0),
Name = "Cobweb_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(756,0),
Name = "Stone_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(810,0),
Name = "Stone_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(864,0),
Name = "Stone_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(918,0),
Name = "Enchanted_Sword",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(972,0),
Name = "Lihzahrd_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1026,0),
Name = "Lihzahrd_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1080,0),
Name = "Lihzahrd_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1134,0),
Name = "Wood_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1188,0),
Name = "Wood_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1242,0),
Name = "Wood_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1296,0),
Name = "Wood_D",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1350,0),
Name = "Wood_E",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1404,0),
Name = "Wood_F",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1458,0),
Name = "Wood_G",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1512,0),
Name = "Wood_H",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1566,0),
Name = "Sandstone_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1620,0),
Name = "Sandstone_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1674,0),
Name = "Sandstone_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1728,0),
Name = "Sandstone_D",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1782,0),
Name = "Sandstone_E",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1836,0),
Name = "Sandstone_F",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(0,36),
Name = "Granite_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(54,36),
Name = "Granite_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(108,36),
Name = "Granite_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(162,36),
Name = "Granite_D",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(216,36),
Name = "Granite_E",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(270,36),
Name = "Granite_F",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(324,36),
Name = "Marble_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(378,36),
Name = "Marble_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(432,36),
Name = "Marble_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(486,36),
Name = "Marble_D",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(540,36),
Name = "Marble_E",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(594,36),
Name = "Marble_F",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(648,36),
Name = "Grass_Seeds_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(702,36),
Name = "Grass_Seeds_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(756,36),
Name = "Grass_Seeds_C",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(810,36),
Name = "Grass_Seeds_D",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(864,36),
Name = "Grass_Seeds_E",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(918,36),
Name = "Bone_A",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(972,36),
Name = "Bone_B",
},

new SpriteData()
{
TileType = 648,
Size = new(3,2),
Origin = new(1026,36),
Name = "Bone_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Name = "Stone_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(36,0),
Name = "Stone_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(72,0),
Name = "Stone_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(108,0),
Name = "Stone_D",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(144,0),
Name = "Stone_E",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(180,0),
Name = "Stone_F",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(216,0),
Name = "Bone_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(252,0),
Name = "Bone_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(288,0),
Name = "Bone_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(324,0),
Name = "Bone_D",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(360,0),
Name = "Bone_E",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(396,0),
Name = "Bone_F",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(432,0),
Name = "Bone_G",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(468,0),
Name = "Bone_H",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(504,0),
Name = "Bone_I",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(540,0),
Name = "Bone_J",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(576,0),
Name = "Copper_Coin",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(612,0),
Name = "Silver_Coin",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(648,0),
Name = "Gold_Coin",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(684,0),
Name = "Amethyst",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(720,0),
Name = "Topaz",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(756,0),
Name = "Sapphire",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(792,0),
Name = "Emerald",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(828,0),
Name = "Ruby",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(864,0),
Name = "Diamond",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(900,0),
Name = "Snow_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(936,0),
Name = "Snow_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(972,0),
Name = "Snow_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1008,0),
Name = "Snow_D",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1044,0),
Name = "Snow_E",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1080,0),
Name = "Snow_F",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1116,0),
Name = "Wood_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1152,0),
Name = "Wood_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1188,0),
Name = "Wood_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1224,0),
Name = "Cobweb_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1260,0),
Name = "Cobweb_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1296,0),
Name = "Cobweb_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1332,0),
Name = "Cobweb_D",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1368,0),
Name = "Stone_G",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1404,0),
Name = "Stone_H",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1440,0),
Name = "Stone_I",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1476,0),
Name = "Sandstone_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1512,0),
Name = "Sandstone_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1548,0),
Name = "Sandstone_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1584,0),
Name = "Sandstone_D",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1620,0),
Name = "Sandstone_E",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1656,0),
Name = "Sandstone_F",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1692,0),
Name = "Granite_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1728,0),
Name = "Granite_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1764,0),
Name = "Granite_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1800,0),
Name = "Granite_D",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1836,0),
Name = "Granite_E",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(1872,0),
Name = "Granite_F",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(0,18),
Name = "Marble_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(36,18),
Name = "Marble_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(72,18),
Name = "Marble_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(108,18),
Name = "Marble_D",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(144,18),
Name = "Marble_E",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(180,18),
Name = "Marble_F",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(216,18),
Name = "Grass_Seeds_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(252,18),
Name = "Grass_Seeds_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(288,18),
Name = "Grass_Seeds_C",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(324,18),
Name = "Sand_A",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(360,18),
Name = "Sand_B",
},

new SpriteData()
{
TileType = 649,
Size = new(2,1),
Origin = new(396,18),
Name = "Sand_C",
},

new SpriteData()
{
TileType = 650,
Name = "Stone_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(18,0),
Name = "Stone_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(36,0),
Name = "Stone_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(54,0),
Name = "Stone_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(72,0),
Name = "Stone_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(90,0),
Name = "Stone_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(108,0),
Name = "Dirt_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(126,0),
Name = "Dirt_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(144,0),
Name = "Dirt_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(162,0),
Name = "Dirt_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(180,0),
Name = "Dirt_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(198,0),
Name = "Dirt_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(216,0),
Name = "Bone_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(234,0),
Name = "Bone_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(252,0),
Name = "Bone_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(270,0),
Name = "Bone_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(288,0),
Name = "Bone_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(306,0),
Name = "Bone_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(324,0),
Name = "Bone_G",
},

new SpriteData()
{
TileType = 650,
Origin = new(342,0),
Name = "Bone_H",
},

new SpriteData()
{
TileType = 650,
Origin = new(360,0),
Name = "Bone_I",
},

new SpriteData()
{
TileType = 650,
Origin = new(378,0),
Name = "Bone_J",
},

new SpriteData()
{
TileType = 650,
Origin = new(396,0),
Name = "Bone_K",
},

new SpriteData()
{
TileType = 650,
Origin = new(414,0),
Name = "Bone_L",
},

new SpriteData()
{
TileType = 650,
Origin = new(432,0),
Name = "Bone_M",
},

new SpriteData()
{
TileType = 650,
Origin = new(450,0),
Name = "Bone_N",
},

new SpriteData()
{
TileType = 650,
Origin = new(468,0),
Name = "Bone_O",
},

new SpriteData()
{
TileType = 650,
Origin = new(486,0),
Name = "Bone_P",
},

new SpriteData()
{
TileType = 650,
Origin = new(504,0),
Name = "Wood_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(522,0),
Name = "Wood_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(540,0),
Name = "Wood_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(558,0),
Name = "Wood_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(576,0),
Name = "Wood_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(594,0),
Name = "Wood_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(612,0),
Name = "Wood_G",
},

new SpriteData()
{
TileType = 650,
Origin = new(630,0),
Name = "Wood_H",
},

new SpriteData()
{
TileType = 650,
Origin = new(648,0),
Name = "Snow_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(666,0),
Name = "Snow_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(684,0),
Name = "Snow_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(702,0),
Name = "Snow_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(720,0),
Name = "Snow_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(738,0),
Name = "Snow_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(756,0),
Name = "Ice_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(774,0),
Name = "Ice_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(792,0),
Name = "Ice_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(810,0),
Name = "Ice_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(828,0),
Name = "Ice_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(846,0),
Name = "Ice_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(864,0),
Name = "Cobweb_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(882,0),
Name = "Cobweb_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(900,0),
Name = "Cobweb_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(918,0),
Name = "Cobweb_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(936,0),
Name = "Cobweb_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(954,0),
Name = "Cobweb_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(972,0),
Name = "Sandstone_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(990,0),
Name = "Sandstone_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(1008,0),
Name = "Sandstone_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(1026,0),
Name = "Sandstone_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(1044,0),
Name = "Sandstone_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(1062,0),
Name = "Sandstone_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(1080,0),
Name = "Granite_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(1098,0),
Name = "Granite_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(1116,0),
Name = "Granite_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(1134,0),
Name = "Granite_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(1152,0),
Name = "Granite_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(1170,0),
Name = "Granite_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(1188,0),
Name = "Marble_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(1206,0),
Name = "Marble_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(1224,0),
Name = "Marble_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(1242,0),
Name = "Marble_D",
},

new SpriteData()
{
TileType = 650,
Origin = new(1260,0),
Name = "Marble_E",
},

new SpriteData()
{
TileType = 650,
Origin = new(1278,0),
Name = "Marble_F",
},

new SpriteData()
{
TileType = 650,
Origin = new(1296,0),
Name = "Grass_Seed",
},

new SpriteData()
{
TileType = 650,
Origin = new(1314,0),
Name = "Sand_A",
},

new SpriteData()
{
TileType = 650,
Origin = new(1332,0),
Name = "Sand_B",
},

new SpriteData()
{
TileType = 650,
Origin = new(1350,0),
Name = "Sand_C",
},

new SpriteData()
{
TileType = 650,
Origin = new(1368,0),
Name = "Sand_D",
},

new SpriteData()
{
TileType = 651,
Size = new(3,2),
Name = "Jungle_Seeds_A",
},

new SpriteData()
{
TileType = 651,
Size = new(3,2),
Origin = new(54,0),
Name = "Jungle_Seeds_B",
},

new SpriteData()
{
TileType = 651,
Size = new(3,2),
Origin = new(108,0),
Name = "Jungle_Seeds_C",
},

new SpriteData()
{
TileType = 651,
Size = new(3,2),
Origin = new(162,0),
Name = "Grass_Seeds_A",
},

new SpriteData()
{
TileType = 651,
Size = new(3,2),
Origin = new(216,0),
Name = "Grass_Seeds_B",
},

new SpriteData()
{
TileType = 651,
Size = new(3,2),
Origin = new(270,0),
Name = "Grass_Seeds_C",
},

new SpriteData()
{
TileType = 651,
Size = new(3,2),
Origin = new(324,0),
Name = "Jungle_Spores_A",
},

new SpriteData()
{
TileType = 651,
Size = new(3,2),
Origin = new(378,0),
Name = "Jungle_Spores_B",
},

new SpriteData()
{
TileType = 651,
Size = new(3,2),
Origin = new(432,0),
Name = "Jungle_Spores_C",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Name = "Jungle_Seeds_A",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(36,0),
Name = "Jungle_Seeds_B",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(72,0),
Name = "Jungle_Seeds_C",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(108,0),
Name = "Grass_Seeds_A",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(144,0),
Name = "Grass_Seeds_B",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(180,0),
Name = "Grass_Seeds_C",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(216,0),
Name = "Jungle_Spores_A",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(252,0),
Name = "Jungle_Spores_B",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(288,0),
Name = "Jungle_Spores_C",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(324,0),
Name = "Jungle_Spores_D",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(360,0),
Name = "Jungle_Spores_E",
},

new SpriteData()
{
TileType = 652,
Size = new(2,2),
Origin = new(396,0),
Name = "Jungle_Spores_F",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Name = "Forest_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,0),
Name = "Forest_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,0),
Name = "Forest_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,36),
Name = "Forest_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,36),
Name = "Forest_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,36),
Name = "Forest_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,72),
Name = "Forest_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,72),
Name = "Forest_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,72),
Name = "Forest_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,108),
Name = "Forest_Pot",
Variety = "D1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,108),
Name = "Forest_Pot",
Variety = "D2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,108),
Name = "Forest_Pot",
Variety = "D3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,144),
Name = "Tundra_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,144),
Name = "Tundra_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,144),
Name = "Tundra_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,180),
Name = "Tundra_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,180),
Name = "Tundra_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,180),
Name = "Tundra_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,216),
Name = "Tundra_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,216),
Name = "Tundra_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,216),
Name = "Tundra_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,252),
Name = "Jungle_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,252),
Name = "Jungle_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,252),
Name = "Jungle_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,288),
Name = "Jungle_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,288),
Name = "Jungle_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,288),
Name = "Jungle_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,324),
Name = "Jungle_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,324),
Name = "Jungle_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,324),
Name = "Jungle_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,360),
Name = "Dungeon_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,360),
Name = "Dungeon_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,360),
Name = "Dungeon_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,396),
Name = "Dungeon_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,396),
Name = "Dungeon_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,396),
Name = "Dungeon_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,432),
Name = "Dungeon_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,432),
Name = "Dungeon_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,432),
Name = "Dungeon_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,468),
Name = "Underworld_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,468),
Name = "Underworld_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,468),
Name = "Underworld_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,504),
Name = "Underworld_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,504),
Name = "Underworld_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,504),
Name = "Underworld_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,540),
Name = "Underworld_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,540),
Name = "Underworld_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,540),
Name = "Underworld_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,576),
Name = "Corruption_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,576),
Name = "Corruption_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,576),
Name = "Corruption_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,612),
Name = "Corruption_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,612),
Name = "Corruption_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,612),
Name = "Corruption_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,648),
Name = "Corruption_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,648),
Name = "Corruption_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,648),
Name = "Corruption_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,648),
Name = "Corruption_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,684),
Name = "Spider_Cave_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,684),
Name = "Spider_Cave_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,684),
Name = "Spider_Cave_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,720),
Name = "Spider_Cave_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,720),
Name = "Spider_Cave_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,720),
Name = "Spider_Cave_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,756),
Name = "Spider_Cave_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,756),
Name = "Spider_Cave_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,756),
Name = "Spider_Cave_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,792),
Name = "Crimson_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,792),
Name = "Crimson_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,792),
Name = "Crimson_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,828),
Name = "Crimson_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,828),
Name = "Crimson_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,828),
Name = "Crimson_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,864),
Name = "Crimson_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,864),
Name = "Crimson_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,864),
Name = "Crimson_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,900),
Name = "Pyramid_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,900),
Name = "Pyramid_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,900),
Name = "Pyramid_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,936),
Name = "Pyramid_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,936),
Name = "Pyramid_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,936),
Name = "Pyramid_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,972),
Name = "Pyramid_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,972),
Name = "Pyramid_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,972),
Name = "Pyramid_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,1008),
Name = "Lihzahrd_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,1008),
Name = "Lihzahrd_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,1008),
Name = "Lihzahrd_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,1044),
Name = "Lihzahrd_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,1044),
Name = "Lihzahrd_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,1044),
Name = "Lihzahrd_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,1080),
Name = "Lihzahrd_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,1080),
Name = "Lihzahrd_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,1080),
Name = "Lihzahrd_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,1116),
Name = "Marble_Cave_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,1116),
Name = "Marble_Cave_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,1116),
Name = "Marble_Cave_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,1152),
Name = "Marble_Cave_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,1152),
Name = "Marble_Cave_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,1152),
Name = "Marble_Cave_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,1188),
Name = "Marble_Cave_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,1188),
Name = "Marble_Cave_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,1188),
Name = "Marble_Cave_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,1224),
Name = "Underground_Desert_Pot",
Variety = "A1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,1224),
Name = "Underground_Desert_Pot",
Variety = "A2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,1224),
Name = "Underground_Desert_Pot",
Variety = "A3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,1260),
Name = "Underground_Desert_Pot",
Variety = "B1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,1260),
Name = "Underground_Desert_Pot",
Variety = "B2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,1260),
Name = "Underground_Desert_Pot",
Variety = "B3",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(0,1296),
Name = "Underground_Desert_Pot",
Variety = "C1",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(36,1296),
Name = "Underground_Desert_Pot",
Variety = "C2",
},

new SpriteData()
{
TileType = 653,
Size = new(2,2),
Origin = new(72,1296),
Name = "Underground_Desert_Pot",
Variety = "C3",
},

new SpriteData()
{
TileType = 654,
Size = new(2,2),
},

new SpriteData()
{
TileType = 656,
Size = new(2,2),
},

new SpriteData()
{
TileType = 657,
Size = new(2,3),
},

new SpriteData()
{
TileType = 658,
Size = new(2,3),
Name = "Off_(Flowing)",
},

new SpriteData()
{
TileType = 658,
Size = new(2,3),
Origin = new(0,540),
Name = "On",
},

new SpriteData()
{
TileType = 658,
Size = new(2,3),
Origin = new(0,1080),
Name = "Off",
},

new SpriteData()
{
TileType = 660,
Size = new(1,2),
},

new SpriteData()
{
TileType = 663,
Size = new(2,3),
},

new SpriteData()
{
TileType = 664,
Size = new(2,2),
},

new SpriteData()
{
TileType = 665,
Size = new(2,2),
},
};
    }
}
