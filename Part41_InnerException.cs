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
                try
                {
                    Console.Write("Enter the first number : ");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the second number : ");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;

                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Sample Files\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);

                        sw.Write("Exception Name : ");
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.WriteLine("------------------------------------------------");
                        sw.WriteLine();
                        sw.Write("Error Message : ");
                        sw.Write(ex.Message);
                        sw.WriteLine();
                        sw.WriteLine("------------------------------------------------");
                        sw.Write("Stack Trace : ");
                        sw.Write(ex.StackTrace);
                        sw.WriteLine();
                        sw.WriteLine("------------------------------------------------");
                        sw.Close();

                        Console.WriteLine("There is a problem. Please try later.");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("Current Exception : {0}" , exception.GetType().Name);
                Console.WriteLine("Inner Exception : {0}", exception.InnerException.GetType().Name);

                //if (exception.InnerException != null)
                //{
                //    Console.WriteLine("Inner Exception : {0}", exception.InnerException.GetType().Name);
                //}
            }
        }
    }
}