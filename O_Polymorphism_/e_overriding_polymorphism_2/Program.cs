namespace e_overriding_polymorphism_2;

class Ayodhya
{
    public virtual void jay()
    {
        Console.WriteLine("Hello Ram!");
    }
}
class Ram : Ayodhya
{
    public override void jay()  //importnat
    {
        Console.WriteLine("Jay shree ram...!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Ram r1=new Ram();
        Ayodhya r1 = new Ram();
        r1.jay();
    }
}

/*Jay shree ram...!*/