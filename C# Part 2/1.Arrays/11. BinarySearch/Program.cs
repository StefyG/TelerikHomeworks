using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int elementX = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(arr, elementX, 0, n));
        }
        //int index = Array.IndexOf(arr, elementX);
        //Console.WriteLine(index);


        //bynary search
        public static object BinarySearch(int[] inputArray, int key, int min, int max)
        {

            while (min <= max)
            {

                int mid = (min + max) / 2;

                if (key == inputArray[mid])
                {

                    return mid;

                }
                else if (key < inputArray[mid])
                {

                    max = mid - 1;

                }
                else {

                    min = mid + 1;

                }

            }

            return "-1";

        }


    }
}


