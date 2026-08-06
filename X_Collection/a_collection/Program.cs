using System.Globalization;

namespace a_collection;

class Program
{
    static void Main(string[] args)
    {
        //method 1
        /*List<int> nums=new List<int>();
        nums.Add(34);
        nums.Add(3);
        nums.Add(23);
        Console.WriteLine(nums[0]);
        Console.WriteLine(nums[1]);
        Console.WriteLine(nums[2]);*/

        //method 2
        /*var nums=new List<int>();
        nums.Add(34);
        nums.Add(3);
        nums.Add(23);
        Console.WriteLine(nums[0]);
        Console.WriteLine(nums[1]);
        Console.WriteLine(nums[2]);*/


        //method 3
       /*  var num=new List<int>(){23,32,3,4};
        Console.WriteLine(num[0]);
        Console.WriteLine(num[1]);
        Console.WriteLine(num[2]);
        Console.WriteLine(num[3]); */

        //method 4
        var nums=new List<int>(){12,3,4,45,32};
        //nums.Insert(0,34);
        //nums.Remove(45);
        //nums.RemoveAt(2);  //indexing Remove 
        nums.Clear();
        nums.Insert(0,4);
        nums.ForEach(nums =>Console.WriteLine(nums));
        /* for(int i = 0; i < 7; i++)
        {
            Console.WriteLine(nums[i]);
        } */
    }
}
