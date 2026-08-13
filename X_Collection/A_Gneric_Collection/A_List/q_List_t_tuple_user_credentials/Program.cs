namespace q_List_t_tuple_user_credentials;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        bool isFound=false;
        List<Tuple<string,string>> credentials=new List<Tuple<string, string>>
        {
           new Tuple<string, string>("Ram","ramu@234"),
           new Tuple<string, string>("Situ","sita@234") 
        };     
        Console.WriteLine("Enter name");
        string u=Console.ReadLine();
        Console.WriteLine("Enter password");
        string p=Console.ReadLine();
        foreach(Tuple<string,string> c in credentials)
        {
            if(c.Item1==u && c.Item2 == p)
            {
                isFound=true;
                break;
            }
        }
        if (isFound)
        {
            Console.WriteLine("Welcome {0}",u);
        }
        else
        {
            Console.WriteLine("Invalid username/password");
        }

    }
}


/*Enter name
Ram
Enter password
ramu@234
Welcome Ram*/