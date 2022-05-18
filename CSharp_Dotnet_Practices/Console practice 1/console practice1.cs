using system;
using system.Collections.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace Gameplay
{
    class game
    {
        static void Main(string[] args)
        {
            int games = convert.ToInt32(Console.ReadLine());
            int wins = convert.ToInt32(Console.ReadLine());

            //player object created here
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            player1.GetWinRate();
        }
    }

    class Player
    {
        public int games;
        public int wins;

        public void GetWinRate()
        {
            Console.WriteLine(wins*100/games);
        }
    }
}