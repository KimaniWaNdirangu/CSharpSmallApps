//using System;

//namespace Pragim
//{
//    public class MainClass
//    {
//        public static void Main()
//        {
//            public int creditScore; //int     creditScore;
//            public decimal loanAmount;
//            public decimal interestRate;
//            public decimal interestAmount;
//            public decimal totalAmountPayable;

//            private const decimal LOW_INTEREST_RATE = 0.050M;
//            private const decimal MEDIUM_INTEREST_RATE = 0.075M;
//            private const decimal HIGH_INTEREST_RATE = 0.10M;
//            private const int REPAYMENT_PERIOD = 30;

//            public string output;

//            Console.WriteLine("M-WEZA PERSONAL LOANS : LOAN APPRAISAL SYSTEM");
//            Console.WriteLine("---------------------------------------------");

//            Console.Write("Enter the Loan Amount : ");
//            loanAmount = Convert.ToDecimal(Console.ReadLine());

//            Console.Write("Enter the Credit Score : ");
//                    creditScore = Convert.ToInt32(Console.ReadLine());

//                    Console.WriteLine(); // Display a blank line for readability

//                    if (creditScore < 600)
//                    {
//                        interestRate = HIGH_INTEREST_RATE;
//                    }
//                    else if(creditScore > 700)
//                    {
//                        interestRate = LOW_INTEREST_RATE;
//                    }
//                    else
//                    {
//                        interestRate = MEDIUM_INTEREST_RATE; // Between 600 and 700
//                    }

//                    interestAmount     = loanAmount* interestRate;
//                    totalAmountPayable = loanAmount + interestAmount;

//                    output = "Loan Amount             : KES {0:N2}  \n"  +
//                             "Credit Score            :     {1}     \n"  +
//                             "Interest Rate           :     {2:N3}% \n"  +
//                             "Interest Amount         : KES {3:N2}  \n"  +
//                             "Total Amount Payable    : KES {4:N2}  \n"  +
//                             "Repayment Period        :     {5} Days";

//                    Console.WriteLine("--------------RESULTS-------------------");
//                    Console.WriteLine(output, loanAmount, creditScore, interestRate,
//                                      interestAmount, totalAmountPayable, REPAYMENT_PERIOD);
//                    Console.WriteLine("---------------------------------------");
//                    Console.WriteLine("-------- ONE STEP SOLUTIONS -----------");
//        }
//    }
//}



#region Part 60 - StringBuilder vs System.String
//using System;
//using System.Text;

//namespace Pragim
//{
//    public class MainClass
//    {
//        private static int Main(string[] args)
//        {

//            //Console.WriteLine(DateTime.Now);

//            //string collector = "Numbers : ";

//            //for(int index = 1; index <= 200000; index++)
//            //{
//            //    collector += index;
//            //}

//            //Console.WriteLine(collector.Substring(0, 1024));
//            //Console.WriteLine(DateTime.Now);

//            //string userString = string.Empty;
//            //for(int i = 1; i <= 10000; i++)
//            //{
//            //    userString += i.ToString() + " ";
//            //}
//            //Console.WriteLine(userString);

//            //string userString = "C#";
//            //userString += " Video";
//            //userString += " Tutorial";
//            //userString += " for";
//            //userString += " Beginners";
//            //Console.WriteLine(userString);

//            //StringBuilder userString = new StringBuilder("C#");
//            //userString.Append(" Video");
//            //userString.Append(" Tutorial");
//            //userString.Append(" for");
//            //userString.Append(" Beginners");
//            //Console.WriteLine(userString.ToString());
//            return 1;
//        }
//    }
//}
#endregion
#region Part 59 - Differences Convert.ToString() and ToString()
//using System;

//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main(string[] args)
//        {
//            Customer C1 = null;
//            string str = C1.ToString();
//            Console.WriteLine(str);
//        }
//    }

//    public class Customer
//    {
//        public string Name { get; set; }
//    }
//}
#endregion
#region Part 58 - Override Equals() Method
//using System;

//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            //int i = 10;
//            //int j = 10;
//            //Console.WriteLine(i == j);
//            //Console.WriteLine(i.Equals(j));

//            //Direction direction1 = Direction.East;
//            //Direction direction2 = Direction.West;

//            //Console.WriteLine(direction1 == direction2);
//            //Console.WriteLine(direction1.Equals(direction2));

//            Customer C1  = new Customer();
//            C1.FirstName = "Simon";
//            C1.LastName  = "Tan";

//            Customer C2  = new Customer();
//            C2.FirstName = "Simon";
//            C2.LastName  = "Tan";

//            Console.WriteLine(C1 == C2);      //  Reference Equality - False
//            Console.WriteLine(C1.Equals(C2)); // Value Equality      - Should return True
//        }
//    }

//    public class Customer
//    {
//        public string FirstName { get; set; }
//        public string LastName  { get; set; }

//        public override bool Equals(object obj)
//        {
//            if(obj == null)
//            {
//                return false;
//            }

//            if(!(obj is Customer))
//            {
//                return false;
//            }

//            return this.FirstName == ((Customer)obj).FirstName &&
//                   this.LastName  == ((Customer)obj).LastName;
//        }

//        public override int GetHashCode()
//        {
//            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
//        }
//    }

//    //public enum Direction
//    //{
//    //    East  = 1,
//    //    West  = 2,
//    //    North = 3,
//    //    South = 4
//    //}
//}
#endregion
#region Part 57 - Override ToString() Method
//using System;

//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            int number = 10;
//            Console.WriteLine(number.ToString());

//            Customer C1 = new Customer();

//            C1.FirstName = "Simon";
//            C1.LastName  = "Tan";

//            //Console.WriteLine(C1.ToString());
//            Console.WriteLine(Convert.ToString(C1));
//        }
//    }

