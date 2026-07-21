namespace d_static_student_user_input;
#nullable disable
static class Student
{
    public static string name;
    public static string address;
    public static int age;
    public static void display()
    {
        Console.WriteLine("Details of Student");
        Console.WriteLine("Name of student:"+name);
        Console.WriteLine("address of student:"+address);
        Console.WriteLine("Age of student:"+age);

    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name:");
        Student.name=Console.ReadLine();

        Console.WriteLine("Enter the address:");
        Student.address=Console.ReadLine();

        Console.WriteLine("Enter the age:");
        Student.age=int.Parse(Console.ReadLine());

        Student.display();
    }
}
