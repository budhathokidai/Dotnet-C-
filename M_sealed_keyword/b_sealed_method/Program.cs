namespace b_sealed_method;
class Utensils
{
    public virtual void Sound()  //only a virtual method can be overridden in a child class.
    {
        Console.WriteLine("Utensils makes a sound when we drop from high.");
    }
}

class Plate :Utensils
{
    public sealed override void Sound()
    {
        Console.WriteLine("Plate makes sound.");
    }
}

class Bowl: Plate
{
    //A sealed method cannot be overridden further
}

class Program
{
    static void Main()
    {
        Plate d = new Plate();
        d.Sound();
    }
}

//Plate makes sound.