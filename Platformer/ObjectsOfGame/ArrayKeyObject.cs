using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.ObjectsOfGame.KeyObjectLibrary;

namespace Platformer.ObjectsOfGame
{
    /// <summary>
    /// Массив обьектов с которыми может взаимодействовать игрок
    /// </summary>
    class ArrayKeyObject : IEnumerable
    {

        List<KeyObject> _keyObject = new List<KeyObject>()
        {
            new Key(30,30,"Ключ от двери", true, true, color: ConsoleColor.White),
        };
      

        public int Length
        {
            get { return _keyObject.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _keyObject.Count; i++)
            {
                yield return _keyObject[i];
            }
        }
    }
}
