using Microsoft.Xna.Framework;
using NCodeRiddian;

namespace AdvancederWarsV2
{
    internal class Tile : TileData
    {
        private int Map_X;
        private int Map_Y;
        private int Variant;
        private Rectangle drawat;

        public Tile(int x, int y, TileData mydata) : base(mydata)
        {
            Map_X = x;
            Map_Y = y;
            Variant = GlobalRandom.random.Next(Variants.Count);
            drawat = new Rectangle(x * Globals.TILE_SIZE, y * Globals.TILE_SIZE, Globals.TILE_SIZE, Globals.TILE_SIZE);
        }

        public Tile(int x, int y, int v, TileData mydata) : base(mydata)
        {
            Map_X = x;
            Map_Y = y;
            Variant = v;
        }
    }
}