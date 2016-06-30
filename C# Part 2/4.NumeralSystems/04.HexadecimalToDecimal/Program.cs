using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexToDec
{
    class Program
    {
        static void HexToDec(string n)
        {
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
            Console.WriteLine(decimalNumber);
        }


        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            HexToDec(number);
        }
    }
}
