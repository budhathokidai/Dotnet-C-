namespace a_partial_class;
 //partial class is a class whose code is split into two or more files. All the parts are combined by the compiler to make one single class.
 class Program
{
    static void Main(string[] args)
    {
       Student s1= new Student();
       s1.hi();
       s1.hello();
    }
}
