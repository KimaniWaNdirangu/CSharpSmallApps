using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimePeriod
{
    public class TimePeriod
    {
        private double seconds;

        public double Hours
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 0 and 24.");
                }
                seconds = value * 3600;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            TimePeriod t = new TimePeriod();
            // The property assignment causes the 'set' accessor to be called.
            t.Hours = 29;

            // Retrieving the property causes the 'get' accessor to be called.
            Console.WriteLine($"Time in Seconds: {t.Hours}");
        }
    }
}
