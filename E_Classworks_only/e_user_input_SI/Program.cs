namespace e_user_input_SI;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Principle");
        int Pr=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Rate:");
        int Ra=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter Time:");
        int Ti=Convert.ToInt32(Console.ReadLine());
        int si=(Pr*Ra*Ti)/100;
        Console.WriteLine("Simple intrest:"+si);
    }
}

/*Enter Principle
34555
Enter Rate:
5
Enter Time:
45
Simple intrest:77748*/
