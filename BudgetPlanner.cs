using System;

class HelloCSharp
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine("1. Monthly Budget Planner\n2. Daily Budget Planner");
        Console.Write("Select the bugget planner of your choice : ");

        int budgetPlannerChoice = int.Parse(Console.ReadLine());

        switch (budgetPlannerChoice)
        {
            case 1:
                MonthlyBudgetPlanner();
                break;
            case 2:
                DailyBudgetPlanner();
                break;
            default:
                Console.WriteLine("You must enter 1 or 2.Please try again.");
                break;
        }
    }

    private static void MonthlyBudgetPlanner()
    {
        Console.WriteLine("Monthly Budget Planner coming soon...");
    }

    private static void DailyBudgetPlanner()
    {
        int userChoice;
        do
        {
            Console.WriteLine("+---- DAILY BUDGET PLANNER ----+");

            Console.Write("Enter Transport To Work Amount (KES): ");
            decimal transportToWork = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Shoe Shine Amount (KES): ");
            decimal shoeshine = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Breakfast Amount (KES): ");
            decimal breakfast = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Lunch Amount (KES): ");
            decimal lunch = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Transport Back Home Amount (KES): ");
            decimal transportBackHome = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Supper Amount (KES): ");
            decimal supper = decimal.Parse(Console.ReadLine());

            decimal totalDailyAmount = transportToWork + shoeshine + breakfast + lunch + transportBackHome + supper;

            Console.WriteLine($"Your Daily Amount is KES:{totalDailyAmount}");

            Console.Write("Do you want to budget again [Yes - 1 or No - 0]? ");

            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();
        } while (userChoice == 1);
    }
}