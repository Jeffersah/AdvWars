using Microsoft.Xna.Framework;
using NCodeRiddian;

namespace AdvancederWarsV2
{
    internal class Tile
    {
        private int Map_X;
        private int Map_Y;
        private int Variant;
        private Rectangle drawat;
        Image image;
        TileData Data;

        public Tile(int x, int y, int v, TileData mydata)
        {
            Map_X = x;
            Map_Y = y;
            Variant = v;
            Data = mydata;
            if(v == 0)
            {
                Variant = GlobalRandom.random.Next(1, Data.Variants.Count + 1);
            }
            else
            {
                Variant = v;
            }
            image = Data.Variants[v - 1];
        }
    }
}