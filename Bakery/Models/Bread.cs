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
      return 0;
    }
  }
}