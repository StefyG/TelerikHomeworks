using System;

namespace NthBit
{
    class NthBit
    {
        static void Main()
        {
            long P = long.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int mask = 1 << N;
            long numberAndMask = P & mask;
            long bit = numberAndMask >> N;
            Console.WriteLine(bit);
        }
    }
}