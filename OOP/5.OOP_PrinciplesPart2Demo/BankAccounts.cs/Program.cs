using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposit deposit = new Deposit(new Individual("Stefania", "Gospodinova", 889689), 15000, 7, 12);

            Console.WriteLine(deposit);
            Console.WriteLine("Interest Amount: " + deposit.InterestAmount());
            deposit.DepositMoney(550);
            Console.WriteLine("New balance after deposit 550: " + deposit.Balance);
            deposit.WithdrawMoney(550);
            Console.WriteLine("Balance after withdraw: "+ deposit.Balance);
            
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            Loan loan = new Loan(new Company("Stefy OOD", 558654), 32000, 12, 36);

            Console.WriteLine(loan);
            loan.DepositMoney(750);
            Console.WriteLine("Balance after deposit 750: " + loan.Balance);

            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
        }
    }
}
