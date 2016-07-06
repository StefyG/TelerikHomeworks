using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    public class Loan : Account, IDepositable
    {
        public Loan(Customer customer, decimal balance, double interestRate, int months) : base(customer, balance, interestRate, months)
        {
        }

        public void DepositMoney(decimal amount)
        {
            if (amount <=0)
            {
                Console.WriteLine("You cannot deposit this amount of money: {0}", amount);
            }
            else if (this.Balance < amount)
            {
                Console.WriteLine("You have paid your loan!");
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

            if (this.NumberOfMonths <= 3 && this.Customer is Individual)                 
            {              
                interestAmount = (decimal)(this.InterestRate * (this.NumberOfMonths-3));
            }

            if (this.NumberOfMonths <=2 && this.Customer is Company)
            {
                interestAmount = (decimal)(this.InterestRate * (this.NumberOfMonths - 2));
            }

            return interestAmount;
        }
    }
}
