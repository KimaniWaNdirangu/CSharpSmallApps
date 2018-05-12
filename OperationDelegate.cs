using System;

namespace PMP
{
    public delegate int OperationDelegate(int firstNumber, int secondNumber);

    public class Program
    {
        public static int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int SubtractNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int MultiplyNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static void Main(string[] args)
        {
            OperationDelegate del = new OperationDelegate(AddNumbers);

            int firstNumber  = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int result = AddNumbers(firstNumber, secondNumber);

            Console.WriteLine("Addition = {0}", result);

            del = MultiplyNumbers;

            result = del(firstNumber, secondNumber);

            Console.WriteLine("Multiplication = {0}", result);
        }
    }
}
