using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platformer.Service;

namespace Platformer.ObjectsOfGame
{
    class ArrayObstractions : IEnumerable
    {

        List<Obstruction> _obstraction = new List<Obstruction>()
        {
            #region Ограждение уровня с левой стороны
            new Obstruction(10, Constants.HEIGHT - 3, ConsoleColor.DarkRed),
            new Obstruction(9, Constants.HEIGHT - 5, ConsoleColor.DarkRed),
            new Obstruction(9, Constants.HEIGHT - 7, ConsoleColor.DarkRed),
            new Obstruction(7, Constants.HEIGHT - 9, ConsoleColor.DarkRed),
            new Obstruction(5, Constants.HEIGHT - 11, ConsoleColor.DarkRed),
            new Obstruction(5, Constants.HEIGHT - 13, ConsoleColor.DarkRed),
            new Obstruction(6, Constants.HEIGHT - 15, ConsoleColor.DarkRed),
            new Obstruction(7, Constants.HEIGHT - 17, ConsoleColor.DarkRed),
            new Obstruction(5, Constants.HEIGHT - 19, ConsoleColor.DarkRed),
            new Obstruction(7, Constants.HEIGHT - 21, ConsoleColor.DarkRed),
            new Obstruction(9, Constants.HEIGHT - 23, ConsoleColor.DarkRed),
            new Obstruction(11, Constants.HEIGHT - 25, ConsoleColor.DarkRed),
            new Obstruction(13, Constants.HEIGHT - 27, ConsoleColor.DarkRed),
            new Obstruction(11, Constants.HEIGHT - 29, ConsoleColor.DarkRed),
            new Obstruction(9, Constants.HEIGHT - 31, ConsoleColor.DarkRed),
            new Obstruction(9, Constants.HEIGHT - 33, ConsoleColor.DarkRed),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkRed),
            #endregion

            #region Платформы
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
            new Obstruction(11, Constants.HEIGHT - 35, ConsoleColor.DarkGray),
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
