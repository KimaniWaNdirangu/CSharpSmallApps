using System;
using System.IO;

namespace IntroToCSharp
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Please enter the Numerator : ");
                int Numerator;

                bool isNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

                if (isNumeratorConversionSuccessful)
                {
                    Console.Write("Please enter the Denominator : ");
                    int Denominator;

                    bool isDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                    if (isDenominatorConversionSuccessful && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine("Result = {0}", Result);
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be zero.");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numerator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}