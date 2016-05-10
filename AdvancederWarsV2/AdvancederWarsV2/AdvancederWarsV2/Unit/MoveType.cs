using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLoader;

namespace AdvancederWarsV2
{
    struct MoveType
    {
        public static List<MoveType> AllMovement;

        public static int Count
        {
            get
            {
                return AllMovement.Count;
            }
        }

        public static void Load(PropertyObject propobj)
        {
            AllMovement = new List<MoveType>();
            foreach (PropertyObject obj in propobj.GetAllPropertyObjects())
            {
                AllMovement.Add(new MoveType(obj));
            }
        }

        public static MoveType? Lookup(string abr)
        {
            abr = abr.ToLower();
            foreach (MoveType mtp in AllMovement)
                if (mtp.abr.Equals(abr) || mtp.name.ToLower().Equals(abr))
                    return mtp;
            return null;
        }

        public string name;
        public string abr;
        public int id;

        public MoveType(PropertyObject prop)
        {
            name = prop["name"].value<string>();
            abr = prop["quickr"].value<string>();
            id = prop["id"].value<int>();
        }

        public MoveType(MoveType clone)
        {
            name = clone.name;
            abr = clone.abr;
            id = clone.id;
        }
    }
}
