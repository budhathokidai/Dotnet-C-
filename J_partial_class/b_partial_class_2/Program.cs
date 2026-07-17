using System.Runtime.Intrinsics.Arm;

namespace b_partial_class_2;

class Program
{
    static void Main(string[] args)
    
    {
        Studnet s1=new Studnet();
        string UserInput=s1.getInput();
        s1.displaydata(UserInput);
        
    }
}
