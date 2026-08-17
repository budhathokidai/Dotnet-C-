namespace a_sealed;
// sealed class ko agadi,method ko agadi
//A sealed class is a class that cannot be inherited by another class.
sealed class Dad   //a sealed class can have objects.
{
    public void hi()
    {
        Console.WriteLine("Hi ma chai father!");
    }
}
class Son
{
    public void hello()
    {
        Console.WriteLine("Hello i am son!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Son s = new Son();//object of son!
        //s.hi(); //call using dad object
        s.hello();
    }
}
