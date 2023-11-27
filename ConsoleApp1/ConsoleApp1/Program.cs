using System;

//  Create a delegate named 'ArithmeticOperation'
delegate int ArithmeticOperation(int a, int b);

class Program
{
    
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static int Divide(int a, int b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
    }

    static void Main()
    {
        // Create instances of the 'ArithmeticOperation' delegate
        ArithmeticOperation addDelegate = Add;
        ArithmeticOperation subtractDelegate = Subtract;
        ArithmeticOperation multiplyDelegate = Multiply;
        ArithmeticOperation divideDelegate = Divide;

        
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Choose an arithmetic operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        
        int choice = int.Parse(Console.ReadLine());
        int result = 0;

        switch (choice)
        {
            case 1:
                result = addDelegate(num1, num2);
                Console.WriteLine($"Result of addition: {result}");
                break;
            case 2:
                result = subtractDelegate(num1, num2);
                Console.WriteLine($"Result of subtraction: {result}");
                break;
            case 3:
                result = multiplyDelegate(num1, num2);
                Console.WriteLine($"Result of multiplication: {result}");
                break;
            case 4:
                result = divideDelegate(num1, num2);
                Console.WriteLine($"Result of division: {result}");
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
                break;
        }
        Console.ReadKey();
    }
}
