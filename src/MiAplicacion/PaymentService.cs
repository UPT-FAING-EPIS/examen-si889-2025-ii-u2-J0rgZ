namespace MiAplicacion;
public class PaymentService
{
    public bool ProcessPayment(string customerId, decimal amount)
    {
        Console.WriteLine($"Processing payment for {customerId} of amount {amount}...");
        return true;
    }
}