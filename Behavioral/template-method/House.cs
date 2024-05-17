namespace Design_Patterns.Behavioral.template_method;

public abstract class House
{
     public void BuildHouse(){
         BuildFoundation();
        BuildPillars();
        BuildWalls();
        BuildWindows();
        BuildRoof();
        Console.WriteLine("House is built");
    }

    private void BuildFoundation() {
        Console.WriteLine("Building foundation for the house");
    }

    private void BuildRoof() {
        Console.WriteLine("Building house roof");
    }

    protected abstract void BuildWalls();
    protected abstract void BuildPillars();
    protected abstract void BuildWindows();
    
}