﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string result = string.Empty;

            while (number > 0)
            {
                switch (number % 16)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 0:
                        result = number % 16 + result;
                        break;
                    case 10: result = "A" + result; break;
                    case 11: result = "B" + result; break;
                    case 12: result = "C" + result; break;
                    case 13: result = "D" + result; break;
                    case 14: result = "E" + result; break;
                    case 15: result = "F" + result; break;
                }
                number /= 16;
            }
            Console.WriteLine(result);
        }
    }
}
