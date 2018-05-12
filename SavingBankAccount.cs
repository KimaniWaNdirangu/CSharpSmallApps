using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeProject.SarveshShukla
{
    public class SavingBankAccount : BankAccount
    {
        protected int withdrawCount = 0;

        public SavingBankAccount(string accountOwnerName, string accountNumber)
            : base(accountOwnerName, accountNumber)
        {
            this.MinAccountBalance = 20000m;
            this.MaxDepositAmount = 50000m;
            InteresetRate = 3.5m;
        }

        public override void Deposit(decimal amount)
        {
            if (amount >= MaxDepositAmount)
            {
                throw new Exception(string.Format("You can not deposit amount greater than {0}", MaxDepositAmount.ToString()));
            }

            AccountBalance = AccountBalance + amount;

            TransactionSummary = string.Format("{0}\n Deposit:{1}",
                                                TransactionSummary, amount);
        }

        public override void Withdraw(decimal amount)
        {
            // some hard coded logic that withdraw count should not be greater than 3
            if (withdrawCount > 3)
            {
                throw new Exception("You can not withdraw amount more than thrice");
            }

            if (AccountBalance - amount <= MinAccountBalance)
            {
                throw new Exception("You can not withdraw amount from your Savings Account as Minimum Balance limit is reached");
            }

            AccountBalance = AccountBalance - amount;
            withdrawCount++;

            TransactionSummary = string.Format("{0}\n Withdraw:{1}",
                                                TransactionSummary, amount);
        }
        // This method adds details to the base class Reporting functionality 
        public override void GenerateAccountReport()
        {
            Console.WriteLine("Saving Account Report");
            base.GenerateAccountReport();

            // Send an email to user if Savings account balance is less 
            // than user specified balance this is different than MinAccountBalance
            if (AccountBalance > 15000)
            {
                Console.WriteLine("Sending Email for Account {0}", AccountNumber);
            }
        }
    }
}
