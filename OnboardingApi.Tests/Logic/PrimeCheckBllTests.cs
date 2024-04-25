using OnboardingApi.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingApi.Tests.Logic
{
    [TestClass]
    public class PrimeCheckBllTests
    {
        [TestMethod]
        public void Get_InputIs7_Returns7()
        {
            // Arrange
            var bll = new PrimeCheckBll();
            var inputNumber = 7;

            // Act
            var result = bll.Get(inputNumber);

            // Assert
            Assert.AreEqual(7, result.result1);
        }
    }
}
