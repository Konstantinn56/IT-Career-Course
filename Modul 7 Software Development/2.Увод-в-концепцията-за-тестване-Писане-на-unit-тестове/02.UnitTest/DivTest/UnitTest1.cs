using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DivTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dividing4By2Gives2()
        {
            Divider div = new Divider();
            var result = div.Divide(4, 2);
            Assert.AreEqual(2, result, "Dividing 4 by 2 does not result in 2.");
        }
    }
}