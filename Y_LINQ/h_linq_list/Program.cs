namespace h_linq_list;

#nullable disable

class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var pList = new List<Person>();

        pList.Add(new Person
        {
            Name = "Suman",
            Age = 25,
            Address = "Pokhara"
        });

        pList.Add(new Person
        {
            Name = "Bikash",
            Age = 18,
            Address = "Bhaktapur"
        });

        pList.Add(new Person
        {
            Name = "Prakash",
            Age = 22,
            Address = "Chitwan"
        });

        pList.Add(new Person
        {
            Name = "Anil",
            Age = 28,
            Address = "Dharan"
        });

        pList.Add(new Person
        {
            Name = "Sagar",
            Age = 19,
            Address = "Butwal"
        });

        var query = from p in pList
                    where p.Name.ToLower().Contains("a") && p.Age > 20
                    select p;

        foreach (var p in query)
        {
            Console.WriteLine("Name    = " + p.Name);
            Console.WriteLine("Address = " + p.Address);
            Console.WriteLine("Age     = " + p.Age);
            Console.WriteLine();
        }
    }
}

/*Name    = Suman
Address = Pokhara
Age     = 25

Name    = Prakash
Address = Chitwan
Age     = 22

Name    = Anil
Address = Dharan
Age     = 28*/