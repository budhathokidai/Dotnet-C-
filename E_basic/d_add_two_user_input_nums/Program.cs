namespace d_add_two_user_input_nums;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of two number:"+(a+b));
    }
}
