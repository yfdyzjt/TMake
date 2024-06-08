using TMake.Terraria;

namespace TMake.File
{
    public static class TileFile
    {
        public static Tile[,] Load(BinaryReader r, int maxX, int maxY, uint version, bool[] tileFrameImportant)
        {
            Tile[,] tiles = new Tile[maxX, maxY];
            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    Tile tile = Deserialize(r, tileFrameImportant, version, out int rle);
                    tiles[x, y] = tile;
                    while (rle > 0)
                    {
                        y++;
                        tiles[x, y] = tile.Clone();
                        rle--;
                    }
                }
            }
            return tiles;
        }
        public static int Save(Tile[,] tiles, BinaryWriter bw, int maxX, int maxY, uint version, bool[] tileFrameImportant)
        {
            int maxTileId = WorldProperty.GetVersionData(version).MaxTileId;
            int maxWallId = WorldProperty.GetVersionData(version).MaxWallId;

            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    Tile tile = tiles[x, y];

                    byte[] tileData = SerializeTileData(tile, version, maxTileId, maxWallId, tileFrameImportant, out int dataIndex, out int headerIndex);

                    // rle compression
                    byte header1 = tileData[headerIndex];

                    short rle = 0;
                    int nextY = y + 1;
                    int remainingY = maxY - y - 1;
                    while (remainingY > 0 && tile.Equals(tiles[x, nextY]) && tile.Type != 520 && tile.Type != 423)
                    {
                        rle = (short)(rle + 1);
                        remainingY--;
                        nextY++;
                    }

                    y += rle;

                    if (rle > 0)
                    {
                        // always write lower half
                        tileData[dataIndex++] = (byte)(rle & 0b_1111_1111); //255

                        if (rle <= 255)
                        {
                            // set bit[6] of header1 for byte size rle
                            header1 = (byte)(header1 | 0b_0100_0000); // 64
                        }
                        else
                        {
                            // set bit[7] of header1 for int16 size rle
                            header1 = (byte)(header1 | 0b_1000_0000); //128

                            // grab the upper half of the int16 and stick it in tiledata
                            tileData[dataIndex++] = (byte)((rle & 0b_1111_1111_0000_0000) >> 8); // 65280
                        }
                    }

                    tileData[headerIndex] = header1;
                    // end rle compression

                    bw.Write(tileData, headerIndex, dataIndex - headerIndex);
                }
            }

            return (int)bw.BaseStream.Position;
        }
        public static Tile Deserialize(BinaryReader r, bool[] tileFrameImportant, uint version, out int rle)
        {
            Tile tile = new();
            int tileType = -1;
            byte header4 = 0;
            byte header3 = 0;
            byte header2 = 0;
            byte header1 = r.ReadByte();

            bool hasHeader2 = false;
            bool hasHeader3 = false;
            bool hasHeader4 = false;

            // check bit[0] to see if header2 has data
            if ((header1 & 0b_0000_0001) == 0b_0000_0001)
            {
                hasHeader2 = true;
                header2 = r.ReadByte();
            }

            // check bit[0] to see if header3 has data
            if (hasHeader2 && (header2 & 0b_0000_0001) == 0b_0000_0001)
            {
                hasHeader3 = true;
                header3 = r.ReadByte();
            }

            if (version >= 269) // 1.4.4+ 
            {
                // check bit[0] to see if header4 has data
                if (hasHeader3 && (header3 & 0b_0000_0001) == 0b_0000_0001)
                {
                    hasHeader4 = true;
                    header4 = r.ReadByte();
                }
            }

            // check bit[1] for active tile
            bool isActive = (header1 & 0b_0000_0010) == 0b_0000_0010;

            if (isActive)
            {
                tile.Active = isActive;
                // read tile type

                if ((header1 & 0b_0010_0000) != 0b_0010_0000) // check bit[5] to see if tile is byte or little endian int16
                {
                    // tile is byte
                    tileType = r.ReadByte();
                }
                else
                {
                    // tile is little endian int16
                    byte lowerByte = r.ReadByte();
                    tileType = r.ReadByte();
                    tileType = tileType << 8 | lowerByte;
                }
                tile.Type = (ushort)tileType; // convert type to ushort after bit operations

                // read frame UV coords
                if (!tileFrameImportant[tileType])
                {
                    tile.FrameX = 0;//-1;
                    tile.FrameY = 0;//-1;
                }
                else
                {
                    // read UV coords
                    tile.FrameX = r.ReadInt16();
                    tile.FrameY = r.ReadInt16();
                }

                // check header3 bit[3] for tile color
                if ((header3 & 0b_0000_1000) == 0b_0000_1000)
                {
                    tile.Color = r.ReadByte();
                }
            }

            // Read Walls
            if ((header1 & 0b_0000_0100) == 0b_0000_0100) // check bit[3] bit for active wall
            {
                tile.Wall = r.ReadByte();


                // check bit[4] of header3 to see if there is a wall color
                if ((header3 & 0b_0001_0000) == 0b_0001_0000)
                {
                    tile.WallColor = r.ReadByte();
                }
            }

            // check for liquids, grab the bit[3] and bit[4], shift them to the 0 and 1 bits
            byte liquidType = (byte)((header1 & 0b_0001_1000) >> 3);
            if (liquidType != 0)
            {
                tile.Liquid = r.ReadByte();

                if (version >= 269 && (header3 & 0b_1000_0000) == 0b_1000_0000)
                {
                    tile.Shimmer = true;
                }
                else if (liquidType > 1)
                {
                    if (liquidType == 2)
                        tile.Lava = true;
                    else
                        tile.Honey = true;
                }
            }

            // check if we have data in header2 other than just telling us we have header3
            if (header2 > 1)
            {
                // check bit[1] for red wire
                if ((header2 & 0b_0000_0010) == 0b_0000_0010)
                {
                    tile.Wire = true;
                }
                // check bit[2] for blue wire
                if ((header2 & 0b_0000_0100) == 0b_0000_0100)
                {
                    tile.Wire2 = true;
                }
                // check bit[3] for green wire
                if ((header2 & 0b_0000_1000) == 0b_0000_1000)
                {
                    tile.Wire3 = true;
                }

                // grab bits[4, 5, 6] and shift 4 places to 0,1,2. This byte is our brick style
                byte brickStyle = (byte)((header2 & 0b_0111_0000) >> 4);
                if (brickStyle != 0 && (ushort)TileID.Count > tile.Type && (TileProperty.Solid[tile.Type] || TileProperty.NonSolidSaveSlopes[tile.Type]))
                {
                    if (brickStyle == 1)
                        tile.HalfBrick = true;
                    else
                        tile.Slope = (byte)(brickStyle - 1);
                }
            }

            // check if we have data in header3 to process
            if (header3 > 1)
            {
                // check bit[1] for actuator
                if ((header3 & 0b_0000_0010) == 0b_0000_0010)
                {
                    tile.Actuator = true;
                }

                // check bit[2] for inactive due to actuator
                if ((header3 & 0b_0000_0100) == 0b_0000_0100)
                {
                    tile.InActive = true;
                }

                if ((header3 & 0b_0010_0000) == 0b_0010_0000)
                {
                    tile.Wire4 = true;
                }

                if (version >= 222)
                {
                    if ((header3 & 0b_0100_0000) == 0b_0100_0000)
                    {
                        tile.Wall = (ushort)(r.ReadByte() << 8 | tile.Wall);

                    }
                }
            }

            if (version >= 269 && header4 > 1)
            {
                if ((header4 & 0b_0000_0010) == 0b_0000_0010)
                {
                    tile.InvisibleBlock = true;
                }
                if ((header4 & 0b_0000_0100) == 0b_0000_0100)
                {
                    tile.InvisibleWall = true;
                }
                if ((header4 & 0b_0000_1000) == 0b_0000_1000)
                {
                    tile.FullBrightBlock = true;
                }
                if ((header4 & 0b_0001_0000) == 0b_0001_0000)
                {
                    tile.FullBrightWall = true;
                }
            }

            // get bit[6,7] shift to 0,1 for RLE encoding type
            // 0 = no RLE compression
            // 1 = byte RLE counter
            // 2 = int16 RLE counter
            // 3 = not implemented, assume int16
            byte rleStorageType = (byte)((header1 & 192) >> 6);

            rle = rleStorageType switch
            {
                0 => 0,
                1 => r.ReadByte(),
                _ => r.ReadInt16()
            };
            return tile;
        }
        public static byte[] SerializeTileData(
            Tile tile,
            uint version,
            int maxTileId,
            int maxWallId,
            bool[] tileFrameImportant,
            out int dataIndex,
            out int headerIndex)
        {
            int size = version switch
            {
                uint v when v >= 269 => 16, // 1.4.4+
                uint v when v > 222 => 15, // 1.4.0+
                _ => 13 // default
            };

            byte[] tileData = new byte[size];
            dataIndex = (version >= 269) ? 4 : 3; // 1.4.4+

            byte header4 = (byte)0;
            byte header3 = (byte)0;
            byte header2 = (byte)0;
            byte header1 = (byte)0;

            // tile data

            if (tile.Active && tile.Type <= maxTileId && tile.Type != (int)TileType.IceByRod)
            {
                // activate bit[1]
                header1 |= 0b_0000_0010;

                // save tile type as byte or int16
                tileData[dataIndex++] = (byte)tile.Type; // low byte
                if (tile.Type > 255)
                {
                    // write high byte
                    tileData[dataIndex++] = (byte)(tile.Type >> 8);

                    // set header1 bit[5] for int16 tile type
                    header1 |= 0b_0010_0000;
                }


                if (tileFrameImportant[tile.Type])
                {
                    // pack UV coords
                    tileData[dataIndex++] = (byte)(tile.FrameX & 0xFF); // low byte
                    tileData[dataIndex++] = (byte)((tile.FrameX & 0xFF00) >> 8); // high byte
                    tileData[dataIndex++] = (byte)(tile.FrameY & 0xFF); // low byte
                    tileData[dataIndex++] = (byte)((tile.FrameY & 0xFF00) >> 8); // high byte

                }

                if (version < 269)
                {
                    if (tile.Color != 0 || tile.FullBrightBlock)
                    {

                        var color = tile.Color;

                        // downgraded illuminate coating to illuminate paint
                        // IF there is no other paint
                        if (color == 0 && tile.FullBrightBlock)
                        {
                            color = 31;
                        }

                        // set header3 bit[3] for tile color active
                        header3 |= 0b_0000_1000;
                        tileData[dataIndex++] = color;
                    }
                }
                else
                {
                    if (tile.Color != 0 && tile.Color != 31)
                    {
                        var color = tile.Color;

                        // set header3 bit[3] for tile color active
                        header3 |= 0b_0000_1000;
                        tileData[dataIndex++] = color;
                    }
                }


            }

            // wall data
            if (tile.Wall != 0 && tile.Wall <= maxWallId)
            {
                // set header1 bit[2] for wall active
                header1 |= 0b_0000_0100;
                tileData[dataIndex++] = (byte)tile.Wall;

                // save tile wall color
                if (version < 269)
                {
                    if (tile.WallColor != 0 || tile.FullBrightWall)
                    {
                        var color = tile.WallColor;

                        // downgraded illuminate coating to illuminate paint
                        // IF there is no other paint
                        if (color == 0 && version < 269 && tile.FullBrightWall)
                        {
                            color = 31;
                        }

                        // set header3 bit[4] for wall color active
                        header3 |= 0b_0001_0000;
                        tileData[dataIndex++] = color;
                    }
                }
                else
                {
                    // for versions >= 269 upgrade illuminant paint to coating
                    if (tile.WallColor != 0 && tile.WallColor != 31)
                    {
                        var color = tile.WallColor;
                        // set header3 bit[4] for wall color active
                        header3 |= 0b_0001_0000;
                        tileData[dataIndex++] = color;
                    }
                }
            }

            // liquid data
            if (tile.Liquid != 0)
            {
                if (tile.Shimmer)
                {
                    header3 = (byte)(header3 | 0b_1000_0000);
                    header1 = (byte)(header1 | 0b_0000_1000);
                }
                else if (tile.Lava)
                {
                    header1 = (byte)(header1 | 0b_0001_0000);
                }
                else if (tile.Honey)
                {
                    header1 = (byte)(header1 | 0b_0001_1000);
                }
                else
                {
                    header1 = (byte)(header1 | 0b_0000_1000);
                }

                tileData[dataIndex++] = tile.Liquid;
            }

            // wire data
            if (tile.Wire)
            {
                // red wire = header2 bit[1]
                header2 |= 0b_0000_0010;
            }
            if (tile.Wire2)
            {
                // blue wire = header2 bit[2]
                header2 |= 0b_0000_0100;
            }
            if (tile.Wire3)
            {
                // green wire = header2 bit[3]
                header2 |= 0b_0000_1000;
            }

            // brick style
            byte brickStyle;
            if (tile.HalfBrick)
            {
                brickStyle = 16;
            }
            else
            {
                if(tile.Slope == 0)
                {
                    brickStyle = 0;
                }
                else
                {
                    brickStyle = (byte)(tile.Slope + 1 << 4);
                }
            }

            // set bits[4,5,6] of header2
            header2 = (byte)(header2 | brickStyle);


            // actuator data
            if (tile.Actuator)
            {
                // set bit[1] of header3
                header3 |= 0b_0000_0010;
            }
            if (tile.InActive)
            {
                // set bit[2] of header3
                header3 |= 0b_0000_0100;
            }
            if (tile.Wire4)
            {
                header3 |= 0b_0010_0000;
            }

            // wall high byte
            if (tile.Wall > 255 && version >= 222)
            {
                header3 |= 0b_0100_0000;
                tileData[dataIndex++] = (byte)(tile.Wall >> 8);
            }

            if (version >= 269)
            {
                // custom block lighting (v1.4.4+)
                if (tile.InvisibleBlock)
                {
                    header4 |= 0b_0000_0010;
                }
                if (tile.InvisibleWall)
                {
                    header4 |= 0b_0000_0100;
                }
                if (tile.FullBrightBlock || tile.Color == 31) // convert illuminant paint
                {
                    header4 |= 0b_0000_1000;
                }
                if (tile.FullBrightWall || tile.WallColor == 31) // convert illuminant paint
                {
                    header4 |= 0b_0001_0000;
                }

                // header 4 only used in 1.4.4+
                headerIndex = 3;
                if (header4 != 0)
                {
                    // set header4 active flag bit[0] of header3
                    header3 |= 0b_0000_0001;
                    tileData[headerIndex--] = header4;
                }
            }
            else
            {
                headerIndex = 2;
            }

            if (header3 != 0)
            {
                // set header3 active flag bit[0] of header2
                header2 |= 0b_0000_0001;
                tileData[headerIndex--] = header3;
            }
            if (header2 != 0)
            {
                // set header2 active flag bit[0] of header1
                header1 |= 0b_0000_0001;
                tileData[headerIndex--] = header2;
            }

            tileData[headerIndex] = header1;
            return tileData;
        }
    }
}
