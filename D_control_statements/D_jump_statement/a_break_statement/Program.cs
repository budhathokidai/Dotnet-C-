namespace a_break_statement;
//The break statement is used to immediately exit a loop or a switch statement.
class Program
{
    static void Main(string[] args)
    {
        for(int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}
/*
1
2*/