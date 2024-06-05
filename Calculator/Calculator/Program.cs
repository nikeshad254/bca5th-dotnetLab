public class Calculator
{
    public static void Main(string[] args)
    {
        double num1, num2;
        char operation;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        double result;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }

        Console.WriteLine("Result: {0} {1} {2} = {3}", num1, operation, num2, result);
    }
}
