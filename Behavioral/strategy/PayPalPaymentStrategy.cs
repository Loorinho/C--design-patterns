namespace Design_Patterns.Behavioral.strategy;

public class PayPalPaymentStrategy: IPaymentStrategy
{
    private string _email;

    public PayPalPaymentStrategy(string email)
    {
        _email = email;
    }

    public void Pay(decimal amount)
    {
        // Implementation of PayPal payment processing
        Console.WriteLine($"Verifying paypal account");
        Console.WriteLine($"Paying {amount:C} using PayPal.");
        Console.WriteLine($"Payment made using paypal");
    }
}