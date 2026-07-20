namespace c_inheritance_multilevel;
class Shop
{
    public void step_1()
    {
        Console.WriteLine("This is Shop!");
    }
}
class Shopkeeper : Shop
{
    public void step_2()
    {
        Console.WriteLine("Shopkeeper can acces the shop");
    }
}
class Product : Shopkeeper
{
    public void step_3()
    {
        Console.WriteLine("Shopkeeper can only access the product!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Product p=new Product();
        p.step_1();
        p.step_2();
        p.step_3();
        
    }
}
/*This is Shop!
Shopkeeper can acces the shop
Shopkeeper can only access the product!*/