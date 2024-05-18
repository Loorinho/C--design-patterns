namespace Design_Patterns.Structural.composite;

//Component --  which is like the common interface the client will work with
public abstract class FileSystemComponent
{
    protected string Name; // protected so that we can access this variable in the subclass

    public FileSystemComponent(string name)
    {
        this.Name = name;
    }

    public abstract void Display(int depth);
    
}