namespace b_delegate_event_2;
#nullable disable
//1:define a delegate

public delegate void TrafficLightChangeHandler(string color);  

public class TrafficLight
{
    //declare event (event is built in refernce)
    public event TrafficLightChangeHandler TrafficLightChanged;
    public void ChangeLight(string color)
    {
        //method that raised the event 
        Console.WriteLine("The Traffic Light is "+color);
        TrafficLightChanged.Invoke(color);
    }
}
public class Car
    {
        public void ReactToLight(string lightcolor)
    {
        //event handling method
        if (lightcolor == "Red")
        {
            Console.WriteLine("Car stops.");
        }else if(lightcolor == "Green")
        {
            Console.WriteLine("Car starts moving.");
        }
    }  
    }
class MainProgram
{
    static void Main(string[] args)
    {
        TrafficLight light=new TrafficLight();
        Car car=new Car();
        //subscribe to the event
        light.TrafficLightChanged +=car.ReactToLight;
        // Trigger the event
        light.ChangeLight("Green");
        light.ChangeLight("Red");
    }
}
