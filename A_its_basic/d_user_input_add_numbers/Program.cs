namespace d_user_input_add_numbers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a first number:");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Second number:");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The addition of two numbers is:"+(a+b));
    }
}

/*Enter a first number:
2
Enter a Second number:
3
The addition of two numbers is:5*/