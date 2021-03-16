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
        [TestCase("abc", "cdf", "fdb", "2022-05-05", 7.8)]
        public void MedicineObjectCreationTest(string name, string medName, string comp, DateTime date, double p)
        {
            //var result = ;
            

            Assert.DoesNotThrow(() => prog.CreateMedicineDetail(name, medName, comp, date, p));
        }

        [Test]
        [TestCase("abc", "", "fdb", "2022-05-05", 7.8)]
        public void TestMedicineName(string name, string medName, string comp, DateTime date, double p)
        {
            Assert.That(() => prog.CreateMedicineDetail(name, medName, comp, date, p), Throws.Exception);
        }

        [Test]
        [TestCase("abc", "cdf", "fdb", "2022-05-05", 0)]
        public void TestPriceValue(string name, string medName, string comp, DateTime date, double p)
        {
            Assert.That(() => prog.CreateMedicineDetail(name, medName, comp, date, p), Throws.Exception);
        }

        [Test]
        [TestCase("abc", "cdf", "fdb", "2012-05-05", 7.8)]
        public void TestExpiryDate(string name, string medName, string comp, DateTime date, double p)
        {
            Assert.That(() => prog.CreateMedicineDetail(name, medName, comp, date, p), Throws.Exception);
        }
    }
}
