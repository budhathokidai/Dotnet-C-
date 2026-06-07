namespace e_object_class_user_input;

class Program
{
    int roll;
    string? name;

    static void Main(string[] args)
    {
        Program p1 = new Program();

        Console.Write("Enter roll number: ");
        p1.roll = Convert.ToInt32(Console.ReadLine()!);

        Console.Write("Enter name: ");
        p1.name = Console.ReadLine();

        Console.WriteLine("Roll number = " + p1.roll);
        Console.WriteLine("Name = " + p1.name);
    }
}

/*Enter roll number: 45
Enter name: Rabi Budhathoki
Roll number = 45
Name = Rabi Budhathoki*/
