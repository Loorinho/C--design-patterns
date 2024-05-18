namespace Design_Patterns.Structural.composite;

// Composite
public class Directory: FileSystemComponent
{
    private List<FileSystemComponent> _components = new List<FileSystemComponent>();

    public Directory(string name) : base(name) { } // We need to call the constructor of the parent and we pass in the name

    public void Add(FileSystemComponent component)
    {
        _components.Add(component);
    }

    public void Remove(FileSystemComponent component)
    {
        _components.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);

        foreach (var component in _components)
        {
            component.Display(depth + 2);
        }
    }
    
}