namespace d_struct_with_user_input_with_function;
#nullable disable
struct Employee
{
    public int e_no;
    public string name;
    public void get_data(int e, string n)
    {
        e_no = e;
        name = n;
    }
    public void display_data()
    {
        Console.WriteLine("\nEmployee details");
        Console.WriteLine("Employee id no:{0}", e_no);
        Console.WriteLine("Employee name:{0}", name);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Console.Write("Enter employee id no:");
        int e=int.Parse(Console.ReadLine());
        Console.Write("Enter employee name:");
        string n=Console.ReadLine();

        e1.get_data(e,n);
        e1.display_data();
      
    }
}

/*Enter employee id no:45
Enter employee name:ram

Employee details
Employee id no:45
Employee name:ram*/
