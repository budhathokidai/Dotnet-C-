using System.ComponentModel;

namespace f_queue_contain;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums= new Queue<int>();
        nums.Enqueue(43);
        nums.Enqueue(3);
        nums.Enqueue(54);
        nums.Enqueue(4663);

        Console.WriteLine(nums.Contains(5));   //queue ma not contain huda false dekhauxa natra true
        Console.WriteLine(nums.Contains(54));
    }
}
