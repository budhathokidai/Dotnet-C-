namespace d_different_parameter_constructor;
#nullable disable
class Employee
{
    public int age;
    public string name;
    public string address;

    public Employee(int a, string n, string ad)
    {
        age = a;
        name = n;
        address = ad;
    }
    public Employee(int b, string d)
    {
        age = b;
        address = d;
    }

    public void DisplayData_1()
    {
        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("----------------");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Address: " + address);
    }
    public void DisplayData_2()
    {
        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("----------------");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Address: " + address);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee(10, "Ram", "KATHMANDU");
        Employee e2 = new Employee(11, "KATHMANDU");


        e1.DisplayData_1();
        e2.DisplayData_2();
    }
}

/*Employee Details
----------------
Age: 10
Name: Ram
Address: KATHMANDU

Employee Details
----------------
Age: 11
Address: KATHMANDU*/