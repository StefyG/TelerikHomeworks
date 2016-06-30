using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 1;
            int result = 0;
            int temp = 0;
            bool isTrue = true;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arr.Length-1; j++)
            {
                if (arr[j] < arr[j+1])
                {
                    isTrue = true;
                    count++;
                    if (j == arr.Length - 2)
                    {
                        temp = count;
                        if (temp<result)
                        {
                            break;
                        }
                        else
                        {
                            result = temp;
                        }
                    }
                    
                }
                else
                {
                    isTrue = false;
                    if (result>count)
                    {
                        count = 1;
                    }
                    else
                    {
                        result = count;
                        count = 1;
                    }
                }
               
            }

            if (isTrue==true)
            {
                             
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result);
            }

        }
    }
}
