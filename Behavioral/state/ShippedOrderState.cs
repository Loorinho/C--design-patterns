namespace Design_Patterns.Behavioral.state;

public class ShippedOrderState: IOrderState
{
    public void NextOrderState(Order order)
    {
        order.SetState(new ClosedOrderState());
    }

    public void PreviousOrderState(Order order)
    {
        order.SetState(new ProcessingOrderState());
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order has been shipped.");
    }
}