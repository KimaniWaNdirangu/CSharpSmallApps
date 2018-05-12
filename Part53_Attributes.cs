using System;
using System.Collections.Generic;

namespace IntroToCSharp
{
    public class Program
    {
        private static void Main()
        {
            Calculator.Add(new List<int>(){10, 20, 40});
            Calculator.Add(10, 20);
        } 
    }

    public class Calculator
    {
        [ObsoleteAttribute("Use Add(List<int> Numbers) Method instead of this method.", true)]
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach (int number in Numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}