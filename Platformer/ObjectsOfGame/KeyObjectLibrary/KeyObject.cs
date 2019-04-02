using System;

namespace Platformer.ObjectsOfGame.KeyObjectLibrary
{

    public abstract class KeyObject : MasterObject
    {
        /// <summary>
        /// Описание обьекта
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Показывает - может ли обьект быть помещен в инвентарь игрока
        /// </summary>
        public bool ForInventory { get; }

        /// <summary>
        /// Отображается ли обьект на сцене
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// Ключевые обьекты игры с которыми может взаиможействовать персонаж
        /// </summary>
        /// <param name="x"> Х - координата обьекта. </param>
        /// <param name="y"> Y - координата обьекта. </param>
        /// <param name="widthSize"> Ширина обьекта. </param>
        /// <param name="heightSize"> Высота обьекта. </param>
        /// <param name="description"> Описание обьекта. ( Если обьект попадает в инвентаоь, в инвенторе игрока отображается это описание ) </param>
        /// <param name="forInventory"> Если TRUE значит обьект может быть помещен в инвентарь </param>
        /// <param name="visible"> Показывает отображается ли обьект на сцене </param>
        /// <param name="color"> Цвет символов из которых составлен обьект </param>
        public KeyObject(int x, int y, int widthSize, int heightSize, string description, bool forInventory, bool visible, ConsoleColor color = ConsoleColor.Gray) : base(x, y, widthSize, heightSize, color)
        {
            Description = description;
            ForInventory = forInventory;
            Visible = visible;
        }

        public override void Draw() {  }

        /// <summary>
        /// Если у обьекта есть какое-то уникальное действие его можно прописать в этои методе
        /// </summary>
        public virtual void Action(Character character) { }
    }
}
