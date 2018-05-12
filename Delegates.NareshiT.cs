using System;

namespace IntroToCSharp
{
    // Step 1 : Define a Delegate
    // Delegate for AddNums(int, int)
    public delegate void AddNumsDelegate(int a, int b);

    // Delegate for SayHello(string)
    public delegate string SayHelloDelegate(string str);

    public class Program
    {

        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }

        public static void Main(string[] args)
        {
            Program p = new Program();
            AddNumsDelegate ad = new AddNumsDelegate(p.AddNums); // Instance Method
            // ad(100, 50);
            ad.Invoke(100, 50);

            SayHelloDelegate shd = new SayHelloDelegate(SayHello); // Static Method

            string str = shd("Raju"); // shd.Invoke("Raju");

            Console.WriteLine(str);
        }
    }
}
