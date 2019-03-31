using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.ObjectsOfGame.KeyObject;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.ObjectsOfGame
{
    /// <summary>
    /// Массив обьектов с которыми может взаимодействовать игрок
    /// </summary>
    class ArrayKeyObject : IEnumerable
    {

        List<MasterObject> _keyObject = new List<MasterObject>()
        {
            new Key(30,30,ConsoleColor.White),

        };

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
