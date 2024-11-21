using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Greenville Idol!");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Enter contestants");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int prevYearContestants = GetContestants("Number of contestants last year (0-30): ");
                int currentYearContestants = GetContestants("Number of contestants this year (0-30): ");

                // Corrected order of conditions
                if (currentYearContestants > 2 * prevYearContestants)
                {
                    Console.WriteLine("The competition is more than twice as big this year!");
                }
                else if (currentYearContestants > prevYearContestants)
                {
                    Console.WriteLine("The competition is bigger than ever!");
                }
                else
                {
                    Console.WriteLine("A tighter race this year! Come out and cast your vote!");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }
    }

    static int GetContestants(string prompt)
    {
        int contestants;

        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out contestants) && contestants >= 0 && contestants <= 30)
            {
                return contestants;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
            }
        }
    }
}
