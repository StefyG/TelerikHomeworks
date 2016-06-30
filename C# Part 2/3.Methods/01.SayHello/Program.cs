using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SayHello
{
    class Program
    {
        static void PrintName(string word)
        {
            Console.WriteLine("Hello, {0}!", word);
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
    }
}
