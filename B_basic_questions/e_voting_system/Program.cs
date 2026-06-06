namespace e_voting_system;

class Program
{
    int age;
    void enter()
    {
        Console.WriteLine("Enter your age");
        age=Convert.ToInt32(Console.ReadLine());
        
    }
    void vote()
    {
        if (age >= 18)
        {
            Console.WriteLine("Timi can vote!");
        }
        else
        {
            Console.WriteLine("Timi cannot vote!");
        }
    }
    static void Main(string[] args)
    {
        Program p1=new Program();
        p1.enter();
        p1.vote();
    }
}

/*Enter your age
23
Timi can vote!*/
