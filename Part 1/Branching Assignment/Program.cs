using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial greeting
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // Check weight constraint
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program
            }

            // Prompt for dimensions
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // Check if the sum of dimensions exceeds 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program
            }

            /* Calculation Logic:
               1. Multiply dimensions (Volume)
               2. Multiply volume by weight
               3. Divide by 100 to get the quote
            */
            float dimensionsProduct = width * height * length;
            double quote = (dimensionsProduct * weight) / 100.0;

            // Display the result formatted as currency ($)
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
            
            // Keep console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
