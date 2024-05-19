namespace Design_Patterns.Creational.prototype;

// This is the Prototype
public abstract class Person
{
    protected Person(string name) // protected so that we only access it via the subclasses
    {
        Name = name;
    }

    public string Name { get; set; }

    public abstract Person Clone();
}