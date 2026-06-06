namespace f_parameter_function;

class Program
{
    int age;
    string? name;

    void detail(int a,string n)
    {
        age=a;
        name=n;
    }
    void display()
    {
        Console.WriteLine("Age="+age);
        Console.WriteLine("Name="+name);
    }
    static void Main(string[] args)
    {
        Program p1=new Program();
        Program p2=new Program();
        p1.detail(30,"Ram");
        p2.detail(23,"Sita");
        p1.display();
        p2.display();
    }
}

/*Age=30
Name=Ram
Age=23
Name=Sita*/
