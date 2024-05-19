// See https://aka.ms/new-console-template for more information

using Design_Patterns.Behavioral.chain_of_responsibility;
using Design_Patterns.Behavioral.observer;
using Design_Patterns.Behavioral.state;
using Design_Patterns.Behavioral.strategy;
using Design_Patterns.Behavioral.template_method;
using Design_Patterns.Creational.factory_method;
using Design_Patterns.Creational.singleton;
using Design_Patterns.Structural.composite;
using Design_Patterns.Structural.decorator;
using Design_Patterns.Structural.Facade;

// Creational design patterns

// Factory method pattern
FactoryMethodClient fm = new FactoryMethodClient();
// fm.Run();

// Singleton design pattern
SingletonClient stp = new SingletonClient();
stp.Run(); 

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
// oc.Run();



// Structural design patterns


// Composite pattern
CompositeClient cp = new CompositeClient();
// cp.Run();


// Decorator pattern
DecoratorClient dc = new DecoratorClient();
// dc.Run();

//Facade pattern
FacadeClient fp = new FacadeClient();
// fp.Run();

