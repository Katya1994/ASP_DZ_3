namespace BlazorApp;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Url { get; set; }
    public Product(string name, decimal price, string url)
    {
        Name = name;
        Price = price;
        Url = url;
    }
}