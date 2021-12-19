namespace BlazorApp;

public interface ICatalog
{
    IList<Product> GetProductList();
}