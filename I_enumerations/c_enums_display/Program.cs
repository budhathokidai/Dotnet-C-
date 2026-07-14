namespace c_enums_display;
#nullable disable
class Program
{
    enum Days{Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Sturday};  //anywhere we can 
    static void Main(string[] args)
    {
        string name ;
        Days day;
        Console.WriteLine("Enter your name: ");
        name=Console.ReadLine();
        Console.WriteLine("Enter your values from (0-6)for days");
        int index=int.Parse(Console.ReadLine());
        day=(Days)index; ///typecasting
        Console.WriteLine("Hello "+name+ "today is "+day+".");
    }
}
