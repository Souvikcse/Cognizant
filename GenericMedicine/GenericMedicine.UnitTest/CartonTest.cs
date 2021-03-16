using NUnit.Framework;
using System;

namespace GenericMedicine.UnitTest
{
    [TestFixture]
    class CartonTest
    {
        Program prog;
        Medicine medicine = new Medicine()
        {
            Id = 1,
            Name = "abc",
            GenericMedicineName = "cgf",
            Composition = "dsb",
            ExpiryDate = new DateTime(2025, 08, 04),
            PricePerStrip = 8.5
        };
        [SetUp]
        public void Init()
        {
            prog = new Program();
        }

        [Test]
        [TestCase(10, "2022-01-09", "fdb")]
        public void CartonObjectCreationTest(int c, DateTime date, string addr)
        {

            Assert.DoesNotThrow(() => prog.CreateCartonDetail(c, date, addr, medicine));
        }

        [Test]
        [TestCase(-1, "2022-1-20", "fdb")]
        public void TestStripCount(int c, DateTime date, string addr)
        {
            Assert.That(() => prog.CreateCartonDetail(c, date, addr, medicine), Throws.Exception);
        }

        [Test]
        [TestCase(10, "2012-1-20", "fdb")]
        public void LaunchDate_lessthan_CurrentDate(int c, DateTime date, string addr)
        {
            Assert.That(() => prog.CreateCartonDetail(c, date, addr, medicine), Throws.Exception);
        }

        [Test]
        [TestCase(10, "2022-1-20", "fdb", null)]
        public void TestNullMedicineObject(int c, DateTime date, string addr, Medicine med)
        {
            med = medicine;
            Assert.AreEqual(prog.CreateCartonDetail(c, date, addr, med), null);
        }
    }
}
