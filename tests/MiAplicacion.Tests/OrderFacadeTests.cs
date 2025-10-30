using Xunit;
using System;
using System.IO;
using MiAplicacion; // ¡Importante! Para acceder a las clases de tu aplicación

public class OrderFacadeTests
{
    [Fact]
    public void PlaceOrder_ExecutesAllStepsSuccessfully()
    {
        // Arrange
        var sw = new StringWriter();
        Console.SetOut(sw); // Redirige la salida de la consola para poder verificarla
        var orderFacade = new OrderFacade();

        // Act
        bool result = orderFacade.PlaceOrder("P001", "C123", 99.99m, "123 Main St");

        // Assert
        var output = sw.ToString();
        Assert.True(result);
        Assert.Contains("Checking stock", output);
        Assert.Contains("Processing payment", output);
        Assert.Contains("Shipping", output);
        Assert.Contains("Order placed successfully!", output);
    }
}