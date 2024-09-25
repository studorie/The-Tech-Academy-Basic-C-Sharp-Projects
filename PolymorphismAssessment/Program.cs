using System;

namespace PolymorphismAssignment
{
    // Step 1: Define an interface called IQuittable
    public interface IQuittable
    {
        // Define a void method called Quit
        void Quit();
    }

    // Step 2: Create the Employee class that inherits the IQuittable interface
    public class Employee : IQuittable
    {
        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("The employee has quit their job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 3: Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = new Employee();

            // Call the Quit() method on the IQuittable object
            quittableEmployee.Quit();

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
