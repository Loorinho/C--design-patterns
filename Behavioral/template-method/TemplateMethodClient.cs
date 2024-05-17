namespace Design_Patterns.Behavioral.template_method;

public class TemplateMethodClient
{
    public void Run()
    {
        House wooden = new WoodenHouse();
        wooden.BuildHouse();
    }
}