namespace e_interface_with_property;
#nullable disable
interface IStudent
{
    string Name { get;set;}
    void show();
}
class Student : IStudent
{
    public string Name { get; set; }

    public void show()
    {
        Console.WriteLine("Student Name: " + Name);
    }   
}
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.Name = "Rabi";
        s.show();
    }
}
/*Student Name: Rabi*/