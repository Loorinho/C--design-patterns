namespace Design_Patterns.Structural.Facade;

public class DvdPlayer
{
    public void On() => Console.WriteLine("DVD Player on");
    public void Off() => Console.WriteLine("DVD Player off");
    public void Play(string movie) => Console.WriteLine($"DVD Player playing \"{movie}\"");
}