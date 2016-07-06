using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    public interface IDepositable
    {
        void DepositMoney(decimal amount);
    }
}
