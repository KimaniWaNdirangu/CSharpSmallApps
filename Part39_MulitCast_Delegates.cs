using System;

public delegate void SampelDelegate(out int intNum);

namespace IntroToCSharp
{
    // Multi-cast Delegates - out parameter
    public class Program
    {
        public static void Main()
        {
            SampelDelegate del = new SampelDelegate(SampleMethodOne);

            del += SampleMethodTwo;

            int delegateOutputParameterValue = -1;

            del(out delegateOutputParameterValue);

            Console.WriteLine("Delegate Returned Value = {0}", delegateOutputParameterValue);
        }

        public static void SampleMethodOne(out int number )
        {
            number = 1;
        }

        public static void SampleMethodTwo(out int number)
        {
            number = 2;
        }

    }
}