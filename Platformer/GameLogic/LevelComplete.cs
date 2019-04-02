using System;
using System.Threading;
using Platformer.Service;

namespace Platformer.GameLogic
{
    /// <summary>
    /// Методы класса вызываются при прохождении уровня
    /// </summary>
    public static class LevelComplete
    {
        /// <summary>
        /// Метод вызыавется по окончанию игры
        /// </summary>
        public static void End()
        {
            #region Закрашивает экран по спирали
            int k = 1;
            int sleep = 0;
            int xStart = -1;
            int xEnd = Constants.WIDHT - 1;

            int yStart = 0;
            int yEnd = Constants.HEIGHT - 1;
            Console.ForegroundColor = ConsoleColor.Black;
            char ch = '█';
            
            while (true)
            {
                xStart++;
                for(int i = xStart; i <= xEnd; i++)
                {
                    Console.SetCursorPosition(i, yStart);
                    Console.Write(ch);
                    Thread.Sleep(sleep);
                }
                yStart++;
                for (int i = yStart; i < yEnd; i++)
                {
                    Console.SetCursorPosition(xEnd, i);
                    Console.Write(ch);
                    Thread.Sleep(sleep);
                }
                yEnd--;
                xEnd--;

                for(int i = xEnd; i > xStart; i--)
                {
                    Console.SetCursorPosition(i, yEnd);
                    Console.Write(ch);
                    Thread.Sleep(sleep);
                }

                for(int i = yEnd; i>=yStart; i--)
                {
                    Console.SetCursorPosition(xStart, i);
                    Console.Write(ch);
                    Thread.Sleep(sleep);
                }
                k++;
                if (k > 20) break;
            }// while()

            #endregion

            Console.BackgroundColor = ConsoleColor.Black;

            for(int i = Constants.WIDHT + 5; i>-160; i--)
            {
                Console.Clear();
                OutputImage.DrawString(":'######:::'#######::'##::: ##::'######:::'########:::::'###::::'########:'##::::'##:'##::::::::::'###::::'########:'####::'#######::'##::: ##::'######::::::::'##:::'##::'#######::'##::::'##:'##:::::'##:'####:'##::: ##:", i, 20);
                OutputImage.DrawString("'##... ##:'##.... ##: ###:: ##:'##... ##:: ##.... ##:::'## ##:::... ##..:: ##:::: ##: ##:::::::::'## ##:::... ##..::. ##::'##.... ##: ###:: ##:'##... ##:::::::. ##:'##::'##.... ##: ##:::: ##: ##:'##: ##:. ##:: ###:: ##:", i, 21);
                OutputImage.DrawString(" ##:::..:: ##:::: ##: ####: ##: ##:::..::: ##:::: ##::'##:. ##::::: ##:::: ##:::: ##: ##::::::::'##:. ##::::: ##::::: ##:: ##:::: ##: ####: ##: ##:::..:::::::::. ####::: ##:::: ##: ##:::: ##: ##: ##: ##:: ##:: ####: ##:", i, 22);
                OutputImage.DrawString(" ##::::::: ##:::: ##: ## ## ##: ##::'####: ########::'##:::. ##:::: ##:::: ##:::: ##: ##:::::::'##:::. ##:::: ##::::: ##:: ##:::: ##: ## ## ##:. ######::'####:::. ##:::: ##:::: ##: ##:::: ##: ##: ##: ##:: ##:: ## ## ##:", i, 23);
                OutputImage.DrawString(" ##::::::: ##:::: ##: ##. ####: ##::: ##:: ##.. ##::: #########:::: ##:::: ##:::: ##: ##::::::: #########:::: ##::::: ##:: ##:::: ##: ##. ####::..... ##: ####:::: ##:::: ##:::: ##: ##:::: ##: ##: ##: ##:: ##:: ##. ####:", i, 24);
                OutputImage.DrawString(" ##::: ##: ##:::: ##: ##:. ###: ##::: ##:: ##::. ##:: ##.... ##:::: ##:::: ##:::: ##: ##::::::: ##.... ##:::: ##::::: ##:: ##:::: ##: ##:. ###:'##::: ##:. ##::::: ##:::: ##:::: ##: ##:::: ##: ##: ##: ##:: ##:: ##:. ###:", i, 25);
                OutputImage.DrawString(". ######::. #######:: ##::. ##:. ######::: ##:::. ##: ##:::: ##:::: ##::::. #######:: ########: ##:::: ##:::: ##::::'####:. #######:: ##::. ##:. ######::'##:::::: ##::::. #######::. #######::. ###. ###::'####: ##::. ##:", i, 26);
                OutputImage.DrawString(":......::::.......:::..::::..:::......::::..:::::..::..:::::..:::::..::::::.......:::........::..:::::..:::::..:::::....:::.......:::..::::..:::......:::..:::::::..::::::.......::::.......::::...::...:::....::..::::..::", i, 27);
                Thread.Sleep(40);
            }

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
