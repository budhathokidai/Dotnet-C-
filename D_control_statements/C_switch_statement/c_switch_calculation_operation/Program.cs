namespace c_switch_calculation_operation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter one number for operation:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number for operation!");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nChoose operation:");
        Console.WriteLine("-------------------");
        Console.WriteLine("Press + :Addition");
        Console.WriteLine("Press - :Subtraction");
        Console.WriteLine("Press * :Multiplication");
        Console.WriteLine("Press / :Division");

        Console.WriteLine("Enter a  choice");
        string? choice = Console.ReadLine();
        int result;

        switch (choice)
        {
            case "+":
                result = a + b;
                Console.WriteLine("Addition result = " + result);
                break;

            case "-":
                result = a - b;
                Console.WriteLine("Subtraction result = " + result);
                break;

            case "*":
                result = a * b;
                Console.WriteLine("Multiplication result = " + result);
                break;

            case "/":
                result = a / b;
                Console.WriteLine("Division result = " + result);
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }

    }
}
/*Enter one number for operation:
4
Enter another number for operation!
5

Choose operation:
-------------------
Press + :Addition
Press - :Subtraction
Press * :Multiplication
Press / :Division
Enter a  choice
+
Addition result = 9*/