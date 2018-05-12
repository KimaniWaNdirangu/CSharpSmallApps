using System;
using System.Reflection;

namespace IntroToCSharp
{
    public class Program
    {
        private static void Main()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("IntroToCSharp.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Anzari";
            parameters[1] = "Technologies";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}", fullName);

            //Customer C1 = new Customer();
            //string fullName = C1.GetFullName("Pragim", "Tech");
            //Console.WriteLine("Full Name = {0}", fullName);
        } 
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}