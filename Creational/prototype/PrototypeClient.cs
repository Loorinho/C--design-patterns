namespace Design_Patterns.Creational.prototype;

public class PrototypeClient
{
    public void Run()
    {
        Teacher teacher = new Teacher("Loorinho", "Design patterns");
        
        // Creating a clone by invoking the clone() of the teacher object
        Teacher teacherClone = (Teacher)teacher.Clone();

        Console.WriteLine($"Teacher was cloned: {teacherClone.Name} who teaches '{teacherClone.Course}' ");

        Student student = new Student("Jacobson", teacherClone);

        // creating a student clone
        Student studentClone = (Student)student.Clone();
        Console.WriteLine($"Student was cloned: {studentClone.Name}  who is enrolled in {studentClone.Teacher.Course} taught by {studentClone.Teacher.Name} ");

        
        // To bring out the concept of shallow copy and why it is somewhat bad(given it does not copy reference types,

        teacherClone.Name = "Ziggy"; // changing the teacher clone's teacher name
        Console.WriteLine($"Student was cloned: {studentClone.Name}  who is enrolled in {studentClone.Teacher.Course} taught by {studentClone.Teacher.Name} ");

    }
}