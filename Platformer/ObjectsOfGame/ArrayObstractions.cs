using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Service;

namespace Platformer.ObjectsOfGame
{
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
            //new Obstruction(11, Constants.HEIGHT - 5, ConsoleColor.DarkGray),
            //new Obstruction(11, Constants.HEIGHT - 5, ConsoleColor.DarkGray),
            #endregion

        };

        public int Length
        {
            get { return _obstraction.Count; }
        }       

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < _obstraction.Count; i++)
            {
                yield return _obstraction[i];
            }
        }
    }
}
