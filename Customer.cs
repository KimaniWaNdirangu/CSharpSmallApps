using System;

public class Customer
{
    string firstName;
    string lastName;

    public Customer()
        : this("No First Name Provided", "No Last Name Provided")
    {

    }

    public Customer(string FirstName, string LastName)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("+-------  CUSTOMER DETAILS   --------+");
        Console.WriteLine("Full Name : {0}", this.firstName + " " + this.lastName);
    }

    ~Customer()
    {
        // Clean up code
    }
}

public class Program
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];

        for (int i = 0; i < customers.Length; i++)
        {
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine().ToUpper();

            Console.Write("Enter Last Name : ");
            string lastName = Console.ReadLine().ToUpper();

            customers[i] = new Customer(firstName, lastName);
            //customers[i].PrintFullName();

            Console.WriteLine("============================================");
        }

        foreach(Customer customer in customers)
        {
            customer.PrintFullName();
        }


            //        Employee[] employees = new Employee[4]; // Array of Employees

            //        employees[0] = new Employee();
            //        employees[1] = new PartTimeEmployee();
            //        employees[2] = new FullTimeEmployee();
            //        employees[3] = new TemporaryEmployee();

            //        foreach(Employee e in employees)
            //        {
            //            e.PrintFullName();
            //        }
        }
    }