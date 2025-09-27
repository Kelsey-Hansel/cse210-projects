public class Product
{
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;

    public float CalculateCost()
    {
        float productTotalCost = _price * _quantity;
        return productTotalCost;
    }

    public string ReturnProductName()
    {
        return _name;
    }

    public string ReturnProductID()
    {
        return _id;
    }

    public void SetProduct(string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
}