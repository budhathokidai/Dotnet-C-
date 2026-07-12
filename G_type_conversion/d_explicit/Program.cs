namespace d_explicit;

class Program
{
    static void Main(string[] args)
    {
        /*double a = 13.46;
        int b = (int)a;
        Console.WriteLine("Double value = " + a);
        Console.WriteLine("Converted integer value = " + b);*/

        int a=234;
        byte b=(byte)a;  //byte range 0-255
        Console.WriteLine("Integer  value="+a);
        Console.WriteLine("Byte value="+b);
    }
}
/*Double value = 13.46
Converted integer value = 13*/

/*Integer  value=234
Byte value=234*/