using Platformer.GameLogic;
using System;

namespace Platformer.ObjectsOfGame
{
    class Obstruction : MasterObject
    {
        public Obstruction(int x, int y, ConsoleColor color = ConsoleColor.Gray) : base(x, y, 4, 1, color) { }

        public override void Draw()
        {            
            OutputImage.DrawString("█████", X, Y, color: Color);
            OutputImage.DrawString("█████", X, Y + 1, color: Color);
        }
    }
}
