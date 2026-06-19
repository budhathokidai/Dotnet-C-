namespace f_pass_fail;

class Program
{
    static void Main(string[] args)
    {
    retry:
        Console.Write("Enter your marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks < 40)
        {
            Console.WriteLine("You are Fail.");
            goto retry;
        }

        Console.WriteLine("Congratulations! You are Pass.");
    }
}

/*Enter your marks: 34
You are Fail.
Enter your marks: 67
Congratulations! You are Pass.*/
