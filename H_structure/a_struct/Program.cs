namespace a_struct;

struct Student
{
    public int roll;
    public void display(int roll)
    {
        Console.WriteLine("Roll number="+roll);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1;
        s1.roll=45;
        Console.WriteLine(s1.roll);
    }
}

/*45*/