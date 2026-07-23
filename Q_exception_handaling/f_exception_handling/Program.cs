namespace f_exception_handling;

class Program
{
    static void Main(string[] args)
    {
        //string value=null;
        string name ="Rabi";
        try
        {
            //if(name.Length==0)
            if(name.Length != 0)
            {
                Console.WriteLine(name);
            }
        }
        catch(Exception e)
        {
           Console.WriteLine("Exception Happened"+e);  
        }
       
    }
}
