namespace h_for_each_loop_example;
//to print students  name 
class Program
{
    static void Main(string[] args)
    {
        string[] names={"Rabi","Rewon","Kushal","Pratik","Sushil"};
        foreach(string nam in names)
        {
            Console.WriteLine(nam);
        }
    }
}


/*Rabi
Rewon
Kushal
Pratik
Sushil*/