using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClassesDemo2
{
    public static class PathStorage
    {
        private const string TEXT_FILE_NAME = "path-storage.txt";

        public static void Save(Path path)
        {
            double distance = 0;
            for (int i = 0; i < path.Points.Count - 1; i++)
            {
                var firstPoint = path.Points[i];
                var secondPoint = path.Points[i + 1];

                distance += Distance.CalculateDistance(firstPoint, secondPoint);
            }

            using (StreamWriter writer = new StreamWriter(TEXT_FILE_NAME))
            {
                foreach (var point in path.Points)
                {
                    writer.WriteLine("Point coordinates: {0}", point.ToString());
                }

                writer.WriteLine("Distance: {0:F2}", distance);
            }
        }

        public static void Load()
        {

            if (File.Exists(TEXT_FILE_NAME))
            {
                using (StreamReader reader = new StreamReader(TEXT_FILE_NAME))
                {
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException();
            }


        }
    }
}

