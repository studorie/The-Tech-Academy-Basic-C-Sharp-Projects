using System;

namespace MathOperationApp
{
    // Define a class called MathOperations
    class MathOperations
    {
        // Create a void method that takes two integer parameters
        public void DoMathOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (num1)
            int result = num1 * 2;  // Example math operation: multiplying the first number by 2

            // Display the result of the math operation and the second integer to the console
            Console.WriteLine("Result of the operation on the first number: " + result);
            Console.WriteLine("Second number is: " + num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the DoMathOperation method, passing in two numbers
            mathOperations.DoMathOperation(5, 10);

            // Call the DoMathOperation method, specifying the parameters by name
            mathOperations.DoMathOperation(num1: 3, num2: 7);

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
