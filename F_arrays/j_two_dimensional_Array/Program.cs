namespace j_two_dimensional_Array;
class Program
{
    static void Main(string[] args)
    {
        int[,] myarray = new int[5, 2]    //means 2-dimensional array (rows and columns).
        {
            {2,4},
            {5,3},
            {42,44},
            {69,112},
            {54,14}
        };
        Console.WriteLine("Printing array elements:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("myArray {0}{1} = {2}", i, j, myarray[i,j]);
            }
        }
    }
}

/*Printing array elements:
myArray 00 = 2
myArray 01 = 4
myArray 10 = 5
myArray 11 = 3
myArray 20 = 42
myArray 21 = 44
myArray 30 = 69
myArray 31 = 112
myArray 40 = 54
myArray 41 = 14*/
