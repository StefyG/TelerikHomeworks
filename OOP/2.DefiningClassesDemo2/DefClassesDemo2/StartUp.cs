using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClassesDemo2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Problems 1-7
            //points
            Point3D point1 = Point3D.O;

            Point3D point2 = new Point3D();
            point2.X = 1.22;
            point2.Y = 2.22;
            point2.Z = 3.22;

            Point3D point3 = new Point3D();
            point3.X = 2.5;
            point3.Y = 4.7;
            point3.Z = 1.3;

            Path path = new Path();
            path.Points.Add(point1);
            path.Points.Add(point2);
            path.Points.Add(point3);

            //save points in text file + load the file
            PathStorage.Save(path);
            PathStorage.Load();
        }
    }
}
