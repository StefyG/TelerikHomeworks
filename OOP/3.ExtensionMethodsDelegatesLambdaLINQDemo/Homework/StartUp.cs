using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Homework
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //problem 1:
            StringBuilder str = new StringBuilder();
            str.Append("12345");
            var sb = str.SubstringExtension(1, 4);
            Console.WriteLine(sb);

            //problem 2:
            List<int> list = new List<int>();
            list.Add(11);
            list.Add(1);
            list.Add(5);
            list.Add(9);
            var result = list.MySum();
            var product = list.CalculateProduct();
            var min = list.MinValue();
            var max = list.MaxValue();
            var average = list.AverageValue();
            Console.WriteLine(result);
            Console.WriteLine(product);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(average);

            //Problem 3:
            var studentsList = new List<Student>()
            {
                new Student("Borqna","Gospodinova",27),
                new Student("Ivan", "Georgiev", 21),
                new Student("Pesho", "Hristov", 17),
                new Student("Anastasia", "Lazarova", 19)
            };

            //Lambda Expressions
            //var orderedListStudents = studentsList.FindAll(x => x.FirstName.CompareTo(x.LastName) == -1).ToList();

            //LINQ Query
            var orderedListStudents =
                from student in studentsList
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            Console.WriteLine("First name before last:");
            foreach (var student in orderedListStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //Problem 4:
            //Lambda
            //var studentsByAge = studentsList.Where(x => x.Age >= 18 && x.Age <= 24).ToList();
            //LINQ
            var studentsByAge =
                from student in studentsList
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("Age between 18 and 24:");
            foreach (var student in studentsByAge)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //Problem 5:
            //Lambda
            //var decendingOrderStudents = studentsList.OrderBy(s => s.FirstName)
            //                                         .ThenBy(s => s.LastName)
            //                                         .ToList();
            //LINQ
            var decendingOrderStudents =
                from student in studentsList
                orderby student.FirstName, student.LastName                   
                select student;

            Console.WriteLine("Decending order by name:");
            foreach (var student in decendingOrderStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //Problem 6: Divisible by 7 and 3
            //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
            //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

            var numbers = new int[] { 2, 5, 0, 55, 79, 13, 7, 49, 33, 21 };

            //Lambda
            //var arr = numbers.Where(n => n % 7 == 0 && n % 3 == 0).ToArray();
            //LINQ
            var arr =
                from number in numbers
                where number % 7 == 0 && number % 3 == 0
                select number;

            Console.WriteLine("Divisible by 7 and 3:");
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine();

            //Problem 7 - Timer
            Timer.ShowTime(1);

            //Problem 8 - Event

            //Problem 9
            var marks1 = new List<double>() { 6, 6,  };
            var marks2 = new List<double>() { 4, 6, 3 };
            var marks3 = new List<double>() { 3, 5, 2 };
            var marks4 = new List<double>() { 3 };

            var students = new List<Student>()
            {
                new Student("Stefania", "Gospodinova", "962506","02 937 20 10", "stef@gmail.com", 1, marks1),
                new Student("Ivan", "Georgiev", "885206", "0884 56 23 45", "vankata@abv.bg", 2, marks2),
                new Student("Maria","Lazarova", "752205", "0886 52 32 14","maria@abv.bg", 2, marks3),
                new Student("Pesho","Ivanow", "852506", "0886 85 45 69","pesho@abv.bg", 3, marks4),
            };

            var groupTwoStudents = students.Where(s => s.GroupNumber == 2).ToList();

            Console.WriteLine("Students from goup 2:");
            foreach (var student in groupTwoStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            var orderedByName =
                from st in students
                orderby st.FirstName
                select st;

            Console.WriteLine("Students ordered by firstname:");
            foreach (var st in orderedByName)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            //Problem 10
            var group = students.ExtractGroupTwoStudents();
            Console.WriteLine("EXTENSION: Students from group 2:");
            foreach (var st in group)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            //Problem 11
            var emailABV = students.Where(s => s.Email.Contains("abv.bg")).ToList();

            Console.WriteLine("Students, whose emails are in ABV.BG:");
            foreach (var st in emailABV)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            //Problem 12:
            var phoneSofia = students.Where(st => st.TelNumber.StartsWith("02")).ToList();
            Console.WriteLine("Students with phone number in Sofia:");
            foreach (var st in phoneSofia)
            {
                Console.WriteLine(st + " " + "tel: " +st.TelNumber);
            }
            Console.WriteLine();

            //Problem 13:
            var excellentMarks = students.Where(s => s.Marks.Contains(6))
                                         .Select(x => new
                                         {
                                             Fullname = x.FirstName + " " + x.LastName,
                                             Marks = string.Join(" ,", x.Marks)
                                         });
            Console.WriteLine("Students with at least one 6:");
            foreach (var st in excellentMarks)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            //Problem 14:
            var twoMarks = students.ContainsTwoMarks();

            Console.WriteLine("Students with two marks:");
            foreach (var st in twoMarks)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " marks: " + string.Join(", ", st.Marks));
            }
            Console.WriteLine();

            //Problem 15:
            var enrolledStudents = students.Where(s => s.FacultyNumber.EndsWith("06")).ToList();

            Console.WriteLine("Students enrolled in 2006:");
            foreach (var st in enrolledStudents)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " marks: " + string.Join(", ", st.Marks));
            }
            Console.WriteLine();

            //Problem 16:
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Physics"),
                new Group(2, "Mathematics"),
                new Group(3, "Sports")
            };

            var department =
                from student in students
                join gr in groups
                on student.GroupNumber equals gr.GroupNumber
                where student.GroupNumber == 2
                select new
                {
                    Name = student.FirstName + " " + student.LastName,
                    Department = gr.DepartmentName
                };

            Console.WriteLine("Students in Mathematics Department:");
            foreach (var st in department)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            //Problem 17 - Longest String
            //Write a program to return the string with maximum length from an array of strings
            //Use LINQ

            string[] fruitArr = new string[]
            {
                "orange", "lemon", "pineapple", "strawberry", "apple"
            };

            var longestString = fruitArr.OrderByDescending(f => f.Length).First();

            Console.WriteLine("The longest string in the array is: {0}", longestString);
            Console.WriteLine();

            //Problem 18
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.

            var groupedByGroupNumber = students.GroupBy(s => s.GroupNumber).ToList();

            foreach (var gr in groupedByGroupNumber)
            {
                foreach (var student in gr)
                {
                    Console.WriteLine("Student {0} {1} is in group {2}", student.FirstName,student.LastName, student.GroupNumber );
                }                
            }
            Console.WriteLine();
            
        }
    }
}
