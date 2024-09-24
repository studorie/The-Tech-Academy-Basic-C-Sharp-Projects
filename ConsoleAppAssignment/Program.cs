using System;

namespace BooleanComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while loop
            Console.WriteLine("Boolean Comparison using While Loop:");

            // Initialize a variable
            int counter = 0;

            // While loop that runs as long as the condition is true (counter < 5)
            while (counter < 5)
            {
                // Output the current value of the counter
                Console.WriteLine("Counter is less than 5. Current value: " + counter);

                // Increment the counter by 1
                counter++;
            }

            // Boolean comparison using a do-while loop
            Console.WriteLine("\nBoolean Comparison using Do-While Loop:");

            // Reset the counter for the do-while loop
            counter = 0;

            // Do-while loop that runs at least once, and continues as long as the condition is true
            do
            {
                // Output the current value of the counter
                Console.WriteLine("Counter is less than 5. Current value: " + counter);

                // Increment the counter by 1
                counter++;
            }
            while (counter < 5); // The loop will keep running while this condition is true

            // End of the program
            Console.WriteLine("End of the program.");
            Console.ReadLine(); // Keeps the console window open until the user presses Enter
        }
    }
}
