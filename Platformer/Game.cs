using System;
using System.Threading;
using Platformer.Service;
using Platformer.ObjectsOfGame;

namespace Platformer
{
    class Game
    {
        Character character = new Character(20, Constants.HEIGHT - 3);
        ArrayObstractions arrayObtractions = new ArrayObstractions();
        Ground ground = new Ground();
        int endWorldCoorditates = Constants.WIDHT;

        public Game()
        {
            Init();
        }

        //Метод запускающий игру
        public void StartGame()
        {
            Action();
            Draw();
            StartGame();
        }

        //Инициализация игры
        private void Init()
        {
            Console.CursorVisible = false;
            #region Задаем размер консоли
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(Constants.WIDHT, Constants.HEIGHT);
            Console.SetWindowSize(Constants.WIDHT, Constants.HEIGHT);
            #endregion

            Draw();
        }

        private void Draw()
        {
            Console.Clear();
            character.Draw();
            //TEST(character);
            foreach (Obstruction obstr in arrayObtractions)
            {
                obstr.Draw();
            }
            ground.Draw();
            Thread.Sleep(8);
        }

        //Метод обновляет расположение обьектов на экране
        //Принимает массив координат в котором находится траектория движения игрока
        private void Update(Coordinates[] action)
        {   
            bool collision = false;
            foreach (var move in action)
            {
                character.X += move.X;
                character.Y += move.Y;

                //Если игрок достигает определенных границ экрана, позиции всех обьектов смещаются ( по горизонтали )
                if(character.X == 70)
                {
                    character.X -= 1;
                    foreach (Obstruction obst in arrayObtractions)
                        obst.X -= 1;
                    
                } else if(character.X == 19)
                {
                    character.X += 1;
                    foreach (Obstruction obst in arrayObtractions)
                        obst.X += 1;                    
                }

                //Если игрок достигает определенных границ экрана, позиции всех обьектов смещаются ( по горизонтали )
                if(character.Y == 20)
                {
                    character.Y += 1;
                    ground.Y += 1;
                    foreach (Obstruction obst in arrayObtractions)
                        obst.Y += 1;
                }else if(character.Y == Constants.HEIGHT - 2 && ground.Y > Constants.HEIGHT - 2)
                {
                    character.Y -= 1;
                    ground.Y -= 1;
                    foreach (Obstruction obst in arrayObtractions)
                        obst.Y -= 1;
                }

                #region Реализация пересечений с другими обьектами
                foreach (Obstruction obst in arrayObtractions)
                {
                    // Если игрок пересекается с обьктом цикл останавливается
                    if ((character.X <= obst.DemensionX && character.DemensionX >= obst.X &&
                    character.Y <= obst.DemensionY && character.DemensionY >= obst.Y) ||
                    (character.X < 0) || (character.X > Constants.WIDHT - 3))
                    {
                        character.X -= move.X;
                        character.Y -= move.Y;
                        collision = true;
                        break;
                    }                    
                }

                if (collision) break;

                Draw();
            #endregion
            }

            //Если игрок выше уровня земли
            bool down = false;
            if (character.Y != Constants.HEIGHT - 3)
                down = true;

            //Игрок падает вниз пока не пересечется с обьектом коллюзии или пока не достигнет земли
            while (down)
            {
                character.Y += 1;
                if(character.Y == Constants.HEIGHT - 7 && ground.Y > Constants.HEIGHT - 2)
                {
                    character.Y -= 1;
                    ground.Y -= 1;
                    foreach (Obstruction obst in arrayObtractions)
                        obst.Y -= 1;
                }


                foreach (Obstruction obst in arrayObtractions)
                {
                    // Если игрок пересекается с обьктом или достигает земли цикл останавливается
                    if (character.X <= obst.DemensionX && character.DemensionX >= obst.X &&
                    character.Y <= obst.DemensionY && character.DemensionY >= obst.Y || character.DemensionY == 39)
                    {
                        character.Y -= 1;
                        down = false;
                        break;
                    }
                }
                Draw();  
            }            
        }

        //Вспомогательный метод для отлавливания координат обьектов
        public void TEST(MasterObject o1)
        {
            Console.SetCursorPosition(1, 2);
            Console.Write("[{0}] -\t\t( X: {1:d3} Y: {2:d3} DemX: {3:d3} DemY: {4:d3})", "Character", o1.X, o1.Y, o1.DemensionX, o1.DemensionY);
            Console.SetCursorPosition(1, 3);
            Console.Write("[ StartWorldCoordinates ] - {0}", endWorldCoorditates - Constants.WIDHT);
            Console.SetCursorPosition(1, 4);
            Console.Write("[  EndWorldCoordinates  ] - {0}", endWorldCoorditates);
            int line = 5;
            foreach (Obstruction obst in arrayObtractions)
            {
                Console.SetCursorPosition(1, line);
                Console.Write("[      Obstruction      ] - X: {0:d3} DemX: {1:d3}", obst.X, obst.DemensionX);
                line++;
            }
        }

        //
        private void Action()
        {
            var act = Console.ReadKey().KeyChar;
            switch (act)
            {
                case 'a':
                    Update(character.MoveToLeft);
                    break;
                case 'd':
                    Update(character.MoveToRight);
                    break;
                case 'q':
                    Update(character.JumpToLeft);
                    break;
                case 'e':
                    Update(character.JumpToRight);
                    break;
                default:
                    break;
            }
        }
    }
}
