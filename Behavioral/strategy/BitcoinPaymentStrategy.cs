namespace Design_Patterns.Behavioral.strategy;

public class BitcoinPaymentStrategy: IPaymentStrategy
{
    private string _walletAddress;

    public BitcoinPaymentStrategy(string walletAddress)
    {
        _walletAddress = walletAddress;
    }

    public void Pay(decimal amount)
    {
        // Implementation of Bitcoin payment processing
        Console.WriteLine($"Verifying bitcoin wallet details");
        Console.WriteLine($"Paying {amount:C} using Bitcoin.");
        Console.WriteLine($"Paid using bitcoin");
    }
    
}