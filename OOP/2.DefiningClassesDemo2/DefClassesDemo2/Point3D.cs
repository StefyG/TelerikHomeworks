using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClassesDemo2
{
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D pointO;

        

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D O
        {
            get { return pointO; }
        }

        static Point3D()
        {
            pointO.X = 0;
            pointO.Y = 0;
            pointO.Z = 0;
        }

        public override string ToString()
        {
            string result = string.Format("Coordinates: {0} {1} {2}", this.X, this.Y, this.Z);
            return result;
        }
    }
}
