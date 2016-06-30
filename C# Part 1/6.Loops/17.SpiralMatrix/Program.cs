using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] spiralMatrix = new int[n, n];
            int counter = 1;

            for (int i = 0; i < n - 1; i++)
            {
                //right
                for (int col = i; col < n - i; col++)
                {
                    spiralMatrix[i, col] = counter;
                    counter++;
                }
                //down
                for (int row = i + 1; row < n - i; row++)
                {
                    spiralMatrix[row, n - i - 1] = counter;
                    counter++;
                }
                //left                    
                for (int col = n - i - 2; col > i; col--)
                {
                    spiralMatrix[n - i - 1, col] = counter;
                    counter++;
                }
                //up
                for (int row = n - i - 1; row > i; row--)
                {
                    spiralMatrix[row, i] = counter;
                    counter++;
                }
            }

            //Display matrix
            for (int r = 0; r < spiralMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < spiralMatrix.GetLength(1); c++)
                {
                    Console.Write("{0} ", spiralMatrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}

