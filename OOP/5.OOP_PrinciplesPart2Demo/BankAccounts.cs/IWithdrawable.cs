using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.cs
{
    public interface IWithdrawable
    {
        void WithdrawMoney(decimal amount);
    }
}
