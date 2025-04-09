using System;

class Program
{
    static void Main()
    {
        // Main program loop
        while (true)
        {
            // Display menu options
            PrintValue("\n--- Choose an Option ---");
            PrintValue("1. Even or Odd");
            PrintValue("2. Largest of Three Numbers");
            PrintValue("3. Celsius to Fahrenheit");
            PrintValue("4. Discount Calculator");
            PrintValue("5. Grading System");
            PrintValue("6. Swap Two Numbers");
            PrintValue("7. Days to Weeks and Days");
            PrintValue("8. Electricity Bill Calculator");
            PrintValue("9. Simple Calculator");
            PrintValue("0. Exit");
            PrintValue("Enter your choice: ");

            // Read user input
            string choice = Console.ReadLine();

            // Clear the console for cleaner output
            Console.Clear();

            // Handle user choice using a switch statement
            switch (choice)
            {
                case "1":
                    EvenOrOdd(); // Check if a number is even or odd
                    break;
                case "2":
                    FindLargest(); // Find the largest of three numbers
                    break;
                case "3":
                    ConvertCelsiusToFahrenheit(); // Convert Celsius to Fahrenheit
                    break;
                case "4":
                    DiscountCalculator(); // Calculate discounted price
                    break;
                case "5":
                    GradeSystem(); // Determine grade based on score
                    break;
                case "6":
                    SwapNumbers(); // Swap two numbers
                    break;
                case "7":
                    ConvertDays(); // Convert days to weeks and days
                    break;
                case "8":
                    CalculateElectricityBill(); // Calculate electricity bill
                    break;
                case "9":
                    SimpleCalculator(); // Perform basic arithmetic operations
                    break;
                case "0":
                    PrintValue("Exiting... Goodbye!"); // Exit the program
                    return;
                default:
                    PrintValue("Invalid option. Try again."); // Handle invalid input
                    break;
            }
        }
    }

    // Built-in function to replace Console.WriteLine
    public static void PrintValue(string message)//to replace the console.writeline
    {
        Console.WriteLine(message);
    }

    // Function to check if a number is even or odd
    public static void EvenOrOdd()
    {
        PrintValue("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        PrintValue(num % 2 == 0 ? "Even" : "Odd");
    }

    // Function to find the largest of three numbers
    public static void FindLargest()
    {
        PrintValue("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        PrintValue("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        PrintValue("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int largest = a; // Assume the first number is the largest
        if (b > largest) largest = b; // Compare with the second number
        if (c > largest) largest = c; // Compare with the third number

        PrintValue($"The largest number is: {largest}");
    }

    // Function to convert Celsius to Fahrenheit
    public static void ConvertCelsiusToFahrenheit()
    {
        PrintValue("Enter temperature in Celsius: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double f = (c * 9 / 5) + 32; // Conversion formula
        PrintValue($"Fahrenheit: {f}");
    }

    // Function to calculate discounted price
    public static void DiscountCalculator()
    {
        PrintValue("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        double finalPrice = price > 100 ? price * 0.9 : price; // Apply 10% discount if price > 100
        PrintValue($"Final price: {finalPrice}");
    }

    // Function to determine grade based on score
    public static void GradeSystem()
    {
        PrintValue("Enter score (0-100): ");
        int score = Convert.ToInt32(Console.ReadLine());

        // Determine grade based on score ranges
        if (score >= 90) PrintValue("Grade: A");
        else if (score >= 80) PrintValue("Grade: B");
        else if (score >= 70) PrintValue("Grade: C");
        else if (score >= 60) PrintValue("Grade: D");
        else PrintValue("Grade: F");
    }

    // Function to swap two numbers
    public static void SwapNumbers()
    {
        PrintValue("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        PrintValue("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Swap logic using a temporary variable
        int temp = a;
        a = b;
        b = temp;

        PrintValue($"After swap: a = {a}, b = {b}");
    }

    // Function to convert days to weeks and remaining days
    public static void ConvertDays()
    {
        PrintValue("Enter number of days: ");
        int days = Convert.ToInt32(Console.ReadLine());
        int weeks = days / 7; // Calculate weeks
        int remDays = days % 7; // Calculate remaining days

        PrintValue($"{weeks} week(s) and {remDays} day(s)");
    }

    // Function to calculate electricity bill based on units consumed
    public static void CalculateElectricityBill()
    {
        PrintValue("Enter units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        double bill = 0;

        // Calculate bill based on slab rates
        if (units <= 100)
            bill = units * 0.5;
        else if (units <= 300)
            bill = (100 * 0.5) + (units - 100) * 0.75;
        else
            bill = (100 * 0.5) + (200 * 0.75) + (units - 300) * 1.0;

        PrintValue($"Total bill: ${bill}");
    }

    // Function to perform basic arithmetic operations
    public static void SimpleCalculator()
    {
        PrintValue("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        PrintValue("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        PrintValue("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        double result = 0;

        // Perform operation based on the operator
        if (op == "+") result = a + b;
        else if (op == "-") result = a - b;
        else if (op == "*") result = a * b;
        else if (op == "/") result = b != 0 ? a / b : double.NaN; // Handle division by zero
        else PrintValue("Invalid operator");

        PrintValue($"Result: {result}");
    }
}
