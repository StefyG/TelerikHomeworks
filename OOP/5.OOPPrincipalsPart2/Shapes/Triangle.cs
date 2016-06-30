using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{

    public class Triangle : Shape
    {
        // Constructors
        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        // Methods
        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
