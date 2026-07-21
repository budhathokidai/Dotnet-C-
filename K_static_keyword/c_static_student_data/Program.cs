namespace c_static_student_data;

static class Student
{
    public static string fname="Rabi";
    public static string lname="Budhathoki";
    public static int age=21;
    public static void display()
    {
        Console.WriteLine("Details of Student");

    }

}
class Program
{
    static void Main(string[] args)
    {
        Student.display();
        Console.WriteLine("First name= "+Student.fname);
        Console.WriteLine("Last name= "+Student.lname);
        Console.WriteLine("Age= "+Student.age);
    }
}
