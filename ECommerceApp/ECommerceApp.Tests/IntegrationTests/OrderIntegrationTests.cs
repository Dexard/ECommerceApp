using ECommerceApp.Core;

namespace ECommerceApp.Tests.IntegrationTests;

public class OrderIntegrationTests
{
    [Test]
    public void PlaceOrder_ValidCart_ShouldClearCartAfterSuccessfulOrder()
    {
        var cart = new Cart();
        cart.AddProduct(new Product(1, "Laptop", 25000, 5));

        var paymentService = new PaymentService();
        var orderService = new OrderService(paymentService);

        bool result = orderService.PlaceOrder(cart);

        Assert.That(result, Is.True);
        Assert.That(cart.GetProductCount(), Is.EqualTo(0));
    }

    [Test]
    public void PlaceOrder_CartWithMultipleProducts_ShouldCompleteSuccessfully()
    {
        var cart = new Cart();
        cart.AddProduct(new Product(1, "Laptop", 25000, 5));
        cart.AddProduct(new Product(2, "Mouse", 500, 10));

        var paymentService = new PaymentService();
        var orderService = new OrderService(paymentService);

        bool result = orderService.PlaceOrder(cart);

        Assert.That(result, Is.True);
    }
}