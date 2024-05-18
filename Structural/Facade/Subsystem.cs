namespace Design_Patterns.Structural.Facade;

class Amplifier1
{
 public void On() => Console.WriteLine("Amplifier on");
 public void Off() => Console.WriteLine("Amplifier off");
 public void SetVolume(int level) => Console.WriteLine($"Amplifier setting volume to {level}");
}

class Tuner1
{
 public void On() => Console.WriteLine("Tuner on");
 public void Off() => Console.WriteLine("Tuner off");
 public void SetFrequency(double frequency) => Console.WriteLine($"Tuner setting frequency to {frequency}");
}

class DvdPlayer3
{
 public void On() => Console.WriteLine("DVD Player on");
 public void Off() => Console.WriteLine("DVD Player off");
 public void Play(string movie) => Console.WriteLine($"DVD Player playing \"{movie}\"");
}