using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NCodeRiddian;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AdvancederWarsV2
{
    class Tile : TileData
    {
        int Map_X;
        int Map_Y;
        int Variant;
        Rectangle drawat;

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
