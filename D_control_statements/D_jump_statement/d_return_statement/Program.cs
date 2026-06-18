namespace d_return_statement;
//The return statement exits a method and optionally returns a value.
class Program
{
    int a, b;

    void Input()
    {
        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
    }

    int Add()
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        Program p1 = new Program();

        p1.Input();

        int sum = p1.Add();

        Console.WriteLine("Sum is: " + sum);
    }
}


/*Enter first number: 4
Enter second number: 5
Sum is: 9*/