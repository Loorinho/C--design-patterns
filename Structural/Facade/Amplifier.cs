namespace Design_Patterns.Structural.Facade;

public class Amplifier
{
    public void On() => Console.WriteLine("Amplifier on");
    public void Off() => Console.WriteLine("Amplifier off");
    public void SetVolume(int level) => Console.WriteLine($"Amplifier setting volume to {level}");
}