namespace a_delegate_event;
public delegate string Mydel(string str);
class Eventdel
{
    event Mydel MyEvent;
    public Eventdel()
    {
        this.MyEvent +=new Mydel(this.DisplayMessage);
    }
    public string DisplayMessage(string username)
    {
        return "Hello " +username;
    }
    static void Main(string[] args)
    {
        Eventdel obj =new Eventdel();
        string result =obj.MyEvent("Sanothimi");
        Console.WriteLine(result);
    }
}
/*Hello Sanothimi*/