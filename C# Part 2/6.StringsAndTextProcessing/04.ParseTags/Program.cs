using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder uppercaseText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    i += 8;
                    while (text[i] != '<')
                    {
                        uppercaseText.Append(text[i].ToString().ToUpper());
                        i++;
                    }
                    i += 8;
                }
                else
                {
                    uppercaseText.Append(text[i]);
                }
            }
            Console.WriteLine(uppercaseText.ToString());
        }
    }
}
