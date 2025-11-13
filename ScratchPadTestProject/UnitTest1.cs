using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimcorpInterview;

namespace ScratchPadTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Question3.Exists(new[] { 1 }, 1);
            Assert.IsTrue(result);
        }
    }
}
