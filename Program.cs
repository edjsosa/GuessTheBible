class Program
{
    static void Main(string[] args)
    {
        while (true) 
        {
            UserInterface.DisplayMainMenu();
            UserInterface.GetMenuOption();
        }
    }
}

class UserInterface
{
    public static void DisplayMainMenu()
    {

        int delay = 50;

        DisplayMessageDelay("\nGuess the Bible", delay);
        DisplayMessageDelay("===============", delay);
        DisplayMessageDelay("1. Guess the Scripture", delay);
        DisplayMessageDelay("2. Guess the Book", delay);
        DisplayMessageDelay("3. Guess the Chapter", delay);
        DisplayMessageDelay("4. Guess the Verse", delay);
        DisplayMessageDelay("5. Scripture Memorizer", delay);
        DisplayMessageDelay("7. Exit\n", delay);
    }

    public static void DisplayMessageDelay(string message, int delay)
    {
        Console.WriteLine(message);
        Thread.Sleep(delay);
    }

    public static int GetMenuOption()
    {
        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            // check if input is a valid number between 1 and 3
            if (int.TryParse(input, out int number) && number >= 1 && number <= 3)
            {
                return int.Parse(input);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            }
        }
    }
}
