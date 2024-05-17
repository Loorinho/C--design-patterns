// See https://aka.ms/new-console-template for more information

using Design_Patterns.Behavioral.chain_of_responsibility;
using Design_Patterns.Behavioral.observer;
using Design_Patterns.Behavioral.state;
using Design_Patterns.Behavioral.strategy;
using Design_Patterns.Behavioral.template_method;

Console.WriteLine("Hello, World!");

// State design pattern
StateClient sc = new StateClient();
// sc.Run();

//Template method pattern
TemplateMethodClient tm = new TemplateMethodClient();
// tm.Run();

// Chain of responsibility pattern
ChainOfResponsibilityClient crc = new ChainOfResponsibilityClient();
// crc.Run();

// Strategy pattern
StrategyClient spc = new StrategyClient();
// spc.Run();

// Observer pattern
ObserverClient oc = new ObserverClient();
oc.Run();