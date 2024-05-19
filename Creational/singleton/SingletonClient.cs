namespace Design_Patterns.Creational.singleton;

public class SingletonClient
{
    public void Run()
    {
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        Console.WriteLine(s1 == s2);
        
    }
}