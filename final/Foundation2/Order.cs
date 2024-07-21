using System.Text;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.TotalCost();
        }

       if (_customer.USA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string PackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in _products)
        {
            packingLabel.AppendLine($"Product: {product.Name}  (ID:{product.ProductId})");
        }
        return packingLabel.ToString();
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address.FullAddress()}";
    }
}
