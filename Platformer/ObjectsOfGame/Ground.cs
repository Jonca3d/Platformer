using System;
using Platformer.Service;
using Platformer.GameLogic;

namespace Platformer.ObjectsOfGame
{
    class Ground : MasterObject
    {
        public Ground(ConsoleColor color = ConsoleColor.Gray) : base(0, Constants.HEIGHT - 2, 140, 3, color) { }

        public override void Draw()
        {
            OutputImage.DrawGround("TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT" +
                "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT", Y);
        }
    }
}
