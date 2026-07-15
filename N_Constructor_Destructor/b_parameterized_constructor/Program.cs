namespace b_parameterized_constructor;
class Employee
{
    public int age;
    public string name;
    public string address;

    public  Employee(int a,string n,string ad)
    {
        age=a;
        name=n;
        address=ad;
    }
    public void displaydata()
    {
        Console.WriteLine("\nEmployee Details");
         Console.WriteLine("----------------");
        Console.WriteLine("Age="+age);
        Console.WriteLine("Name="+name);
        Console.WriteLine("Address="+address);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee e=new Employee(10,"Hari","Ktm");
        e.displaydata();
       
    }
}