//    public class Customer
//    {
//        public string FirstName { get; set; }
//        public string LastName  { get; set; }

//        public override string ToString()
//        {
//            return this.LastName + ", " + this.FirstName;
//        }
//    }
//}
#endregion
#region Part 56 - Generics
//using System;
//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            bool Equal = Calculator<int>.AreEqual(10, 10);

//            if(Equal)
//            {
//                Console.WriteLine("Equal");
//            }
//            else
//            {
//                Console.WriteLine("Not Equal");
//            }
//        }
//    }

//    public class Calculator<T>
//    {
//        public static bool AreEqual(T Value1, T Value2)
//        {
//            return Value1.Equals(Value2);
//        }
//    }
//}
#endregion
#region Part 55 - Late Binding Example
//using System;
//using System.Reflection;

//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            Assembly executingAssembly = Assembly.GetExecutingAssembly();

//            Type customerType = executingAssembly.GetType("Pragim.Customer");

//            object customerInstance = Activator.CreateInstance(customerType);

//            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

//            string[] parameters = new string[2];
//            parameters[0] = "Pragim";
//            parameters[1] = "Technologies";

//            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

//            Console.WriteLine("Full Name : {0} ", fullName);

//            //Customer C1 = new Customer();
//            //string fullName = C1.GetFullName("Pragim", "Tech");
//            //Console.WriteLine("Full Name : {0} ", fullName);
//        }
//    }

//    public class Customer
//    {
//        public string GetFullName(string FirstName, string LastName)
//        {
//            return FirstName + " " + LastName;
//        }
//    }
//}
#endregion
#region Part 53 - Reflections
//using System;
//using System.Reflection;

//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            //Type T = Type.GetType("Pragim.Customer");
//            //Type T = typeof(Customer);

//            Customer c1 = new Customer();
//            Type T = c1.GetType();

//            Console.WriteLine("Full Name          : {0}", T.FullName);
//            Console.WriteLine("Just the Name      : {0}", T.Name);
//            Console.WriteLine("Just the Namespace : {0}", T.Namespace);

//            Console.WriteLine();

//            Console.WriteLine("Properties in Customer Class");
//            Console.WriteLine("----------------------------");
//            PropertyInfo[] properties = T.GetProperties();

//            foreach(PropertyInfo property in properties)
//            {
//                Console.WriteLine("Property Data Type : {0}\n" +
//                                  "Property Name      : {1}", property.PropertyType.Name, property.Name);
//                Console.WriteLine("=================================");
//            }


//            Console.WriteLine("Methods in Customer Class");
//            Console.WriteLine("---------------------------");

//            MethodInfo[] methods = T.GetMethods();

//            foreach (MethodInfo method in methods)
//            {
//                Console.WriteLine("Method Return Type : {0}\n" +
//                                  "Method Name        : {1}", method.ReturnType.Name, method.Name);
//                Console.WriteLine("=================================");
//            }

//            Console.WriteLine("Constructors in Customer Class");
//            Console.WriteLine("------------------------------");

//            ConstructorInfo[] constructors = T.GetConstructors();

//            foreach (ConstructorInfo constructor in constructors)
//            {
//                Console.WriteLine("Constructor Parameters      : {0}", constructor.ToString());
//                Console.WriteLine("=============================================");
//            }
//        }
//    }

//    public class Customer
//    {
//        #region Properties
//        public int id { get; set; }
//        public string name { get; set; }
//        #endregion

//        #region Constructors
//        public Customer(int Id, string Name)
//        {
//            this.id = Id;
//            this.name = Name;
//        }

//        public Customer()
//        {
//            this.id = -1;
//            this.name = string.Empty;
//        }
//        #endregion

//        #region Public Methods
//        public void PrintID()
//        {
//            Console.WriteLine("ID = {0}", this.id);
//        }

//        public void PrintName()
//        {
//            Console.WriteLine("Name = {0}", this.name);
//        }
//    #endregion
//    }
//}
#endregion
#region Part 52 - Attributes
//using System;
//using System.Collections.Generic;

//public class Program
//{
//    private static void Main()
//    {
//        Calculator.Add(new List<int>() { 10, 20, 40 });
//    }
//}

//public class Calculator
//{
//    [ObsoleteAttribute("Use Add(List<int> numbers) method", true)]
//    public static int Add(int firstNumber, int secondNumber)
//    {
//        return firstNumber + secondNumber;
//    } 

//    public static int Add(List<int> numbers)
//    {
//        int sum = 0;
//        foreach (int number in numbers)
//        {
//            sum = sum + number;
//        }
//        return sum;
//    }
//}
#endregion
#region Part 49 - Pubic, Private & Protected Access Modifiers
//using System;

//public class Customer
//{
//    protected int Id;
//}

//public class CorporateCustomer : Customer
//{
//    public void PrintId()
//    {
//        CorporateCustomer CC = new CorporateCustomer();
//        CC.Id = 101;
//    }
//}

//public class MainClass
//{
//    private static void Main()
//    {
//        Customer C1 = new Customer();
//        Console.WriteLine(C1.Id);
//    }
//}
#endregion
#region Part 43 & 44 - Exception Handling Abuse Example
//using System;

//public class ExceptionHandlingAbuse
//{
//    public static void Main()
//    {
//        try
//        {
//            Console.Write("Please enter the Numerator   : ");
//            int numerator;
//            bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);

//            if (IsNumeratorConversionSuccessful)
//            {
//                Console.Write("Please enter the Denominator : ");
//                int denominator;
//                bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out denominator);

