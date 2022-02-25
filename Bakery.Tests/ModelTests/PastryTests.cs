using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    [TestMethod]
    public void GetAmount_ReturnsAmount_Int()
    {
      int amount = 5;
      Pastry testPastry = new Pastry(amount);
      int result = testPastry.Amount;
      Assert.AreEqual(amount, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsInt_Int()
    {
      int amount = 5;
      Pastry testPastry = new Pastry(amount);
      int price = testPastry.GetPrice();
      Assert.AreEqual(typeof(int), price.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceBasedOnAmount_Int()
    {
      int amount = 5;
      int pricePer = 2;
      Pastry testPastry = new Pastry(amount);
      int price = testPastry.GetPrice();
      Assert.AreEqual((amount * pricePer), price);
    }

    [TestMethod]
    public void Deals_ReturnsInt_Int()
    {
      int amount = 5;
      Pastry testPastry = new Pastry(amount);
      int discount = testPastry.Deals();
      Assert.AreEqual(typeof(int), discount.GetType());
    }

    [TestMethod]
    public void Deals_ReturnsDiscountBasedOnAmount_Int()
    {
      int amount = 5;
      int discountAmount = 1;
      int discountOccurs = 1;
      Pastry testPastry = new Pastry(amount);
      int discount = testPastry.Deals();
      Assert.AreEqual((discountAmount * discountOccurs), discount);
    }
  }
}