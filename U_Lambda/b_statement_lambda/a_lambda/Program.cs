namespace a_lambda;
delegate void MyDel(int a,int b);

class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) =>
        {
          Console.WriteLine("The sum = "+(a+b));  
        };
        d(5,1);
    }
}

/*The sum = 6*/
