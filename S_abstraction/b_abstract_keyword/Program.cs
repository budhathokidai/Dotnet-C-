namespace b_abstract_keyword;
abstract class Nums
{
    public virtual int add(int a,int b)
    {
        return (a+b);
    }
}
class Calc : Nums
{
    public override int add(int a,int b)
    {
        return (a+b);
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        Calc c=new Calc();
        int result=c.add(90,90);
       Console.WriteLine("Sum="+result);
    }
}
