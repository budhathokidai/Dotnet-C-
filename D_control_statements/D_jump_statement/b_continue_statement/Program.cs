namespace b_continue_statement;
//The continue statement skips the current iteration of a loop and continues with the next iteration.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Continue statement");
        for(int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

/*
Continue statement
1
2
4
5*/