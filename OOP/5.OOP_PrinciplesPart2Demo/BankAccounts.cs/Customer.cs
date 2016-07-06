using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    public class Customer
    {
        private long idNumber;


        //property
        public long IDNumber
        {
            get { return idNumber; }
            set { this.idNumber = value; }
        }


        //constructor
        public Customer(long id)
        {            
            this.idNumber = id;
        }               
    }
}
