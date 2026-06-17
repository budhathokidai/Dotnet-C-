namespace d_switch_month;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number from  1 to 12:");
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("January ho!");
                break;
            case 2:
                Console.WriteLine("Feburary ho!");
                break;
            case 3:
                Console.WriteLine("March ho!");
                break;
            case 4:
                Console.WriteLine("April ho!");
                break;
            case 5:
            Console.WriteLine("May ho!");
            break;
            default:
            Console.WriteLine("English month halana babu !");
            break;
        }
    }
}


/*Enter a number from  1 to 12:
3
March ho!*/