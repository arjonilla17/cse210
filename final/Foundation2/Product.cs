public class Product{
    public string _name { get; set; }
    public string _product { get; set; }
    public double _price { get; set; }
    public int _quantity { get; set; }

    public Product(string name, string product, double price, int quantity)
    {
        _name = name;
        _product = product;
        _price = price;
        _quantity = quantity;
    }
}