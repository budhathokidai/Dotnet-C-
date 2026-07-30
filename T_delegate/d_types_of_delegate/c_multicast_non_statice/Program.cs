namespace c_multicast_non_statice;
public delegate void MyDel(int a,int b);  //bith static and non static in delegate
class Calculation
{
    public   static void add(int a,int b)
    {
        Console.WriteLine("The sum="+(a+b));
    }
    public  static void mul(int a,int b)
    {
        Console.WriteLine("The Product="+(a*b));
    }
    static void Main(string[] args)
    {
        Calculation cobj=new Calculation();
        MyDel d1=new MyDel(Calculation.add);
        MyDel d2=new MyDel(Calculation.mul);
        d1=d1+d2;
        d1(20,30);
    }
}
