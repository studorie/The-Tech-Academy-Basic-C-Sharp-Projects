using System;
using System.Text; // Needed for the StringBuilder class

namespace StringManipulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenate three strings
            string str1 = "Hello, ";
            string str2 = "my name is ";
            string str3 = "John!";
            // Concatenating the three strings into one
            string concatenatedString = str1 + str2 + str3;
            // Display the concatenated string
            Console.WriteLine("Concatenated String: " + concatenatedString);

            // Convert a string to uppercase
            string lowercaseString = "this will be uppercase";
            // Convert the string to uppercase and store it
            string uppercaseString = lowercaseString.ToUpper();
            // Display the uppercase string
            Console.WriteLine("Uppercase String: " + uppercaseString);

            // Create a StringBuilder and build a paragraph one sentence at a time
            StringBuilder sb = new StringBuilder();

            // Adding sentences to the StringBuilder
            sb.Append("This is the first sentence. ");
            sb.Append("Here comes the second sentence. ");
            sb.Append("Now we are at the third sentence. ");
            sb.Append("Finally, this is the last sentence in the paragraph.");

            // Convert StringBuilder to a string and display the paragraph
            Console.WriteLine("Paragraph built using StringBuilder:");
            Console.WriteLine(sb.ToString());

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
