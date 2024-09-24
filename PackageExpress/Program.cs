using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight and store it
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the weight exceeds 50
            if (weight > 50)
            {
                // Display error message if package is too heavy and end the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Prompt the user for the package width and store it
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Prompt the user for the package height and store it
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Prompt the user for the package length and store it
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum of dimensions to check if it exceeds 50
            int totalDimensions = width + height + length;

            // Check if the total dimensions exceed 50
            if (totalDimensions > 50)
            {
                // Display error message if package is too big and end the program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the shipping quote by multiplying dimensions and weight, then dividing by 100
            int dimensionProduct = width * height * length;
            decimal quote = (dimensionProduct * weight) / 100m;

            // Display the shipping quote to the user, formatted as a dollar amount
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
