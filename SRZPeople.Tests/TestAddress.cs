using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SRZPeople.Tests
{
    [TestClass]
    public class TestAddress
    {
        [TestMethod]
        public void TestAddressCreation()
        {
            Address addr = new Address("123 Somewhere Place", "Juno", "Alaska", "12356");

            // Test Street
            Assert.AreEqual("123 Somewhere Place", addr.Street);

            // Test City
            Assert.AreEqual("Juno", addr.City);

            // Test State   
            Assert.AreEqual("Alaska", addr.State);

            // Test Zipcode
            Assert.AreEqual("12356", addr.Zipcode);
        }
    }
}
