namespace b_delegate_3;

public delegate void MyDel(string nmae);

class Program
{

    public static void displayName(String name)
    {
        Console.WriteLine("Hello " + name);

    }
    static void Main(string[] args)
    {
        MyDel d1 = new MyDel(displayName);
        d1("samothimi");
    }
}
