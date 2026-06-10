namespace f_do_while_example;
//password check 
class Program
{
    static void Main(string[] args)
    {
        int pass;
        do
        {
            Console.WriteLine("Enter  your Password: ");
            pass=Convert.ToInt32(Console.ReadLine());
        }while(pass!=1234);  //loops Keep repeating while the password is NOT "1234" and if password eneterd is 1234 loop stops!
        Console.WriteLine("Access Granted!");
    }
}


/*
Enter  your Password: 
22223
Enter  your Password: 
2345
Enter  your Password: 
2345
Enter  your Password: 
1234
Access Granted!
*/