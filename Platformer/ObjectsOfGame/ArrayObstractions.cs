using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Service;

namespace Platformer.ObjectsOfGame
{
    /// <summary>
    /// Массив обьектов которые являются препядствиями для игрока
    /// </summary>
    class ArrayObstractions : IEnumerable
    {

        List<Obstruction> _obstraction = new List<Obstruction>()
        {
            #region Ограждение уровня с левой стороны          
            new Obstruction(9, Constants.HEIGHT - 5, ConsoleColor.DarkRed),
            new Obstruction(9, Constants.HEIGHT - 7, ConsoleColor.DarkRed),
            new Obstruction(9, Constants.HEIGHT - 9, ConsoleColor.DarkRed),
            new Obstruction(11, Constants.HEIGHT - 11, ConsoleColor.DarkRed),
            new Obstruction(12, Constants.HEIGHT - 13, ConsoleColor.DarkRed),
            new Obstruction(15, Constants.HEIGHT - 15, ConsoleColor.DarkRed),
            new Obstruction(17, Constants.HEIGHT - 17, ConsoleColor.DarkRed),  
            #endregion

            #region Платформы
            new Obstruction(50, Constants.HEIGHT - 5, ConsoleColor.DarkGray),
            new Obstruction(90, Constants.HEIGHT - 5, ConsoleColor.DarkGray),
            new Obstruction(110, Constants.HEIGHT - 10, ConsoleColor.DarkGray),
            new Obstruction(130, Constants.HEIGHT - 15, ConsoleColor.DarkGray),
            new Obstruction(150, Constants.HEIGHT - 18, ConsoleColor.DarkGray),
            new Obstruction(128, Constants.HEIGHT - 23, ConsoleColor.DarkGray),
            new Obstruction(110, Constants.HEIGHT - 27, ConsoleColor.DarkGray),
            new Obstruction(90, Constants.HEIGHT - 30, ConsoleColor.DarkGray),
            new Obstruction(115, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(130, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(145, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(155, Constants.HEIGHT - 40, ConsoleColor.DarkGray),
            new Obstruction(165, Constants.HEIGHT - 45, ConsoleColor.DarkGray),
            new Obstruction(175, Constants.HEIGHT - 50, ConsoleColor.DarkGray),
            new Obstruction(185, Constants.HEIGHT - 55, ConsoleColor.DarkGray),
            new Obstruction(195, Constants.HEIGHT - 60, ConsoleColor.DarkGray),
            new Obstruction(205, Constants.HEIGHT - 65, ConsoleColor.DarkGray),
            new Obstruction(234, Constants.HEIGHT - 45, ConsoleColor.DarkGray),
            new Obstruction(250, Constants.HEIGHT - 47, ConsoleColor.DarkGray),
            new Obstruction(265, Constants.HEIGHT - 49, ConsoleColor.DarkGray),
            new Obstruction(280, Constants.HEIGHT - 53, ConsoleColor.DarkGray),
            new Obstruction(260, Constants.HEIGHT - 57, ConsoleColor.DarkGray),
            new Obstruction(280, Constants.HEIGHT - 61, ConsoleColor.DarkGray),
            new Obstruction(260, Constants.HEIGHT - 65, ConsoleColor.DarkGray),
            new Obstruction(280, Constants.HEIGHT - 69, ConsoleColor.DarkGray),
            new Obstruction(260, Constants.HEIGHT - 73, ConsoleColor.DarkGray),
            new Obstruction(280, Constants.HEIGHT - 77, ConsoleColor.DarkGray),
            new Obstruction(260, Constants.HEIGHT - 81, ConsoleColor.DarkGray),
            new Obstruction(280, Constants.HEIGHT - 85, ConsoleColor.DarkGray),
            new Obstruction(260, Constants.HEIGHT - 89, ConsoleColor.DarkGray),
            new Obstruction(280, Constants.HEIGHT - 93, ConsoleColor.DarkGray),
            new Obstruction(260, Constants.HEIGHT - 97, ConsoleColor.DarkGray),
            new Obstruction(280, Constants.HEIGHT - 101, ConsoleColor.DarkGray),
            new Obstruction(260, Constants.HEIGHT - 105, ConsoleColor.DarkGray),
            new Obstruction(245, Constants.HEIGHT - 105, ConsoleColor.DarkGray),
            new Obstruction(230, Constants.HEIGHT - 105, ConsoleColor.DarkGray),
            new Obstruction(215, Constants.HEIGHT - 107, ConsoleColor.DarkGray),
            new Obstruction(200, Constants.HEIGHT - 109, ConsoleColor.DarkGray),
            #endregion

        };

        public int Length
        {
            get { return _obstraction.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _obstraction.Count; i++)
            {
                yield return _obstraction[i];
            }
        }
    }
}
