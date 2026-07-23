namespace e_string_exception;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Rabi", "Ram", "Rewon" };
        try
        {
            //Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception found " + e);
        }
    }
}