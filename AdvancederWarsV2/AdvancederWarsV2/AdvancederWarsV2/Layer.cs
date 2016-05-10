using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancederWarsV2
{
    partial class Map
    {
        public static int GetLayer(string name)
        {
            name = name.ToUpper();
            for (int i = 0; i < Enum.GetNames(typeof(Layer)).Length; i++)
            {
                if (Enum.GetNames(typeof(Layer))[i].Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }
        public static string GetLayerName(int layer)
        {
            return Enum.GetName(typeof(Layer), (Layer)layer);
        }

        public static int NumberOfLayers()
        {
            return (int)Layer.ORBIT + 1;
        }
    }

    enum Layer : int
    {
        INVALID = -1,
        SUB = 0,
        NAVY = 1,
        LAND = 2,
        AIR = 3,
        MISSILE = 4,
        ORBIT = 5
    }
}
