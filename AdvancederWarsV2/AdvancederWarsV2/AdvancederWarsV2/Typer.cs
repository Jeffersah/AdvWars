using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NCodeRiddian;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace AdvancederWarsV2
{
    class Typer
    {
        const string INI_ALLOW = "abcdefghijklmnopqrstuvwxyz1234567890-=[];',./\\` ";
        const string INI_ALLOW_SHIFT = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_+{}:\"<>?|~ ";

        string Allow = "";
        string AllowShift = "";

        string sofar;

        public string Message
        {
            get
            {
                return sofar;
            }
            set
            {
                sofar = value;
            }
        }

        public Typer()
        {
            sofar = "";
            Allow = INI_ALLOW;
            AllowShift = INI_ALLOW_SHIFT;
        }

        public Typer(string start)
        {
            sofar = start;
        }

        public void Update()
        {
            for(int x = 0; x < Allow.Length; x++)
            {
                char ch = Allow[x];
                char chs = AllowShift[x];
                Keys baseKey = (Keys)ch;
                Keys shiKey = (Keys)chs;

                if(KeyboardInputManager.isKeyDown(Keys.LeftShift) || KeyboardInputManager.isKeyDown(Keys.RightShift))
                {
                    if(KeyboardInputManager.isKeyPressed(baseKey)|| KeyboardInputManager.isKeyPressed(shiKey))
                    {
                        sofar += chs;
                    }
                }
                else if (KeyboardInputManager.isKeyPressed(baseKey))
                {
                    sofar += ch;
                }
            }
        }
    }
}
