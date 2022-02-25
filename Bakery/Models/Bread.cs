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
      int discountAmount = 5;
      int discountOccurs = 0;
      for (int i = 1; i <= Amount; i++ ) 
      {
        if (i % 3 == 0) 
        {
          discountOccurs += 1;
        }
      }
      return discountOccurs * discountAmount;
    }

  }
}