// See https://aka.ms/new-console-template for more information

using Design_Patterns.Behavioral.state;
using Design_Patterns.Behavioral.template_method;

Console.WriteLine("Hello, World!");

// State design pattern
StateClient sc = new StateClient();
// sc.Run();

//Template method pattern
TemplateMethodClient tm = new TemplateMethodClient();
tm.Run();