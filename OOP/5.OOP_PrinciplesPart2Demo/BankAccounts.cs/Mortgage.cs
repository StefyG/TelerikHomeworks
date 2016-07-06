using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    public class Mortgage : Account, IDepositable
    {
        public Mortgage(Customer customer, decimal balance, double interestRate, int months) : base(customer, balance, interestRate, months)
        {
        }

        public void DepositMoney(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("You cannot deposit this amount of money: {0}", amount);
            }
            else if (this.Balance < amount)
            {
                Console.WriteLine("You have paid your mortgage!");
                this.Balance = 0;
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override decimal InterestAmount()
        {
            decimal interestAmount = 0;
            if (this.NumberOfMonths <=12 && this.Customer is Company)                 
            {
                interestAmount = (decimal)((this.InterestRate / 2) * this.NumberOfMonths);
            }
            else
            {
                interestAmount = (decimal)((this.InterestRate / 2) * this.NumberOfMonths) +
                    (decimal)this.InterestRate * this.NumberOfMonths;
            }

            if (this.NumberOfMonths >6 && this.Customer is Individual)
            {
                interestAmount = (decimal)(this.InterestRate * (this.NumberOfMonths - 6));
            }

            return interestAmount;
        }
    }
}
