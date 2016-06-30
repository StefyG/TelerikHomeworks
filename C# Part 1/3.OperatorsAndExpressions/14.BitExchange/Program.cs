using System;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string numberAsBinary = Convert.ToString(number, 2).PadLeft(64, '0');
            var binArray = numberAsBinary.ToCharArray();
            Array.Reverse(binArray);

            char temp = binArray[3];
            binArray[3] = binArray[24];
            binArray[24] = temp;

            char temp2 = binArray[4];
            binArray[4] = binArray[25];
            binArray[25] = temp2;

            char temp3 = binArray[5];
            binArray[5] = binArray[26];
            binArray[26] = temp3;

            Array.Reverse(binArray);
            string result = new string(binArray);
            long finalResult = Convert.ToInt64(result, 2);
            Console.WriteLine(finalResult);


        }
    }
}