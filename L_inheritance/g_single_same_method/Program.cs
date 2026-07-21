namespace g_single_same_method;
class SuperClass
{
    public void hello()
    {
        Console.WriteLine("Hello ma chai superclass");
    }
}
class SubClass : SuperClass
{
    public new void hello()
    {
        Console.WriteLine("Hello ma chai subclass");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubClass s1 = new SubClass();
        SuperClass s2 = new SubClass();
        s1.hello();
        s2.hello();
    }
}
/*Hello ma chai subclass
Hello ma chai superclass*/