using System.Numerics;

public class Order
{
    private Customer _customer;
    private List<Product> _products;


    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetDisplayText()}";
    }

    public string GetPackingLabel()
    {
        string productlabel = "";
        foreach (Product product in _products)
        {
            productlabel += product.GetDisplayText();
        }
        return productlabel;
    }

    public int GetTotalCost()
    {
        int totals = 0;
        foreach (Product product in _products)
        {
            totals += product.GetCost();
        }
        if (_customer.ReturnUSResidents() == false)
        {
            totals += 5;
        }
        else
        {
            totals += 35;
        }
        return totals;
    }



}