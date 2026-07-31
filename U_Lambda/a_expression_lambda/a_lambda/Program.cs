namespace a_lambda;

delegate int MyDel(int a);
class Program
{
    static void Main(string[] args)
    {
        MyDel d = a => a * a;
        int value = d(10);
        Console.WriteLine("The result= " + value);
    }
}
/*The result= 100*/

/*In csharp Lambda Expression is short block of code that accepts parameters and returns a value.It is defiend as an annonyms function
It uses the =>(goes to operator) to handel annonymus function which seperates its input parameters from exceutable body.

There are two types of lambda expressions:
  1. Expression Lambda
         It contains a singler expression on the right side of the operator which returns the result from givrn expression automatically 
         without using return keyword.
  2.Statement Lambda
        It contains a block of code enclosed within {} on the right side which may contain multiple statements or loops and requires a "return" statement
        to return a value from the expression.
        */
