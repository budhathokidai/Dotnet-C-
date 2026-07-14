namespace e_student_grade;

class Program
{
    enum Grades{A,B,C,D,E};
    static void Main(string[] args)
    {
        Grades stdgrade=Grades.A;
         Console.WriteLine("Grade: " + stdgrade);
    }
}
