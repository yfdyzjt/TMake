using Neo.IronLua;
using System.Drawing;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static Sign PlaceSign<T>(T area, Point position, FrameData sprite) where T : ITileArea
        {
            PlaceSprite(area, position, sprite);
            return GetSign(area, position);
        }
        public static Chest PlaceChest<T>(T area, Point position, FrameData sprite) where T : ITileArea
        {
            PlaceSprite(area, position, sprite);
            return GetChest(area, position);
        }
        public static TileEntity PlaceTileEntity<T>(T area, Point position, FrameData sprite) where T : ITileArea
        {
            PlaceSprite(area, position, sprite);
            return GetTileEntity(area, position);
        }
        public static Tile? PlaceSprite<T>(T area, Point position, FrameData sprite) where T : ITileArea
        {
            Rectangle selection = Rectangle.Intersect(
                new(position, new(sprite.Size)),
                new(0, 0, area.MaxTilesX, area.MaxTilesY));

            DeleteChests(area, selection);
            DeleteSigns(area, selection);
            DeleteTileEntities(area, selection);

            var tileDate = TileProperty.GetTileData(sprite.Type);
            for (int x = selection.Left, i = 0; x < selection.Right; x++, i++)
            {
                for (int y = selection.Top, j = 0; y < selection.Bottom; y++, j++)
                {
                    Tile tile = area.Tile[x, y];
                    tile.Active = true;
                    tile.Type = sprite.Type;
                    tile.FrameX = (short)(i * (tileDate.TextureGrid.X + 2) + sprite.Origin.X);
                    tile.FrameY = (short)(j * (tileDate.TextureGrid.Y + 2) + sprite.Origin.Y);

                    if (sprite.Type == (ushort)TileID.ChristmasTree && x == 0 && y == 0) tile.FrameX = 10;
                }
            }

            if (selection.Contains(position))
            {
                if (IsChest(sprite.Type))
                {
                    area.Chest.Add(new Chest() { X = position.X, Y = position.Y });
                }
                else if (IsSign(sprite.Type))
                {
                    area.Sign.Add(new Sign() { X = position.X, Y = position.Y });
                }
                else if (IsTileEntity(sprite.Type))
                {
                    area.TileEntity.Add(GetTileEntityFromSprite(area, position, sprite));
                }
                return area.Tile[position.X, position.Y];
            }
            return null;
        }
        private static TileEntity GetTileEntityFromSprite<T>(T area, Point position, FrameData sprite) where T : ITileArea
        {
            TileEntity TE = new()
            {
                X = position.X,
                Y = position.Y,
                ID = area.TileEntity.Count
            };
            if (sprite.Type == (int)TileID.TargetDummy)
            {
                TE.Type = 0;
                TE.NPC = new() { Type = (int)NPCID.TargetDummy };
            }
            else if (sprite.Type == (int)TileID.ItemFrame)
            {
                TE.Type = 1;
                TE.Item = new() { Type = 0, Prefix = 0, StackSize = 0 };
            }
            else if (sprite.Type == (int)TileID.LogicSensor)
            {
                TE.Type = 2;
                TE.On = false;
                TE.LogicCheck = (byte)(sprite.Origin.Y / 18 + 1);
            }
            else if (sprite.Type == (int)TileID.Mannequin || sprite.Type == (int)TileID.Womannequin || sprite.Type == (int)TileID.DisplayDoll)
            {
                TE.Type = 3;
                TE.Items = Enumerable.Repeat(new Item(), 8).ToArray();
                TE.Dyes = Enumerable.Repeat(new Item(), 8).ToArray();
            }
            else if (sprite.Type == (int)TileID.WeaponsRack || sprite.Type == (int)TileID.WeaponsRack2)
            {
                TE.Type = 4;
                TE.Item = new() { Type = 0, Prefix = 0, StackSize = 0 };
            }
            else if (sprite.Type == (int)TileID.HatRack)
            {
                TE.Type = 5;
                TE.Items = Enumerable.Repeat(new Item(), 2).ToArray();
                TE.Dyes = Enumerable.Repeat(new Item(), 2).ToArray();
            }
            else if (sprite.Type == (int)TileID.FoodPlatter)
            {
                TE.Type = 6;
                TE.Item = new() { Type = 0, Prefix = 0, StackSize = 0 };
            }
            else if (sprite.Type == (int)TileID.TeleportationPylon)
            {
                TE.Type = 7;
            }
            return TE;
        }
    }
}
