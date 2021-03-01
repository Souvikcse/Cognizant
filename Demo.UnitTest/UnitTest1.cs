using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit_demo;
using System;

namespace Demo.UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        SimpleCalculator calc;
        double ans;
        [SetUp]
        public void Init()
        {
            calc = new SimpleCalculator();
        }

        [Test]
        [TestCase(18, 10, 8)]
        [TestCase(9, 5, 4)]
        public void AddTest(int a, int b, int c)
        {
            //Act
            calc.Addition(c, b);

            //Assert
            ans = calc.GetResult;
            Assert.AreEqual(a, ans);
        }

        [Test]
        [TestCase(2, 10, 8)]
        [TestCase(-1, 5, 4)]
        public void SubtractTest(double a, int b, int c)
        {
            //Act
            calc.Subtraction(c, b);

            //Assert
            ans = calc.GetResult;
            Assert.AreEqual(a, ans);
        }

        [Test]
        [TestCase(80, 10, 8)]
        [TestCase(20, 5, 4)]
        public void MultiplyTest(double a, int b, int c)
        {
            //Act
            calc.Multiplication(c, b);

            //Assert
            ans = calc.GetResult;
            Assert.AreEqual(a, ans);
        }

        [Test]
        [TestCase(0.8, 10, 8)]
        [TestCase(11, 44, 4)]
        [TestCase(2, 0, 10)]
        public void DivisionTest(double a, int b, int c)
        {
            try
            {
                //Act
                calc.Division(c, b);

                //Assert
                ans = calc.GetResult;
                Assert.AreEqual(a, ans);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TearDown]
        public void Clear()
        {
            //Act
            calc.AllClear();

            //Assert
            ans = calc.GetResult;
            Assert.AreEqual(ans, 0);
        }
    }
}
