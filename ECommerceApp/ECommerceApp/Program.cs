using ECommerceApp.Core;

var product = new Product(1, "Laptop", 25000, 5);

var cart = new Cart();
cart.AddProduct(product);

var paymentService = new PaymentService();
var orderService = new OrderService(paymentService);

bool result = orderService.PlaceOrder(cart);

Console.WriteLine(result ? "Sipariş başarılı." : "Sipariş başarısız.");