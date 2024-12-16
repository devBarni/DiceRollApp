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

    static void RunStatisticsTracker()
    {
        Console.Clear();
        Console.WriteLine("=== Dice Roll Statistics Tracker ===");

        // Collect basic input parameters
        Console.Write("Enter number of rolls to simulate: ");
        int numberOfRolls = int.Parse(Console.ReadLine() ?? "100");

        Console.Write("Enter number of dice sides (default 6): ");
        int diceSides = int.TryParse(Console.ReadLine(), out int sides) ? sides : 6;

        // Initialize statistics tracking
        int[] rollCounts = new int[diceSides];
        Random random = new Random();
        double totalSum = 0;

        // Perform dice rolls
        for (int i = 0; i < numberOfRolls; i++)
        {
            int rollResult = random.Next(1, diceSides + 1);
            rollCounts[rollResult - 1]++;
            totalSum += rollResult;
        }

        // Display statistical analysis
        Console.WriteLine("\n=== Roll Distribution ===");
        for (int i = 0; i < diceSides; i++)
        {
            double percentage = (rollCounts[i] / (double)numberOfRolls) * 100;
            Console.WriteLine($"Number {i + 1}: {rollCounts[i]} times ({percentage:F2}%)");
        }

        // Calculate and display additional statistics
        double averageRoll = totalSum / numberOfRolls;
        int mostFrequentRoll = Array.IndexOf(rollCounts, rollCounts.Max()) + 1;
        int leastFrequentRoll = Array.IndexOf(rollCounts, rollCounts.Min()) + 1;

        Console.WriteLine("\n=== Summary Statistics ===");
        Console.WriteLine($"Total Rolls: {numberOfRolls}");
        Console.WriteLine($"Average Roll: {averageRoll:F2}");
        Console.WriteLine($"Most Frequent Number: {mostFrequentRoll}");
        Console.WriteLine($"Least Frequent Number: {leastFrequentRoll}");

        // Visualization of distribution
        Console.WriteLine("\n=== Distribution Visualization ===");
        int maxCount = rollCounts.Max();
        for (int i = 0; i < diceSides; i++)
        {
            int barLength = (rollCounts[i] * 50) / maxCount;
            Console.WriteLine($"Number {i + 1}: {new string('#', barLength)} ({rollCounts[i]} rolls)");
        }
    }

    static void RunCustomDiceConfiguration()
    {
        Console.Clear();
        Console.WriteLine("Custom Dice Configuration");
        Console.WriteLine("(Future implementation - will allow custom dice sides, special dice)");
    }

    static void RunGameModeSelector()
    {
        Console.Clear();
        Console.WriteLine("Game Mode Selector");
        Console.WriteLine("(Future implementation - will add game modes like Yahtzee, Craps)");
    }
}