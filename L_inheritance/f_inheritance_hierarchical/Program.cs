namespace f_inheritance_hierarchical;
public class Number
{
    public int x = 20;
}

public class Add : Number
{
    public int y = 30;

    public void Sum()
    {
        Console.WriteLine("Sum = " + (x + y));
    }
}

public class Multiply : Number
{
    public int z = 5;

    public void Product()
    {
        Console.WriteLine("Product = " + (x * z));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Add a1 = new Add();
        a1.Sum();

        Multiply m1 = new Multiply();
        m1.Product();
    }
}

/*Sum = 50
Product = 100*/