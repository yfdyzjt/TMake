using System.Drawing;
using TMake.Terraria;

namespace TMake.Script
{
    public static partial class Tool
    {
        public static void PlaceSprite<T>(T area, Point position, SpriteData sprite) where T : ITileArea
        {
            Rectangle selection = Rectangle.Intersect(
                new(position, new(sprite.Size)),
                new(0, 0, area.MaxTilesX, area.MaxTilesY));

            DeleteChests(area, selection, false);
            DeleteSigns(area, selection, false);
            DeleteTileEntities(area, selection, false);

            var tileDate = TileProperty.GetTileData(sprite.TileType);
            if (sprite.TileType == (ushort)TileID.ChristmasTree)
            {
                for (int x = selection.Left, i = 0; x < selection.Right; x++, i++)
                {
                    for (int y = selection.Top, j = 0; y < selection.Bottom; y++, j++)
                    {
                        Tile tile = area.Tile[x, y];
                        tile.Active = true;
                        tile.Type = sprite.TileType;
                        if (x == 0 && y == 0)
                        {
                            tile.FrameX = 10;
                        }
                        else
                        {
                            tile.FrameX = (short)(x * (tileDate.TextureGrid.X + 2) + sprite.Origin.X);
                        }
                        tile.FrameY = (short)(y * (tileDate.TextureGrid.Y + 2) + sprite.Origin.Y);
                    }
                }
            }
            else
            {
                for (int x = selection.Left, i = 0; x < selection.Right; x++, i++)
                {
                    for (int y = selection.Top, j = 0; y < selection.Bottom; y++, j++)
                    {
                        Tile tile = area.Tile[x, y];
                        tile.Active = true;
                        tile.Type = sprite.TileType;
                        tile.FrameX = (short)(i * (tileDate.TextureGrid.X + 2) + sprite.Origin.X);
                        tile.FrameY = (short)(j * (tileDate.TextureGrid.Y + 2) + sprite.Origin.Y);
                    }
                }
            }

            if (selection.Contains(position))
            {
                if (IsChest(sprite.TileType))
                {
                    area.Chest.Add(new Chest() { X = position.X, Y = position.Y });
                }
                else if (IsSign(sprite.TileType))
                {
                    area.Sign.Add(new Sign() { X = position.X, Y = position.Y });
                }
                else if (IsTileEntity(sprite.TileType))
                {
                    TileEntity TE = new()
                    {
                        X = position.X,
                        Y = position.Y,
                        ID = area.TileEntity.Count
                    };
                    if (sprite.TileType == (int)TileID.TargetDummy)
                    {
                        TE.Type = 0;
                        TE.NPC = new() { Type = (int)NPCID.TargetDummy };
                    }
                    else if (sprite.TileType == (int)TileID.ItemFrame)
                    {
                        TE.Type = 1;
                        TE.Item = new() { Type = 0, Prefix = 0, StackSize = 0 };
                    }
                    else if (sprite.TileType == (int)TileID.LogicSensor)
                    {
                        TE.Type = 2;
                        TE.On = false;
                        TE.LogicCheck = (byte)(sprite.Origin.Y / 18 + 1);
                    }
                    else if (sprite.TileType == (int)TileID.Mannequin || sprite.TileType == (int)TileID.Womannequin || sprite.TileType == (int)TileID.DisplayDoll)
                    {
                        TE.Type = 3;
                        TE.Items = Enumerable.Repeat(new Item(), 8).ToArray();
                        TE.Dyes = Enumerable.Repeat(new Item(), 8).ToArray();
                    }
                    else if (sprite.TileType == (int)TileID.WeaponsRack || sprite.TileType == (int)TileID.WeaponsRack2)
                    {
                        TE.Type = 4;
                        TE.Item = new() { Type = 0, Prefix = 0, StackSize = 0 };
                    }
                    else if (sprite.TileType == (int)TileID.HatRack)
                    {
                        TE.Type = 5;
                        TE.Items = Enumerable.Repeat(new Item(), 2).ToArray();
                        TE.Dyes = Enumerable.Repeat(new Item(), 2).ToArray();
                    }
                    else if (sprite.TileType == (int)TileID.FoodPlatter)
                    {
                        TE.Type = 6;
                        TE.Item = new() { Type = 0, Prefix = 0, StackSize = 0 };
                    }
                    else if (sprite.TileType == (int)TileID.TeleportationPylon)
                    {
                        TE.Type = 7;
                    }
                    area.TileEntity.Add(TE);
                }
            }
        }
    }
}
