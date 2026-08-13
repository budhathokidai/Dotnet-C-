namespace j_Dictionary_user_credentials;
#nullable disable
class Program
{
    static void Main(string[] args)

    {
         Dictionary<string, string> user_credentials = new Dictionary<string, string>
        {
            {"Ram", "Ram@1345"},
            {"Rabi", "Rabi30456"}
        };

        Console.WriteLine("Enter username:");
        string u = Console.ReadLine();

        Console.WriteLine("Enter Password:");
        string p = Console.ReadLine();

        bool isFound = false;

        if (user_credentials.ContainsKey(u))
        {
            if (user_credentials[u] == p)
            {
                isFound = true;
            }
        }

        if (isFound)
        {
            Console.WriteLine("Hello " + u);
        }
        else
        {
            Console.WriteLine("Credential mismatched");
        }
    }
}


/*Enter username:
Ram
Enter Password:
Ram@1345
Hello Ram*/