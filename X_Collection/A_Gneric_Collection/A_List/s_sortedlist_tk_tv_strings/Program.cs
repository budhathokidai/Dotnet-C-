//What is collection-initilizer in Generic Types?Write a program in c# with creating a SortedList of string keys and string values using collection-initializer syntax.
namespace s_sortedlist_tk_tv_strings;

class Program
{
    static void Main(string[] args)
    {
        /*creating a sorted list of string keys,string values using collection initalizer syntax*/
        SortedList<string,string> cities=new SortedList<string, string>()
        {
            {"Nepal","KTM"},
            {"India","Delhi"},
            {"Japan","Tokyo"}
        };
        foreach(var item in cities)
        {
            Console.WriteLine("{0} is the capital city of {1}",item.Value,item.Key);
        }
    }
}
