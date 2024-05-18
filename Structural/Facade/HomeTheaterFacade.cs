namespace Design_Patterns.Structural.Facade;

public class HomeTheaterFacade
{
    
    // These are the 3 subsystem classes
    private Amplifier _amplifier;
    private Tuner _tuner;
    private DvdPlayer _dvdPlayer;

    public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvd)
    {
        _amplifier = amp;
        _tuner = tuner;
        _dvdPlayer = dvd;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _amplifier.On();
        _amplifier.SetVolume(5);
        _dvdPlayer.On();
        _dvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theater down...");
        _dvdPlayer.Off();
        _amplifier.Off();
    }
}