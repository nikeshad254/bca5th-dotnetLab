public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal Can Eat");
    }
}

public class Dog : Animal
{
    public void Barks()
    {
        Console.WriteLine("Woof!");
    }
}

public class InheritanceExample
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Barks();
    }
}
