namespace Design_Patterns.Behavioral.observer;

public class EmailSubscriber: ISubscriber
{
    private string _email;

    public EmailSubscriber(string email)
    {
        _email = email;
    }

    public void Update(string message)
    {
        Console.WriteLine($"Email to {_email}: {message}");
    }
}