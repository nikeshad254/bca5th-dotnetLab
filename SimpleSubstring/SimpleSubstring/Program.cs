public class SimpleSubstring
{
    public static void Main(string[] args)
    {
        string message = "This is a sample message.";
        Console.WriteLine("Original String: "+ message);

        int startIndex = 10;
        int length = 6;
        string substring = message.Substring(startIndex, length);

        Console.WriteLine("\nSubstring: {0}", substring);
    }
}
