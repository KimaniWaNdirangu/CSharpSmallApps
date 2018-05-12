using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeProject.SarveshShukla
{
    class Program
    {
        public static void Main()
        {
            BankAccount savingAccount = new SavingBankAccount("Sarvesh", "S12345");
            BankAccount currentAccount = new CurrentBankAccount("Mark", "C12345");

            savingAccount.Deposit(40000);
            savingAccount.Withdraw(1000);
            savingAccount.Withdraw(1000);
            savingAccount.Withdraw(1000);

            // Generate Report
            savingAccount.GenerateAccountReport();

            Console.WriteLine();
            currentAccount.Deposit(190000);
            currentAccount.Withdraw(1000);
            currentAccount.GenerateAccountReport();

            Console.ReadLine();
        }
    }
}
