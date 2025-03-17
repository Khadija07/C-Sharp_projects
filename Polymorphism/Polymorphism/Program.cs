namespace Polymorphism;


// Interface defined
public interface IPayment
{
    void ProcessPayment(decimal amount);
}

//derived class
public class CreditCardProcessor : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Credit card processing: ${amount}");
    }
}

public class PayPalProcessor : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"PayPal card processing: ${amount}");
    }
}

public class PaymentService
{
    /// <summary> a private, read-only field _payment of type IPayment. This means it stores a reference to an object that implements IPayment </summary>
    /// <param name="_payment"></param>
    /// <returns> store a reference to any class/object that implements IPayment</returns>
    private readonly IPayment _payment;  

    public PaymentService(IPayment payment)
    {
        _payment = payment;
    }
    
    
    //this will process the payment for whichever class is assigned in _payment
    public void ProcessPayment(decimal amount)
    {
        _payment.ProcessPayment(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        //implementing polymorphism
        IPayment creditcard = new CreditCardProcessor();   //runtime polymorphism
        PaymentService service = new PaymentService(creditcard); //_payment is now assigned with creditcard class
        service.ProcessPayment(100.00m); //it calls the ProcessPayment method of CreditCard
        
        
        IPayment paypal = new PayPalProcessor();
        service = new PaymentService(paypal);   //now we have assigned different class to service object
        service.ProcessPayment(100.00m); //now it calls the ProcessPayment method of PayPal
        
    }
}