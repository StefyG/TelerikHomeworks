using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 1;
            int temp = 1;            
            int neededNumber=0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[j] == arr[k])
                    {
                        temp++;
                        if (temp > count)
                        {
                            count = temp;
                            neededNumber = arr[j];
                        }                       
                    }                    
                }
                temp = 1;
            }
            Console.WriteLine("{0} ({1} times)", neededNumber, count);
        }
    }
}
