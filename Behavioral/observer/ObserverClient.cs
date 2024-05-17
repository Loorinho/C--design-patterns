namespace Design_Patterns.Behavioral.observer;

public class ObserverClient
{
    public void Run()
    {
        // Create the publisher
        NewsPublisher publisher = new NewsPublisher();

        // Create subscribers
        ISubscriber emailSubscriber = new EmailSubscriber("subscriber1@example.com");
        ISubscriber smsSubscriber = new SmsSubscriber("123-456-7890");
        ISubscriber pushSubscriber = new PushNotificationSubscriber("deviceToken123");

        // Attach subscribers to the publisher
        publisher.Subscribe(emailSubscriber);
        publisher.Subscribe(smsSubscriber);
        publisher.Subscribe(pushSubscriber);

        // Publish news
        publisher.PublishNews("Breaking News: Observer pattern implemented in C#!");

        // Detach a subscriber and publish news again
        publisher.Unsubscribe(smsSubscriber);
        publisher.PublishNews("Update: SMS subscriber detached.");
    }
}