namespace i_Dictionary_String;

class Program
{
    static void Main(string[] args)
    {
        var subjects = new Dictionary<string, string>()
            {
                {"education", "Nepali, Maths, Population, ICT"},
                {"science", "Biology, Chemistry, Physics"},
                {"humanities", "Sociology, Social Work"}
            };

        Console.WriteLine(subjects["education"]);
        Console.WriteLine(subjects["humanities"]);

        if (subjects.ContainsKey("education"))
        {
            Console.WriteLine(subjects["education"]);
        }
    }
}

/*Nepali, Maths, Population, ICT
Sociology, Social Work
Nepali, Maths, Population, ICT*/