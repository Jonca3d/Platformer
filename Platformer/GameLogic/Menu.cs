using System;

namespace Platformer.GameLogic
{
    /// <summary>
    /// Игровое меню.
    /// </summary>
    public class Menu
    {
        private string[] ElementsMenu { get; }
        private int WindowSizeX { get; }
        private int WindowSiseY { get; }
        public Game Game { get; }

        private int focusPosition = 0;

        /// <summary>
        /// Игровое меню.
        /// </summary>
        /// <param name="elementsMenu"> Массив строк. Каждая строка будет элементом меню. </param>
        /// <param name="windowSizeX"> Ширина окна консоли. </param>
        /// <param name="windowSizeY"> Высота окна консоли. </param>
        /// <param name="game"> Экземпляр класса игры. </param>
        public Menu(string[] elementsMenu, int windowSizeX, int windowSizeY,  Game game)
        {
            ElementsMenu = elementsMenu;
            WindowSizeX = windowSizeX;
            WindowSiseY = windowSizeY;
            Game = game;
        }

        /// <summary>
        /// Вывкести меню на консоль.
        /// </summary>
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

        /// <summary>
        /// Метод создает из массива строк вертикальное меню.
        /// </summary>
        /// <param name="focusPosition">  </param>
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
