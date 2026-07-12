namespace k_jagged_array_two_dimensional;


class Program
{
    static void Main(string[] args)
    {
        int[][] myArray = new int[3][];
        //int[] → one-dimensional array.
        //int[][] → array containing other arrays.
        //new int[3][] → creates an array with 3 rows, but the rows are empty for now.

        myArray[0] = new int[3] { 12, 3, 6 };
        myArray[1] = new int[5] { 2, 3, 6, 5, 1 };
        myArray[2] = new int[2] { 8, 4 };
        foreach (int[] i in myArray)
        {
            foreach (int item in i)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*
12
3
6
2
3
6
5
1
8
4
*/