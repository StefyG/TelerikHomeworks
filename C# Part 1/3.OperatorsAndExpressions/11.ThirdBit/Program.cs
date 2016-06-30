using System;


namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int position = 3;
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> position;
            Console.WriteLine(bit);

        }
    }
}