namespace Bakery.Models

{
  public class Bread
  {
    public int Amount { get; }
    public Bread(int amount)
    {
      Amount = amount;
    }

    public int GetPrice()
    {
      int pricePer = 5;
      return pricePer * Amount;
    }

    public int Deals()
    {
      return 0;
    }
  }
}