namespace a_enum;
//An enum (enumeration) is a user-defined data type that is used to store a fixed set of named constants.
class Program
{
    enum Days{Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Sturday};
    static void Main(string[] args)
    {
        int firstDay=(int)Days.Sunday;
        Console.WriteLine(firstDay);

        var wd=(Days)5;
        Console.WriteLine(wd);
    }
}
/*0
Friday*/