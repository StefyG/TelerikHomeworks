using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char symbol = '*';

            if (text.Length <= 20)
            {
                Console.WriteLine(text.PadRight(20, symbol));
            }
        }
    }
}
