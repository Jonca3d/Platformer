using Platformer.GameLogic;
using Platformer.Service;
using System;

namespace Platformer.ObjectsOfGame.KeyObjectLibrary
{
    class Door : KeyObject
    {
        public Door(int x, 
                    int y,  
                    string description, 
                    bool forInventory, 
                    bool visible, 
                    ConsoleColor color = ConsoleColor.Gray) : 
            base(x, y, 12, 5, description, forInventory, visible, color) {  }

    

        public override void Action(Character character)
        {
            foreach(string str in character.getName())
            {
                if (str == "KEY")
                {                   
                    LevelComplete.End();
                }
            }            
        }

  

        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            OutputImage.DrawString(   "$ $ $ $",    X + 3, Y, color: Color);
            OutputImage.DrawString( "$  $ $ $  $",  X + 1, Y + 1, color: Color);
            OutputImage.DrawString("$  $  $  $  $", X, Y + 2, color: Color);
            OutputImage.DrawString("$  $  $  $  $", X, Y + 3, color: Color);
            OutputImage.DrawString("$ ( ) $  $  $", X, Y + 4, color: Color);
            OutputImage.DrawString("$  $  $  $  $", X, Y + 5, color: Color);
            OutputImage.DrawString("$  $  $  $  $", X, Y + 6, color: Color);
            OutputImage.DrawString("$  $  $  $  $", X, Y + 7, color: Color);
            OutputImage.DrawString("$$$$$$$$$$$$$", X, Y + 8, color: Color);
            Console.BackgroundColor = Constants.BACKGROUNDCOLOR;
        }
    }
}
