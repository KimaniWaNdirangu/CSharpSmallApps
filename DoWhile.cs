using System;

namespace DoWhile
{
    public class DoWhile
    {
        static void Main()
        {
            Console.Write("Angle in radians : ");
            double angle = double.Parse(Console.ReadLine());

            int choice;

            do
            {
                MenuPrompt();
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("SIN RESULT");
                        break;
                    case 2:
                        Console.WriteLine("COS RESULT");
                        break;
                    case 3:
                        Console.WriteLine("TAN RESULT");
                        break;
                    case 0:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }
                Console.WriteLine(); // Blank line for readability
            } while (choice != 0);
        } // End Main() method

        private static void MenuPrompt()
        {
            Console.WriteLine("1. sin");
            Console.WriteLine("2. cos");
            Console.WriteLine("3. tan");
            Console.WriteLine("0. exit");
            Console.WriteLine("Your choice : ");
        }
    } 
}
