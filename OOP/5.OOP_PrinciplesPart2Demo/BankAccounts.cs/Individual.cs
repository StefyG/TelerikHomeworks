using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    public class Individual : Customer
    {
        private string firstName;
        private string lastName;

        //property
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        //constructor
        public Individual(string firstName, string lastName, long id) : base(id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            string individualInfo = string.Format("Name: {0} {1} ID: {2}", this.firstName, this.lastName, this.IDNumber);
            return individualInfo;
        }
    }
}
