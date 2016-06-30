using System;

namespace SortThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int smallest;
            int medium;
            int biggest;

            if (a > b)
            {
                if (a > c)
                {
                    biggest = a;
                    if (b > c)
                    {
                        medium = b;
                        smallest = c;
                    }
                    else
                    {
                        medium = c;
                        smallest = b;
                    }
                }
                else
                {
                    biggest = c;
                    smallest = b;
                    medium = a;
                }
            }
            else
            {
                if (b < c)
                {
                    biggest = c;
                    medium = b;
                    smallest = a;
                }
                else
                {
                    if (a < c)
                    {
                        biggest = b;
                        medium = c;
                        smallest = a;
                    }
                    else
                    {
                        biggest = b;
                        medium = a;
                        smallest = c;
                    }
                }
            }
            Console.WriteLine("{0} {1} {2}", biggest, medium, smallest);
        }
    }
}