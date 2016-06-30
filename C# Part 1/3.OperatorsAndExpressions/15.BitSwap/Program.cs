using System;


namespace BitSwap
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            char temp;

            string numberAsBinary = Convert.ToString(n, 2).PadLeft(64, '0');
            var binArray = numberAsBinary.ToCharArray();
            Array.Reverse(binArray);

            for (int i = p, j = q; i <= p + k - 1; i++, j++)
            {
                temp = binArray[i];
                binArray[i] = binArray[j];
                binArray[j] = temp;
            }

            Array.Reverse(binArray);
            string result = new string(binArray);
            long finalResult = Convert.ToInt64(result, 2);
            Console.WriteLine(finalResult);
        }
    }
}
