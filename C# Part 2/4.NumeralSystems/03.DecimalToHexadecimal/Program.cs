using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.DecimalToHex
{
    class Program
    {
        static void DecToHex(BigInteger n)
        {
            string hex = "";
            while (n > 0)
            {
                var digit = n % 16;
                if (digit >= 0 && digit <= 9)
                {
                    hex += (char)(digit + '0');
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hex += (char)(digit + 'A' - 10);
                }
                n /= 16;
            }

            var result = hex.ToCharArray();
            Array.Reverse(result);
            hex = new string(result);
            Console.WriteLine(hex);
        }


        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            DecToHex(number);
        }
    }
}
