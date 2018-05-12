using System;
using System.IO;

namespace IntroToCSharp
{
    public class Program
    {
        public static void Main()
        {
            string[] daysOfWeek = (string[])Enum.GetNames(typeof(DayOfWeek));

            int[] dayCodes = (int[])Enum.GetValues(typeof(DayOfWeek));

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day); 
                foreach (int dayCode in dayCodes)
                {
                    Console.WriteLine(" : " + dayCode);
                } 
            }
        } // End Main()
    }

    public enum DayOfWeek
    { 
        Sunday              = 1,
        Monday, Tuesday     = 1,
        Wednesday, Thursday = 2,
        Friday, Saturday
    }
}