class Program
 {
    static void Main(string[] args)
    {
        Console.Write("If you would like to perform division between two integers, please enter the first number: ");
        string input1 = Console.ReadLine();

         Console.Write("Enter the second number: ");
         string input2 = Console.ReadLine();

         PerformDivision(input1, input2);
    }

    static void PerformDivision(string num1, string num2)
  {
        try
        {
            int number1 = int.Parse(num1);
            int number2 = int.Parse(num2);

            int result = number1 / number2;

            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One or both inputs are not valid integers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        }
    }
