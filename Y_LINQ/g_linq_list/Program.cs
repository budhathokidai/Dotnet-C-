namespace g_linq_list;

#nullable disable

class Program
{
    static void Main(string[] args)
    {
        IList<Laptop> LaptopList = new List<Laptop>()
        {
            new Laptop()
            {
                LaptopID = 1,
                LaptopName = "Dell",
                LaptopCost = 55000,
                LotNo = 5
            },

            new Laptop()
            {
                LaptopID = 2,
                LaptopName = "HP",
                LaptopCost = 45000,
                LotNo = 1
            },

            new Laptop()
            {
                LaptopID = 3,
                LaptopName = "Lenovo",
                LaptopCost = 45896,
                LotNo = 2
            },

            new Laptop()
            {
                LaptopID = 4,
                LaptopName = "Apple",
                LaptopCost = 120000,
                LotNo = 3
            }
        };

        var LaptopNames = LaptopList
            .Where(l => l.LaptopCost > 40000 && l.LotNo > 1)
            .Select(l => l.LaptopName);

        foreach (var name in LaptopNames)
        {
            Console.WriteLine(name);
        }
    }
}

public class Laptop
{
    public int LaptopID { get; set; }
    public string LaptopName { get; set; }
    public int LaptopCost { get; set; }
    public int LotNo { get; set; }
}
  /*Dell
Lenovo
Apple*/