//                if (IsDenominatorConversionSuccessful && denominator != 0)
//                {
//                    int result = numerator / denominator;
//                    Console.WriteLine("Result = {0}", result);
//                }
//                else
//                {
//                    if (denominator == 0)
//                    {
//                        Console.WriteLine("Denominator cannot be zero");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Denominator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine("Numerator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
//            }
//        }
//        catch(Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}
#endregion
#region Part 42 - Custom Exceptions
//using System;
//using System.IO;
//using System.Runtime.Serialization;

//public class CustomExceptionsDemo
//{
//    public static void Main()
//    {
//        try
//        {
//            throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
//        }
//        catch(UserAlreadyLoggedInException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}

//[Serializable]
//public class UserAlreadyLoggedInException : Exception
//{
//    public UserAlreadyLoggedInException()
//        : base()
//    {

//    }

//    public UserAlreadyLoggedInException(string message)
//        : base(message)
//    {

//    }

//    public UserAlreadyLoggedInException(string message, Exception innerException)
//        : base(message, innerException)
//    {

//    }

//    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
//        : base(info, context)
//    {

//    }
//}
#endregion
#region Part 41 - Inner Exception
//using System;
//using System.IO;

//// Inner Exception
//public class Program
//{
//    public static void Main()
//    {
//        try
//        {
//            try
//            {
//                Console.Write("Enter the first number : ");
//                int FN = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter the second number : ");
//                int SN = Convert.ToInt32(Console.ReadLine());

//                int Result = FN / SN;

//                Console.WriteLine("Result = {0}", Result);
//            }
//            catch (Exception ex)
//            {
//                string filePath = @"C:\Sample Files\Log.txt";

//                if (File.Exists(filePath))
//                {
//                    StreamWriter sw = new StreamWriter(filePath);
//                    sw.Write(ex.GetType().Name);
//                    sw.WriteLine();
//                    sw.Write(ex.Message);
//                    sw.Close();
//                    Console.WriteLine("There is a problem, please try later.");
//                }
//                else
//                {
//                    throw new FileNotFoundException(filePath + " is not present", ex);
//                }
//            }
//        }
//        catch(Exception exception)
//        {
//            Console.WriteLine("Current Exception : {0} ", exception.GetType().Name);

//            if (exception.InnerException != null)
//            {
//                Console.WriteLine("Inner Exception   : {0}", exception.InnerException.GetType().Name);
//            }
//        }
//    }
//}
#endregion
#region Part 40 - Exception Handling
//using System;
//using System.IO;

//public class Program
//{
//    public static void Main()
//    {
//        StreamReader streamReader = null;

//        try
//        {
//            streamReader = new StreamReader(@"C:\Sample Files\Data1.txt");
//            Console.WriteLine(streamReader.ReadToEnd());
//        }
//        catch (FileNotFoundException ex)
//        {

//            Console.WriteLine("Please check if the file path \"{0}\" is correct or whether the file exists.", ex.FileName);
//            //Console.WriteLine();
//            //Console.WriteLine();

//            //Console.WriteLine(ex.StackTrace);
//            //StreamWriter streamWriter = new StreamWriter(@"C:\Sample Files\Log.txt");
//            //streamWriter.WriteLine(ex.StackTrace);
//            //streamWriter.WriteLine("----------------------------------------------");
//            //streamWriter.WriteLine("FilePath : {0}", ex.FileName);
//            //streamWriter.WriteLine("===================================================================================================================");
//            //streamWriter.Close();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//        finally
//        {
//            if (streamReader != null)
//            {
//                streamReader.Close();
//            }
//            Console.WriteLine("Finally Block Invoked");
//        }
//    }
//}
#endregion
#region Part 39 - Multicast Delegates
//using System;

//public delegate void SampleDelegate();

//public delegate int SampleDelegate();

//public delegate void SampleDelegate(out int Integer); 

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        SampleDelegate del = new SampleDelegate(SampleMethodOne);
//        del += SampleMethodTwo;

//        //int DelegateReturnedValue = del();

//        int DelegatOutputParameterValue = -1;

//        del(out DelegatOutputParameterValue);

//        Console.WriteLine("DelegatOutputParameterValue = {0}", DelegatOutputParameterValue);

//del += SampleMethodTwo;
//del += SampleMethodThree;
//del -= SampleMethodOne;

//SampleDelegate del1, del2, del3, del4;

//del1 = new SampleDelegate(SampleMethodOne);
//del2 = new SampleDelegate(SampleMethodTwo);
//del3 = new SampleDelegate(SampleMethodThree);
//del4 = del1 + del2 + del3 - del2;
//del4(); // del4 is a multi-cast delegate
//}


//public static void SampleMethodOne(out int Number)
//{
//    Number = 1;
//}

//public static void SampleMethodTwo(out int Number)
//{
//    Number = 2;
//}

//public static int SampleMethodOne()
//{
//    return 1;
//}

//public static int SampleMethodTwo()
//{
//    return 2;
//}
//public static void SampleMethodOne()
//{
//    Console.WriteLine("SampleMethodOne Invoked");
//}
//public static void SampleMethodTwo()
//{
//    Console.WriteLine("SampleMethodTwo Invoked");
//}
//public static void SampleMethodThree()
//{
//    Console.WriteLine("SampleMethodThree Invoked");
//}
//}
#endregion
#region Part 38 - Delegates Usage in C# Continued
//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();

//        empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
//        empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
//        empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
//        empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

//        //IsPromotable isPromotable = new IsPromotable(Promote);

//        //Employee.PromoteEmployee(empList, isPromotable);
//        Employee.PromoteEmployee(empList, emp => emp.Salary >= 4000);

//    }

//    //public static bool Promote(Employee emp)
//    //{
//    //    if (emp.Experience >= 5)
//    //    {
//    //        return true;
//    //    }
//    //    else
//    //    {
//    //        return false;
//    //    }
//    //}
//}

