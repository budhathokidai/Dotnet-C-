namespace c_user_inpu_string;
//#nullable disable  (insted of ?,according to requirement)
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name :");
        string ? name=Console.ReadLine();
        Console.WriteLine("Your name is:"+name);
    }
}
