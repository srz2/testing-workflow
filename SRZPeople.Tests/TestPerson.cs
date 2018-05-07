using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SRZPeople.Tests
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void TestPersonCreation()
        {
            Person p = new Person("Billy", "Bob");

            // Test First Name
            Assert.AreEqual("Billy", p.FirstName);

            // Test Last Name
            Assert.AreEqual("Bob", p.LastName);
        }
    }
}
