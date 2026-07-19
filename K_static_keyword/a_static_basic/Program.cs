namespace a_static_basic;
//The static keyword is used to make a variable, method, constructor, or class belong to the class itself, not to any object.
static class Shapes
{
    public static int len=56;
}
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("The length of Shape="+Shapes.len);
    }
}
