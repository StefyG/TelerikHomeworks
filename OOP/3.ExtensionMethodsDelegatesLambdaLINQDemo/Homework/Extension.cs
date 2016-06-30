using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class Extension
    {
        //problem 1: Implement an extension method Substring(int index, int length) 
        //for the class StringBuilder that returns new StringBuilder 
        //and has the same functionality as Substring in the class String.
        public static StringBuilder SubstringExtension(this StringBuilder str, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            int count = 0;

            if (startIndex > str.Length || startIndex < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range: " + startIndex);
            }

            for (int i = startIndex; count < length; i++)
            {
                result.Append(str[i]);
                count++;
            }
            return result;
        }

        //problem 2
        public static T MySum<T>(this IEnumerable<T> elements)
        {
            T sum = default(T);

            foreach (var el in elements)
            {
                sum += (dynamic)el;
            }

            return sum;
        }

        public static T CalculateProduct<T>(this IEnumerable<T> elements)
        {
            T product = default(T) + (dynamic)1;

            foreach (var el in elements)
            {
                product *= (dynamic)el;
            }

            return product;
        }

        public static T MinValue<T>(this IEnumerable<T> elements)
        {
            T min = elements.ElementAt(0);

            foreach (var el in elements)
            {
                if (min > (dynamic)el)
                {
                    min = el;
                }
            }
            return min;
        }

        public static T MaxValue<T>(this IEnumerable<T> elements)
        {
            T max = elements.ElementAt(0);

            foreach (var el in elements)
            {
                if (max < (dynamic)el)
                {
                    max = el;
                }
            }
            return max;
        }

        public static T AverageValue<T>(this IEnumerable<T> elements)
        {
            T sum = default(T);
            T average = default(T);
            int count = elements.Count();

            foreach (var el in elements)
            {
                sum += (dynamic)el;
            }
            average = sum / (dynamic)count;
            return average;
        }

        public static List<Student> ExtractGroupTwoStudents(this List<Student> list)
        {
            var group = //list.Where(s => s.GroupNumber == 2).ToList();
                from l in list
                where l.GroupNumber == 2
                select l;

            return new List<Student>(group);
           
        }

        public static List<Student> ContainsTwoMarks(this List<Student> list)
        {
            var marks = list.Where(l => l.Marks.Count == 2).ToList();

            return marks;
        }          
       
             

    }
}
