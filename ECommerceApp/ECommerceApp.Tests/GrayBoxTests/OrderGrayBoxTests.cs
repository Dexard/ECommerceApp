using ECommerceApp.Core;

namespace ECommerceApp.Tests.GrayBoxTests;

public class OrderGrayBoxTests
{
    [Test]
    public void PlaceOrder_EmptyCart_ShouldReturnFalse()
    {
        var cart = new Cart();
        var paymentService = new PaymentService();
        var orderService = new OrderService(paymentService);

        bool result = orderService.PlaceOrder(cart);

        Assert.That(result, Is.False);
    }

    [Test]
    public void Payment_NegativeAmount_ShouldReturnFalse()
    {
        var paymentService = new PaymentService();

        bool result = paymentService.Pay(-100);

        Assert.That(result, Is.False);
    }
}