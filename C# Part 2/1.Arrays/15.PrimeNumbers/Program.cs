using System;

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        
        //Input
        for (int i = 2; i <= n; i++)
        {
            numbers[i - 2] = i;
        }

        int p = 2;
        int k = 0;
        while (k <= n)
        {
            for (k = 2 * p; k <= n; k += p)
            {
                if (numbers[k - 2] > 0)
                {
                    numbers[k - 2] = -numbers[k - 2];
                }
            }

            k = p + 1;
            while (k <= n)
            {
                if (numbers[k - 2] > 0)
                {
                    p = numbers[k - 2];
                    break;
                }
                k++;
            }
        }

        //Output
        for (int i = n; i >= 2; i--)
        {
            if (numbers[i - 2] > 0)
            {
                Console.WriteLine(numbers[i - 2]);
                break;
            }
        }
    }
}
