using System;
using System.Xml;
using ClassicUO.Configuration;
using ClassicUO.Game.Data;
using ClassicUO.Game.GameObjects;
using ClassicUO.Game.Managers;
using ClassicUO.Game.Scenes;
using ClassicUO.Game.UI.Controls;
using ClassicUO.Input;
using ClassicUO.Assets;
using ClassicUO.Network;
using ClassicUO.Renderer;
using ClassicUO.Utility;
using Microsoft.Xna.Framework;

namespace ClassicUO.Game.UI.Gumps
{
    internal class SignGump : Gump
    {
        public SignGump(World world, uint objectID, ushort gumpType, string unknownText, string gumpText)
            : base(world, objectID, 0) // Call base constructor with objectID and initial position
        {
            CanMove = true;
            AcceptMouseInput = true;
            AcceptKeyboardInput = false;
            CanCloseWithRightClick = true; // Allow closing with right-click

            // Use the gump type to create an image control
            Add(new GumpPic(0, 0, gumpType, 0)); // Use the incoming gumpType directly

        }
    }
}
