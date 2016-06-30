using System;
using System.Collections.Generic;

class BinaryShort
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        string binary;
        if (n >= 0)
        {
            binary = Convert.ToString(n, 2).PadLeft(16, '0');
        }
        else
        {
            binary = Convert.ToString(n, 2);
        }

        Console.WriteLine(binary);
    }
}
