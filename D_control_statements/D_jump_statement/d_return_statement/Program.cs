namespace d_return_statement;
//The return statement exits a method and optionally returns a value.
class Program
{
  static void Main(string[] args)
    {
        int a = 3, b = 25, sum = 0;
        sum = add(a, b);
        Console.WriteLine("The sum = " + sum);
    }
    public static int add(int x, int y)
    {
        int s = x + y;
        return s;
    }
}


/*The sum = 28*/