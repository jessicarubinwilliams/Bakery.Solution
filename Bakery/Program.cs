using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\r\nWelcome to Pierre's Bakery! \r\nWe serve a rotating selection of bread and pastries. We offer one unique variety of each daily. \r\nSee our chalk board for today's seasonal varieties. \r\n \r\nRegardless of flavors prices are: \r\nBread: Buy 2 loaves, Get 1 Free \r\nPastry: Buy 1 for $2 or 3 for $5 \r\n \r\nHow many loaves of fresh baked bread would you like to order? [Simply hit enter without typing a number if you don't wish to order bread]");
      string stringNumLoaves = Console.ReadLine();
      int numLoaves = int.Parse(stringNumLoaves);
      Bread customerBread = new Bread(numLoaves);
      int breadSubTotal = customerBread.CalculateSubTotal();
      Console.WriteLine("\r\nYour bread subtotal is $" + breadSubTotal + ".\r\n");
      Console.WriteLine("\r\nHow many pastries would you like to order? [Simply hit enter without typing a number if you don't wish to order pastries]");
      string stringNumPastries = Console.ReadLine();
      int numPastries = int.Parse(stringNumPastries);
      Pastry customerPastry = new Pastry(numPastries);
      int pastrySubTotal = customerPastry.CalculateSubTotal();
      int orderTotal = breadSubTotal + pastrySubTotal;
      Console.WriteLine("\r\nYour pastry subtotal is $" + pastrySubTotal + " and your order total is $" + orderTotal + ". Thank you for ordering with us!");
    }
  }
}