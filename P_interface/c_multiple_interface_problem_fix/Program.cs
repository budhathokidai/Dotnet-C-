namespace c_multiple_interface_problem_fix;

interface IFather
{
    void FatherMethod();
}
interface IMother
{
    void MotherMethod();
}

class Child : IFather, IMother
{
    public void FatherMethod()
    {
        Console.WriteLine("Hello i am dad");
    }
    public void MotherMethod()
    {
        Console.WriteLine("Hello i am mother");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.FatherMethod();
        c1.MotherMethod();
    }
}

/*Hello i am dad
Hello i am mother*/