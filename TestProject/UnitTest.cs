using Microsoft.VisualStudio.TestTools.UnitTesting;
using First_Task;

namespace TestProject
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void SolveTestFirst()
        {
            int num = 129;

            int max = Logic.Solve(num);

            Assert.AreEqual(9, max);
        }

        [TestMethod]
        public void SolveTestSecond()
        {
            int num = 112;

            int max = Logic.Solve(num);

            Assert.AreEqual(2, max);
        }
    }
}
