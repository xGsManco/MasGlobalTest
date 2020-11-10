using MasGlobalTest.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobalTest.Tests
{
    [TestClass]
    public class BusinessLayerTest
    {

        [TestMethod]
        public async Task GetEmployeesTest()
        {
            var bussinesLayer = new EmployeeBl();
            var employees = await bussinesLayer.GetEmployeesAsync();
            Assert.IsTrue(employees != null && employees.Count() == 2);

        }
    }
}
