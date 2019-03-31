using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.ObjectsOfGame.KeyObject
{
    public abstract class KeyObject : MasterObject
    {
        protected KeyObject(int x, int y, int widthSize, int heightSize, ConsoleColor color) : base(x, y, widthSize, heightSize, color)
        {
        }

        public override void Draw()
        {           
        }
    }
}
