using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetNumLoaves_ReturnsNumLoaves_Int()
    {
      int numLoaves = 5;
      Bread newBread = new Bread(numLoaves);
      int result = newBread.NumLoaves;
      Assert.AreEqual(numLoaves, result);
    }
  }
}