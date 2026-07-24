namespace a_virtual_method;

class SuperClass
{
    public virtual int calc(int a,int b)
    {
        return(a+b);
    }
}
class SubClass : SuperClass
{
    public override int calc(int a, int b)
    {
        return (a+b+4);
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass obj=new SubClass();
        Console.WriteLine("Redefined result="+obj.calc(1,2));
    }
}

/*Redefined result=7*/