using System.Reflection.Metadata;

namespace c_virtual_method;

class Shape
{
    protected int width, height;

    public Shape(int a = 0, int b = 0)
    {
        width = a;
        height = b;
    }

    public virtual int area()
    {
        return 0;
    }
}

class Rectangle : Shape
{
    public Rectangle(int a = 0, int b = 0) : base(a, b) { }

    public override int area()
    {
        Console.Write("Rectangle ");
        return width * height;
    }
}

class Triangle : Shape
{
    public Triangle(int a = 0, int b = 0) : base(a, b) { }

    public override int area()
    {
        Console.Write("Triangle ");
        return (width * height) / 2;
    }
}

class Caller
{
    public void CallArea(Shape sh)
    {
        int ar = sh.area();
        Console.WriteLine("Area = " + ar);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Caller c = new Caller();

        Triangle t = new Triangle(10, 20);
        Rectangle r = new Rectangle(30, 40);

        c.CallArea(t);
        c.CallArea(r);
    }
}

/*Triangle Area = 100
Rectangle Area = 1200*/