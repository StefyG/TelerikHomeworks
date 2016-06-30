using System;


namespace ConsoleApplication2
{
    class MoonGravity
    {
        static void Main()
        {
            double W = double.Parse(Console.ReadLine());
            double weightOnTheMoon = W * 0.17;
            Console.WriteLine("{0:0.000}", weightOnTheMoon);
        }
    }
}