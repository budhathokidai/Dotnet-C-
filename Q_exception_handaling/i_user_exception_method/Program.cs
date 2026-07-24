using System.Runtime.CompilerServices;

namespace i_user_exception_method;

class VoterInvalid: Exception
{
    public VoterInvalid(string message):base(message){}
}
class Program
{
    static void AgeVlidator(int age)
    {
        if (age < 18)
        {
            throw new VoterInvalid("You are not elidigible to get your voter id by age");
        }
        else
        {
            Console.WriteLine("You are  eligible to get your voter id by age");
        }
    }
    static void Main(string[] args)

    {
        Console.WriteLine("Enter your age");
        int a=Convert.ToInt32(Console.ReadLine());
        try
        {
            AgeVlidator(a);
        }
        catch(VoterInvalid e)
        {
            Console.WriteLine(e);
        }
    }
}

/*Enter your age
34
You are  eligible to get your voter id by age*/