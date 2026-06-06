namespace b_object_class;

class Program
{
    int roll;
   string? name;
    static void Main(string[] args)
    {
        Program p1=new Program();
        p1.roll=5;
        p1.name="Rabi Budhathoki";
        Console.WriteLine("Roll number="+p1.roll);
        Console.WriteLine("Name="+p1.name);
    }
}

/*Roll number=5
Name=Rabi Budhathoki*/
