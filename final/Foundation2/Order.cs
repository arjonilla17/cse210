public class Order{
    private List<Product> products;
    public Customer Customer { get; set; }

    public Order()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in products)
        {
            totalPrice += product._price * product._quantity;
        }

        totalPrice += Customer._address.IsInUSA() ? 5 : 35;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"Product Name: {product._name}, Product ID: {product._product}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + Customer._address.GetAddressInfo();
    }}