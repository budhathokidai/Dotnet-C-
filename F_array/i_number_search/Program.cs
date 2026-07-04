namespace i_number_search;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        int [] myarray={1,43,5,4,76,86,200};
        Console.WriteLine("Enter a number to search it in array");
        int num=int.Parse(Console.ReadLine());
        bool found =false;
        for(int i = 0; i < myarray.Length; i++)
        {
            if(num == myarray[i])
            {
                found=true;
                break;
            }
        }
        if(found == true)
        {
            Console.WriteLine("Number Found");
        }
        else
        {
            Console.WriteLine("Number  not found");
        }

    }
}
