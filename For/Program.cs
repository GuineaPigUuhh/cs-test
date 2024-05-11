class Program 
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"My first program! ({i})");
        }

        // * Separator
        Console.WriteLine("---------------");

        string[] collection = [
            "Hello, World!",
            "My first program!",
            "Test!",
            "Other test!",
            "test?"
        ];
        foreach (var item in collection)
        {
            Console.WriteLine($"{item}");
        }
    }
}