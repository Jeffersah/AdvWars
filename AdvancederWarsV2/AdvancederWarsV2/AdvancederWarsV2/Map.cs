using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using NCodeRiddian;
using Microsoft.Xna.Framework;

namespace AdvancederWarsV2
{
    partial class Map
    {
        Tile[,] World;

        public Map(Map cloneMe)
        {

        }

        public Map(Texture2D load)
        {
            Color[,] Data = ImageTransform.GetData2(load);
            World = new Tile[Data.GetLength(0), Data.GetLength(1)];

            for(int x = 0; x < Data.GetLength(0); x++)
            {
                for (int y = 0; y < Data.GetLength(1); y++)
                {
                    World[x, y] = new Tile(x, y, Data[x, y].G, TileData.ByData(Data[x, y].R));
                }
            }
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch sb)
        {

        }
    }
}