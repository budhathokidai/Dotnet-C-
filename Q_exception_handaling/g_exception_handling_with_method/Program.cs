namespace g_exception_handling_with_method; 
class Calculator
{
    public int Modulus(int num1, int num2)
    {
        return num1 % num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator cal = new Calculator();

        int number1 = 25;
        int number2 = 4;

        try
        {
            int remainder = cal.Modulus(number1, number2);
            Console.WriteLine("The remainder is: " + remainder);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
//The remainder is: 1