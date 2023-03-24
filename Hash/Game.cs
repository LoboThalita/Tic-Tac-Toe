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
            round = 2;
        }

        public void Match(Board Board)
        {
            int player = round % 2;
            round++;
            string Splayer;
            if (player == 0) Splayer = "Jogador 1 (o)";
            else Splayer = "Jogador 2 (x)";

            Console.WriteLine("\n\n" + Splayer + " escolha a linha e a coluna respectivamente");
            int row = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());

            Board.Change(row-1, column-1,player);
            Board.Print();
            if (Board.Checks() == 0) this.Match(Board);
        }
    }
}
