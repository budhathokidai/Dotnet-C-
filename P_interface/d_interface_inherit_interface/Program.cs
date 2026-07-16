namespace d_interface_inherit_interface;

interface ISchool
{
    void Admin();
}

interface ISir : ISchool
{
    void Teach();
}

class Mam : ISir
{
    public void Admin()
    {
        Console.WriteLine("I am admin of all");
    }

    public void Teach()
    {
        Console.WriteLine("I teach under admin instructions!");
    }
}

class Program
{
    static void Main(string[] args)
    {
       Mam d = new Mam();
       //ISir s1=new Mam
        d.Admin();
        d.Teach();
    }
}

/*I am admin of all
I teach under admin instructions!*/