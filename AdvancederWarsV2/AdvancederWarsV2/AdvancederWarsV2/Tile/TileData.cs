using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLoader;
using NCodeRiddian;

namespace AdvancederWarsV2
{
    class TileData
    {
        protected string Name;

        protected List<Image> Variants;

        protected int[] MoveCosts;
        protected int[] SightCosts;
        protected float[] DefenseModifiers;
        protected bool[] isHidingPlace;

        public TileData(PropertyObject loadfrom)
        {

        }

        public TileData(TileData cloneme)
        {
            Name = cloneme.Name;
            MoveCosts = new int[cloneme.MoveCosts.Length];
            SightCosts = new int[cloneme.SightCosts.Length];
            DefenseModifiers = new float[cloneme.DefenseModifiers.Length];
            isHidingPlace = new bool[cloneme.isHidingPlace.Length];
            for (int i = 0; i < Map.NumberOfLayers(); i++)
            {
                MoveCosts[i] = cloneme.MoveCosts[i];
                SightCosts[i] = cloneme.SightCosts[i];
                DefenseModifiers[i] = cloneme.DefenseModifiers[i];
                isHidingPlace[i] = cloneme.isHidingPlace[i];
            }
            Variants = new List<Image>();
            foreach(Image i in cloneme.Variants)
            {
                Variants.Add(new Image(i.getTexture()));
            }
        }
        
        public Tile MakeTile(int x, int y)
        {
            return new Tile(x, y, this);
        }

        public Tile MakeTile(int x, int y, int v)
        {
            return new Tile(x, y, v, this);
        }
    }
}
