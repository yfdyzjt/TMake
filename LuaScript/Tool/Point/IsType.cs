using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static bool IsChest(int tileType)
        {
            return tileType == (int)TileID.Containers
                || tileType == (int)TileID.Dressers
                || tileType == (int)TileID.Containers2
                || tileType == (int)TileID.FakeContainers
                || tileType == (int)TileID.FakeContainers2;
        }
        public static bool IsSign(int tileType)
        {
            return tileType == (int)TileID.Signs
                || tileType == (int)TileID.Tombstones
                || tileType == (int)TileID.AnnouncementBox
                || tileType == (int)TileID.TatteredWoodSign;
        }
        public static bool IsTileEntity(int tileType)
        {
            return tileType == (int)TileID.DisplayDoll
                || tileType == (int)TileID.Mannequin
                || tileType == (int)TileID.Womannequin
                || tileType == (int)TileID.FoodPlatter
                || tileType == (int)TileID.TargetDummy
                || tileType == (int)TileID.ItemFrame
                || tileType == (int)TileID.LogicSensor
                || tileType == (int)TileID.WeaponsRack
                || tileType == (int)TileID.WeaponsRack2
                || tileType == (int)TileID.HatRack
                || tileType == (int)TileID.TeleportationPylon;
        }
    }
}
