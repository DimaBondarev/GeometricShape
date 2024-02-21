using System;

public class GeometricShape
{
    public virtual double CalculateArea(params double[] parameters)
    {
        return 0;
    }

    public virtual double CalculatePerimeter(params double[] parameters)
    {
        return 0;
    }
}

public class Program
{
    static void Main()
    {
        Rectangle rectangle1 = new Rectangle();
        Rectangle rectangle2 = new Rectangle();

        rectangle1.Length = 4;
        rectangle1.Width = 5;

        rectangle2.Length = 3;
        rectangle2.Width = 6;

        Console.WriteLine("Do rectangles have the same area? " + (rectangle1 == rectangle2));

        Console.WriteLine("Area of rectangle 1: " + rectangle1.CalculateArea(rectangle1.Length, rectangle1.Width));
        Console.WriteLine("Area of rectangle 2: " + rectangle2.CalculateArea(rectangle2.Length, rectangle2.Width));

        Triangle triangle = new Triangle();
        double baseLength = 5;
        double height = 8;

        Console.WriteLine("Area of the triangle: " + triangle.CalculateArea(baseLength, height));

        Circle circle = new Circle();
        double radius = 4;

        Console.WriteLine("Area of the circle: " + circle.CalculateArea(radius));
    }
}
