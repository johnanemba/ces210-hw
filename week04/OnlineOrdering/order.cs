using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double ComputeTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.CalculateTotalCost();
        }
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GeneratePackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetLabel() + "\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        return "Shipping Label:\n" + _customer.RetrieveShippingDetails();
    }
}
