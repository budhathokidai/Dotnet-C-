namespace b_overloading_different_data_types;

class Numbers
{
    public int subtract(int a,int b,int c)
    {
        return(a+b+c);
    }
    public double subtract(double a,double b)
    {
        return(a+b);
    }

  public string subtract(string a,string b)
    {
        return(a+b);
    }

    

}
class Program
{
    static void Main(string[] args)
    {
        Numbers n1=new Numbers();
        Numbers n2=new Numbers();
        Numbers n3=new Numbers();
        Console.WriteLine("The sum of numbers = "+n1.subtract(1,2,3));
        Console.WriteLine("The sum ="+n2.subtract(1.3,2.5));
        Console.WriteLine("The sum ="+n3.subtract("Hello","Rabi"));
    }
}


/*The sum of numbers = 6
The sum =3.8
The sum =HelloRabi*/