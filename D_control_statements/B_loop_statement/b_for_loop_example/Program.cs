namespace b_for_loop_example;
//natural numbers from 1 to 10
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a range you want!");
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

/*Enter a range you want!
10
1
2
3
4
5
6
7
8
9
10*/