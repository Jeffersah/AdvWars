using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancederWarsV2
{
    abstract class A_Player
    {
        public bool isLocal()
        {
            return (this is LocalPlayer);
        }

        public abstract void Non_Turn_Active_Update();

        public abstract void Update();

        public abstract void Draw();
    }
}
