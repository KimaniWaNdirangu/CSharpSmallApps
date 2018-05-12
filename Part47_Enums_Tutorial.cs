using System;
using System.IO;

namespace IntroToCSharp
{
    public class Program
    {
        public static void Main()
        {
            //Gender gender = (Gender)Season.Winter;

            //Gender gender = (Gender)3;
            //int num = (int)Gender.Unknown;

            //short[] values = (short[])Enum.GetValues(typeof(Gender));

            //foreach (short value in values)
            //{
            //    Console.WriteLine(value);
            //}

            //string[] names = (string[])Enum.GetNames(typeof(Gender));

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name );
            //}
        } // End Main()
    }

    public enum Gender
    {
        Unknown = 1,
        Male    = 2,
        Female  = 3
    }

    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }
}