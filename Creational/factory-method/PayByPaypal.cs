namespace Design_Patterns.Creational.factory_method;

public class PayByPaypal: IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} to merchant using paypal");
    }
}