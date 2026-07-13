namespace b_struct_student;

struct Student
{
    public int roll;
    public string name;
    public int age;
    public string address;
    public string faculty;

}
class Program
{
    static void Main(string[] args)
    {
        Student s1;
        s1.roll=45;
        s1.name="Rabi";
        s1.age=21;
        s1.address="Bhaktapur";
        s1.faculty="ICT";

        Student s2;
        s2.roll=43;
        s2.name="Ram";
        s2.age=31;
        s2.address="KTM";
        s2.faculty="ICT";

        Console.WriteLine("Roll number of student one:"+s1.roll);
        Console.WriteLine("Name of student one:"+s1.name);
        Console.WriteLine("Age of student one:"+s1.age);
        Console.WriteLine("Address of student one:"+s1.address);
        Console.WriteLine("Faculty of student one:"+s1.faculty);
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Roll number of student Two:"+s2.roll);
        Console.WriteLine("Name of student Two:"+s2.name);
        Console.WriteLine("Age of student Two:"+s2.age);
        Console.WriteLine("Address of student Two:"+s2.address);
        Console.WriteLine("Facukty of student Two:"+s2.faculty);
      
    }
}
/*Roll number of student one:45
Name of student one:Rabi
Age of student one:21
Address of student one:Bhaktapur
Faculty of student one:ICT
------------------------------------
Roll number of student Two:43
Name of student Two:Ram
Age of student Two:31
Address of student Two:KTM
Facukty of student Two:ICT*/
