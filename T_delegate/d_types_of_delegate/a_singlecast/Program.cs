namespace a_singlecast;

public class Program
{
    public delegate void Delegatemethod();
    class Myclass
    {
        public static void display()
        {
            Console.WriteLine("Hello Rabi");
        }
        public static void show()
        {
            Console.WriteLine("Hi budhathoki bhai");
        }
        public  void get()
        {
            Console.WriteLine("Good night!");
        }

        static void Main(string[] args)
        {
            Delegatemethod d1=Myclass.display;
            d1();
            Delegatemethod d2=new Delegatemethod(Myclass.show);
            d2();
            Myclass obj=new Myclass();
            Delegatemethod d3=obj.get;
            d3.Invoke();
        }
    }

}

/*Hello Rabi
Hi budhathoki bhai
Good night!*/
