using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;
using NUnit.Framework;

namespace MyFoodSupply.Tests
{
    [TestFixture]
    public class FoodItemTest
    {
        Program prog;
        [SetUp]
        public void Init()
        {
            prog = new Program();
        }

        [Test]
        [TestCase("abc", 1, "2022-05-08", 8.5)]
        public void FoodItem_Object_Creation_Test(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.DoesNotThrow(() => prog.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase("", 1, "2022-05-08", 9.6)]
        public void FoodItem_EmptyName_Test(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => prog.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase("nbs", 2, "2022-05-09", -8.7)]
        public void FoodItem_NegativePrice_Test(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => prog.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase("ggf", 1, "2023-05-09", 9.5)]
        public void FoodItem_Expirydate_Test(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => prog.CreateFoodDetail(name, dishType, expiryDate, price));
        }
    }
}
