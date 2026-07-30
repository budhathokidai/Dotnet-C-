namespace c_delegate_int_return;

public delegate int NumCalc(int num);

class Program
{
    public static int num=10;
    public static int addnum(int a)
    {
        num+=a;
        return num;
    }
    public static int mulnum(int a)
    {
        num*=a;
        return num;
    }
     public static int getnum()
    {
        return num;
    }
    static void Main(string[] args)
    {
        NumCalc n1= new NumCalc(addnum);
        n1(5);
        Console.WriteLine("New value is = {0}",getnum());
        NumCalc n2= new NumCalc(mulnum);
        n2(5);
        Console.WriteLine("New value is {0}",getnum());
    } 
}
/*New value is = 15
New value is 75*/

