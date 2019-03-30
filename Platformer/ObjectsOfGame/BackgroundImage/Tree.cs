using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platformer.GameLogic;

namespace Platformer.ObjectsOfGame.BackgroundImage
{
    class Tree : MasterObject
    {
        public Tree(int x, int y) : base(x, y, 20, 20) { }

        public override void Draw()
        {
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
            OutputImage.DrawString("", X, Y);
        }
    }
}
