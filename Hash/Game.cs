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

        public Game()
        {
            round = 2;
        }

        public void Match(Board Board)
        {
            int player = round % 2;
            string Splayer;
            if (player == 0) Splayer = "Jogador 1 (o)";
            else Splayer = "Jogador 2 (x)";

            Console.WriteLine("\n\n" + Splayer + " escolha a linha e a coluna respectivamente");
            int row = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());

            if (ValidNumber(row,column,Board.Set()) == 2)
            {
                round++;
                Board.Change(row - 1, column - 1, player);
                Board.Print();
                if (Board.Checks() == 0) this.Match(Board);
            }
            else if (ValidNumber(row, column, Board.Set()) == 1)
            {
                Console.WriteLine("Casa ocupada, escolha outra");
                this.Match(Board);
            }
            else
            {
                Console.WriteLine("Número inválido, escolha outro");
                this.Match(Board);
            }
        }

        private int ValidNumber(int row, int column, int[,] Matrix)
        {
            // 0 - numero invalido (> 3 ou < 0)
            // 1 - Casa ocupada
            // 2 - ok
            row--;
            column--;
            if(row > 3 || column > 3) return 0;
            else if(row < 0 || column< 0) return 0;
            else if (Matrix[row,column] != 0) return 1;
            else return 2;
        }
    }
}
