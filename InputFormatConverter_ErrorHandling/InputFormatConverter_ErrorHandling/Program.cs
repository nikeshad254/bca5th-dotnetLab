public class InputConverter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string inputString = Console.ReadLine();

        int number;
        try
        {
            number = Convert.ToInt32(inputString);
            Console.WriteLine("You entered the number: {0}", number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect input. Please enter a valid number.");
        }
    }
}
