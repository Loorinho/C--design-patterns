namespace Design_Patterns.Behavioral.state;

public class ProcessingOrderState: IOrderState
{
    public void NextOrderState(Order order)
    {
        order.SetState(new ShippedOrderState());
    }

    public void PreviousOrderState(Order order)
    {
        order.SetState(new NewOrderState());
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is being processed.");
    }
}