namespace c_if_else_ladder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter marks in following subjects ");
        Console.WriteLine("------------------------");
        Console.WriteLine("Enter marks in English :");
        int eng=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Optional Math :");
        int omath=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Nepali :");
        int nep=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Computer :");
        int comp=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Compulsory Math :");
        int math=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Science :");
        int sci=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Samajik :");
        int sam=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Environment Sceince :");
        int ensci=Convert.ToInt32(Console.ReadLine());

        if(eng>35 && omath>35 && nep>35 && comp>35 && math>35 && sci>35 && sam>35 && ensci>35)
        {
            int total=eng+omath+nep+comp+math+sci+sam+ensci;
            float per=total/8f;
            Console.WriteLine("\n Total percentage you scored="+per+"%");
            if(per>=80)
            {
                Console.WriteLine("Division:Distinction!");
            }
            else if(per >=60)
            {
                Console.WriteLine("Division:First Division!");
            }
            else if(per>=45)
            {
                Console.WriteLine("Division:Second Division!");
            }
            else if (per >= 35)
            {
                Console.WriteLine("Division:Third Division!");
            }
            else if(per < 35)
            {
                Console.WriteLine("Better luck next time!");
            }
            else
            {
                Console.WriteLine("Just put legeal marks");
            }
        }
        else
        {
            Console.WriteLine("Result: Fail (One or more subjects are below pass marks)");
        }
    }
}


/*Enter marks in following subjects 
------------------------
Enter marks in English :
36  
Enter marks in Optional Math :
56
Enter marks in Nepali :
67
Enter marks in Computer :
76
Enter marks in Compulsory Math :
56
Enter marks in Science :
66
Enter marks in Samajik :
65
Enter marks in Environment Sceince :
45

 Total percentage you scored=58.375%
Division:Second Division!*/