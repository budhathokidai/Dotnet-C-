using System.Runtime.InteropServices;
#nullable disable
namespace p_List_t_student_list;

public class Student
{
    public int roll { get; set; }
    public string name { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student(){roll=20,name= "Hari Bahadur"},
            new Student(){roll=21,name= "Hari "},
            new Student(){roll=22,name= " Bahadur"},
            new Student(){roll=22,name= "Hary"}
        };
        //linkqueue
        var StudNames =    
            from s in students
               where s.name == "Hary"
            select s;
            foreach (var student in StudNames)
        {
            Console.WriteLine(student.roll + " " + student.name);
        }

    }
}
