public class Customer
{
    private string _name;
    private Address _address;

    public string GetName()
    {
        return _name;
    }

    public bool DetermineCountry()
    {
        bool isUSA = _address.IsUSA();
        return false;
    }

    public string GetFullAddress()
    {
       string fullAddress = _address.ReturnFullAddress();
        return fullAddress;
    }

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }
}