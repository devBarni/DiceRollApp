class DiceRollSimulation
{
    static void Main()
    {
        Random random = new Random();  // Create a Random object to generate random numbers

        Console.WriteLine("Welcome to DiceRollApp!");
        
        // Ask the user how many times they want to roll the dice
        Console.Write("Enter the number of rolls: ");
        int numberOfRolls = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        
        // Perform the specified number of rolls
        for (int i = 0; i < numberOfRolls; i++)
        {
            int result = random.Next(1, 7);  // Generate a random number between 1 and 6.
            Console.WriteLine($"Roll {i + 1}: {result}");
        }
        
        Console.WriteLine("End of the program. Goodbye!");
    }
}