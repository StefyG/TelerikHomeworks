using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            List<long> binary = new List<long>();

            if (number == 0)
            {
                Console.Write(0);
            }
            while (number > 0)
            {
                long remainder = number % 2;
                binary.Add(remainder);
                number /= 2;
            }
            binary.Reverse();
            foreach (var bin in binary)
            {
                Console.Write(bin);
            }
            Console.WriteLine();
        }
    }
}
