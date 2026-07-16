namespace a_interface;
interface IGadgets
{
    public void brand();
}
class Laptop : IGadgets
{
    public void brand()
    {
        Console.WriteLine("laptop is of dell brand! ");
    }
}

class Mobile : IGadgets
{
    public void brand()
    {
        Console.WriteLine("mobile is of nothing brand! ");
    }
}
class Program
{
    static void Main(string[] args)
    {
        /*Laptop l1=new Laptop();
        l1.brand();
        Mobile m1=new Mobile();
        m1.brand();*/
        IGadgets hp1=new Laptop();
        IGadgets a4=new Mobile();
        hp1.brand();
        a4.brand();
        
    }
}

/*laptop is of dell brand! 
mobile is of nothing brand! */