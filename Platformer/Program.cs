using Platformer.GameLogic;
using Platformer.Service;

namespace Platformer
{
    public class Program
    {
        static Game game = new Game();
        static string[] menuArray = new string[] { "GAME", "CONTROL", "EXIT" };
        public static Menu menu = new Menu(menuArray, Constants.WIDHT, Constants.HEIGHT, game);


        static void Main()
        {         
            menu.Show();
        }
    }
}
