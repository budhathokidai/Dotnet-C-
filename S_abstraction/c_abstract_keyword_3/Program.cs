namespace c_abstract_keyword_3;

abstract class Nums
{
    public abstract int Calculate(int a);
}

class Sqrt : Nums
{
    public override int Calculate(int a)
    {
        return (int)Math.Sqrt(a);
    }
}

class Square : Nums
{
    public override int Calculate(int a)
    {
        return a * a;
    }
}

class Cube : Nums
{
    public override int Calculate(int a)
    {
        return a * a * a;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Sqrt s0 = new Sqrt();
        Square s1 = new Square();
        Cube c1 = new Cube();

        Console.WriteLine("Square Root = " + s0.Calculate(25));
        Console.WriteLine("Square = " + s1.Calculate(3));
        Console.WriteLine("Cube = " + c1.Calculate(4));
    }
}
/*Square Root = 5
Square = 9
Cube = 64*/