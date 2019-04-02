using System;

namespace Platformer.GameLogic
{
    static class ControlsInstruction
    {
        public static void Show()
        {
            Console.Clear();
            OutputImage.DrawString("MOVE TO RIGHT : D", 20, 5);
            OutputImage.DrawString(" MOVE TO LEFT : A", 20, 6);
            OutputImage.DrawString("JUMP TO RIGHT : E", 20, 7);
            OutputImage.DrawString(" JUMP TO LEFT : Q", 20, 8);
            OutputImage.DrawString("       ACTION : ENTER", 20, 9);
            OutputImage.DrawString("         MENU : ESC", 20, 10);

            OutputImage.DrawString("PRESS ANY KEY", 20, 13);

            Console.ReadLine();
        }
    }
}
