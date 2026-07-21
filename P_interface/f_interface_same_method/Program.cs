namespace f_interface_same_method;
//Explicit Interface Implementation
interface ITeacher
{
    void Show();
}

interface IStudent
{
    void Show();
}

class Person : ITeacher, IStudent
{
    void IStudent.Show()
    {
        Console.WriteLine("I am a Student.");
    }
    void ITeacher.Show()
    {
        Console.WriteLine("I am a Teacher.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        ITeacher t1=p;
        IStudent s1=p;
        t1.Show();
        s1.Show();
    }
}
/*I am a Teacher.
I am a Student.*/