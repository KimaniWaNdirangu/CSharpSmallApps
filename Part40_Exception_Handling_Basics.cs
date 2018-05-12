using System;
using System.IO;

namespace IntroToCSharp
{
    // Part 40 - Exception Handing Basics
    
    public class Program
    {
        public static void Main()
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"C:\Sample1 Files\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());

                streamReader.Close();
            }

            catch (FileNotFoundException ex)
            {
                // log the details to the DB or log file for later debugging
                Console.WriteLine("Please check if the file {0} exist.", ex.FileName);
                //Console.WriteLine(ex.Message);
                //Console.WriteLine("----------------------------------------------------------");
                //Console.WriteLine("File Name : {0}", ex.FileName);
                //Console.WriteLine("----------------------------------------------------------");
                //Console.WriteLine(ex.StackTrace);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}