namespace b_static_area;

static class Shapes
{
    public static int len=56;
    public static int sqarea()
    {
        return(len*len);
    }
    public static int cube(int l)
    {
        return(l*l*l);
    }
}
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("The length of Shape= "+Shapes.len);
        Console.WriteLine("The area of Shape= "+Shapes.sqarea()+ " unit square");
        Console.WriteLine("The cube of Shape= "+Shapes.cube(3)+ " unit cube");
    }
}

/*The length of Shape= 56
The area of Shape= 3136 unit square
The cube of Shape= 27 unit cube*/