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
        public static List<TileData> AllTileData;

        public static void Load()
        {
            AllTileData = new List<TileData>();
            foreach(PropertyObject prop in PropertyObject.Load("tiles\\tiledata.txt").GetAllPropertyObjects())
            {
                AllTileData.Add(new TileData(prop));
            }
        }

        public static TileData ByData(int data)
        {
            foreach (TileData td in AllTileData)
                if (td.data == data)
                    return td;
            return null;
        }

        protected string Name;
        public int data;

        public List<Image> Variants;

        protected int[] MoveCosts;
        protected int[] SightCosts;
        protected float[] DefenseModifiers;
        protected bool[] isHidingPlace;

        public TileData(PropertyObject loadfrom)
        {
            Name = loadfrom["Name"].value<string>();
            int vcount = loadfrom["Variants"].value<int>();
            string folder = @"tiles\" + loadfrom["Folder"].value<string>();
            Variants = new List<Image>();

            for(int i = 1; i <= vcount; i++)
            {
                string filelocation = folder + "\\" + i;
                Variants.Add(new Image(filelocation));
            }

            data = loadfrom["Data"].value<int>();
            MoveCosts = new int[MoveType.Count];
            DefenseModifiers = new float[MoveType.Count];
            isHidingPlace = new bool[Map.NumberOfLayers()];
            SightCosts = new int[Map.NumberOfLayers()];
            foreach (PropertyDefinition definition in loadfrom.GetPropertyObject("MoveCost").GetAllFields())
            {
                MoveCosts[MoveType.Lookup(definition.name).Value.id] = definition.value.value<int>();
            }
            foreach (PropertyDefinition definition in loadfrom.GetPropertyObject("Def").GetAllFields())
            {
                DefenseModifiers[MoveType.Lookup(definition.name).Value.id] = definition.value.value<float>();
            }
            foreach (PropertyDefinition definition in loadfrom.GetPropertyObject("Sight").GetAllFields())
            {
                for(int i = 0; i < Map.NumberOfLayers(); i++)
                {
                    if(definition.name.Equals(Map.GetLayerName(i).ToLower()))
                    {
                        SightCosts[i] = definition.value.value<int>();
                    }
                }
            }
            for (int i = 0; i < isHidingPlace.Length; i++)
                isHidingPlace[i] = false;
            foreach (PropertyDefinition definition in loadfrom.GetPropertyObject("Hide").GetAllFields())
            {
                for (int i = 0; i < Map.NumberOfLayers(); i++)
                {
                    if (definition.name.Equals(Map.GetLayerName(i).ToLower()) && definition.value.value<int>() > 0)
                    {
                        isHidingPlace[i] = true;
                    }
                }
            }
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
            return new Tile(x, y, 0, this);
        }

        public Tile MakeTile(int x, int y, int v)
        {
            return new Tile(x, y, v, this);
        }
    }
}
