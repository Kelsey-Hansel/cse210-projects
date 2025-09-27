public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public float TotalCost()
    {
        float runningTotalCost = 0.00f;
        foreach (Product product in _products)
        {
            runningTotalCost += product.CalculateCost();
        }

        Address country = new Address();
        bool inUSA = country.IsUSA();
        int shippingFee = 0;
        if (inUSA == true)
        {
            shippingFee = 5;
        }
        else
        {
            shippingFee = 35;
        }
        float totalCost = runningTotalCost + shippingFee;

        return totalCost;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.ReturnProductName()} ID: {product.ReturnProductID()} ");
        }

        float totalCost = TotalCost();
        Console.WriteLine($"Total Cost: ${totalCost:F2}");
        Console.WriteLine();
    }

    public void DisplayShippingLabel()
    {
        Address fullAddress = new Address();

        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetFullAddress()}");
        Console.WriteLine();
    }

    public void MakeProductList(string name, string id, float price, int quantity)
    {
        Product product = new Product();
        product.SetProduct(name, id, price, quantity);
        _products.Add(product);
    }

    public void MakeCustomer(string name, string street, string city, string state, string country)
    {
        _customer = new Customer(name, street, city, state, country);
    }
}