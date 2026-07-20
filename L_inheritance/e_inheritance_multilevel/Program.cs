namespace e_inheritance_multilevel;

public class Geometry_Box
{
    public int price = 100;
}

public class Pencil : Geometry_Box
{
    public int price_1 = 10;
}

public class Eraser : Pencil
{
    public int price_2 = 5;

    public void Sum()
    {
        Console.WriteLine("The sum of items = " + (price + price_1 + price_2));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Eraser e1 = new Eraser();
        e1.Sum();
    }
}
/*The sum of items = 115*/