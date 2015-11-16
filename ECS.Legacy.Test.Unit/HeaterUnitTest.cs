using NSubstitute;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    public class HeaterUnitTest
    {
        private FakeHeater _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new FakeHeater();
        }

        [Test]
        public void RunSelfTest_returnTrue()
        {
            Assert.That(_uut.RunSelfTest(), Is.EqualTo(true));
        }

        [Test]
        public void TurnOn_ReturnTrue()
        {
            _uut.TurnOn();
            Assert.That(_uut.HeaterState, Is.EqualTo(true));
        }
        [Test]
        public void TurnOff_ReturnFalse()
        {
            _uut.TurnOff();
            Assert.That(_uut.HeaterState, Is.EqualTo(false));
        }
    }
}