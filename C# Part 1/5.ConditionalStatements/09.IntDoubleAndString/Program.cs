using System;


namespace IntDoubleString
{
    class Program
    {
        static void Main()
        {
            var type = Console.ReadLine();
            var value = Console.ReadLine();

            switch (type)
            {
                case "integer": Console.WriteLine("{0}", int.Parse(value) + 1); break;
                case "real": Console.WriteLine("{0:F2}", double.Parse(value) + 1); break;
                case "text": Console.WriteLine("{0}*", value); break;
            }
        }
    }
}
