namespace c_struct_with_function;

struct Employee
{
    public int e_no;
    public string name;
    public string address;
    public string designation;

    public void get_data(int e, string n, string a, string d)
    {
        e_no = e;
        name = n;
        address = a;
        designation = d;
    }
    public void display_data()
    {
        Console.WriteLine("\nEmployee details");
        Console.WriteLine("Employee id no:{0}", e_no);
        Console.WriteLine("Employee name:{0}", name);
        Console.WriteLine("Employee address:{0}", address);
        Console.WriteLine("Employee designation:{0}", designation);

    }

}
class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();

        e1.get_data(120, "Ramu Kaka", "Bkt", "Helper");
        e2.get_data(130, "Hari Bahadur", "Ktm", "Manager");

        e1.display_data();
        e2.display_data();
    }
}
/*Employee details
Employee id no:120
Employee name:Ramu Kaka
Employee address:Bkt
Employee designation:Helper

Employee details
Employee id no:130
Employee name:Hari Bahadur
Employee address:Ktm
Employee designation:Manager*/