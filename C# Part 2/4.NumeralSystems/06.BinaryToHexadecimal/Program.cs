using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinToHex
{
    class Program
    {
        static void BinToHex(string n)
        {
            long decimalNumber = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int digit = n[i] - '0';
                int position = n.Length - i - 1;
                decimalNumber += digit * (long)Math.Pow(2, position);
            }
            string hex = "";

            while (decimalNumber > 0)
            {
                var digit = decimalNumber % 16;
                if (digit >= 0 && digit <= 9)
                {
                    hex += (char)(digit + '0');
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hex += (char)(digit + 'A' - 10);
                }
                decimalNumber /= 16;
            }

            var result = hex.ToCharArray();
            Array.Reverse(result);
            hex = new string(result);
            Console.WriteLine(hex);
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            BinToHex(number);
        }
    }
}
