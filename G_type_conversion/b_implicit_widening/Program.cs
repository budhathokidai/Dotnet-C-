namespace b_implicit_widening;

class Program
{
    static void Main(string[] args)
    {
        //byte a=256;// data type in byte ranges from 0 -255
        byte a=254;
        int b=a;
        Console.WriteLine("Byte value="+a);
        Console.WriteLine("Integer value="+b);

        /*byte a = 10;
        int b = a;
        long c = a;

        /* int b = (int)a;
        long c = (long)a; */

        /*Console.WriteLine("Byte a =" + a);
        Console.WriteLine("Integer b = " + b);
        Console.WriteLine("Long integer c = " + c);*/



       
    }
}
/*Byte value=254
Integer value=254*/
