using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace AdvancederWarsV2
{
    class InGame : Screen
    {

        public override void Update()
        {
        }

        public override void Draw(SpriteBatch sb)
        {
            sb.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);

            sb.End();
        }
    }
}
