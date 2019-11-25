
using AnimalShelter.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelter.Tests
{
	[TestClass]
	public class GetResult_ObjectTests
	{
        [TestMethod]
        public void GetResult_ReturnDefaults_WhenInitiaized()
        {
            var result = new GetResult();

            Assert.AreEqual(null, result.Animal);
            Assert.AreEqual(false, result.Status);
            Assert.AreEqual(null, result.Error);
        }
    }
}


