namespace b_switch_character_case;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your choice from (a to g) to see the meanings:");
        string ? input=Console.ReadLine();
        switch (input)
        {
            case "a":
            Console.WriteLine("A for Apple!");
            break;
            case "b":
            Console.WriteLine("B for Ball!");
            break;
            case "c":
            Console.WriteLine("C for Cat!");
            break;
            case "d":
            Console.WriteLine("D for Dog!");
            break;
            case "e":
            Console.WriteLine("E for Elaphent!");
            break;
            case "f":
            Console.WriteLine("F for fan!");
            break;
            case "g":
            Console.WriteLine("G for gun!");
            break;
            default:
            Console.WriteLine("K input gareko ?");
            break;
        }
    }
}


/*Enter your choice from (a to f) to see the meanings:
A
K input gareko ?*/