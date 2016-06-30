using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            string[] numbers = numberString.Split(' ');
            int n = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);

            int[,] array = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                string elements = Console.ReadLine();
                var elementsArr = elements.Split(' ');
                for (int col = 0; col < m; col++)
                {
                    array[row, col] = int.Parse(elementsArr[col]);
                }
            }

            int maxSum = int.MinValue;
            int sum = 0;


            for (int row = 0; row < array.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 2; col++)
                {

                    for (int r = row; r < row + 3; r++)
                    {
                        for (int c = col; c < col + 3; c++)
                        {
                            sum += array[r, c];
                        }
                    }
                    if (maxSum < sum)
                    {
                        maxSum = sum;

                    }
                    sum = 0;
                }
            }

            Console.WriteLine(maxSum);

        }
    }
}
