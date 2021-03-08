//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;


namespace GenericMedicine.UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        Program prog;
        [SetUp]
        public void Init()
        {
            prog = new Program();
        }

        [Test]
        [TestCase("abc", "cdf", "fdb", 7.8)]
        public void MedicineObjectCreationTest(string name, string medName, string comp, double p)
        {
            //var result = ;
            

            Assert.DoesNotThrow(() => prog.CreateMedicineDetail(name, medName, comp, DateTime.Now.AddDays(10), p));
        }

        [Test]
        [TestCase("abc", "cdf", "fdb", 7.8)]
        public void TestMedicineName(string name, string medName, string comp, double p)
        {
            Assert.That(() => prog.CreateMedicineDetail(name, null, comp, DateTime.Now.AddDays(10), p), Throws.Exception);
        }

        [Test]
        [TestCase("abc", "cdf", "fdb", 7.8)]
        public void TestPriceValue(string name, string medName, string comp, double p)
        {
            Assert.That(() => prog.CreateMedicineDetail(name, medName, comp, DateTime.Now.AddDays(10), 0), Throws.Exception);
        }

        [Test]
        [TestCase("abc", "cdf", "fdb", 7.8)]
        public void TestExpiryDate(string name, string medName, string comp, double p)
        {
            Assert.That(() => prog.CreateMedicineDetail(name, medName, comp, DateTime.Now.AddDays(-10), p), Throws.Exception);
        }
    }
}
