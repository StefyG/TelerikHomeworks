using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexToBin
{
    class Program
    {
        static void HexToBin(string n)
        {
            string binaryNumber = "";
            long decimalNumber = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int digit = 0;
                if (n[i] >= '0' && n[i] <= '9')
                {
                    digit = n[i] - '0';
                }
                else if (n[i] >= 'A' && n[i] <= 'F')
                {
                    digit = n[i] - 'A' + 10;
                }
                decimalNumber += digit * (long)Math.Pow(16, n.Length - i - 1);
            }
            while (decimalNumber != 0)
            {
                var digit = decimalNumber % 2;
                binaryNumber += digit;
                decimalNumber /= 2;
            }

            var result = binaryNumber.ToCharArray();
            Array.Reverse(result);
            binaryNumber = new string(result);
            Console.WriteLine(binaryNumber);
        }

        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();

            HexToBin(hexNumber);
        }
    }
}
