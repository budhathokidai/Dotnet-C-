namespace e_abstract_class_n_method;

abstract class Nepal
{
    public abstract void hel();
}
class Lalitpur : Nepal
{
    public override void hel()
    {
        Console.WriteLine("Ma chai lalitpur bata hai");
    }
}
class Bhaktapur : Nepal
{
    public override void hel()
    {
        Console.WriteLine("Ma chai Bhaktapur bata hai");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Nepal n;
        n = new Lalitpur();
        n.hel();
        n = new Bhaktapur();
        n.hel();
    }
}

/*Ma chai lalitpur bata hai
Ma chai Bhaktapur bata hai*/