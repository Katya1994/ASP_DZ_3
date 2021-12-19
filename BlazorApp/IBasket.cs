namespace BlazorApp;

public interface IBasket
{
    public void AddToBasket(Product product);
    public IDictionary<Product, int> GetBasketProducts();
    public void ClearBasket();
}