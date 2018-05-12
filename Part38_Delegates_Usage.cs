using System;
using System.Collections.Generic;

namespace IntroToCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList, isPromotable);
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public delegate bool IsPromotable(Employee empl);

    class Employee
    {
        public int ID         { get; set; }
        public string Name    { get; set; }
        public int Salary     { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (isEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted.");
                }
            }
        }
    }
}