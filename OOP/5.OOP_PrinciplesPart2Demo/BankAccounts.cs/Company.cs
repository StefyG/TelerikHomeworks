using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    public class Company : Customer
    {
        private string companyName;

        //property
        public string CompanyName
        {
            get { return companyName; }
            set { this.companyName = value; }
        }

        //constructor
        public Company(string companyName, long id) : base(id)
        {
            this.companyName = companyName;
        }

        public override string ToString()
        {
            string companyInfo = string.Format("Name: {0}, ID: {1}",this.CompanyName, this.IDNumber);
            return companyInfo;
        }
    }
}