//delegate bool IsPromotable(Employee empl);

//class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }

//    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
//    {
//        foreach (Employee employee in employeeList)
//        {
//            if (IsEligibleToPromote(employee))
//            {
//                Console.WriteLine(employee.Name + " : Eligible For Promotion");
//            }
//        }
//    }
//}
#endregion
#region Part 37 - Delegates Usage in C# - 1
//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();

//        empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
//        empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
//        empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
//        empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

//        Employee.PromoteEmployee(empList);
//    }
//}

//class Employee
//{
//    public int    ID         { get; set; }
//    public string Name       { get; set; }
//    public int    Salary     { get; set; }
//    public int    Experience { get; set; }

//    public static void PromoteEmployee(List<Employee> employeeList)
//    {
//        foreach (Employee employee in employeeList)
//        {
//            if(employee.Experience >= 5)
//            {
//                Console.WriteLine(employee.Name + "promoted");
//            }
//        }
//    }
//}
#endregion
#region Part 36 - Delegates in C#
//using System;

//public delegate void HelloFunctionDelegate(string Message);

//public class Program
//{
//    public static void Main()
//    {
//        // A delegate is a type-safe function pointer

//        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
//        del("Hello from delegate");
//    }

//    public static void Hello(string strMessage)
//    {
//        Console.WriteLine(strMessage);
//    }
//}
#endregion
#region Part 34 - Multiple Class Inheritance
//using System;

//class A
//{
//    public virtual void Print()
//    {
//        Console.WriteLine("Base Class Implementation");
//    }
//}

//class B : A
//{
//    public override void Print()
//    {
//        Console.WriteLine("A implementation from B");
//    }
//}

//class C : A
//{

//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Multiple Inheritance - Not Alowed in C#


//    }
//}
#endregion
#region Part 33 - Differences Between Abstract Classes & Interfaces
//public abstract class Customer
//{
//    // Abstract classes cannot be sealed
//    // Abstract class methods can be implemented [optional]
//    // Abstract class can have fields
//    // Abstract class can inherit from anothre abstract class and from an interface
//    // Abstract class can have access modifiers

//    public void Print()
//    {
//        Console.WriteLine("Abstract Class - Print Method");
//    }
//}

//interface ICustomer
//{
//    // Interface cannot have access modifier - They are public by default since they expose an API to the public
//    // Interface Methods cannot have access modifiers - They are public by default
//    // Interface cannot contain fields
//    // Interface can inherit from another interface only and cannot inherit from an abstract class

