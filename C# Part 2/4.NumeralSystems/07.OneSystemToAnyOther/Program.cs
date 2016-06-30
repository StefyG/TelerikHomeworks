using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.OneSystemToAnyOther
{
    class Program
    {
        static void BaseToOtherBase(string number, long numeralSystemOne, int numeralSystemTwo)
        {
            long decimalNumber = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;

                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else
                {
                    digit = number[i] - 'A' + 10;
                }
                decimalNumber += digit * (long)BigInteger.Pow(numeralSystemOne, number.Length - i - 1);
            }

            string newNumber = "";
            while (decimalNumber > 0)
            {
                var digit2 = decimalNumber % numeralSystemTwo;
                if (digit2 >= 0 && digit2 <= 9)
                {
                    newNumber += (char)(digit2 + '0');
                }
                else
                {
                    newNumber += (char)(digit2 + 'A' - 10);
                }
                decimalNumber /= numeralSystemTwo;
            }

            var result = newNumber.ToCharArray();
            Array.Reverse(result);
            newNumber = new string(result);
            Console.WriteLine(newNumber);
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());

            BaseToOtherBase(number, n, d);
        }
    }
}
