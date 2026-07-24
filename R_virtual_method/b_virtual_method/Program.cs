namespace b_virtual_method;

class Shape
{
    protected int width,height;
    public Shape(int a=0,int b = 0)
    {
        width=a;
        height=b;
    }
    public virtual int area()
    {
        return 0;
    }
}
class Rectangle : Shape
{
    public Rectangle(int a=0, int b=0):base(a,b){}
    public override int area()
    {
        Console.Write("Rectangele ");
        return(width*height);
    }
}
class Triangle : Shape
{
    public Triangle(int a=0, int b=0):base(a,b){}
    public override int area()
    {
        Console.Write("Triangle ");
        return((width*height)/2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Triangle t1=new Triangle(4,5);
        Rectangle r1=new Rectangle(10,20);
    }
}
