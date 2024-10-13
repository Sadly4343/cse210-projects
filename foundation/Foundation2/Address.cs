public class Address
{
    private string _streetAdd;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAdd = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetDisplayText()
    {
        return $"{_streetAdd} {_city} {_state} {_country}";
    }

    public bool GetInUS()
    {
        if (_country == "usa")
        {
            return true;
        }
        return false;

    }
}
