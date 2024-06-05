using System.Runtime.CompilerServices;

public interface IShape
{
    double GetArea();
}

public class Square : IShape
{
    private double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public double GetArea()
    {
        return sideLength * sideLength;
    }


}

public class Program
{
    public static void Main(string[] args)
    {
        Square sq = new Square(10);
        Console.WriteLine("Square Area is: "+sq.GetArea());
    }
}
