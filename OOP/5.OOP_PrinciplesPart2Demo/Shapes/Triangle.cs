﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {

        public Triangle(double width, double height):base (width, height)
        {
        }


        public override double CalculateSurface()
        {
            double surface = 0;
            surface = (this.Height * this.Width) / 2;
            return surface;
        }
    }
}
