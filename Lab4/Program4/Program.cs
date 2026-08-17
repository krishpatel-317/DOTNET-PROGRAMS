using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
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

    public override double CalculateArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter radius of circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle(radius);

        Console.Write("Enter length of rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width of rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(length, width);

        Console.WriteLine("\nCircle Area = " + circle.CalculateArea());
        Console.WriteLine("Rectangle Area = " + rectangle.CalculateArea());
    }
}