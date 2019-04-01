using Platformer.ObjectsOfGame;
using Platformer.ObjectsOfGame.KeyObjectLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.GameLogic
{
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
    }
}
