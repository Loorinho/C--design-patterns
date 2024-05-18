namespace Design_Patterns.Structural.composite;

public class CompositeClient
{
    public void Run()
    {
        FileSystemComponent file1 = new File("File1.txt");
        FileSystemComponent file2 = new File("File2.txt");
        FileSystemComponent file3 = new File("File3.txt");

        Directory root = new Directory("Root");
        Directory subDir = new Directory("SubDir");

        root.Add(file1);
        root.Add(subDir);

        subDir.Add(file2);
        subDir.Add(file3);

        root.Display(1);
    }
}