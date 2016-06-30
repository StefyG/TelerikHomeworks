using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string wayFilled = Console.ReadLine();
            int[,] array = new int[n, n];
            int count = 1;

            switch (wayFilled)
            {
                case "a":
                    for (int col = 0; col < array.GetLength(0); col++)
                    {
                        for (int row = 0; row < array.GetLength(1); row++)
                        {
                            array[row, col] = count;
                            count++;
                        }
                    }
                    break;
                case "b":
                    for (int col = 0; col < array.GetLength(0); col++)
                    {
                        if (col % 2 == 0)
                        {
                            for (int row = 0; row < array.GetLength(1); row++)
                            {
                                array[row, col] = count;
                                count++;
                            }
                        }
                        else
                        {
                            for (int row = n - 1; row >= 0; row--)
                            {
                                array[row, col] = count;
                                count++;
                            }
                        }
                    }
                    break;
                case "c":
                    for (int i = n - 1; i >= 0; i--)
                    {
                        int row = i;
                        int col = 0;
                        while (row < n && col < n)
                        {
                            array[row++, col++] = count++;
                        }
                    }
                    for (int j = 1; j < n; j++)
                    {
                        int row = j;
                        int col = 0;
                        while (row < n && col < n)
                        {
                            array[col++, row++] = count++;
                        }
                    }
                    break;
                case "d":
                    for (int i = 0; i < n - 1; i++)
                    {
                        //down 
                        for (int row = i; row < n - i; row++)
                        {
                            array[row, i] = count;
                            count++;
                        }

                        //right
                        for (int col = i + 1; col < n - i; col++)
                        {
                            array[n - 1 - i, col] = count;
                            count++;
                        }

                        //up 
                        for (int row = n - i - 1 - 1; row > i; row--)
                        {
                            array[row, n - 1 - i] = count;
                            count++;
                        }

                        //left                    
                        for (int col = n - i - 1; col > i; col--)
                        {
                            array[i, col] = count;
                            count++;
                        }
                    }
                    break;
            }



            //print
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (col == array.GetLength(0) - 1)
                    {
                        Console.Write("{0}", array[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", array[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
