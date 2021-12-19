namespace BlazorApp;

public class SimpleBasket: IBasket
{
    private IDictionary<Product, int> basketProducts = new Dictionary<Product, int>();
    private object locker = new object();
        
    public void AddToBasket(Product product)
    {
        lock (locker)
        {
            if (basketProducts.ContainsKey(product))
                basketProducts[product]++;
            else
                basketProducts.Add(product, 1);
        }
    }

    public IDictionary<Product, int> GetBasketProducts()
    {
        return basketProducts;
    }

    public void ClearBasket()
    {
        basketProducts.Clear();
    }
}