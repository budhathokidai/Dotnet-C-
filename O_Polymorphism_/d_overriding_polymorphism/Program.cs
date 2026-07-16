namespace d_overriding_polymorphism;

class Ayodhya
{
    public void jay()
    {
        Console.WriteLine("Hello Ram!");
    }
}
class Ram : Ayodhya
{
    public new void jay()  //importnat
    {
        Console.WriteLine("Jay shree ram...!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Ram r1=new Ram();
        r1.jay();
    }
}

/*Jay shree ram...!*/