//    void Print();
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {

//    }
//}
#endregion
#region Part 32 - Abstract Classes

//public abstract class Customer
//{
//    //public abstract void Print();
//    public void Print()
//    {
//        Console.WriteLine("Print");
//    }
//}

//public class Program : Customer
//{
//    //public override void Print()
//    //{
//    //    Console.WriteLine("Print Method");
//    //}
//    public static void Main(string[] args)
//    {
//        //Program P = new Program();
//        //P.Print();

//        //Customer C = new Program();
//        //C.Print();
//    }
//}
#endregion
#region Part 31 - Explicit Interface Implementation

//interface I1
//{
//    void InterfaceMethod();
//}

//interface I2
//{
//    void InterfaceMethod();
//}

//public class Program : I1, I2
//{
//    void I1.InterfaceMethod()
//    {
//        Console.WriteLine("I1 Interface Method");
//    }

//    void I2.InterfaceMethod()
//    {
//        Console.WriteLine("I2 Interface Method");
//    }
//    public static void Main()
//    {
//        //Program P = new Program();
//        ////P.InterfaceMethod();
//        //((I1)P).InterfaceMethod();
//        //((I2)P).InterfaceMethod();

//        I1 i1 = new Program();
//        I2 i2 = new Program();
//        i1.InterfaceMethod();
//        i2.InterfaceMethod();
//    }
//}
#endregion
#region Part 30 - Interfaces
//interface ICustomer1
//{
//    void Print1(); // Public by default
//}

//interface ICustomer2 : ICustomer1
//{
//    void Print2();
//}
//public class Customer : ICustomer2
//{
//    public void Print1()
//    {
//        Console.WriteLine("Print1");
//    }

//    public void Print2()
//    {
//        Console.WriteLine("Print2");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        ICustomer2 customer = new Customer();
//        customer.Print1();
//    }
//}
#endregion
#region Part 29 - Structures
//public struct Customer
//{
//    private int id;
//    private string name;

//    public int Id
//    {
//        get { return this.Id; }
//        set { this.id = value; }
//    }

//    public string Name { get => name; set => name = value; }

//    //public string Name
//    //{
//    //    get { return this.Name; }
//    //    set { this.Name = value; }
//    //}



//    public Customer(int Id, string Name)
//    {
//        this.id = Id;
//        this.name = Name;
//    }

//    public void PrintDetails()
//    {
//        Console.WriteLine("Id= {0} && Name = {1}", this.id, this.name);
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        //Customer C1 = new Customer(101, "Mark");
//        //C1.PrintDetails();

//        //Customer C2 = new Customer();
//        //C2.Id = 102;
//        //C2.Name = "John";
//        //C2.PrintDetails();

//        //Customer C3 = new Customer
//        //{
//        //    Id = 103,
//        //    Name = "Rob"
//        //};
//        //C3.PrintDetails();

//        Customer C1 = new Customer();
//        C1.Name = "Mark";

//        Customer C2 = C1;

//        C2.Name = "Mary";

//        Console.WriteLine("C1.Name = {0} && C2.Name = {1}", C1.Name, C2.Name);
//    }
//}
#endregion
#region Part 27 - C# Properties
//using System;

//public class Student
//{
//    // Private Fields
//    private int id;
//    private string name;
//    private int passMark = 35;

//    // Auto-Implemented Properties
//    public string City { get; set; }
//    public string EmailAddress { get; set; }

//    // Read-Write Property - Id
//    public int Id
//    {
//        set
//        {
//            if (value <= 0)
//            {
//                throw new Exception("Student ID cannot be negative.");
//            }
//            this.id = value;
//        }
//        get
//        {
//            return this.id;
//        }
//    }

//    // Read-Write Property - Name
//    public string Name
//    {
//        set
//        {
//            if (string.IsNullOrEmpty(value))
//            {
//                throw new Exception("Student name cannot be null or empty.");
//            }
//            this.name = value;
//        }
//        get
//        {
//            return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
//        }
//    }

//    // Read-Only Property - PassMark
//    public int PassMark
//    {    
//        get
//        {
//            return this.passMark;
//        }
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        Student C1 = new Student();
//        C1.Id = 101;
//        C1.Name = "Mark";

//        Console.WriteLine("Student ID = {0}", C1.Id);
//        Console.WriteLine("Student Name = {0}", C1.Name);
//        Console.WriteLine("PassMark = {0}", C1.PassMark);
//    }
//}

// ================================================================================================

//using System;


//public class Example
//{
//    DayOfWeek day;

//    public DayOfWeek Day
//    {
//        get
//        {
//            if (this.day == DayOfWeek.Friday)
//            {
//                throw new Exception("Invalid Access");
//            }
//            return this.day;
//        }
//        set
//        {
//            this.day = value;
//        }
//    }

//}
//public class Program
//{
//    public static void Main()
//    {
//        Example example = new Example();
//        example.Day = DayOfWeek.Monday; // set
//        Console.WriteLine(example.Day == DayOfWeek.Monday); // get
//    }
//}

#endregion
#region Part 26 - Why Properties in C#
//public class Student
//{
//    private int id;
//    private string name;
//    private int passMark = 35;

//    public void SetId(int Id)
//    {
//        if(Id <= 0)
//        {
//            throw new Exception("Student ID cannot be negative.");
//        }
//        this.id = Id;
//    }

//    public int GetId()
//    {
//        return this.id;
//    }

//    public void SetName(string Name)
//    {
//        if (string.IsNullOrEmpty(Name))
//        {
//            throw new Exception("Student name cannot be null or empty.");
//        }
//        this.name = Name;
//    }

//    public string GetName()
//    {
//        return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
//    }

//    public int GetPassMark()
//    {
//        return this.passMark;
//    }

//}
//class Program
//{
//    public static void Main()
//    {
//        Student C1 = new Student();
//        C1.SetId(101);
//        C1.SetName("Mark");

//        Console.WriteLine("Student ID = {0}", C1.GetId());
//        Console.WriteLine("Student Name = {0}", C1.GetName());
//        Console.WriteLine("PassMark = {0}", C1.GetPassMark());
//        //Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}",
//        //                  C1.ID, C1.Name, C1.PassMark);
//    }
//}
#endregion
#region Part 25 - Method Overloading
/*
 Method Overloading
 ------------------
 Methods have SAME NAME but DIFFERENT SIGNATURE
     Number of parameters
     Data type of parameters
     Kind of parameters - value, reference and output
     Sequence/Order of parameters
     !!! DOESN'T INCLUDE RETURN TYPE AND params KEYWORD
*/
//public static void Main()
//{
//    Add(3.05f, 2);
//    Add(2, 3.05f);
//}

//public static void Add(float FN, int SN)
//{
//    Console.WriteLine("Add(float, int) : Sum = {0}", FN + SN);
//}

//public static void Add(int FN, float SN)
//{
//    Console.WriteLine("Add(int, float) Sum = {0}", FN + SN);
//}

//public static void Add(int FN, int SN, int TN)
//{
//    Console.WriteLine("Sum = {0}", FN + SN + TN);
//}

//public static void Add(int FN, int SN, params int[] TN)
//{
//    Console.WriteLine("Sum = {0}", FN + SN);
//}

//public static void Add(int FN, int SN, int[] TN)
//{
//    Console.WriteLine("Sum = {0}", FN + SN);
//}

//public static int Add(int FN, int SN, int TN)
//{
//    Console.WriteLine("Sum = {0}", FN + SN + TN);
//    return FN + SN + TN;
//}

//public static void Add(int FN, int SN, out int Sum)
//{
//    Console.WriteLine("Sum = {0}", FN + SN);
//    Sum = FN + SN;
//}

/*
public static void Add(int FN, int SN)
{
    Console.WriteLine("Sum = {0}", FN + SN);
}

public static void Add(float FN, float SN)
{
    Console.WriteLine("Sum = {0}", FN + SN);
}

public static void Add(int FN, float SN)
{
    Console.WriteLine("Sum = {0}", FN + SN);
}
*/
#endregion
#region Part 23 - Polymorphism

//public class Employee
//{
//    public string FirstName;
//    public string LastName;

//    public void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName);
//    }
//}

//public virtual void PrintFullName()
//{
//    Console.WriteLine(FirstName + " " + LastName);
//}

//public class PartTimeEmployee : Employee
//{
//    public override void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName + " - Part Time Employee");
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    public override void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName + " - Full Time Employee");
//    }
//}

//public class TemporaryEmployee : Employee
//{
//    public override void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName + " - Temporary Employee");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Employee[] employees = new Employee[4]; // Array of Employees

//        employees[0] = new Employee();
//        employees[1] = new PartTimeEmployee();
//        employees[2] = new FullTimeEmployee();
//        employees[3] = new TemporaryEmployee();

//        foreach(Employee e in employees)
//        {
//            e.PrintFullName();
//        }
//    }
//}
#endregion
#region Part 22 - Method Hiding
//public class Employee
//{
//    public string FirstName;
//    public string LastName;

