using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string TelNumber { get; set; }

        public string Email { get; set; }

        public List<double> Marks { get; set; }

        public int GroupNumber { get; set; }

        

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName, string FN, string tel, string email, int group, List<double> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = FN;
            this.TelNumber = tel;
            this.Email = email;
            this.GroupNumber = group;
            this.Marks = marks;            
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} email: {this.Email} group:{this.GroupNumber}";
        }
    }
}
