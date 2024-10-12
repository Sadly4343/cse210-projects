using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public string GetDisplayText()
    {
        return $"{_name}{_address}";
    }
    public bool ReturnUSResidents()
    {
        if (_address.GetInUS() == true)
        {
            return true;
        }
        return false;
    }
}