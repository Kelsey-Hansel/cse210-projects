public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public bool IsUSA()
    {
        bool isUSA = _country == "USA";
        return isUSA;
    }

    public string ReturnFullAddress()
    {

        string fullAddress = $"{_street} \n{_city}, {_state} \n{_country}";
        return fullAddress;
    }

    public Address()
    {
        
    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
}