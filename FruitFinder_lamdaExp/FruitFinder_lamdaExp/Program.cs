public class FruitFinder
{
    public static void Main(string[] args)
    {
        List<string> fruits = new List<string>() { "apple", "banana", "orange", "apricot" };

        var filteredFruits = fruits.Where(fruit => fruit.StartsWith("a", StringComparison.OrdinalIgnoreCase)); // Case-insensitive search

        Console.WriteLine("Fruits starting with 'a':");
        foreach (string fruit in filteredFruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
