namespace ConsoleApp1;

public class Task4
{
    static void Main()
    {
        bool continueCalculation = true;

        while (continueCalculation)
        {
            Console.Clear();
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            // Validate user choice
            if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
            {
                Console.WriteLine("Invalid choice. Please select a valid operation (1-4).");
                Pause();
                continue;
            }

            // Prompt for numerical inputs
            Console.Write("Enter Value 1: ");
            double value1 = GetValidatedNumber();

            Console.Write("Enter Value 2: ");
            double value2 = GetValidatedNumber();

            // Perform the selected operation
            switch (choice)
            {
                case "1": // Addition
                    Console.WriteLine($"{value1} + {value2} = {Add(value1, value2)}");
                    break;

                case "2": // Subtraction
                    Console.WriteLine($"{value1} - {value2} = {Subtract(value1, value2)}");
                    break;

                case "3": // Multiplication
                    Console.WriteLine($"{value1} * {value2} = {Multiply(value1, value2)}");
                    break;

                case "4": // Division
                    if (value2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"{value1} / {value2} = {Divide(value1, value2)}");
                    }
                    break;
            }

            // Prompt to continue or exit
            Console.Write("Do you want to continue again (Y/N)? ");
            string continueResponse = Console.ReadLine()?.Trim().ToUpper();

            if (continueResponse == "N")
            {
                continueCalculation = false;
                Console.WriteLine("Thank you for using the calculator. Goodbye!");
            }
        }
    }

    // Method to validate numerical input
    static double GetValidatedNumber()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }
        return number;
    }

    // Addition method
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Subtraction method
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Multiplication method
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Division method
    static double Divide(double a, double b)
    {
        return a / b;
    }

    // Helper method to pause the console
    static void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}