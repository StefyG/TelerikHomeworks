using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 11;
            int tempSum = 0;
            bool isTrue = true;
            List<int> list = new List<int>();
            int[] arr = new int[] { 4, 3, 1, 4, 2, 5, 8 };

            for (int i = 0; i < arr.Length; i++)
            {
                tempSum = arr[i];
                list.Add(arr[i]);
                for (int j = i+1; j < arr.Length; j++)
                {
                    tempSum += arr[j];
                    list.Add(arr[j]);
                    if (sum == tempSum)
                    {
                        Console.WriteLine(string.Join(", ", list));
                    }
                    else if (sum > tempSum)
                    {
                        continue;
                    }
                    else //sum<tempSum
                    {
                        list.Clear();
                        break;
                    }
                }
            }
           
        }
    }
}
