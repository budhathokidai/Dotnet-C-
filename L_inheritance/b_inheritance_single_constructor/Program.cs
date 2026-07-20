namespace b_inheritance_single_constructor;

class StudentClass
{
    public StudentClass()
    {
      Console.WriteLine("Constructor of student class!");  
    } 
    public void StudentMethod()
    {
        Console.WriteLine("I am a student!");
    }

}
class TeacherClass : StudentClass
{
    public TeacherClass()
    {
        Console.WriteLine("Constructor of cHild class! ");
    }
    public void TeacherMethod()
    {
        Console.WriteLine("I am your teacher");
    }
}
class Program
{
    static void Main(string[] args)
    {
        TeacherClass t1=new TeacherClass();
        t1.StudentMethod();
        t1.TeacherMethod();
    }
}


/*Constructor of student class!
Constructor of cHild class! 
I am a student!
I am your teacher
*/