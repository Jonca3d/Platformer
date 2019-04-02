using Platformer.ObjectsOfGame;
using Platformer.ObjectsOfGame.KeyObjectLibrary;
using System;

namespace Platformer.GameLogic
{

    /// <summary>
    /// Логика взаимодействия с "Ключевыми обьектами". 
    /// Либо Обьект помещается в инвентарь, либо игрок как-то иначе взаимодействует с обьектом.
    /// Логика взаимодействия с обьектом находится в самом обьекте.
    /// </summary>
    public static class ObjectInteraction
    {
        public static void Interaction(ArrayKeyObject arrayKeyObject, Character character)
        {
            foreach (KeyObject keyObj in arrayKeyObject)
            {
                // Если игрок пересекается с ключевым обьектом
                if ((character.X <= keyObj.DemensionX && character.DemensionX >= keyObj.X &&
                character.Y <= keyObj.DemensionY && character.DemensionY >= keyObj.Y))
                {
                    // Если обьект может стать частью инвенторя, он ею становиться и пропадает со сцены
                    if (keyObj.ForInventory)
                    {
                        character.Add(keyObj);
                        arrayKeyObject.Remove(keyObj);
                    }
                }
            }
        }

        public static void Interaction(ArrayKeyObject arrayKeyObject, Character character, ConsoleKey key)
        {
            foreach (KeyObject keyObj in arrayKeyObject)
            {
                // Если игрок пересекается с ключевым обьектом
                if ((character.X <= keyObj.DemensionX && character.DemensionX >= keyObj.X &&
                character.Y <= keyObj.DemensionY && character.DemensionY >= keyObj.Y))
                {                    
                    if (key == ConsoleKey.Enter)
                    {
                        keyObj.Action(character);
                    }
                }
            }
        }      
    }
}
