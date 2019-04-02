using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.GameLogic
{
    public class Menu
    {
        private string[] ElementsMenu { get; }
        private int WindowSizeX { get; }
        private int WindowSiseY { get; }
        public Game Game { get; }

        private int focusPosition = 0;

        public Menu(string[] elementsMenu, int windowSizeX, int windowSizeY,  Game game)
        {
            ElementsMenu = elementsMenu;
            WindowSizeX = windowSizeX;
            WindowSiseY = windowSizeY;
            Game = game;
        }

        public void Show()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                CreateMenu(focusPosition);

                if (menuNavigation() == 1)
                {
                    switch(ElementsMenu[focusPosition])
                    {
                        case "GAME":
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Game.Draw();
                            Game.StartGame();
                            break;
                        case "CONTROL":
                            ControlsInstruction.Show();
                            break;
                        case "EXIT":
                            Environment.Exit(0);
                            break;
                    }
                }
                Console.Clear();

            }
        }

        void CreateMenu(int focusPosition)
        {
            int menuY = (WindowSiseY / 2) - (ElementsMenu.Length / 2);
            int menuX;
            int i = 0;

            foreach (var v in ElementsMenu)
            {
                menuX = (WindowSizeX / 2) - (v.Length / 2);
                Console.SetCursorPosition(menuX, menuY + i);
                if (focusPosition == i)
                {
                    Console.SetCursorPosition(menuX - 4, menuY + i);
                    Console.Write("-=[ {0} ]=-", v);
                }
                else
                {
                    Console.Write(v);
                }
                i++;
            }
        }

        int menuNavigation()
        {
            while (true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (focusPosition > 0)
                            focusPosition -= 1;
                        return 0;
                    case ConsoleKey.DownArrow:
                        if (focusPosition < ElementsMenu.Length - 1)
                            focusPosition += 1;
                        return 0;
                    case ConsoleKey.Enter:
                        return 1;

                    default:
                        break;
                }
            }
        }
    }
}
