using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.ObjectsOfGame.KeyObjectLibrary;
using Platformer.Service;

namespace Platformer.ObjectsOfGame
{
    /// <summary>
    /// Массив обьектов с которыми может взаимодействовать игрок
    /// </summary>
    public class ArrayKeyObject : IEnumerable
    {

        List<KeyObject> _keyObject = new List<KeyObject>()
        {
            new Key(185, Constants.HEIGHT -118, "KEY", true, true, color: ConsoleColor.White),
            new Door( 220, Constants.HEIGHT - 11, "DOOR", false, true, color: ConsoleColor.DarkYellow )
        };
      

        public int Length
        {
            get { return _keyObject.Count; }
        }

        public void Remove(KeyObject keyObj)
        {
            _keyObject.Remove(keyObj);
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
