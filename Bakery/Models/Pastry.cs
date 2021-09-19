namespace Bakery.Models
{
  public class Pastry
  {
    public int NumPastries { get; }

    public Pastry(int pastries)
    {
      NumPastries = pastries;
    }

    public int CalculateSubTotal()
    {
      int dollarPastries = (NumPastries - (NumPastries % 3)) / 3;
      int subTotal = ((NumPastries - dollarPastries) * 2) + (dollarPastries);
      return subTotal;
    }
  }
}