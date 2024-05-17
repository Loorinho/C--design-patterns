namespace Design_Patterns.Behavioral.observer;

public interface IPublisher
{
    void Subscribe(ISubscriber subscriber);
    void Unsubscribe(ISubscriber subscriber);
    void Notify(string message);
}