using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddBagelTest()
    {
        Basket basket = new Basket();
        string item = "Cheese bagel";
        bool expected = true;

        bool result = basket.addBagel(item);

        Assert.That(expected == result);
    }
}