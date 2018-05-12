// Chapter 2 - PRIMITIVE TYPES AND VARIABLES

using System;

class HelloCSharp
{
    public static void Main()
    {
        // Declare some variables
        byte centuries = 20;
        ushort years = 2000;
        uint days = 730480;
        ulong hours = 17531520;

        Console.WriteLine(centuries + " centuries are" + years +
            " years, or " + days + " days, or " + hours + " hours.");

        // Biggest Integer Type
        ulong maxIntValue = UInt64.MaxValue;
        Console.WriteLine(maxIntValue);

    }
}

// =============================================================================

using System;

class HelloCSharp
{
    public static void Main()
    {
        // float - Single Precision Real Type
        Console.WriteLine("Single Precision Real-Types");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Minimum Value : " + Single.MinValue);
        Console.WriteLine("Maximum Value : " + Single.MaxValue);
        Console.WriteLine("Positive Infinity : " + Single.PositiveInfinity);
        Console.WriteLine("Negative Infinity : " + Single.NegativeInfinity);
        Console.WriteLine("NaN : " + Single.NaN);
        Console.WriteLine(); // Blank Line for readablitiy

        // double - Double Precision Real Type
        Console.WriteLine("Double Precision Real-Types");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Minimum Value : " + Double.MinValue);
        Console.WriteLine("Maximum Value : " + Double.MaxValue);
        Console.WriteLine("Positive Infinity : " + Double.PositiveInfinity);
        Console.WriteLine("Negative Infinity : " + Double.NegativeInfinity);
        Console.WriteLine("NaN : " + Double.NaN);
        
        Console.WriteLine(); // Blank Line for readablitiy
        float floatPI = 3.14f;
        Console.WriteLine(floatPI);

        double doublePI = 3.14;
        Console.WriteLine(doublePI);

        double nan = Double.NaN;
        Console.WriteLine(nan);

        double infinity = Double.PositiveInfinity;
        Console.WriteLine(infinity);
    }
}

// =============================================================================
using System;

class HelloCSharp
{
    public static void Main()
    {
        char ch = 'a';
        Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);

        ch = 'b';
        Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);

        ch = 'A';
        Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
    }
}

// =============================================================================
using System;

class HelloCSharp
{
    public static void Main()
    {
        object container1 = 5;
        object container2 = "Five";

        Console.WriteLine("The value of container 1 is : " + container1);
        Console.WriteLine("The value of container 2 is : " + container2);
    }
}

//==============================================================================
// Implicit Type Conversion
using System;
namespace SvetlinNakov.FundamentalsOfComputerProgramming
{
    public class HelloCSharp
    {
        public static void Main()
        {
            int myInt = 5;
            Console.WriteLine(myInt);

            long myLong = myInt;
            Console.WriteLine(myLong);

            Console.WriteLine(myLong + myInt);
            
        }
    }
}

//==============================================================================
// Explicit Type Conversion
using System;
namespace SvetlinNakov.FundamentalsOfComputerProgramming
{
    public class HelloCSharp
    {
        public static void Main()
        {
            double myDouble = 5.1d;
            Console.WriteLine(myDouble);     // 5.1

            long myLong = (long)myDouble;
            Console.WriteLine(myLong);       // 5

            myDouble = 5e9d;                 // 5 * 10^9
            Console.WriteLine(myDouble);     // 5000000000

            int myInt = (int)myDouble;
            Console.WriteLine(myInt);        // -2147483648

            Console.WriteLine(int.MinValue); // -2147483648

            long myLong = long.MaxValue;

            int myInt = (int)myLong;

            Console.WriteLine(myLong); // 
            Console.WriteLine(myInt);  // -1

            float heightInMeters = 1.74f;
            double maxHeight = heightInMeters;
            double minHeight = (double)heightInMeters; // Explicit type conversion for readability only
            float actualHeight = (float)maxHeight;
            float maxHeightFloat = (float)maxHeight;

            double d = 5e9d;         // 5 * 10^ 9
            Console.WriteLine(d);    // 5000000000
            int i = checked((int)d); // System.OverflowException
            Console.WriteLine(i);
        }
    }
}

// =============================================================================
// Side Effects of Expressions
using System;
namespace SvetlinNakov.FundamentalsOfComputerProgramming
{
    public class HelloCSharp
    {
        public static void Main()
        {
            int a = 5;
            int b = ++a;

            Console.WriteLine("a = {0}", a); // 6
            Console.WriteLine("b = {0}", b); // 6

            double d = 1 / 2;
            Console.WriteLine(d);  // 0 not 0.5

            int num = 1;
            double denum = 0;                     // 0.0 (real number)
            int zeroInt = (int)denum;             // 0

            Console.WriteLine(num / denum);       // Infinity
            Console.WriteLine(denum / denum);     // NaN
            Console.WriteLine(zeroInt / zeroInt); // DivisionByZeroException
        }
    }
}