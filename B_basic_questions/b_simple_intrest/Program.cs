namespace b_simple_intrest;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("Enter Principal Amount:");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Rate of Interest:");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Time (in years):");
        double t = Convert.ToDouble(Console.ReadLine());

        double si = (p * r * t) / 100;

        Console.WriteLine("Simple Interest = " + si);
    }
}


/*Enter Principal Amount:
2345
Enter Rate of Interest:
4
Enter Time (in years):
5
Simple Interest = 469*/

