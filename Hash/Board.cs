using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class Board
    {
        public bool[,] BoardMatrix { get; set; }

        public Board()
        {
            BoardMatrix = new bool[3, 3];
        }

        public void Print(int player)
        {
            Console.WriteLine("   1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" " + (i + 1) + " ");
                for (int j = 0; j < 3; j++)
                {
                    if (!BoardMatrix[i, j]) Console.Write("*   ");
                    else if (player == 0) Console.Write("O   ");
                    else Console.Write("X   ");
                }
                Console.WriteLine();
            }
        }

        public void Change(int row, int column)
        {
            BoardMatrix[row, column] = true;
        }

        public bool Checks()
        {

            return false;
        }
    }
}
