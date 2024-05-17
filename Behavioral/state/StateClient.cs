namespace Design_Patterns.Behavioral.state;

public class StateClient
{
    public void Run()
    {
        Order order = new Order();

        order.PrintStatus();
        order.Next();
        order.PrintStatus();
        order.Next();
        order.PrintStatus();
        order.Next();
        order.PrintStatus();
        order.Next();
        order.PrintStatus();
        order.Prev();
        order.PrintStatus();
    }
}