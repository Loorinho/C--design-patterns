namespace Design_Patterns.Creational.factory_method;

public class PayByCreditCard: IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} to merchant using credit card");
    }
}