using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for weight
        Console.WriteLine("Please enter the package weight:");
        if (!double.TryParse(Console.ReadLine(), out double weight))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt for width
        Console.WriteLine("Please enter the package width:");
        if (!double.TryParse(Console.ReadLine(), out double width))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Prompt for height
        Console.WriteLine("Please enter the package height:");
        if (!double.TryParse(Console.ReadLine(), out double height))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Prompt for length
        Console.WriteLine("Please enter the package length:");
        if (!double.TryParse(Console.ReadLine(), out double length))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        double dimensionTotal = width + height + length;

        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate shipping quote
        double quote = (width * height * length * weight) / 100;

        Console.WriteLine("Your estimated total for shipping this package is: ${0:0.00}", quote);
        Console.WriteLine("Thank you!");
    }
}
