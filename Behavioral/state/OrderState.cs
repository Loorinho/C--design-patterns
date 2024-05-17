namespace Design_Patterns.Behavioral.state;

public interface IOrderState
{
    void NextOrderState(Order order);
    void PreviousOrderState(Order order);
    void PrintStatus();
    
}