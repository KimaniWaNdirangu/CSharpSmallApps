using System;

abstract class Shape
{
    abstract public double Area();
}

class Square : Shape
{
    private double side;
    
    public double Side
    {
        get
        {
            return this.side;
        }
        set
        {
            this.side = value;
        }
    }

    public Square(double side)
    {
        this.Side = side;
    }

    public override double Area()
    {
        return this.side * this.side;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Square objSquare = new Square(12);
        Console.WriteLine("Area of the Square of side {0} is : {1}", objSquare.Side, objSquare.Area());
    }
}