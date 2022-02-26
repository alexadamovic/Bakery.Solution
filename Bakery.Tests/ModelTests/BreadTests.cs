using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread testBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void GetAmount_ReturnsAmount_Int()
    {
      int amount = 5;
      Bread testBread = new Bread(amount);
      int result = testBread.Amount;
      Assert.AreEqual(amount, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsInt_Int()
    {
      int amount = 5;
      Bread testBread = new Bread(amount);
      int price = testBread.GetPrice();
      Assert.AreEqual(typeof(int), price.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceBasedOnAmount_Int()
    {
      int amount = 5;
      int pricePer = 5;
      Bread testBread = new Bread(amount);
      int price = testBread.GetPrice();
      Assert.AreEqual((amount * pricePer), price);
    }

    [TestMethod]
    public void Deals_ReturnsInt_Int()
    {
      int amount = 5;
      Bread testBread = new Bread(amount);
      int discount = testBread.Deals();
      Assert.AreEqual(typeof(int), discount.GetType());
    }

    [TestMethod]
    public void Deals_ReturnsDiscountBasedOnAmount_Int()
    {
      int amount = 5;
      int discountAmount = 5;
      int discountOccurs = 1;
      Bread testBread = new Bread(amount);
      int discount = testBread.Deals();
      Assert.AreEqual((discountAmount * discountOccurs), discount);
    }
  }
}