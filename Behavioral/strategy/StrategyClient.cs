namespace Design_Patterns.Behavioral.strategy;

public class StrategyClient
{
    public void Run()
    {
        PaymentContext context = new PaymentContext();

        // Use Credit Card payment strategy
        context.SetPaymentStrategy(new CreditCardPaymentStrategy("1234567890123456", "John Doe", "12/25", "123"));
        context.ProcessPayment(100.00m);

        Console.WriteLine("==========================================================");

        // Use PayPal payment strategy
        context.SetPaymentStrategy(new PayPalPaymentStrategy("john.doe@example.com"));
        context.ProcessPayment(200.00m);
        
        Console.WriteLine("==========================================================");


        // Use Bitcoin payment strategy
        context.SetPaymentStrategy(new BitcoinPaymentStrategy("1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa"));
        context.ProcessPayment(300.00m);
    }
}