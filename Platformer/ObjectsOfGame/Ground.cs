using System;
using Platformer.Service;
using Platformer.GameLogic;

namespace Platformer.ObjectsOfGame
{
    class Ground : MasterObject
    {
        public Ground() : base(0, Constants.HEIGHT - 2, 140, 3) { }

        public override void Draw()
        {
            OutputImage.DrawGround("TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT" +
                "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT", Y);
        }
    }
}
