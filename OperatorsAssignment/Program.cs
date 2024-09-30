namespace EmployeeApp
{
    // Define the Employee class
    public class Employee
    {
        // Properties for Employee class
        public int Id { get; set; }           // Unique identifier for the employee
        public string FirstName { get; set; } // First name of the employee
        public string LastName { get; set; }  // Last name of the employee

        // Overload the '==' operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if either emp1 or emp2 is null
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return ReferenceEquals(emp1, emp2); // If both are null, they are equal
            }

            // Compare Employee objects by their Id
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator to complement the '==' operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2); // Use the result of '==' to define '!='
        }

        // Override Equals method to ensure compatibility with object comparisons
        public override bool Equals(object obj)
        {
            // Ensure obj is of type Employee
            if (obj is Employee emp)
            {
                // Use the '==' operator to compare
                return this == emp;
            }
            return false;
        }

        // Override GetHashCode, necessary when overriding Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode(); // Hash the employee's Id
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with the same Id
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

            // Create another Employee object with a different Id
            Employee emp3 = new Employee { Id = 2, FirstName = "Alice", LastName = "Johnson" };

            // Compare emp1 and emp2 using the overloaded '==' operator
            if (emp1 == emp2)
            {
                Console.WriteLine("emp1 and emp2 are equal (same Id)");
            }
            else
            {
                Console.WriteLine("emp1 and emp2 are not equal");
            }

            // Compare emp1 and emp3 using the overloaded '!=' operator
            if (emp1 != emp3)
            {
                Console.WriteLine("emp1 and emp3 are not equal (different Ids)");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
