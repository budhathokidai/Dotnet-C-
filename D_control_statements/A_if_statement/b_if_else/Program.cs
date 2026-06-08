namespace b_if_else;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number between 1 to 100:");
        int num=Convert.ToInt32(Console.ReadLine());
        if(num % 2 == 0)
        {
            Console.WriteLine("The enetered number is prime!");
        }
        else
        {
            Console.WriteLine("The enterede number is composite!");
        }
    }
}
/*Enter a number between 1 to 100:
2
The enetered number is prime!*/