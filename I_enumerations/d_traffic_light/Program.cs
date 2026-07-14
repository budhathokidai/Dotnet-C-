namespace d_traffic_light;

class Program
{
    enum Lights { Red, Yellow, Green };
    static void Main(string[] args)
    {
        var Traffic = Lights.Yellow;
        if (Traffic == Lights.Red)
        {
            Console.WriteLine("Stop where you are!");
        }
        else if (Traffic == Lights.Green)
        {
            Console.WriteLine("Goooooooo!");
        }
        else
        {
            Console.WriteLine("Daya Baya herau!");
        }
    }
}
