class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        Circle circle = new Circle();
        shape.Draw();
        circle.Draw();
    }
}
