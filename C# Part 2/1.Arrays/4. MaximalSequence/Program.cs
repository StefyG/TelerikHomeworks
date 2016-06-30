using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int count = 1;
            int result = 0;
            bool isTrue = true;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < array.Length-1; j++)
            {
                if (array[j]==array[j+1])
                {
                    count++;
                    
                }
                else
                {
                    isTrue = false;
                    if (result < count)
                    {
                        result = count;
                        count = 1;
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }

            if (isTrue==true)
            {
                result = count;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
