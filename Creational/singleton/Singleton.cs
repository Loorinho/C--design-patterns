namespace Design_Patterns.Creational.singleton;

public class Singleton
{
    private static Singleton _instance;
    private static readonly object _lockObj = new object();

    private Singleton() {
        // Private constructor to prevent instantiation
    }

    public static Singleton GetInstance()
    {
            if (_instance == null) {
                lock (_lockObj) {
                    if (_instance == null) {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
            }
}