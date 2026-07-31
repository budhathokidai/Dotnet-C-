namespace b_lambda;

class Program
{
    static void Main(string[] args)

    {
        var calcSum=(int a,int b)=>
        {
            int sum=(a+b);
            return a+b;
        };
        Console.WriteLine("The sum ="+calcSum(10,20));
    }
}

/*The sum =30*/