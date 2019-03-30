using Platformer.GameLogic;

namespace Platformer.ObjectsOfGame
{
    class Obstruction : MasterObject
    {
        public Obstruction(int x, int y) : base(x, y, 20, 1) { }

        public override void Draw()
        {            
            OutputImage.DrawString("█████████████████████", X, Y - 1);
            OutputImage.DrawString("█████████████████████", X, Y);
        }
    }
}
