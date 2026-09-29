using System.Diagnostics.Contracts;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalProducts()
    {
        double total = 0;
        foreach (Product item in _products)
        {
            total += item.totalCostProduct();
        }
        return total;
    }

    public double shippingCost()
    {
       if (_customer.UsaCountry())
        {
            return 5;
        }
        return 35;
    }

    public double total()
    {
        Console.WriteLine($"SubTotal: {TotalProducts()}");
        Console.WriteLine($"Shipping Cost: {shippingCost()}");
        return TotalProducts() + shippingCost();
    }

    public void packingLabel()
    {
        foreach (Product item in _products)
        {
            Console.WriteLine($"{item.GetName()} | {item.GetProductId()} | {item.GetQuantity()} | {item.GetPrice()}");
        }
    }

    public void shippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress()}");
    }
}