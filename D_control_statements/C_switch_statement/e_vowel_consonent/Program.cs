namespace e_vowel_consonent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a letter:");
        string? letter=Console.ReadLine();

        switch (letter)
        {
            case "a":
            Console.WriteLine("Its vowel!");
            break;
            case "e":
            case "i":
            case "o":
            case "u":
            Console.WriteLine("Its vowel!");
            break;
            default:
            Console.WriteLine("its consonent!");
            break;
        }

    
    }
}

/*Enter a letter:
u
Its vowel!*/
