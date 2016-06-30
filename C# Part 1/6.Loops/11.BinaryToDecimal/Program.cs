using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger binaryNumber = BigInteger.Parse(Console.ReadLine());
            int[] digits = binaryNumber.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            Array.Reverse(digits);
            int sum = 0;

            for (int i = 0, power = 1; i < digits.Length; i++, power *= 2)
            {
                sum += (digits[i] - 48) * power;
            }
            Console.WriteLine(sum);
        }
    }
}
