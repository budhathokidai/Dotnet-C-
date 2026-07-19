namespace l_array_num_search;

#nullable disable
class Program
{
    static void Main(string[] args)
    {
        //single dimensional array to find a number from an array

        int[] myArray = { 44,56,76,54,34,23,21,34,54 };
        Console.WriteLine("Enter number to search it in array:");
        int num = int.Parse(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (num == myArray[i])
            {
                found = true;
                break;
            }
        }
        if (found == true)
        {
            Console.WriteLine("Number found");
        }
        else
        {
            Console.WriteLine("Number not found");
        }   
    }
}

/*Enter number to search it in array:
34
Number found*/