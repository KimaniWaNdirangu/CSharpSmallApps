using System;

namespace Anzari.PesaFasta.ATM
{
    /// <summary>
    /// Screen Class - Display messages to the customer on the ATM screen
    /// </summary>
    public class Screen
    {
        public void DisplayMessage(string message)
        {
            Console.Write(message);
        }

        public void DisplayMessageLine(string message)
        {
            Console.WriteLine(message);
        }
        public void DisplayKESAmount(decimal amount)
        {
            Console.WriteLine("KES : {0:N2}", amount);
        }
    } // End class Screen
}
