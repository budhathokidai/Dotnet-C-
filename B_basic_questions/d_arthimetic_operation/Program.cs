namespace d_arthimetic_operation;

class Program
{
    int a,b;
    void input()
    {
       Console.WriteLine("Enter First number:");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second number:");
        b=Convert.ToInt32(Console.ReadLine());
    }
    void output()
    {
         Console.WriteLine("Addition = " + (a + b));
        Console.WriteLine("Subtraction = " + (a - b));
        Console.WriteLine("Multiplication = " + (a * b));
        Console.WriteLine("Division = " + (a / b));
        Console.WriteLine("Modulus = " + (a % b));
    }
    static void Main(string[] args)
    {
       Program p1=new Program();
       p1.input();
       p1.output();
    }
}

/*Enter First number:
4
Enter Second number:
2
Addition = 6
Subtraction = 2
Multiplication = 8
Division = 2
Modulus = 0*/


