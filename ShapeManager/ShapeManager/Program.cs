public abstract class Shape
{
    public abstract double GetArea();
}

public class Square : Shape
{
    private double sideLength;
    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public override double GetArea() // Override abstract method with specific implementation
    {
        return sideLength * sideLength;
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea() // Override abstract method with specific implementation
    {
        return Math.PI * radius * radius;
    }
}

public class ShapeManager
{
    public static void Main(string[] args)
    {
        Shape square = new Square(5);
        Shape circle = new Circle(3);

        Console.WriteLine("Square Area: " + square.GetArea());
        Console.WriteLine("Circle Area: " + circle.GetArea());
    }
}
