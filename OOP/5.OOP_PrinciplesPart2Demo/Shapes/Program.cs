using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(5, 4),
                new Rectangle(8, 4),
                new Square(4)
            };

            foreach (var shape in shapes)
            {
                Console.Write("The surface of the {0} is: ",shape.GetType().Name);
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
