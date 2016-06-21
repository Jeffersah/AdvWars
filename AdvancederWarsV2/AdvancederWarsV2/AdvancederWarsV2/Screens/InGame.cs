using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Lidgren.Network;

namespace AdvancederWarsV2
{
    class InGame : Screen
    {
        List<LocalPlayer> LocalPlayers;
        List<ForeignPlayer> ForeignPlayers;
        List<A_Player> AllPlayers;
        NetPeer NetClient;

        public InGame()
        {

        }

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
