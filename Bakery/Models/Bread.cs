namespace Bakery.Models
{
  public class Bread
  {
    public int NumLoaves { get; }

    public Bread(int loaves)
    {
      NumLoaves = loaves;
    }

    public int CalculateSubTotal()
    {
      int freeLoaves = (NumLoaves - (NumLoaves % 3)) / 3;
      int subTotal = (NumLoaves - freeLoaves) * 5;
      return subTotal;
    }
  }
}