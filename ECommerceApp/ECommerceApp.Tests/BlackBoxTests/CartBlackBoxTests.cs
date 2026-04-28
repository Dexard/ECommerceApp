using ECommerceApp.Core;

namespace ECommerceApp.Tests.BlackBoxTests;

public class CartBlackBoxTests
{
    [Test]
    public void AddProduct_OutOfStockProduct_ShouldNotBeAdded()
    {
        var cart = new Cart();
        var product = new Product(1, "Phone", 15000, 0);

        cart.AddProduct(product);

        Assert.That(cart.GetProductCount(), Is.EqualTo(0));
    }

    [Test]
    public void RemoveProduct_NotExistingProduct_ShouldThrowException()
    {
        var cart = new Cart();

        Assert.Throws<InvalidOperationException>(() => cart.RemoveProduct(99));
    }

    [Test]
    public void CalculateTotal_EmptyCart_ShouldReturnZero()
    {
        var cart = new Cart();

        Assert.That(cart.CalculateTotal(), Is.EqualTo(0));
    }
}