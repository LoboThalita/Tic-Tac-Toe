using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class Game
    {
        public static int round { get; private set; }
        public int player0 { get; private set; }
        public int player1 { get; private set; }

        public Game()
        {
            player0 = 0;
            player1 = 1;
            round = 0;
        }

        public void Match(Board Board)
        {
            
            string player;
            if (round % 2 == 0) player = "Jogador 1";
            else player = "Jogador 2";

            Console.WriteLine("\n\n" + player + " escolha a linha e a coluna respectivamente");
            int row = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());

            Board.Change(row-1, column-1);
            Board.Print(round++);
            Board.Checks();
        }
    }
}
