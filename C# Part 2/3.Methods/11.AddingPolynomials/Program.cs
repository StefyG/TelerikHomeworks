using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingPolynomials
{
    class Program
    {
        static void SumPolynomials(int[] arr1, int[] arr2)
        {
            int[] sum = new int[arr1.Length];
            for (int e = 0; e < sum.Length; e++)
            {
                sum[e] = arr1[e] + arr2[e];
            }

            for (int k = 0; k < sum.Length; k++)
            {
                if (k == sum.Length - 1)
                {
                    Console.Write("{0}", sum[k]);

                }
                else
                {
                    Console.Write("{0} ", sum[k]);
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstPolynom = Console.ReadLine();
            string secondPolynom = Console.ReadLine();
            string[] first = firstPolynom.Split(' ');
            string[] second = secondPolynom.Split(' ');
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(first[i]);
            }
            for (int j = 0; j < secondArray.Length; j++)
            {
                secondArray[j] = int.Parse(second[j]);
            }

            SumPolynomials(firstArray, secondArray);
        }
    }
}
