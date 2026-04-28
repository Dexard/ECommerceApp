namespace ECommerceApp.Core;

public class Cart
{
    private readonly List<Product> _products = new();

    public IReadOnlyList<Product> Products => _products;

    public void AddProduct(Product product)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        // BUG 1:
        // Stok 0 olsa bile ürün sepete ekleniyor.
        _products.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        var product = _products.FirstOrDefault(p => p.Id == productId);

        // BUG 2:
        // Ürün bulunamazsa hata fýrlatmýyor, sessizce geçiyor.
        if (product != null)
            _products.Remove(product);
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;

        foreach (var product in _products)
        {
            total += product.Price;
        }

        // BUG 3:
        // Toplam tutara gereksiz +10 ekleniyor.
        return total + 10;
    }

    public int GetProductCount()
    {
        return _products.Count;
    }

    public void ClearCart()
    {
        _products.Clear();
    }
}