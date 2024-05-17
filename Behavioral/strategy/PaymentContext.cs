namespace Design_Patterns.Behavioral.strategy;

public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    // The context is configured with a strategy at runtime
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    // Delegate the payment processing to the strategy
    public void ProcessPayment(decimal amount)
    {
        _paymentStrategy.Pay(amount);
    }
}