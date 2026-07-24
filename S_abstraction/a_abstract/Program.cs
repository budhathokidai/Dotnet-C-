namespace a_abstract;
abstract class Nepal
{
   public abstract void hlo(); 
}
class China: Nepal
{
    public override void hlo()
    {
        Console.WriteLine("I am chinese!");
    }
}
class India : Nepal
{
    public override void hlo()
    {
        Console.WriteLine("I am indian!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Nepal n;  //not object just a refernce
        n=new China();
        n.hlo();
        n=new India();
        n.hlo();

    }
}

/*I am chinese!
I am indian!*/
