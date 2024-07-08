using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        internal static void ValidateTileIsNormalLogicLamp(Tile tile)
        {
            if (tile.Type != (ushort)TileID.LogicGateLamp)
                throw new Exception($"Tile type: {tile.Type} is not a logic lamp");
            if (FrameProperty.GetFrameData(tile).Variety == "Faulty")
                throw new Exception($"This logic lamp is a faulty logic lamp");
        }
    }
}
