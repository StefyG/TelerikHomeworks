﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {

        public Square(double side) : base (side, side)
        {
        }


        public override double CalculateSurface()
        {
            double surface = 0;
            surface = this.Width * this.Height;
            return surface;
        }
    }
}
