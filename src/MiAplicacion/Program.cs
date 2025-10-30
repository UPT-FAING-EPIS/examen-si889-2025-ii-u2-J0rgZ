using MiAplicacion;

Console.WriteLine("--- Running Order Facade Demo ---");
var facade = new OrderFacade();
facade.PlaceOrder("P001", "C123", 99.99m, "123 Main St");