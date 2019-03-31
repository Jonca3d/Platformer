using System;

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

        public ConsoleColor Color { get; }// Цвет обьекта


        protected MasterObject(int x, int y, int widthSize, int heightSize, ConsoleColor color)
        {            
            X = x;
            Y = y;
            WidhtSize = widthSize;
            HeightSize = heightSize;            
            DemensionX = x + WidhtSize;
            DemensionY = y + HeightSize;
            Color = color;
        }

        public abstract void Draw();
    }
}
