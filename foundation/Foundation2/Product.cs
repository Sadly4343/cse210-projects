public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public double GetCost()
    {
        return 1.1;
    }

    public string GetDisplayText()
    {
        return "";
    }
}