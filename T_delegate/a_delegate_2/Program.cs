namespace a_delegate_2;

public delegate void MyDel(int num);

class MyClass
{
    public static void square(int num)
    {
        Console.WriteLine("Square of {0} is {1}", num, num * num);
    }
    public static void cube(int num)
    {
        Console.WriteLine("Square of {0} is {1}", num, num * num);
    }
}
class Program : MyClass
{
    static void Main(string[] args)
    {
        MyDel d1 = square;
        d1(3);
        MyDel d2 = square;
        d2(4);
    }
}

/*Square of 3 is 9
Square of 4 is 16*/