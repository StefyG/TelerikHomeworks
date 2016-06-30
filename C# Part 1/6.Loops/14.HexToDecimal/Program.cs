using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();
            long decNumber = 0;

            for (int i = 0; i < hexNumber.Length; i++)
            {
                switch (hexNumber[i])
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        decNumber += Convert.ToInt64(hexNumber[i] - 48) * ((long)Math.Pow(16, hexNumber.Length - 1 - i)); break;
                    case 'A': decNumber += 10 * ((long)Math.Pow(16, hexNumber.Length - 1 - i)); break;
                    case 'B': decNumber += 11 * ((long)Math.Pow(16, hexNumber.Length - 1 - i)); break;
                    case 'C': decNumber += 12 * ((long)Math.Pow(16, hexNumber.Length - 1 - i)); break;
                    case 'D': decNumber += 13 * ((long)Math.Pow(16, hexNumber.Length - 1 - i)); break;
                    case 'E': decNumber += 14 * ((long)Math.Pow(16, hexNumber.Length - 1 - i)); break;
                    case 'F': decNumber += 15 * ((long)Math.Pow(16, hexNumber.Length - 1 - i)); break;
                }
            }
            Console.WriteLine(decNumber);
        }
    }
}
