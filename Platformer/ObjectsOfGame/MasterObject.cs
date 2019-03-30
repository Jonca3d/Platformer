using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.ObjectsOfGame
{
    public abstract class MasterObject
    {
        private int x;
        
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                DemensionX = x + WidhtSize;
            }
        } //Координаты X, Y Верхнего левого угла обьекта
        private int y;
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                DemensionY = y + HeightSize;
            }
        } //

        //Габариты обьекта
        public int WidhtSize { get; set; } //Размеры ширины и высоты обьекта
        public int HeightSize { get; set; }//

        public int DemensionX { get; private set; }//Координаты X, Y нижнего правого угла
        public int DemensionY { get; private set; }
        protected MasterObject(int x, int y, int widthSize, int heightSize)
        {            
            X = x;
            Y = y;
            WidhtSize = widthSize;
            HeightSize = heightSize;
            DemensionX = x + WidhtSize;
            DemensionY = y + HeightSize;
        }

        public abstract void Draw();
    }
}
