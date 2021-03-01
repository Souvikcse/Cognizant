using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        Mock<IPlayerMapper> _Playermapper;
        [OneTimeSetUp]
        public void Init()
        {
            _Playermapper = new Mock<IPlayerMapper>();

            _Playermapper
                .Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>()))
                .Returns((string x) => { return false; });
        }

        [Test]
        [TestCase("abc")]
        public void TestPlayerAttributes(string n)
        {
            //var obj = new Player(n, a, c, nm);
            var obj = Player.RegisterNewPlayer(n, _Playermapper.Object);

            Assert.AreEqual(obj.Name, "abc");
            Assert.AreEqual(obj.Age, 23);
        }
    }
}
