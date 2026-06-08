namespace a_if;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int a=Convert.ToInt32(Console.ReadLine());
        if (a<0)
        {
            Console.WriteLine("The number "+a+" is negative!");

        }

    }
}


/*Enter number:
-1
The number -1 is negative!*/
