using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using random_web_api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_web_api.Controllers.Tests
{
    [TestClass()]
    public class RandomControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var mock = new Mock<ILogger<RandomController>>();
            var controller = new RandomController(mock.Object);
            var response = controller.Get() as OkObjectResult;
            var randomValue = response?.Value as string;
            Assert.IsNotNull(randomValue);
            Assert.AreEqual(randomValue.Length, 5);
        }
    }
}