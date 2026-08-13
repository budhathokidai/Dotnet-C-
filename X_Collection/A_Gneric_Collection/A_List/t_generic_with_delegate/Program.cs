namespace t_generic_with_delegate;
//differentiate between generic and non generic collection
class Program
{
    delegate T Add<T>(T a,T b);
    static void Main(string[] args)
    {
        Add<int> intResult=FunctionOne;
        Console.WriteLine("The sum={0}",intResult(23,45));
        Add<string> stringResult=FunctionTwo;
        Console.WriteLine("The Concatenated string={0}",stringResult("RAM","SITA"));
        Add<double> doubleResult=FunctionThree;
        Console.WriteLine("The sum={0}",doubleResult(23.5,45.6));
    }
    static int FunctionOne(int x,int y)
    {
        return(x+y);
    }
    static string FunctionTwo(string x,string y)
    {
        return(x+y);
    }
    static double FunctionThree(double x,double y) //class templete and function templete
    {
        return(x+y);
    }
}
