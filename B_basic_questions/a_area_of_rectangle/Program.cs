namespace a_area_of_rectangle;

class Program
{
    int L,B,area;

    void data()
    {
        Console.WriteLine("Eneter length of a rectangle: ");
        L=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Eneter breadth of a rectangle: ");
        B=Convert.ToInt32(Console.ReadLine());
    }
    void calculate()
    {
        area=L*B;
        Console.WriteLine("The area of rectangle is :"+area);
    }
    static void Main(string[] args)
    {
        Program p1=new Program();
        p1.data();
        p1.calculate();
    }
}

/*Eneter length of a rectangle: 
12
Eneter breadth of a rectangle: 
4
The area of rectangle is :48*/
