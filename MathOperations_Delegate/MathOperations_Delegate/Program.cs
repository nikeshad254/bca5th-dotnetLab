using System;

public delegate int AddDelegate(int a, int b); // Delegate declaration

public class MathOperations
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static void Main(string[] args)
    {
        // Create a delegate instance and reference the Add method
        AddDelegate addFunction = Add;
        int num1, num2;
        Console.Write("num1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("num2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Call the delegate to add numbers
        int result = addFunction(num1, num2);

        Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, result);
    }
}
