using System;

public class Student
{
    private int id;
    private string name;
    private int passMark = 35;

    // Read-Write Property
    public int Id
    {
        set
        {
            if(value <= 0)
            {
                throw new Exception("Student ID cannot be Negative.");
            }
            this.id = value;
        }
        get
        {
            return this.id;
        }
    }

    // Read-Write Property
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Student Name cannot be null or empty.");
            }
            this.name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
        }
    }

    // Read-Only Property
    public int PassMark
    {
        get
        {
            return this.passMark;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student C1 = new Student();

        C1.Id = 101;
        C1.Name = "Mark";

        Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}",
                           C1.Id, C1.Name, C1.PassMark);
        
    }

}

