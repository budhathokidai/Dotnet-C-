namespace a_switch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your choice from 1 to 7 for weekdays!");
        int wd=Convert.ToInt32(Console.ReadLine());
        switch (wd)
        {
            case 1:
            Console.WriteLine("The day is Sunday");
            break;
            case 2:
            Console.WriteLine("The day is Monday");
            break;
            case 3:
            Console.WriteLine("The day is Tuesday");
            break;
            case 4:
            Console.WriteLine("The day is Wednesday");
            break;
            case 5:
            Console.WriteLine("The day is Thursday");
            break;
            case 6:
            Console.WriteLine("The day is Friday");
            break;
            case 7:
            Console.WriteLine("The day is Saturday");
            break;
            default:
            Console.WriteLine("Input is invalid");
            break;

        }
    }
}

/*Enter your choice from 1 to 7 for weekdays!
6
The day is Friday*/
