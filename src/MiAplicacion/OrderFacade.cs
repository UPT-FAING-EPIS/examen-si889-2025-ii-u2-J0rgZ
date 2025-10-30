namespace MiAplicacion;
public class OrderFacade
{
    private readonly InventoryService _inventoryService = new();
    private readonly PaymentService _paymentService = new();
    private readonly ShippingService _shippingService = new();

    public bool PlaceOrder(string productId, string customerId, decimal amount, string address)
    {
        Console.WriteLine("\nStarting order placement using Facade...");

        if (!_inventoryService.CheckStock(productId))
        {
            Console.WriteLine("Order failed: Product out of stock.");
            return false;
        }

        if (!_paymentService.ProcessPayment(customerId, amount))
        {
            Console.WriteLine("Order failed: Payment processing failed.");
            return false;
        }

        _shippingService.ShipProduct(productId, address);
        Console.WriteLine("Order placed successfully!");
        return true;
    }
}