namespace Design_Patterns.Creational.factory_method;

public class FactoryMethodClient
{
    public void Run()
    {
        IPayment payment1 = PaymentFactory.MakePayment(PaymentMethodEnum.Mobilemoney);
        payment1.Pay(1000.00);
        
        IPayment payment2 = PaymentFactory.MakePayment(PaymentMethodEnum.Creditcard);
        payment2.Pay(400.00);
        
        IPayment payment3 = PaymentFactory.MakePayment(PaymentMethodEnum.Paypal);
        payment3.Pay(1000.00);
        
        // IPayment payment4 = PaymentFactory.MakePayment(PaymentMethodEnum.Cash);
        // payment4.Pay(1000.00);
    }
}