//    public void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName);
//    }
//}

//public class FullTimeEmployee : Employee
//{

//}

//public class PartTimeEmployee : Employee
//{
//    public new void PrintFullName()
//    {
//        //base.PrintFullName();
//        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        FullTimeEmployee FTE = new FullTimeEmployee();
//        FTE.FirstName = "Full Time";
//        FTE.LastName = "Employee";
//        FTE.PrintFullName();

//        PartTimeEmployee PTE = new PartTimeEmployee();
//        Employee PTE = new PartTimeEmployee();
//        PartTimeEmployee PTE = new Employee();
//        PTE.FirstName = "Part Time";
//        PTE.LastName = "Employee";
//        //((Employee)PTE).PrintFullName();
//        PTE.PrintFullName();
//    }
//}
#endregion
#region Part 21 - Inheritance
//public class ParentClass
//{
//    public ParentClass()
//    {
//        Console.WriteLine("ParentClass Constructor Called");
//    }

//    public ParentClass(string Message)
//    {
//        Console.WriteLine(Message);
//    }
//}

//public class ChildClass : ParentClass
//{
//    public ChildClass()
//        : base("Derived Class Controlling Parent Class")
//    {
//        Console.WriteLine("ChildClass Constructor Called");
//    }
//}

//public class Employee
//{
//    public string FirstName;
//    public string LastName;
//    public string Email;

//    public void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName);
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    public float YearlySalary;
//}

//public class PartTimeEmployee : Employee
//{
//    public float HourlyRate;
//}

//class Program
//{
//    public static void Main()
//    {
//        ChildClass CC = new ChildClass();

//        //FullTimeEmployee FTE = new FullTimeEmployee();
//        //FTE.FirstName = "Pragim";
//        //FTE.LastName = "Tech";
//        //FTE.YearlySalary = 500000;
//        //FTE.PrintFullName();

//        //PartTimeEmployee PTE = new PartTimeEmployee();
//        //PTE.FirstName = "Part";
//        //PTE.LastName = "Time";
//        //PTE.PrintFullName();

//    }
//}

#endregion
#region Part 20 - Static and Instance Members
//class Circle
//{
//    static float _PI;
//    int _Radius;

//    static Circle()
//    {
//        Console.WriteLine("Static Constructor Called");
//        Circle._PI = 3.141F;
//    }

//    public Circle(int Radius)
//    {
//        Console.WriteLine("Instance Constructor Called");
//        this._Radius = Radius;
//    }

//    public float CalculateArea()
//    {
//        return Circle._PI * this._Radius * this._Radius;
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        //Console.WriteLine(Circle._PI);
//        Circle C1 = new Circle(5);
//        float Area1 = C1.CalculateArea();

//        Console.WriteLine("Area = {0}", Area1);

//        Circle C2 = new Circle(6);
//        float Area2 = C2.CalculateArea();

//        Console.WriteLine("Area = {0}", Area2);
//    }
//}
#endregion
#region Part 19 - Introduction To Classes
//class Customer
//{
//    string _firstName;
//    string _lastName;

//    public Customer()
//        : this("No First Name Provided", "No Last Name Provided")
//    {

//    }

//    public Customer(string FirstName, string LastName)
//    {
//        this._firstName = FirstName;
//        this._lastName = LastName;
//    }

//    public void PrintFullName()
//    {
//        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
//    }

//    ~Customer()
//    {
//        // Clean up code
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        Customer C1 = new Customer();
//        C1.PrintFullName();

//        Customer C2 = new Customer("P", "T");
//        C2.PrintFullName();
//    }
//}
#endregion
#region Coffee Program - do ... while
//int TotalCoffeeCost = 0;

//string UserDecision = string.Empty;
//do
//{
//    int UserChoice = 0;
//    do
//    {
//        Console.WriteLine("Please select your coffee size : 1 - Small, 2 - Medium, 3 - Large");
//        UserChoice = int.Parse(Console.ReadLine());

//        switch (UserChoice)
//        {
//            case 1:
//                TotalCoffeeCost += 1;
//                break;
//            case 2:
//                TotalCoffeeCost += 2;
//                break;
//            case 3:
//                TotalCoffeeCost += 3;
//                break;
//            default:
//                Console.WriteLine("Your choice {0} is invalid.", UserChoice);
//                break;
//        }
//    } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);

//    do
//    {
//        Console.WriteLine("Do you want to buy another coffee - Yes or No?");
//        UserDecision = Console.ReadLine();

//        switch (UserDecision.ToUpper())
//        {
//            case "YES":
//                break;
//            case "NO":
//                break;
//            default:
//                Console.WriteLine("Your choice {0} is invalid. Please try again.", UserDecision);
//                break;
//        }
//    } while (UserDecision != "YES" && UserDecision != "NO");
//} while (UserDecision == "YES");

//Console.WriteLine("Thank you for shopping with us");
//Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
#endregion
#region Part 17 - Method Parameters
//using System;
// Method Parameters
/*
 * Value Parameters
 * Reference Parameters
 * Out Parameters
 * Parameter Arrays
 */

// Method Parameters and Method Arguments

//public class Program
//{
//    public static void Main()
//    {
//        int[] numbers = new int[3];

//        numbers[0] = 101;
//        numbers[1] = 102;
//        numbers[2] = 103;

//        //ParamsMethod();
//        //ParamsMethod(Numbers);
//        ParamsMethod(1, 2, 3, 4, 5); // Arguments
//    }

//    public static void ParamsMethod(params int[] numbers)
//    {
//        Console.WriteLine("There are {0} elements", numbers.Length);

