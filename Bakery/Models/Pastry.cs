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
      int discountAmount = 1;
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