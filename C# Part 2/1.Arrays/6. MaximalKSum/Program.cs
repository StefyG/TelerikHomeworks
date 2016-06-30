using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);
            int sum = 0;            

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
            }

            for (int j = 0; j < k; j++)
            {
                int max = list.Max();
                sum += max;
                list.Remove(max);                
            }
            Console.WriteLine(sum);
        }
    }
}
