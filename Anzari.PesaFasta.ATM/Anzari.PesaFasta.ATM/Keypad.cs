using System;


namespace Anzari.PesaFasta.ATM
{
    public class Keypad
    {
        private int input;

        public Keypad()
        {
            input = int.Parse(Console.ReadLine());
        }

        public int getInput()
        {
            return this.input;
        }
    }
}
