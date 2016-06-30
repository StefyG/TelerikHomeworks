using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1)
                {
                    sb.Append(text[i]);
                }
                else if (text[i] == text[i + 1])
                {
                    continue;
                }
                else
                {
                    sb.Append(text[i]);
                }

            }
            Console.WriteLine(sb);

        }
    }
}
