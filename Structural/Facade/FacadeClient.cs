namespace Design_Patterns.Structural.Facade;

public class FacadeClient
{
    public void Run()
    {
        Amplifier amp = new Amplifier();
        Tuner tuner = new Tuner();
        DvdPlayer dvd = new DvdPlayer();

        HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd);

        homeTheater.WatchMovie("Inception");
        homeTheater.EndMovie();
    }
}