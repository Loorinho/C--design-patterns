namespace Design_Patterns.Behavioral.chain_of_responsibility;

public class ChainOfResponsibilityClient
{
    public void Run()
    {
        // Create handlers
        QueryHandler operatorHandler = new OperatorHandler();
        QueryHandler supervisorHandler = new SupervisorHandler();
        QueryHandler managerHandler = new ManagerHandler();

        // Set up chain of responsibility
        operatorHandler.SetNextHandler(supervisorHandler);
        supervisorHandler.SetNextHandler(managerHandler);

        // Make calls
        Console.WriteLine("Client: I have a simple issue.");
        operatorHandler.HandleCall("simple issue");

        Console.WriteLine("\nClient: I have a moderate issue.");
        operatorHandler.HandleCall("moderate issue");

        Console.WriteLine("\nClient: I have a complex issue.");
        operatorHandler.HandleCall("complex issue");

        Console.WriteLine("\nClient: I have an unknown issue.");
        operatorHandler.HandleCall("unknown issue");
    } 
}