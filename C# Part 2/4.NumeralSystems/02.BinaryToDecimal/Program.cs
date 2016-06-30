using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    class Program
    {
        static void BinaryToDecimal(string n)
        {
            long decimalNumber = 0;

            for (int i = 0; i < n.Length; i++)
            {
                int digit = n[i] - '0';
                int position = n.Length - i - 1;
                decimalNumber += digit * (long)Math.Pow(2, position);
            }
            Console.WriteLine(decimalNumber);
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            BinaryToDecimal(number);
        }
    }
}
