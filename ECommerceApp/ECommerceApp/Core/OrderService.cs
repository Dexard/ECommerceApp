namespace ECommerceApp.Core;

public class OrderService
{
    private readonly PaymentService _paymentService;

    public OrderService(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public bool PlaceOrder(Cart cart)
    {
        if (cart == null)
            throw new ArgumentNullException(nameof(cart));

        // BUG 5:
        // Sepet boþ olsa bile sipariþ verilebiliyor.
        decimal total = cart.CalculateTotal();

        bool paymentResult = _paymentService.Pay(total);

        if (paymentResult)
        {
            cart.ClearCart();
            return true;
        }

        return false;
    }
}