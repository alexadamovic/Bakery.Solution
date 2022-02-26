using System;
using Bakery.Models;

namespace Bakery 
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\n############################################\n###    ~ Welcome to Pierre's Bakery ~    ### \n############################################\n^ The only bakery with bread AND pastries! ^\n\nWould you like to buy some bread and/or pastries?? (Y/N)");
      string userDecision = Console.ReadLine().ToUpper();
      UserSwitch();

      void UserSwitch()
      {
        switch (userDecision)
        {
          case "Y":
            Console.WriteLine("Good decision my friend!\nHere is our pricing:\n\nBread - $5 per loaf w/ every 3rd loaf FREE\nPastries - $2 per pastry w/ $1 OFF every 3rd pastry\n(we're so generous, we know...)\n\nHow many loaves of bread would you like to buy?? (please enter a positive, whole number)");
            int userBreadNumber = 0;
            try
            {
              userBreadNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
              Console.WriteLine("You entered something that wasn't just a whole number. I'm gonna assume you don't want any bread then");
            }

            Bread userBread = new Bread(userBreadNumber);
            int breadFullPrice = userBread.GetPrice();
            int breadDiscount = userBread.Deals();

            Console.WriteLine("Okay gotcha! That'll be $" + breadFullPrice + " for the bread without the special deal (discount is applied at checkout after all).\nNow how many pastries would you like to buy?? (please enter a positive, whole number)");
            int userPastryNumber = 0;
            try
            {
              userPastryNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
              Console.WriteLine("You entered something that wasn't just a whole number. I'm gonna assume you don't want any pastries then");
            }
            
            Pastry userPastry = new Pastry(userPastryNumber);
            int pastryFullPrice = userPastry.GetPrice();
            int pastryDiscount = userPastry.Deals();

            int userTotal = breadFullPrice + pastryFullPrice - breadDiscount - pastryDiscount;
            int savings = breadDiscount + pastryDiscount;

            Console.WriteLine("Wonderful! That'll be $" + pastryFullPrice + " for the pastries without the special deal (discount is still applied at checkout)\n\nSo let's see here... That's " + userBreadNumber + "x loaves of bread and " + userPastryNumber + "x pastries, which means that your total with the discount is...\n(hold on a sec just gotta do the math real quick...)\n\n...only $" + userTotal + ". WOW!!! Looks like you saved $" + savings +".\n\nThanks for your business and please come again!");
            break;
          
          case "N":
            Console.WriteLine("Then scram! Window shoppers aren't welcome here at Pierre's Bakery!");
            break;

          default:
            Console.WriteLine("What??? I don't know what you're saying. We only deal in Y or N for this answer. Try again please:");
            userDecision = Console.ReadLine().ToUpper();
            UserSwitch();
            break;
        }
      }
    }
  }
}