
class DiceRollSimulation
{
    static void Main()
    {
        // Control variable to manage game repetition
        bool playAgain = true;

        while (playAgain)
        {
            // Run the main dice roll simulation
            RunDiceRollSimulation();

            // Ask user if they want to play again
            Console.WriteLine("\nPress 'R' to roll again, or any other key to exit.");
            var key = Console.ReadKey(true); // Capture key press without displaying it
            playAgain = (key.Key == ConsoleKey.R);
        }

        // Farewell message when user chooses to exit
        Console.WriteLine("Thank you for playing. Goodbye!");
    }

    static void RunDiceRollSimulation()
    {
        // Create random number generator
        Random random = new Random();

        Console.WriteLine("Welcome to Dice Roll Application!");
        
        // Prompt user for number of dice rolls
        Console.Write("Enter the number of rolls: ");
        int numberOfRolls = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        
        // Simulate dice rolls
        for (int i = 0; i < numberOfRolls; i++)
        {
            // Generate random number between 1 and 6 (inclusive)
            int result = random.Next(1, 7);
            Console.WriteLine($"Roll {i + 1}: {result}");
        }
    }
}