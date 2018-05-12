using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeProject.SarveshShukla
{
    public class CurrentBankAccount : BankAccount
    {
        public CurrentBankAccount(string accountOwnerName, string accountNumber)
            : base(accountOwnerName, accountNumber)
        {
            this.MinAccountBalance = 0m;
            this.MaxDepositAmount = 100000000m;
            InteresetRate = .25m;
        }

        public override void Deposit(decimal amount)
        {
            AccountBalance = AccountBalance + amount;
            TransactionSummary = string.Format("{0}\n Deposit:{1}",
                                                TransactionSummary, amount);
        }

        public override void Withdraw(decimal amount)
        {
            if (AccountBalance - amount <= MinAccountBalance)
            {
                throw new Exception("You can not withdraw amount from your Current Account as Minimum Balance limit is reached");
            }

            AccountBalance = AccountBalance - amount;
            TransactionSummary = string.Format("{0}\n Withdraw:{1}",
                                                 TransactionSummary, amount);
        }
        // This method adds details to the base class Reporting functionality 
        public override void GenerateAccountReport()
        {
            Console.WriteLine("Current Account Report");
            base.GenerateAccountReport();
        }
    }
}
