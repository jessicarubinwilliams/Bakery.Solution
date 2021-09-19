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
      return 7;
    }
  }
}