using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        if (customer == null)
        {
            throw new ArgumentNullException(nameof(customer), "Customer cannot be null");
        }
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product), "Product cannot be null");
        }
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += p.GetLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetCustomerAddress()}";
    }

    public double GetTotalCost()
    {
        double productTotal = 0;
        foreach (Product p in _products)
        {
            productTotal += p.GetTotalPrice();
        }

        double shippingFee = _customer.IsKenyaResidentialArea() ? 5 : 35;
        return productTotal + shippingFee;
    }
}
