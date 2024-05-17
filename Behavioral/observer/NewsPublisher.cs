namespace Design_Patterns.Behavioral.observer;

public class NewsPublisher: IPublisher
{
    private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify(string message)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(message);
        }
    }

    // Additional method to simulate news updates
    public void PublishNews(string news)
    {
        Console.WriteLine($"Publishing news: {news}");
        Notify(news);
    }
}