public class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;

    public int GetCost()
    {
        return _price * _quantity;
    }

    public string GetDisplayText()
    {
        return $"{_name}{_productId}";
    }
}