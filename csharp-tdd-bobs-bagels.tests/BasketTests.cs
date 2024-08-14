using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("Cheese Bagel")]
    public void AddBagelTest(string bagel)
    {
        Basket basket = new Basket();
        bool expected = true;

        bool result = basket.addBagel(bagel);

        Assert.That(expected == result);
    }
}