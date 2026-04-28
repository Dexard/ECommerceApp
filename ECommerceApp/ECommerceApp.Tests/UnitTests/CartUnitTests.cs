using NUnit.Framework;
using ECommerceApp.Core;

namespace ECommerceApp.Tests.UnitTests;

public class CartUnitTests
{
    [Test]
    public void AddProduct_ValidProduct_ProductCountShouldBeOne()
    {
        var cart = new Cart();
        var product = new Product(1, "Mouse", 500, 10);

        cart.AddProduct(product);

        Assert.That(cart.GetProductCount(), Is.EqualTo(1));
    }

    [Test]
    public void AddProduct_NullProduct_ShouldThrowArgumentNullException()
    {
        var cart = new Cart();

        Assert.Throws<ArgumentNullException>(() => cart.AddProduct(null));
    }

    [Test]
    public void CalculateTotal_TwoProducts_ShouldReturnCorrectTotal()
    {
        var cart = new Cart();

        cart.AddProduct(new Product(1, "Keyboard", 1000, 5));
        cart.AddProduct(new Product(2, "Mouse", 500, 10));

        Assert.That(cart.CalculateTotal(), Is.EqualTo(1500));
    }

    [Test]
    public void RemoveProduct_ExistingProduct_ProductCountShouldDecrease()
    {
        var cart = new Cart();
        var product = new Product(1, "Monitor", 4000, 3);

        cart.AddProduct(product);
        cart.RemoveProduct(1);

        Assert.That(cart.GetProductCount(), Is.EqualTo(0));
    }
}