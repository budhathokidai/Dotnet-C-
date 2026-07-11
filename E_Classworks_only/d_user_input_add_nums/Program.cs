namespace d_user_input_add_nums;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum is:"+(num1+num2));

    }
}
/*
Enter first number:
23
Enter second number:
4
The sum is:27*/