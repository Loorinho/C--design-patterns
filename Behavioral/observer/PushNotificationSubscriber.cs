namespace Design_Patterns.Behavioral.observer;

public class PushNotificationSubscriber: ISubscriber
{
    private string _deviceToken;

    public PushNotificationSubscriber(string deviceToken)
    {
        _deviceToken = deviceToken;
    }

    public void Update(string message)
    {
        Console.WriteLine($"Push notification to device {_deviceToken}: {message}");
    }
}