namespace Design_Patterns.Creational.factory_method;

public class PaymentFactory
{
    public static IPayment MakePayment(PaymentMethodEnum paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethodEnum.Creditcard:
                return new PayByCreditCard();
            
            case PaymentMethodEnum.Mobilemoney:
                return new PayByMobileMoney();
            
            case PaymentMethodEnum.Paypal:
                return new PayByPaypal();
            
            default:
                throw new NotSupportedException($"{paymentMethod} not supported at the moment");
        }
        
    }
}