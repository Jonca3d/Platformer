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
            new Obstruction(30, Constants.HEIGHT - 3),
            new Obstruction(60, Constants.HEIGHT - 3),
            new Obstruction(90, Constants.HEIGHT - 3),
            new Obstruction(50, Constants.HEIGHT - 10),
            new Obstruction(70, Constants.HEIGHT - 15),
            new Obstruction(90, Constants.HEIGHT - 20),
            new Obstruction(120, Constants.HEIGHT - 25),
            new Obstruction(140, Constants.HEIGHT - 30),
            new Obstruction(150, Constants.HEIGHT - 35),
            new Obstruction(160, Constants.HEIGHT - 40),
            new Obstruction(170, Constants.HEIGHT - 45),
            new Obstruction(40, Constants.HEIGHT - 7),
            new Obstruction(140, Constants.HEIGHT - 7),
            new Obstruction(-10, Constants.HEIGHT - 7),

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
