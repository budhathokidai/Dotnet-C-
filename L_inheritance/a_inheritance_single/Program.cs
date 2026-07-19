namespace a_inheritance_single;

class Parents
{
    public void hello()
    {
        Console.WriteLine("I am parent of my child!");
    }
}
class Child : Parents
{
    public void hi()
    {
        Console.WriteLine("I am child of my parent!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.hello();
        c1.hi();
    }
}
