using System;
using System.IO;

namespace PMP.Login
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("+ ---------- Login ------------ +");

            #region Register New User

            //string userName = string.Empty;
            //string password = string.Empty;

            //Console.WriteLine("Username : ");
            //userName = Console.ReadLine();

            //Console.WriteLine("Password : ");
            //password = Console.ReadLine();

            //string filePath = @"C:\kudvenkat\pmp\credentials.txt";

            //using (StreamWriter sw = new StreamWriter(File.Create(filePath)))
            //{
            //    sw.WriteLine(userName);
            //    sw.WriteLine(password);
            //    sw.Close();
            //}
            #endregion


            string userName = string.Empty;
            string password = string.Empty;

            string userNameDB = string.Empty;
            string passwordDB = string.Empty;

            Console.WriteLine("Username : ");
            userName = Console.ReadLine();

            Console.WriteLine("Password : ");
            password = Console.ReadLine();

            string filePath = @"C:\kudvenkat\pmp\credentials.txt";

            using (StreamReader sr = new StreamReader(File.Open(filePath, FileMode.Open)))
            {
                userNameDB = sr.ReadLine();
                passwordDB = sr.ReadLine();
                sr.Close();
            }

            if (userName == userNameDB && password == passwordDB)
            {
                Console.WriteLine("Login Successsful");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }
    }
}
