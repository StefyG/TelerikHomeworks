﻿using System;


namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}