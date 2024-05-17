namespace Design_Patterns.Behavioral.state;

public class Order
{
    private IOrderState _currentState;
    
    // public Order(OrderState currentState)
    public Order()
    {
        this._currentState = new NewOrderState();
    }

    public void SetState(IOrderState state) {
        _currentState = state;
    }

    public IOrderState GetState() {
        return _currentState;
    }

    public void Next() {
        _currentState.NextOrderState(this);
    }

    public void Prev() {
        _currentState.PreviousOrderState(this);
        Console.WriteLine($"The order is in its default state. No previous state");
    }

    public void PrintStatus() {
        _currentState.PrintStatus();
    }
}