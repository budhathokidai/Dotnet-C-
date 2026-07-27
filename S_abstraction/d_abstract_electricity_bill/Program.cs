namespace d_abstract_electricity_bill;
public abstract class ElectricityPlan
{
    protected double rate;

    // Abstract method
    public abstract void GetRate();

    // Normal method
    public void CalculateBill(int units)
    {
        Console.WriteLine("Total Bill for {0} units = Rs. {1}", units, units * rate);
    }
}
class DomesticPlan : ElectricityPlan
{
    public override void GetRate()
    {
        rate = 8;
    }
}
class CommercialPlan : ElectricityPlan
{
    public override void GetRate()
    {
        rate = 12;
    }
}
class IndustrialPlan : ElectricityPlan
{
    public override void GetRate()
    {
        rate = 15;
    }
}
class Program
{
    static void Main(string[] args)
    {
        ElectricityPlan customer;

        customer = new DomesticPlan();
        customer.GetRate();
        customer.CalculateBill(100);

        customer = new CommercialPlan();
        customer.GetRate();
        customer.CalculateBill(100);

        customer = new IndustrialPlan();
        customer.GetRate();
        customer.CalculateBill(100);
    }
}

/*Total Bill for 100 units = Rs. 800
Total Bill for 100 units = Rs. 1200
Total Bill for 100 units = Rs. 1500*/