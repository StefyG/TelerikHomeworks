using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class Program
    {
        static void ReverseNumber(char[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            char[] numberArray = number.ToCharArray();

            ReverseNumber(numberArray);
        }
    }
}
