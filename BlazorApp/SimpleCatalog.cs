namespace BlazorApp;

public class SimpleCatalog: ICatalog
{
    private IMyDateTime myDate;
    
    private IList<Product> _products = new List<Product>()
    {
        new Product("Книга Стивена Кинга", 1500, "https://img4.labirint.ru/rc/2f7d48ee73c87a4d16e8385b1a0d413b/220x340/books69/683432/cover.jpg?1564173848"),
        new Product("Книга Бориса Акунина", 1400, "https://img4.labirint.ru/rc/72e9df791abc65b7421717b99f880206/220x340/books76/754834/cover.jpg?1597847102"),
        new Product("Книга Михаила Булгакова", 999, "https://img4.labirint.ru/rc/be52f38894b280fb49d5c6c7ef390287/220x340/books25/244606/cover.jpg?1472463171")
    };

    private IList<Product> _productsAtWeekend = new List<Product>();

    public IList<Product> GetProductList()
    {
        var dateOfWeek = myDate.GetCurrentDate().DayOfWeek;
        if (dateOfWeek == DayOfWeek.Sunday || dateOfWeek == DayOfWeek.Saturday)
        {
            //if (_productsAtWeekend.Count != 0)
                //return _productsAtWeekend;
                
            _productsAtWeekend.Clear();
            foreach (var item in _products)
            {
                _productsAtWeekend.Add(new Product(item.Name, item.Price * 1.5m, item.Url));
            }
            return _productsAtWeekend;
        }

        return _products;
    }

    public SimpleCatalog(IMyDateTime myDate)
    {
        this.myDate = myDate;
    }
}