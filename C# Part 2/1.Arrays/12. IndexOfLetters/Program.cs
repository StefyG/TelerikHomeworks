using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                Console.WriteLine(Array.IndexOf(alpha, wordArray[i]));
            }
        }
    }
}
