namespace a_polymorphism;
class Numbers
{
    public int add(int a,int b,int c)
    {
        return(a+b+c);
    }
    public int add(int a,int b)
    {
        return(a+b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Numbers n1=new Numbers();
        Numbers n2=new Numbers();
        Console.WriteLine("The sum of numbers = "+n1.add(1,2,3));
        Console.WriteLine("The sum ="+n2.add(1,2));
    }
}

/*The sum of numbers = 6
The sum =3*/