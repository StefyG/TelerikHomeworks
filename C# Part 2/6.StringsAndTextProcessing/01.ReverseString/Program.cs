using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversedStr = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedStr += word[i];
            }
            Console.WriteLine(reversedStr);
        }
    }
}
