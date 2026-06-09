namespace d_nested_if;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number you want!");
        int num=Convert.ToInt32(Console.ReadLine());
        if(num!=0)
        {
            if(num > 0)
            {
                Console.WriteLine("The number you enetered is positive!");
            }
            else
            {
                Console.WriteLine("The number you entered is negative!");
            }
        }
        else
        {
            Console.WriteLine("The number is"+num+"!");
        }
    }
}
/*Enter a number you want!
-2
The number you entered is negative!*/