using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFoodSupply.Tests
{
    [TestFixture]
    class SupplyDetailTest
    {
        Program prog;
        [SetUp]
        public void Init()
        {
            prog = new Program();
        }

        [Test]
        [TestCase(10, "2022-03-04", "ddx", 10.2)]
        public void SupplyDetail_Object_Creation_Test(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail item = prog.CreateFoodDetail("abc", 1, new DateTime(2025, 01, 05), 8.5);
            Assert.DoesNotThrow(() => prog.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, item));
        }

        [Test]
        [TestCase(-3, "2022-03-04", "ddx", 10.2)]
        public void SupplyDetail_itemCount_Test(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail item = prog.CreateFoodDetail("abc", 1, new DateTime(2025, 01, 05), 8.5);
            Assert.Throws<Exception>(() => prog.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, item));
        }

        [Test]
        [TestCase(3, "2020-03-04", "ddx", 10.2)]
        public void SupplyDetail_LaunchDate_Test(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail item = prog.CreateFoodDetail("abc", 1, new DateTime(2025, 01, 05), 8.5);
            Assert.Throws<Exception>(() => prog.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, item));
        }

    }
}
