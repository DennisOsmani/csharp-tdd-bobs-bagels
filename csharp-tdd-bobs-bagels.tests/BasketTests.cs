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

    [TestCase("Cheese Bagel", "Ham Bagel", "Salad Bagel", "Turkey Bagel")]
    public void AddBagelTest(string bagel1, string bagel2, string bagel3, string bagel4)
    {
        Basket basket = new Basket();
        bool expected = false;

        basket.addBagel(bagel1);
        basket.addBagel(bagel2);
        basket.addBagel(bagel3);

        bool result = basket.addBagel(bagel4);

        Assert.That(expected == result);
    }

    
}