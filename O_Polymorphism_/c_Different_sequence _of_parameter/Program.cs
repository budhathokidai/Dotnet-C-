namespace c_Different_sequence__of_parameter;
class Myclass
{
    public void displayDetails(int roll,string name)
    {
        Console.WriteLine("Roll ={0} and name = {1}",roll,name);
    }
    public void displayDetails(string name,int roll)
    {
        Console.WriteLine("Roll ={0} and name = {1}",roll,name);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Myclass m1=new Myclass();
        m1.displayDetails(10,"Rabi");
        m1.displayDetails("Hari",20);
    }
}

/*Roll =10 and name = Rabi
Roll =20 and name = Hari*/