using System.Drawing;
using TMake.Data;
using TMake.Terraria;

namespace TMake
{
    public static partial class Tool
    {
        public static void Delete(World world, Rectangle selection)
        {
            Rectangle rectangle = Rectangle.Intersect(selection, new(0, 0, world.MaxTilesX, world.MaxTilesY));

            world.Chest.RemoveAll(chest => rectangle.Contains(chest.X, chest.Y));
            world.Sign.RemoveAll(sign => rectangle.Contains(sign.X, sign.Y));
            world.TileEntity.RemoveAll(tileEntity => rectangle.Contains(tileEntity.X, tileEntity.Y));

            for (int x = rectangle.Left; x < rectangle.Right; x++)
            {
                for (int y = rectangle.Top; x < rectangle.Bottom; y++)
                {
                    world.Tile[x, y].Reset();
                }
            }
        }
        public static Schematic Copy(World world, Rectangle selection)
        {
            Rectangle rectangle = Rectangle.Intersect(selection, new(0, 0, world.MaxTilesX, world.MaxTilesY));

            Schematic sch = new()
            {
                Tile = new Tile[rectangle.Width, rectangle.Height],
                Size = new Point(rectangle.Width, rectangle.Height),
                Version = world.Version
            };

            sch.Chest.AddRange(world.Chest.Where(chest =>
            rectangle.Contains(chest.X, chest.Y)).Select(chest =>
            {
                var clone = chest.Clone();
                clone.X -= rectangle.Left;
                clone.Y -= rectangle.Top;
                return clone;
            }));
            sch.Sign.AddRange(world.Sign.Where(sign =>
            rectangle.Contains(sign.X, sign.Y)).Select(sign =>
            {
                var clone = sign.Clone();
                clone.X -= rectangle.Left;
                clone.Y -= rectangle.Top;
                return clone;
            }));
            sch.TileEntity.AddRange(world.TileEntity.Where(tileEntity =>
            rectangle.Contains(tileEntity.X, tileEntity.Y)).Select(tileEntity =>
            {
                var clone = tileEntity.Clone();
                clone.X -= rectangle.Left;
                clone.Y -= rectangle.Top;
                return clone;
            }));

            for (int x = rectangle.Left, i = 0; x < rectangle.Right; x++, i++)
            {
                for (int y = rectangle.Top, j = 0; x < rectangle.Bottom; y++, j++)
                {
                    sch.Tile[i, j] = world.Tile[x, y].Clone();
                }
            }
            return sch;
        }
        public static void Copy(World world, Rectangle fromRectangle, Point toPosition)
        {
            Schematic sch = Copy(world, fromRectangle);
            Paste(world, sch, toPosition);
        }
        public static Schematic Cut(World world, Rectangle rectangle)
        {
            Schematic sch = Copy(world, rectangle);
            Delete(world, rectangle);
            return sch;
        }
        public static void Cut(World world, Rectangle fromRectangle, Point toPosition)
        {
            Schematic sch = Cut(world, fromRectangle);
            Paste(world, sch, toPosition);
        }
        public static void Paste(World world, Schematic sch, Point position)
        {
            Rectangle rectangle = Rectangle.Intersect(new(position, new(sch.Size)), new(0, 0, world.MaxTilesX, world.MaxTilesY));

            Delete(world, rectangle);

            world.Chest.AddRange(sch.Chest.Where(chest =>
            rectangle.Contains(chest.X, chest.Y)).Select(chest =>
            {
                var clone = chest.Clone();
                clone.X += rectangle.Left;
                clone.Y += rectangle.Top;
                return clone;
            }));
            world.Sign.AddRange(sch.Sign.Where(sign =>
            rectangle.Contains(sign.X, sign.Y)).Select(sign =>
            {
                var clone = sign.Clone();
                clone.X += rectangle.Left;
                clone.Y += rectangle.Top;
                return clone;
            }));
            world.TileEntity.AddRange(sch.TileEntity.Where(tileEntity =>
            rectangle.Contains(tileEntity.X, tileEntity.Y)).Select(tileEntity =>
            {
                var clone = tileEntity.Clone();
                clone.X += rectangle.Left;
                clone.Y += rectangle.Top;
                return clone;
            }));

            for (int x = rectangle.Left, i = 0; x < rectangle.Right; x++, i++)
            {
                for (int y = rectangle.Top, j = 0; x < rectangle.Bottom; y++, j++)
                {
                    world.Tile[x, y] = sch.Tile[i, j].Clone();
                }
            }
        }
    }
}
