public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public string GetShippingLabel()
    {
        return "";
    }

    public string GetPackingLabel()
    {
        return "";
    }

    public string GetTotalCost()
    {
        return "";
    }
}