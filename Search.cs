using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] validValues = { 101, 108, 201, 213, 266, 304, 311, 409, 411, 412 };

        Console.Write("Enter an Order Nubmber : ");
        int orderNumber = int.Parse(Console.ReadLine());

        bool isItemInStock = false;

        isItemInStock = SearchItem(orderNumber, validValues);

        if (isItemInStock)
        {
            Console.WriteLine("The item is in stock.");
        }

        else
        {
            Console.WriteLine("The item is not in stock.");
        }
    }

    private static bool SearchItem(int orderNumber, int[] validValues)
    {
        for (int i = 0; i < validValues.Length; i++)
        {
            if (orderNumber == validValues[i])
            {
                return true; // Item is in stock
            }
        }
        return false; // Item not in stock
    }
}