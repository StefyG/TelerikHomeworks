using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return height; }
            set { this.height = value; }
        }

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract double CalculateSurface();
        
    }
}
