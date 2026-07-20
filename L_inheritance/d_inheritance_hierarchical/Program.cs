namespace d_inheritance_hierarchical;

class Vehicle
{
    public void starts()
    {
        Console.WriteLine("I am main here!");
    }
}
class Bus : Vehicle
{
    public void starts_1()
    {
        Console.WriteLine("I am child one of my father!");
    }
}
class Van : Vehicle
{
    public void starts_2()
    {
        Console.WriteLine("I am child two of my father!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Bus b1 = new Bus();
        b1.starts();
        b1.starts_1();
        Van v1 = new Van();
        v1.starts();
        v1.starts_2();

    }
}
