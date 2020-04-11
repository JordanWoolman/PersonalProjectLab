using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class VolleyballStats
    {
        [TestMethod]
        public void VolleyballStats_CalculatingKillAverage()
        {
            //arange
            VolleyballStats stats = new VolleyballStats();

            //act
            decimal avg = stats.CalculatingKillAverage(12, 3, 20);

            //asserting
            Assert.AreEqual(.450m, avg);
        }


        [TestMethod]
        public void VolleyballStats_CalculatingPassingAverage()
        {
            //arange
            VolleyballStats stats = new VolleyballStats();

            //act
            decimal avg = stats.CalculatingPassingAverage(20,49);

            //asserting
            Assert.AreEqual(2.45m, avg);
        }
    }
}