//        foreach(int number in numbers)
//        {
//            Console.WriteLine(number);
//        }
//    }
//public static void Main()
//{
//    int Sum = 0;
//    int Product = 0;
//    Calculate(10, 20, out Sum, out Product);

//    Console.WriteLine("Sum = {0} and Product = {1}", Sum, Product);

//    int i = 0;

//    SimpleMethod(ref i);

//    Console.WriteLine(i);
//}

//public static void Calculate(int FN, int SN, out int Sum, out int Product)
//{
//    Sum     = FN + SN;
//    Product = FN * SN;
//}

//public static void SimpleMethod(ref int j)
//{
//    j = 101;
//}
//}
#endregion
#region Part 16 - Methods
//public static void Main()
//{
//    //Program p = new Program();
//    //p.EvenNumbers();

//    Program.EvenNumbers(30);

//    Program p = new Program();
//    int Sum = p.Add(10, 20);

//    Console.WriteLine("Sum = {0}", Sum);
//}

//public int Add(int FN, int SN)
//{
//    return FN + SN;
//}

//public static void EvenNumbers(int Target)
//{
//    int Start = 0;

//    while (Start <= Target)
//    {
//        Console.WriteLine(Start);
//        Start = Start + 2;
//    }
//}
#endregion
#region Part 15 - for and foreach loop

//for (int i = 0; i <= 20; i++)
//{
//    Console.WriteLine(i);
//    if(i == 10)
//    {
//        break; // Control gets out of the for loop - the rest of the for loop will not be executed
//    }
//}

//for (int i = 0; i <= 20; i++)
//{
//    if (i % 2 == 1)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

// Iterate array with while loop
//int[] Numbers = new int[4];

//Numbers[0] = 101;
//Numbers[1] = 102;
//Numbers[2] = 103;
//Numbers[3] = 104;

//int i = 0; // Initialization
//while(i < Numbers.Length) // Condition Check
//{
//    Console.WriteLine(Numbers[i]);
//    i++; // Increment
//}

// Iterate array with for loop
//for (int j = 0; j < Numbers.Length; j++)
//{
//    Console.WriteLine(Numbers[j]);
//}

// Iterate array with foreach loop
//foreach (int k in Numbers)
//{
//    Console.WriteLine(k);
//}
#endregion
#region Part 14 - do...while loop : Coffee Shop System
// decimal TotalCoffeeCost = 0.00M;
//             string userDecision = string.Empty;

//             do
//             {
//                 Console.WriteLine("Please select your Coffee Size");
//                 Console.WriteLine("1 - Small\n2 - Medium\n3 - Large");

//                 int userChoice = int.Parse(Console.ReadLine());

//                 switch (userChoice)
//                 {
//                     case 1:
//                         TotalCoffeeCost += 100.00M;
//                         break;
//                     case 2:
//                         TotalCoffeeCost += 200.00M;
//                         break;
//                     case 3:
//                         TotalCoffeeCost += 300.00M;
//                         break;
//                     default:
//                         Console.WriteLine("Your choice {0} is invalid.", userChoice);
//                         break;
//                 }           

//                 do
//                 {
//                     Console.WriteLine("Do you want to buy another coffee - Yes or No?");
//                     userDecision = Console.ReadLine().ToUpper();

//                     if (userDecision != "YES" && userDecision != "NO")
//                     {
//                         Console.WriteLine("Invalid Choice, please enter YES or NO");
//                     }
//                 } while (userDecision != "YES" && userDecision != "NO");
//             } while (userDecision == "YES");

//             Console.WriteLine("Thank you for shopping with us");
//             Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
#endregion
#region Part 13 - while loop
//Console.WriteLine("Please enter your target");
//int UserTarget = int.Parse(Console.ReadLine());

//int Start = 0;

//while(Start <= UserTarget)
//{
//    Console.Write(Start + " ");
//    Start = Start + 2;
//}
#endregion
#region Part 12 - switch statement continued
//int TotalCoffeeCost = 0;

//Start:

//Console.WriteLine("Please select your coffee size : 1 - Small, 2 - Medium, 3 - Large");
//int UserChoice = int.Parse(Console.ReadLine());

//switch (UserChoice)
//{
//    case 1:
//        TotalCoffeeCost += 1;
//        break;
//    case 2:
//        TotalCoffeeCost += 2;
//        break; //goto case 1;
//    case 3:
//        TotalCoffeeCost += 3;
//        break;
//    default:
//        Console.WriteLine("Your choice {0} is invalid.", UserChoice);
//        goto Start;
//}

//Decide:
//Console.WriteLine("Do you want to buy another coffee - Yes or No?");
//string UserDecision = Console.ReadLine();

//switch (UserDecision.ToUpper())
//{
//    case "YES":
//        goto Start;
//    case "NO":
//        break;
//    default:
//        Console.WriteLine("Your choice {0} is invalid. Please try again.", UserDecision);
//        goto Decide;
//}

//Console.WriteLine("Thank you for shopping with us");
//Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
#endregion
#region Part 11 - switch statement
//Console.WriteLine("Please enter a number");
//int UserNumber = int.Parse(Console.ReadLine());

//switch(UserNumber)
//{
//    case 10:
//    case 20:
//    case 30:
//        Console.WriteLine("Your number is {0}", UserNumber);
//        break;
//    default:
//        Console.WriteLine("Your number is not 10, 20 or 30.");
//        break;
//}
#endregion
#region Part 10 - if...else statements
//Console.WriteLine("Please enter a number");

//int UserNumber = int.Parse(Console.ReadLine());

//if (UserNumber == 10 && UserNumber == 20)
//{
//    Console.WriteLine("Your number is 10 or 20");
//}
//else
//{

//}

//if (UserNumber == 1)
//{
//    Console.WriteLine("Your number is one");
//}

