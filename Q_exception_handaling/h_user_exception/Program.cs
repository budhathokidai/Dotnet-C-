namespace h_user_exception;

class MyExeption : Exception
{
    public MyExeption(string str)
    {
        Console.WriteLine(str);
    }
}
class Program
{
    static void Main(string[] args)

    {
        MyExeption obj = new MyExeption("This is user defiened exception");
        try
        {
            throw obj;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }

    }
}
