namespace Design_Patterns.Structural.composite;

//Leaf 
public class File: FileSystemComponent
{
    public File(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
    }
}