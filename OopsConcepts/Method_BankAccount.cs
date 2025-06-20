using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Method_BankAccount
    {
        string accaccountName;
        double accountBalance;
        public Method_BankAccount(String accountName, double accountBalance)
        {
            this.accaccountName = accaccountName;
            this.accountBalance = accountBalance;
        }
        public void Deposit(double amount)
        {
            accountBalance += amount;
            Console.WriteLine("Balance after deposit = " + accountBalance);
        }
        public void Withdraw(double amount)
        {
            if (accountBalance >= amount)
            {
                accountBalance -= amount;
            }
            Console.WriteLine("Credit Amount =" + accountBalance);
        }

    }
    
}
