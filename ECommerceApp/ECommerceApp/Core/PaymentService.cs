namespace ECommerceApp.Core;

public class PaymentService
{
    public bool Pay(decimal amount)
    {
        // BUG 4:
        // Negatif ödeme tutarýný da kabul ediyor.
        if (amount == 0)
            return false;

        return true;
    }
}