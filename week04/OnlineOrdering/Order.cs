using System.Reflection.Emit;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
       
    }

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }


    public string TotalOrderCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.ProductCost();
        }
        
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return $"Total: ${total:F2}";
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"ID: {product.GetID()}, {product.GetName()}\n";

        }
        return $"Products ordered:\n{label}";
    }

    public string ShippingLabel()
    {
        return $"Shipping adress:\n{_customer.GetName()}\n{_customer.GetAddress().DisplayAdress()}";
    }
}