namespace c_goto_statement;
//The goto statement transfers control directly to a labeled statement within the same method.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Goto Statement");

        int i = 1;

    Start:
        if (i <= 5)
        {
            Console.WriteLine(i);
            i++;
            goto Start;
        }

        Console.WriteLine("Loop Finished");
    }
}

/*
Goto Statement
1
2
3
4
5
Loop Finished*/
