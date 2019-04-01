using System;
using System.Threading;
using Platformer.Service;
using Platformer.ObjectsOfGame;
using Platformer.ObjectsOfGame.KeyObjectLibrary;
using Platformer.GameLogic;

namespace Platformer
{
    class Game
    {
        Character character = new Character(40, Constants.HEIGHT - 6);
        ArrayObstractions arrayObtractions = new ArrayObstractions();
        ArrayKeyObject arrayKeyObject = new ArrayKeyObject();
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
            StartGame();
        }

        
        /// <summary>
        /// Инициализация игры.
        /// </summary>
        private void Init()
        {
            Console.CursorVisible = false;           
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(Constants.WIDHT, Constants.HEIGHT);
            Console.SetWindowSize(Constants.WIDHT, Constants.HEIGHT);
            Console.BackgroundColor = Constants.BACKGROUNDCOLOR;

            Draw();
        }

        /// <summary>
        /// Отрисовка обьектов на сцене.
        /// </summary>
        private void Draw()
        {
            Console.Clear();
            //TEST(character);
            foreach (Obstruction obstr in arrayObtractions)
            {
                obstr.Draw();
            }          
            foreach (KeyObject keyObj in arrayKeyObject)
            {
                if (keyObj.Visible)
                    keyObj.Draw();
            }
            ground.Draw();
            Inventory.Draw(character.getName());
            character.Draw();
            Thread.Sleep(8);
        }
        
        /// <summary>
        /// Метод обновляет расположение обьектов на экране.
        /// Принимает массив координат в котором находится траектория движения игрока.
        /// </summary>
        /// <param name="action"> Массив координат траектории движения обьекта </param>
        private void Update(Coordinates[] action)
        {

            // collision - принимает значение true если персонаж пересекается с обьектом коллизии
            bool collision = false;

            foreach (var move in action)
            {
                character.X += move.X;
                character.Y += move.Y;

                //Если игрок достигает определенных границ экрана, позиции всех обьектов смещаются ( по горизонтали )
                if (character.X == 70)
                {
                    character.X -= 1;
                    foreach (Obstruction obst in arrayObtractions)
                        obst.X -= 1;
                    foreach (KeyObject keyObj in arrayKeyObject)
                        keyObj.X -= 1;

                }
                else if (character.X == 19)
                {
                    character.X += 1;
                    foreach (Obstruction obst in arrayObtractions)
                        obst.X += 1;
                    foreach (KeyObject keyObj in arrayKeyObject)
                        keyObj.X += 1;

                }

                //Если игрок достигает определенных границ экрана, позиции всех обьектов смещаются ( по вертикали )
                if (character.Y == 15)
                {
                    character.Y += 1;
                    ground.Y += 1;
                    foreach (Obstruction obst in arrayObtractions)
                        obst.Y += 1;
                    foreach (KeyObject keyObj in arrayKeyObject)
                        keyObj.Y += 1;

                }
                else if (character.Y == Constants.HEIGHT - 2 && ground.Y > Constants.HEIGHT - 2)
                {
                    character.Y -= 1;
                    ground.Y -= 1;
                    foreach (Obstruction obst in arrayObtractions)
                        obst.Y -= 1;
                    foreach (KeyObject keyObj in arrayKeyObject)
                        keyObj.Y -= 1;

                }

                #region Реализация пересечений с другими обьектами
                foreach (Obstruction obst in arrayObtractions)
                {
                    // Если игрок пересекается с обьктом цикл останавливается
                    if ((character.X <= obst.DemensionX && character.DemensionX >= obst.X &&
                    character.Y <= obst.DemensionY && character.DemensionY >= obst.Y))
                    {
                        character.X -= move.X;
                        character.Y -= move.Y;
                        collision = true;
                        break;
                    }
                }

                ObjectInteraction.Interaction(arrayKeyObject, character);

                if (collision) break;

                Draw();
                #endregion
            }

            // Если игрок выше уровня земли
            // Если значение down == true, реализуется анимация падения вниз
            bool down = false;

            // Если персонаж выше уровня земли
            if (character.Y != Constants.HEIGHT - 3)
                down = true;

            //Игрок падает вниз пока не пересечется с обьектом коллизии или пока не достигнет земли
            while (down)
            {
                character.Y += 1;

                foreach (Obstruction obst in arrayObtractions)
                {
                    // Если игрок пересекается с обьктом или достигает земли цикл останавливается
                    if (character.X <= obst.DemensionX && character.DemensionX >= obst.X &&
                    character.Y <= obst.DemensionY && character.DemensionY >= obst.Y || character.DemensionY == 38)
                    {
                        character.Y -= 1;
                        down = false;
                        break;
                    }
                }
                if (character.Y < Constants.HEIGHT - 1 && ground.Y > Constants.HEIGHT - 2 && down)
                {
                    character.Y -= 1;
                    ground.Y -= 1;

                    foreach (Obstruction obst in arrayObtractions)
                        obst.Y -= 1;                    

                    foreach (KeyObject keyObj in arrayKeyObject)
                        keyObj.Y -= 1;

                }
                if (down)
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
            //int line = 5;
            //foreach (Obstruction obst in arrayObtractions)
            //{
            //    Console.SetCursorPosition(1, line);
            //    Console.Write("[      Obstruction      ] - X: {0:d3} DemX: {1:d3}", obst.X, obst.DemensionX);
            //    line++;
            //}
        }

        //
        private void Action()
        {
            var act = Console.ReadKey().Key;
            switch (act)
            {
                case ConsoleKey.A:
                    Update(character.MoveToLeft);
                    break;
                case ConsoleKey.D:
                    Update(character.MoveToRight);
                    break;
                case ConsoleKey.Q:
                    Update(character.JumpToLeft);
                    break;
                case ConsoleKey.E:
                    Update(character.JumpToRight);
                    break;
                case ConsoleKey.Enter:
                    ObjectInteraction.Interaction(arrayKeyObject, character, act);
                    break;
                default:
                    break;
            }
        }
    }
}
