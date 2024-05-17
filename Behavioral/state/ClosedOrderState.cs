namespace Design_Patterns.Behavioral.state;

public class ClosedOrderState: IOrderState
{
    public void NextOrderState(Order order)
    {
        // throw new NotImplementedException();
        Console.WriteLine($"This is the final state of the order");
    }

    public void PreviousOrderState(Order order)
    {
        order.SetState(new ShippedOrderState());
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order has been delivered.");
    }
}