using System;
using Platformer.GameLogic;

namespace Platformer.ObjectsOfGame.KeyObject
{
    class Key : MasterObject
    {
        public Key(int x, int y, ConsoleColor color) : base(x, y, 17, 2, color) { }

        public override void Draw()
        {
            OutputImage.DrawString(" oooo         ░  ░", X, Y, color: Color);
            OutputImage.DrawString("o    Oo===========", X, Y + 1, color: Color);
            OutputImage.DrawString(" oooo", X, Y + 2, color: Color);
        }

        
    }
}
