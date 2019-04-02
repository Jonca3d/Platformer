using System;
using Platformer.GameLogic;

namespace Platformer.ObjectsOfGame.KeyObjectLibrary
{
    class Key : KeyObject
    {
        public Key(int x, int y, string description, bool forInventory, bool visible, ConsoleColor color = ConsoleColor.Gray) : base(x, y, 17, 2, description, forInventory, visible, color) {  }
       

        public override void Draw()
        {
            OutputImage.DrawString(" oooo         ░  ░", X, Y, color: Color);
            OutputImage.DrawString("o    Oo===========", X, Y + 1, color: Color);
            OutputImage.DrawString(" oooo", X, Y + 2, color: Color);
        }       

        public override void Action(Character c)
        {
            base.Action(c);
        }
    }
}
