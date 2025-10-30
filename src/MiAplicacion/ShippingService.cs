namespace MiAplicacion;
public class ShippingService
{
    public void ShipProduct(string productId, string address)
    {
        Console.WriteLine($"Shipping {productId} to {address}...");
    }
}