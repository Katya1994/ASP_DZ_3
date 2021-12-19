using BlazorApp;
using BlazorApp.Pages;
using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    SimpleBasket basket = new SimpleBasket();
    Product p = new Product("Хлеб", 99m, "");
    
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestAddToBasketSameProduct()
    {
        for (int i = 0; i < 5; i++)
        {
            basket.AddToBasket(p);
        }

        int expectedValue = 5;
        int realValue = basket.GetBasketProducts()[p];

        Assert.AreEqual(expectedValue, realValue);
    }
}