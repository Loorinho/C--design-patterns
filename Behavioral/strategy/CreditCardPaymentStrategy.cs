namespace Design_Patterns.Behavioral.strategy;

public class CreditCardPaymentStrategy: IPaymentStrategy
{
    private string _cardNumber;
    private string _cardHolderName;
    private string _expiryDate;
    private string _cvv;

    public CreditCardPaymentStrategy(string cardNumber, string cardHolderName, string expiryDate, string cvv)
    {
        _cardNumber = cardNumber;
        _cardHolderName = cardHolderName;
        _expiryDate = expiryDate;
        _cvv = cvv;
    }

    public void Pay(decimal amount)
    {
        // Implementation of credit card payment processing
        Console.WriteLine("Verifying card details");
        Console.WriteLine($"Paying {amount:C} using Credit Card.");
        Console.WriteLine($"Paid using credit card");
    }
    
}