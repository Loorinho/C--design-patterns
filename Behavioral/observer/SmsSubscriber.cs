namespace Design_Patterns.Behavioral.observer;

public class SmsSubscriber: ISubscriber
{
    private string _phoneNumber;

    public SmsSubscriber(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
    }

    public void Update(string message)
    {
        Console.WriteLine($"SMS to {_phoneNumber}: {message}");
    }
}