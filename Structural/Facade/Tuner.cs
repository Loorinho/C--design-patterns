namespace Design_Patterns.Structural.Facade;

public class Tuner
{
    public void On() => Console.WriteLine("Tuner on");
    public void Off() => Console.WriteLine("Tuner off");
    public void SetFrequency(double frequency) => Console.WriteLine($"Tuner setting frequency to {frequency}");

}