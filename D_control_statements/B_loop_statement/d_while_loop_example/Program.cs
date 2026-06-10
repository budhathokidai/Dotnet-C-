namespace d_while_loop_example;
//natural number upto n 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter range you need :");
        int n=Convert.ToInt32(Console.ReadLine());
        int i=1;
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
/*
Enter range you need :
15
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15*/