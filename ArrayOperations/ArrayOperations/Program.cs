public class ArrayOperations
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maxNumber = numbers[0];
        int maxIndex = 0;
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
                maxIndex = i;
            }

            sum += numbers[i];
        }

        Console.WriteLine("\nMax number: {0}", maxNumber);
        Console.WriteLine("Index of max number: {0}", maxIndex);
        Console.WriteLine("Sum of numbers: {0}", sum);
    }
}
