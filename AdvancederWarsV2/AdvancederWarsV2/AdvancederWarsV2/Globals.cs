using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace AdvancederWarsV2
{
    abstract class Globals
    {
        public const int SCREEN_SIZE_X = 1024;
        public const int SCREEN_SIZE_Y = 768;
        public const int TILE_SIZE = 32;

        public static Point SCREEN_SIZE = new Point(SCREEN_SIZE_X, SCREEN_SIZE_Y);
        public static Rectangle FULL_SCREEN = new Rectangle(0, 0, SCREEN_SIZE_X, SCREEN_SIZE_Y);
        public static Point STD_TILE = new Point(TILE_SIZE, TILE_SIZE);
        public static Rectangle FULL_TILE = new Rectangle(0, 0, TILE_SIZE, TILE_SIZE);
    }
}
