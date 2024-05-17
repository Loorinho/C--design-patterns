namespace Design_Patterns.Behavioral.state;

public class NewOrderState: IOrderState
{
    public void NextOrderState(Order order)
    {
        order.SetState(new ProcessingOrderState());
    }

    public void PreviousOrderState(Order order)
    {
        Console.WriteLine($"Cannot go back to the new order state ");
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is in new state.");
    }
}