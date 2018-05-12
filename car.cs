using System;

class Program
{
    public static void Main()
    {
       // var car = new Car();
        var ferarri = new Ferarri(22);
    }
}

public class Car
{
    public int WheelSize { get; set; }
    public int NumberOfDoors { get; set; }

    public Car()
    {

    }
}

public class Ferarri : Car
{
    public Ferarri()
    {

    }
    public Ferarri(int wheelSize)
    {
        this.WheelSize = wheelSize;
    }
}