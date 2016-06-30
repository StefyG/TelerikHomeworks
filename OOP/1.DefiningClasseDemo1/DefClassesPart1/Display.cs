using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClassesPart1
{
    public class Display
    {
        private double size;
        private int colors;

        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }

        public Display()
        {

        }

        public Display(double size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }

        public override string ToString()
        {
            string result = string.Format("Display size is {0} with {1} colors", this.size, this.colors);
            return result;
        }
    }
}
