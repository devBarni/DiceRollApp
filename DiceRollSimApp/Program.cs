
class DiceRollSimulation
{
    static void Main()
    {
        bool exitApplication = false;

        while (!exitApplication)
        {
            DisplayMainMenu();
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    RunDiceRollSimulation();
                    break;
                case "2":
                    RunStatisticsTracker();
                    break;
                case "3":
                    RunCustomDiceConfiguration();
                    break;
                case "4":
                    RunGameModeSelector();
                    break;
                case "0":
                    exitApplication = true;
                    Console.WriteLine("Exiting application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            if (!exitApplication)
            {
                Console.WriteLine("\nPress any key to return to main menu...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }

    static void DisplayMainMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Dice Roll Simulator App ===");
        Console.WriteLine("1. Basic Dice Roll");
        Console.WriteLine("2. Roll Statistics");
        Console.WriteLine("3. Custom Dice Configuration");
        Console.WriteLine("4. Game Mode Selector");
        Console.WriteLine("0. Exit");
        Console.Write("Select an option: ");
    }

    static void RunDiceRollSimulation()
    {
        Console.Clear();
        Random random = new Random();

        Console.WriteLine("Welcome to Basic Dice Roll!");
        Console.Write("Enter the number of rolls: ");
        int numberOfRolls = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        for (int i = 0; i < numberOfRolls; i++)
        {
            int result = random.Next(1, 7);
            Console.WriteLine($"Roll {i + 1}: {result}");
        }
    }

    // Placeholder methods for future implementation
    static void RunStatisticsTracker()
    {
        Console.Clear();
        Console.WriteLine("Function 1");
        Console.WriteLine("(Future implementation 1)");
    }

    static void RunCustomDiceConfiguration()
    {
        Console.Clear();
        Console.WriteLine("Function 2");
        Console.WriteLine("(Future implementation 2)");
    }

    static void RunGameModeSelector()
    {
        Console.Clear();
        Console.WriteLine("Function 3");
        Console.WriteLine("(Future implementation 3)");
    }
}