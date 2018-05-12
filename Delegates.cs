using System;

namespace PMP
{
    public delegate int AddNumbersDelegate(int firstNumber, int secondNumber);

    public class Program
    {
        public static int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int MultiplyNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static void Main(string[] args)
        {
            AddNumbersDelegate del = new AddNumbersDelegate(AddNumbers);

            int firstNumber  = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int result = del(firstNumber, secondNumber);

            Console.WriteLine("Addition = {0}", result);

            del = MultiplyNumbers;

            result = del(firstNumber, secondNumber);

            Console.WriteLine("Multiplication = {0}", result);
        }
    }
}

