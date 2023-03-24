using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class Board
    {
        public int[,] BoardMatrix { get; set; }

        public Board()
        {
            BoardMatrix = new int[3, 3];
        }

        public void Print()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao jogo da velha\n\n");
            Console.WriteLine("   1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" " + (i + 1) + " ");
                for (int j = 0; j < 3; j++)
                {
                    if (BoardMatrix[i, j] == 0) Console.Write("*   ");
                    else if (BoardMatrix[i, j] == 1) Console.Write("o   ");
                    else Console.Write("x   ");
                }
                Console.WriteLine();
            }
        }

        public void Change(int row, int column, int player)
        {
            BoardMatrix[row, column] = player + 1;
        }

        public int Checks()
        {
            int result =0, diagonal = 0;
            for (int i = 0; i < 3; i++)
            {
                int j = 0;

                if (ChecksRows(i))
                {
                    result = BoardMatrix[i, 0];
                    break;
                }
                else if (ChecksColumns(i))
                {
                    result = BoardMatrix[i, 0];
                    break;
                }
                else if (i == j++)
                {
                    diagonal++;
                    if (diagonal == 3)
                    {
                        result = 3;
                    }
                }
            }
            return result;
        }

        private bool ChecksRows(int i)
        {
            return BoardMatrix[i, 0] == BoardMatrix[i, 1] && BoardMatrix[i, 1] == BoardMatrix[i, 2];
        }
        private bool ChecksColumns(int i)
        {
            return BoardMatrix[0, i] == BoardMatrix[1, i] && BoardMatrix[1, i] == BoardMatrix[2, i];
        }
    }
}
