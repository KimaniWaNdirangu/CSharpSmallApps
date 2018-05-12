using System;
using System.Collections.Generic;

namespace IntroToCSharp
{
    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            if (dictionaryCustomers.ContainsKey(135))
            {
                Customer cust = dictionaryCustomers[135];
            }

            //foreach(Customer customerValue in dictionaryCustomers.Values)
            //{
            //    Console.WriteLine(customerValue.ToString());
            //    //Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
            //    //Customer cust = customerKeyValuePair.Value;
            //    //Console.WriteLine("ID = {0}, Name = {1} and Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //    //Console.WriteLine("====================================================================");
            //}
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return "ID = " + this.ID + "| Name = " + this.Name + "| Salary = " + this.Salary;
        }
    }
}