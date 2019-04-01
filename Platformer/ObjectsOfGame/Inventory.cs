using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.ObjectsOfGame.KeyObjectLibrary;

namespace Platformer.ObjectsOfGame
{
    public static class Inventory 
    {   
        public static void Draw(string[] _inventory)
        {
            if(_inventory != null)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < _inventory.Length; i++)
                {
                    Console.SetCursorPosition(3, i + 1);
                    Console.Write(_inventory[i]);
                }
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
           
        }



    }
}
