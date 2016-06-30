using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.DecimalToBinary
{
    class Program
    {
        static void DecimalToBinary(BigInteger n)
        {
            string binaryNumber = "";

            while (n != 0)
            {
                var digit = n % 2;
                binaryNumber += digit;
                n /= 2;
            }

            var result = binaryNumber.ToCharArray();
            Array.Reverse(result);
            binaryNumber = new string(result);
            Console.WriteLine(binaryNumber);
        }

        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            DecimalToBinary(number);
        }
    }
}
