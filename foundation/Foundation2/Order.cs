using System.Numerics;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public string GetShippingLabel()
    {
        return $"{_customer.GetDisplayText()}";
    }

    public string GetPackingLabel()
    {
        return $"{_products}";
    }

    public int GetTotalCost()
    {
        int totals = 0;
        foreach (Product product in _products)
        {
            if (_customer.ReturnUSResidents() == false)
            {
                totals += product.GetCost() + 5;
            }
            else
            {
                totals += product.GetCost() + 35;
            }

        }
        return totals;


    }
}