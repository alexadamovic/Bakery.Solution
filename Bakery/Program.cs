using System;
using Bakery.Models;

namespace Bakery 
{

  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("\n############################################\n###    ~ Welcome to Pierre's Bakery ~    ### \n############################################\n^ The only bakery with bread AND pastries! ^\n\nWould you like to buy some bread and/or pastries?? (Y/N)\n");
      string userDecision = Console.ReadLine().ToUpper();
      switch (userDecision)
      {
        case "Y":
          Console.WriteLine("Good decision my friend!\nHere is our pricing:\n\nBread - $5 per loaf w/ every 3rd loaf FREE\nPastries - $2 per pastry w/ $1 OFF every 3rd pastry\n(we're so generous, we know...\n\n)");
      }
    }
  }
}