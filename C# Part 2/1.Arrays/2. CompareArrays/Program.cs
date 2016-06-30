using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] one = new int[n];
            int[] two = new int[n];
            bool isEqual = true;

            for (int i = 0; i < one.Length; i++)
            {
                one[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < two.Length; j++)
            {
                two[j] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < one.Length; k++)
            {
                if (one[k] != two[k])
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual==true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
