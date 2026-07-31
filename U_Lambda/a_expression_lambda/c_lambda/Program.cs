namespace c_lambda;

delegate int MyDel(int a, int b);
class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) => (a>b)?a:b;
        int value = d(10, 15);
        Console.WriteLine("The Greater value= " + value);
    }
}

/*The Greater value= 15*/