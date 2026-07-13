using System.Drawing;

namespace e_area_of_rectangle;

struct Rectangle
{
    public int length;
    public int breadth;

    static void Main(string[] args)
    {
        Rectangle r;
        r.length=3;
        r.breadth=4;
        int A=r.length*r.breadth;
        Console.WriteLine("Area of rectangle="+A);
    }
}
/*Area of rectangle=12*/