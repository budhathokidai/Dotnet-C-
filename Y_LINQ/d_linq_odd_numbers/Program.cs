namespace d_linq_odd_numbers;

class Program
{
    static void Main(string[] args)
    {
         int[] num = { 12, 32, 3, 4, 21, 34, 32, 122, 22, 3, 4 };

        int oddNum = num.Distinct().Count(n => n % 2 == 1);

        Console.WriteLine("Total number of odd numbers: " + oddNum);
    }
}
