namespace Design_Patterns.Creational.prototype;

public class Teacher: Person
{
    // This is the concrete prototype one
    public string  Course { get; set; }

    public Teacher(string name, string course) : base(name)
    {
        Course = course;
    }

    public override Person Clone()
    {
        return (Person)MemberwiseClone(); // this line alone creates a shallow copy of the current objeect
    }
}