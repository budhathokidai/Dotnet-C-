namespace i_array_element_dispaly;

class Program
{
    static void Main(string[] args)
    {
        int[] num=new int[5];
        int i,j;
        for (i = 0; i < 5; i++)
        {
            num[i] = i + 100;
        }
        for (j = 0; j < 5; j++)
        {
            Console.WriteLine("Element [{0}] = {1} ", j, num[j]);
        }
        
    }
}
/*Element [0] = 100 
Element [1] = 101 
Element [2] = 102 
Element [3] = 103 
Element [4] = 104*/