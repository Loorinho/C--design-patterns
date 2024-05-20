namespace Design_Patterns.Creational.prototype;

public class Student: Person
{
    // This is the concrete prototype 2
    
    public Teacher Teacher {get;
        set;
    }
    
    // mine
    private Student _st;

    public Student(string name, Teacher teacher) : base(name)
    {
        Teacher = teacher;
    }
    
    // private Student(Person student) 
    // {
    //     _st = student;
    // }

    public override Person Clone()
    {
        /**
           * A shallow copy only copies primitive types
           * return (Person)MemberwiseClone();
           *
           * To solve this issue, we do a deep copy which copies the reference types as well
           *
       */
        
        // Correct way
        Student studentClone = (Student)MemberwiseClone();
        
        // Here we are now creating a new copy of the Teacher object and we are not referencing the old one
        studentClone.Teacher = new Teacher(this.Teacher.Name, this.Teacher.Course);
        return studentClone;
        
        // My own
        // return new Student(this);
    }
}