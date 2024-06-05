public class TernaryMessage
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string message = (age >= 18) ? $"\nYou are {age} years old, you are an adult." : $"\nYou are {age} years old, you are not an adult yet.";

        Console.WriteLine(message);
    }
}
