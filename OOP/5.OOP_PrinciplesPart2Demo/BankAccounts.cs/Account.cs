using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private double interestRate;
        private int numberOfMonths;


        public Customer Customer { get; set; }

        public decimal Balance
        {
            get { return balance; }
            set { this.balance = value; }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { this.interestRate = value; }
        }

        public int NumberOfMonths
        {
            get { return numberOfMonths; }
            set { this.numberOfMonths = value; }
        }

        public Account(Customer customer, decimal balance, double interestRate, int months)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
            this.numberOfMonths = months;
        }

        public abstract decimal InterestAmount();

        public override string ToString()
        {
            string info = string.Format("Customer {0} Balance: {1} Interest Rate:{2} Months: {3}", this.customer, this.Balance, this.interestRate, this.numberOfMonths);
            return info;
        }

    }
}
