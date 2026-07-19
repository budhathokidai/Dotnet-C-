namespace f_enum_hello;

class Program
{ 
    enum Days{Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Sturday};
    static void Main(string[] args)
    { 
        var wd=Days.Tuesday;
        if(wd==Days.Sunday  ||  wd==Days.Monday)
        {
            Console.WriteLine("Hello ist not the day you wnat!");
        }
        else
        {
            Console.WriteLine("Hello ram its the day "+wd);
        }
    }
}
