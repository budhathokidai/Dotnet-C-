namespace e_employee_details;
#nullable disable
 class Employee
{
    public static string company="Microsoft";
    public int empid;
    public  string name;
   
    
}
class Program
{
    static void Main(string[] args)
    {
        Employee e1=new Employee();
        e1.empid=98;
        e1.name="Rabi";
        Console.WriteLine("Employee Id="+e1.empid);
        Console.WriteLine("Employee Name="+e1.name);
        Console.WriteLine("Company name="+Employee.company);

        Employee e2=new Employee();
        e2.empid=9;
        e2.name="Mina";
        Console.WriteLine("Employee Id="+e2.empid);
        Console.WriteLine("Employee Name="+e2.name);
        Console.WriteLine("Company name="+Employee.company);

        Employee e3=new Employee();
        e3.empid=97;
        e3.name="Hari";
        Employee.company="Amazon";
        Console.WriteLine("Employee Id="+e3.empid);
        Console.WriteLine("Employee Name="+e3.name);
        Console.WriteLine("Company name="+Employee.company);
    }
}
