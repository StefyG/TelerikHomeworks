using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, double interestRate, int months) : base(customer, balance, interestRate, months)
        {
        }

        public override decimal InterestAmount()
        {
            decimal interestAmount = 0;
            if (this.Balance >=0 && this.Balance <1000)
            {
                Console.WriteLine("To have interest rate the Deposit account have to have ballance more than 1000 and the balance in this one is {0}", this.Balance);
            }
            else
            {
                interestAmount = (decimal)(this.InterestRate * this.NumberOfMonths);
            }
            return interestAmount;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }       

        public void WithdrawMoney(decimal amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("There is no enough money it this bank account!");
            }
            else
            {
                this.Balance -= amount;
            }            
        }
    }
}
