using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.ObjectsOfGame.KeyObjectLibrary
{
    public abstract class KeyObject : MasterObject
    {
        public string Description { get; }
        public bool ForInventory { get; }
        public bool Visible { get; set; }

        public KeyObject(int x, int y, int widthSize, int heightSize, string description, bool forInventory, bool visible, ConsoleColor color = ConsoleColor.Gray) : base(x, y, widthSize, heightSize, color)
        {
            Description = description;
            ForInventory = forInventory;
            Visible = visible;
        }

        public override void Draw()
        {           
        }

        public virtual void Action()
        {
        }
    }
}
