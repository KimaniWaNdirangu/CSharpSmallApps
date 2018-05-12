using System;

namespace Anzari.PesaFasta.ATM
{
    public class CashDispenser
    {
        public const int INITIAL_COUNT = 500;

        private int count;

        public CashDispenser()
        {
            count = INITIAL_COUNT;
        }

        public void dispenseCash(int amount)
        {
            int billsRequired = amount / 20;
            count = count - billsRequired;
        }

        /// <summary>
        /// indicates whether cash dispenser can dispense desired amount of money
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool isSufficientCashAvailable(int amount)
        {
            int billsRequired = amount / 1000;

            if (count >= billsRequired)
            {
                return true;
            }
            else
            {
                return false;
            }
        } // End mehthod isSufficientCashAvailable
    }
}
