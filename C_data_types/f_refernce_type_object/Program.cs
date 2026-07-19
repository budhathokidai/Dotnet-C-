namespace f_refernce_type_object;

class Program
{
    static void Main(string[] args)
    {
        // object is a base type in C# that can store any data type

        object data;

        // storing integer value inside object
        data = 45566;

        Console.WriteLine("Value stored in object: " + data);

        // GetType() shows the actual data type stored inside object
        Console.WriteLine("Actual type: " + data.GetType());
    }
}

/*Value stored in object: 45566
Actual type: System.Int32*/
