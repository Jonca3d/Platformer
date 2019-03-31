using Platformer.Service;
using System;

namespace Platformer.GameLogic
{
    public static class OutputImage
    {
        /// <summary>
        /// Метод выводит строку текста на экран.
        /// В него передаются координаты начала строки.
        /// Если строка выходит за пределы экрани ( или начинается за его пределами ), метод обрезает непометившуюся часть
        /// </summary>
        /// <param name="str">Строка для вывода</param>
        /// <param name="x">Координата Х начала строки</param>
        /// <param name="y">Координата Y начала строки</param>
        /// <param name="width">Ширина окна консоли</param>
        public static void DrawString(string str, int x, int y, int width = Constants.WIDHT, ConsoleColor color = ConsoleColor.White)
        {
            
            bool onDisplay = true;


            //Если текст выходит за левую границу окна консоли
            if (x <= 0 && x + str.Length > 0)
            {
                str = str.Substring(-x);
                x = 0;
            }
            else if (x + str.Length > width && x < width) // Если текст выходит за правую границу окна консоли
            {
                int tail = x + str.Length - width;
                str = str.Substring(0, str.Length - tail);
            }
            else if (x > 0 && x + str.Length < width) { } // Если обьект из текста целиком помещается на экране в длину
            else
                onDisplay = false; // Иниче, если текс скрылся за границей экрана, его отображать не нужно

            //Если обьект выходит за верхнюю или нижнюю границы экрана
            if (y < 0 || y >= Constants.HEIGHT)
                onDisplay = false;

            if (onDisplay)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = color;
                Console.Write(str);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }

        public static void DrawGround(string ground, int y)
        {
            if(y >= Constants.HEIGHT)            
                return;
            
            Console.SetCursorPosition(0, y);
            Console.Write(ground);
        }
    }
}
