namespace e_goto_vote_or_not;

class Program
{
    static void Main(string[] args)
    {
    ineligible:
       

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
        {
             Console.WriteLine("You cannot  vote.");
            goto ineligible;
        }
        else
        {
            Console.WriteLine("You can vote.");
        }
    }
}

/*Enter your age:
5
You cannot  vote.
Enter your age:
67
You can vote.*/
