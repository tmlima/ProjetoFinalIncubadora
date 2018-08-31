using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace IncubadoraDB.Test.PhpTravels
{
    [TestClass]
    public class PhpTravelsTests : TestBase
    {
        public PhpTravelsTests() { }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Csv\\TC_001.csv", "TC_001#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }
    }
}
