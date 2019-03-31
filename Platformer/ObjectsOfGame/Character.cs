using System;
using Platformer.Service;

namespace Platformer.ObjectsOfGame
{
    class Character : MasterObject
    {
        public Character(int x, int y, ConsoleColor color = ConsoleColor.Gray) : base(x, y, 4, 3, color) { }

        #region Массивы которые определяют траекторию движения обьекта
        // Массивы передаются в метод Update(Array arr) основного класса игры
        // Сам метод Update проверяет не пересекается траектория движения игрока с остальными обьектами
        private Coordinates[] moveToRight = new[] { new Coordinates { X = 1, Y = 0 } };
        public Coordinates[] MoveToRight { get { return moveToRight; } }
        private Coordinates[] moveToLeft = new[] { new Coordinates { X = -1, Y = 0 } };
        public Coordinates[] MoveToLeft { get { return moveToLeft; } }
        private Coordinates[] jumpToRight = new[] {
            new Coordinates { X = 0, Y = -1 },
            new Coordinates { X = 1, Y = -1 },
            new Coordinates { X = 0, Y = -1 },
            new Coordinates { X = 1, Y = -1 },
            new Coordinates { X = 0, Y = -1 },
            new Coordinates { X = 1, Y = -1 },
            new Coordinates { X = 1, Y = -1 },
            new Coordinates { X = 1, Y = 0 },
            new Coordinates { X = 1, Y = 0 },
            new Coordinates { X = 1, Y = 0 },
            new Coordinates { X = 1, Y = 1 },
            new Coordinates { X = 1, Y = 1 },
            new Coordinates { X = 0, Y = 1 },
            new Coordinates { X = 1, Y = 1 },
            new Coordinates { X = 0, Y = 1 },
            new Coordinates { X = 1, Y = 1 },
            new Coordinates { X = 0, Y = 1 },
        };
        public Coordinates[] JumpToRight { get { return jumpToRight; } }
        private Coordinates[] jumpToLeft = new[] {
            new Coordinates { X = 0, Y = -1 },
            new Coordinates { X = -1, Y = -1 },
            new Coordinates { X = 0, Y = -1 },
            new Coordinates { X = -1, Y = -1 },
            new Coordinates { X = 0, Y = -1 },
            new Coordinates { X = -1, Y = -1 },
            new Coordinates { X = -1, Y = -1 },
            new Coordinates { X = -1, Y = 0 },
            new Coordinates { X = -1, Y = 0 },
            new Coordinates { X = -1, Y = 0 },
            new Coordinates { X = -1, Y = 1 },
            new Coordinates { X = -1, Y = 1 },
            new Coordinates { X = 0, Y = 1 },
            new Coordinates { X = -1, Y = 1 },
            new Coordinates { X = 0, Y = 1 },
            new Coordinates { X = -1, Y = 1 },
            new Coordinates { X = 0, Y = 1 },
        };
        public Coordinates[] JumpToLeft { get { return jumpToLeft; } }
        #endregion

        //Отрисовка персонажа
        public override void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ███");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write("█O O█");
            Console.SetCursorPosition(X, Y + 2);
            Console.Write("█ U █");
            Console.SetCursorPosition(X, Y + 3);
            Console.Write("█████");
        }

    }
}
