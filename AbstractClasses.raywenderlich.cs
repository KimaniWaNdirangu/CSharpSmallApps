using System;

public abstract class Shape
{
    public abstract double GetPerimeter();
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetPerimeter()
    {
        return (width + length) * 2;
    }
}

class Triangle : Shape
{
    private double sideA, sideB, sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public override double GetPerimeter()
    {
        return (sideA + sideB + sideC);
    }
}

public class Program
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle(10, 10);
        Triangle triangle = new Triangle(1, 2, 3);

        Shape[] shapes = new Shape[]
        {
            rectangle,
            triangle
        };

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetPerimeter());
        }
    }
}
