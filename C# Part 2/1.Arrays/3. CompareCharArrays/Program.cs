using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = Console.ReadLine();
            string strB = Console.ReadLine();
            string result = string.Empty;


            var lenght = Math.Min(strA.Length, strB.Length);
            for (int i = 0; i < lenght; i++)
            {
                if (strA[i] == strB[i])
                {
                    result = "=";
                }
                else
                {
                    result = (strA[i] > strB[i]) ? ">" : "<";
                    break;
                }
            }

            if (result == "=" && strA.Length != strB.Length)
            {
                result = (strA.Length > strB.Length) ? ">" : "<";
            }

            Console.WriteLine(result);
        }
    }
}
