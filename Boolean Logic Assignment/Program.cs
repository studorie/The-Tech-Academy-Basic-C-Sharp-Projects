using System;

namespace BooleanLogic // Define the namespace for the program
{
    class Program // Define the main class
    {
        static void Main(string[] args) // Entry point of the program
        {
            // Output a message indicating that this is a car insurance application
            Console.WriteLine("Car Insurance Application");

            // Ask the user for their age and store the input in the variable 'age'
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask the user if they have ever had a DUI and store the answer in 'answer'
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();

            // Convert the 'answer' to a boolean value. True if they answered 'yes', false otherwise
            bool dui = answer == "yes";

            // Ask the user how many speeding tickets they have and store the input in 'tickets'
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Determine if the applicant qualifies for insurance based on age, DUI, and tickets
            // The conditions are: over 15 years old, no DUI, and no more than 3 tickets
            bool qualified = (age > 15) && !dui && (tickets <= 3);

            // Output the result of the qualification check
            Console.WriteLine("Qualified for insurance?");
            Console.WriteLine(qualified); // Print 'true' or 'false' based on whether the applicant qualifies
        }
    }
}
