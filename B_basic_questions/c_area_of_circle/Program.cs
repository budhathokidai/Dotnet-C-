namespace c_area_of_circle;


class Program
{
    double radius;
    void input()
    {
        Console.WriteLine("Enter radius of circle");
        radius=Convert.ToDouble(Console.ReadLine());
    }
    void output()
    {
        double area= 3.14 *radius *radius;
        Console.WriteLine("Area of circle:" +area);
    }
    static void Main(string[] args)
    {
        Program p1=new Program();
        p1.input();
        p1.output();
    }
}
 
 /*Enter radius of circle
7
Area of circle:153.86*/
