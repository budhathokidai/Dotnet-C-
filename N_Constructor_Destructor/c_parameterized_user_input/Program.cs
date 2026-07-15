namespace c_parameterized_user_input;
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

    public void DisplayData()
    {
        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("----------------");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Address: " + address);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        Employee e = new Employee(age, name, address);

        e.DisplayData();
    }
}
/*Enter Age: 20   
Enter Name: Kushal Chor
Enter Address: Ghar

Employee Details
----------------
Age: 20
Name: Kushal Chor
Address: Ghar*/