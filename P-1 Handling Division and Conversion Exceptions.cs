class Program
{
    static void Main(String[] args)
    {
        //Prompt user for inputs as String
        Console.WriteLine("Enter the first number: ");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter the second number: ");
        string input2 = Console.ReadLine();

        try
        {
            //Convert these inputs into integers
            int n1 = Convert.ToInt32(input1);
            int n2 = Convert.ToInt32(input2);
            //Perform Division
            int result = Divide(n1, n2);
            //Display Result
            Console.WriteLine($"The result of {n1} divided by {n2} is: {result}");
        }
        catch (FormatException ex)
        {
            //Format Exception
            Console.WriteLine("Error: One or both inputs are not valid integers.");
            Console.WriteLine($"Detailed Info: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            //DivideByZero Exception
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Detailed Info: {ex.Message}");
        }
        catch (OverflowException ex)
        {
            //Overflow Exception
            Console.WriteLine("Error: One or both of the inputs are too large or too small.");
            Console.WriteLine($"Detailed Info: {ex.Message}");
        }
        catch (Exception ex)
        {
            //Unexpected exceptions
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Detailed Info: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }


    //Function to perform division
    static int Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}


