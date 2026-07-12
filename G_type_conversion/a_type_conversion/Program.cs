namespace a_type_conversion;

class Program
{
    static void Main(string[] args)
    {
        byte a=10;
        //float b=a;//implicite
        float b=(float)a; //explisit i.e Type Casting
        Console.WriteLine("Byte value="+a);
        Console.WriteLine("Float value="+b);

    }
}
