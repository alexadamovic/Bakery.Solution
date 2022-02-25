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
  }
}