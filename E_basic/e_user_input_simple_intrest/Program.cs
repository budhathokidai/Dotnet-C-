namespace e_user_input_simple_intrest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Principal:");
        int p=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Rate:");
        int r=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Time:");
        int t=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Simple intrest:"+((p*t*r)/100));
    }
}
