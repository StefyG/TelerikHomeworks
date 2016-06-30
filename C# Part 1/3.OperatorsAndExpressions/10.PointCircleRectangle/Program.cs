using System;


namespace PointCircleRectangle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool insideCircle = true;
            bool insideRectangle = true;

            if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5)
            {
                insideCircle = true;
            }
            else
            {
                insideCircle = false;
            }

            if ((x >= -1 && x <= 5 && y <= 1 && y >= -1))
            {
                insideRectangle = true;
            }
            else
            {
                insideRectangle = false;
            }

            if (insideCircle)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if (insideRectangle)
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }
    }
}