//else if (UserNumber == 2)
//{
//    Console.WriteLine("Your number is two");
//}

//else if (UserNumber == 3)
//{
//    Console.WriteLine("Your number is three");
//}

//else // (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
//{
//    Console.WriteLine("Your number is not between 1 and 3.");
//}

//if (UserNumber == 1)
//{
//    Console.WriteLine("Your number is one");
//}

//if (UserNumber == 2)
//{
//    Console.WriteLine("Your number is two");
//}

//if (UserNumber == 3)
//{
//    Console.WriteLine("Your number is three");
//}

//if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
//{
//    Console.WriteLine("Your number is not between 1 and 3.");
//}
#endregion
#region Part 9 - Comments
//SampleClass

//string City = "London";

//// If city is London
//if (City == "London")
//{
//    Console.WriteLine("");
//}

///// <summary>
///// This is a Sample Class and a Sample Documentation
///// </summary>
//public class SampleClass
//{

//}
#endregion
#region Part 8 - Arrays
//using System;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        //int[] myFirstArray = new int[3];

//        //myFirstArray[0] = 5;
//        //myFirstArray[1] = 6;
//        //myFirstArray[2] = 7;

//        //int[] mySecondArray = new int[3] { 100, 30, 60 };
//        //int[] myThirdArray = new int[] { 100, 34, 70 };
//        //int[] myLastArray = { 100, 50, 90 };

//        //int[] score = { 96, 76, 88, 89, 90, 56 };

//        //for(int i = 0; i < 5; i++)
//        //{
//        //    score[i] += 3;
//        //}

//        //for (int i = 0; i < score.Length; i++)
//        //{
//        //    score[i] += 3;
//        //}

//        //for (int i = 0; i < score.Length; i++)
//        //{
//        //    Console.WriteLine("Student #{0}: {1}", i + 1, score[i]);
//        //}

//        int[] validValues = { 101, 108, 201, 213, 266, 304, 311, 409, 411, 412 };

//        Console.Write("Enter an Order Number : ");
//        int orderNumber = int.Parse(Console.ReadLine());

//        bool isItemInStock = false;

//        isItemInStock = SearchItem(orderNumber, validValues);

//        if (isItemInStock)
//        {
//            Console.WriteLine("The item is in stock.");
//        }

//        else
//        {
//            Console.WriteLine("The item is not in stock.");
//        }
//    }

//    private static bool SearchItem(int orderNumber, int[] validValues)
//    {
//        for (int i = 0; i < validValues.Length; i++)
//        {
//            if (orderNumber == validValues[i])
//            {
//                return true; // Item is in stock
//            }
//        }
//        return false; // Item not in stock
//    }
//}
#endregion
#region Part 7
// Implicit Conversion
// - No loss of information
// - No possibility of throwing an exception

//int i = 100;

//float f = i;

//Console.WriteLine(f);

//float f = 12345676452.45F;

//int i = (int)f;

//int i = Convert.ToInt32(f);

//Console.WriteLine(i);

//string strNumber = "9987";

//int i = int.Parse(strNumber);

//int result = 0;

//bool isConversionSuccessful = int.TryParse(strNumber, out result);

//        if (isConversionSuccessful)
//        {
//            Console.WriteLine(result);
//        }
//        else
//        {
//            Console.WriteLine("Please enter a valid number.");
//        }
#endregion
#region Part 6
//int? TicketsOnSale = 100;

//int AvailableTickets = TicketsOnSale ?? 0;

//if (TicketsOnSale == null)
//{
//    AvailableTickets = 0;
//}
//else
//{
//    AvailableTickets = (int)TicketsOnSale;
//}

//Console.WriteLine("Available Tickets = {0}", AvailableTickets);

//bool? AreYouMajor = null;

//if (AreYouMajor == true)
//{
//    Console.WriteLine("User is Major");
//}
//else if (AreYouMajor == false)
//{
//    Console.WriteLine("User is Not Major");
//}
//else
//{
//    Console.WriteLine("User did not answer the question.");
//}
#endregion
#region Part 5

/*  Operators
 *  Assignement Operators =
 *  Artithmetic Operators +, - , * , / , %
 *  Comparison Operators ==, !=, >
 *  Conditional Operators && ||
 *  Ternary Operator ?:
 *  Null Coalescing Operator ??
*/
//int numerator   = 10;
//int denominator = 2;

//int result = numerator / denominator;

//Console.WriteLine("Result = {0}", result);

//int Number = 10;
//int AnotherNumber = 21;

//if(Number == 10 || AnotherNumber == 20)
//{
//    Console.WriteLine("Hello");
//}

// Ternary Operator ?:

//int Number = 10;

//bool IsNumber10 = Number == 10 ? true : false;

//bool IsNumber10;

//if (Number == 10)
//{
//    IsNumber10 = true;
//}
//else
//{
//    IsNumber10 = false;
//}

//Console.WriteLine("Number == 10 is {0}", IsNumber10);
#endregion
#region Part 4
// string name = "C:\\Pragim\\DotNet\\Training\\Csharp";
//string name = @"C:\Pragim\DotNet\Training\Csharp";
//Console.WriteLine(name);
#endregion
#region Part 2
//Console.Write("Please enter your first name : ");
//string FirstName = Console.ReadLine();

//Console.Write("Please enter your last name : ");
//string LastName = Console.ReadLine();
//// Console.WriteLine("Hello " + UserName); // Concatenation

//Console.WriteLine("Hello {0}, {1}", FirstName, LastName); // Placeholder - C# is Case Sensitive
#endregion
#region Part 1
//static void Main1()
//{
//    Console.WriteLine("Welcome to C# Training 1");
//}

//static void Main()
//{
//    Console.WriteLine("Welcome to C# Training");
//    Main1();
//}
#endregion
