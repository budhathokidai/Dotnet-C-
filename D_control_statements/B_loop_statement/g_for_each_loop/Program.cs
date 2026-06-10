namespace g_for_each_loop;
//A foreach loop is used to access each element of an array or collection one by one without using an index.
class Program
{
    static void Main(string[] args)
    {

        int [] numbers={10,20,30,40,50};
        foreach(int n in numbers)  //"in" takes each element from numbers one by one and store it in 'n'
        {
            Console.WriteLine(n);
        }
        
    }
}


/*
10
20
30
40
50
*/