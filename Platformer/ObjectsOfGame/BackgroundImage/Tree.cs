﻿using System;
using Platformer.GameLogic;

namespace Platformer.ObjectsOfGame.BackgroundImage
{
    class Tree : MasterObject
    {
        public Tree(int x, int y, ConsoleColor color) : base(x, y, 20, 20, color) { }

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
            OutputImage.DrawString("", X, Y, color:ConsoleColor.DarkYellow);
        }
    }
}
