using MyMonkeyApp;

namespace MyMonkeyApp;

internal class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("   🐒 Monkey App Console   ");
            Console.WriteLine("============================");
            Console.WriteLine("1) List all monkeys");
            Console.WriteLine("2) Get details for a specific monkey by name");
            Console.WriteLine("3) Get a random monkey");
            Console.WriteLine("4) Exit");
            Console.Write("Select an option: ");

            var userInput = Console.ReadLine();
            Console.WriteLine();

            switch (userInput)
            {
                case "1":
                    ListAllMonkeys();
                    break;
                case "2":
                    GetMonkeyByName();
                    break;
                case "3":
                    GetRandomMonkey();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private static void ListAllMonkeys()
    {
        var monkeys = MonkeyHelper.GetMonkeys();
        Console.WriteLine("Name                 | Location                          | Population | Access Count");
        Console.WriteLine("-----------------------------------------------------------------------------------");
        foreach (var monkey in monkeys)
        {
            Console.WriteLine($"{monkey.Name,-20} | {monkey.Location,-32} | {monkey.Population,10} | {MonkeyHelper.GetAccessCount(monkey.Name),12}");
        }
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    private static void GetMonkeyByName()
    {
        Console.Write("Enter monkey name: ");
        var name = Console.ReadLine();
        var monkey = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
        if (monkey == null)
        {
            Console.WriteLine("Monkey not found.");
        }
        else
        {
            DisplayMonkeyDetails(monkey);
        }
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    private static void GetRandomMonkey()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        DisplayMonkeyDetails(monkey);
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    private static void DisplayMonkeyDetails(Monkey monkey)
    {
        Console.WriteLine("   .-\"\"\"\"-.   ");
        Console.WriteLine("  / .===. \\");
        Console.WriteLine("  \\ 6 6 \\");
        Console.WriteLine("  ( \\___/ )");
        Console.WriteLine("___ooo__ooo___");
        Console.WriteLine();
        Console.WriteLine($"Name: {monkey.Name}");
        Console.WriteLine($"Location: {monkey.Location}");
        Console.WriteLine($"Population: {monkey.Population}");
        Console.WriteLine($"Details: {monkey.Details}");
        Console.WriteLine($"Image: {monkey.Image}");
        Console.WriteLine($"Latitude: {monkey.Latitude}");
        Console.WriteLine($"Longitude: {monkey.Longitude}");
        Console.WriteLine($"Access Count: {MonkeyHelper.GetAccessCount(monkey.Name)}");
    }
}

