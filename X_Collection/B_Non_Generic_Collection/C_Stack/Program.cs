namespace C_Stack;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Stack stack=new Stack();
        stack.Push("Kushal");
        stack.Push("10");
        stack.Push("2345.345");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Stack contains:"+stack.Contains("Ram"));
        Console.WriteLine("Peek element:"+stack.Peek());
        stack.Pop();
        /* Console.WriteLine("Elements after pop:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        } */   
    }
}
