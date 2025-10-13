using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimpleBankingSystem
{
    public interface IBankService
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        void CheckBalance();
    }
}
