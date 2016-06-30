using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sub_stringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine();
            string text = Console.ReadLine();

            string mainText = text.ToLower();
            string mainSubstring = substring.ToLower();



            int count = 0;
            int index = mainText.IndexOf(mainSubstring);

            while (index > -1)
            {
                count++;
                index = mainText.IndexOf(mainSubstring, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
