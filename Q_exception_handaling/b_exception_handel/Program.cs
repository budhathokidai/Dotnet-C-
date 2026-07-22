namespace b_exception_handel;

class Program
{
    static void Main(string[] args)
    {
        int a=10;
        int b=0;
        try
        {
        int output=a/b;
        Console.WriteLine("Answer is :"+output);   
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("A cannot be divided by b"+e);
        }
    }
}
