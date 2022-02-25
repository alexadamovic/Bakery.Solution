namespace Bakery.Models

{
  public class Pastry
  {
    public int Amount { get; }
    public Pastry(int amount)
    {
      Amount = amount;
    }

    public int GetPrice()
    {
      int pricePer = 2;
      return pricePer * Amount;
    }

    public int Deals()
    {
      return 0;
    }

  }
}