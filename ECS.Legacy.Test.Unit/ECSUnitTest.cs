using NSubstitute;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    public class ECSUnitTest
    {
        private ITempSensor _tempSensor;
        private FakeHeater _heater;
        private ECS _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new ECS(15, _tempSensor = new TempSensor(), _heater = new FakeHeater());
        }

        [Test]
        public void Regulate_HeaterOffCalled()
        {
            _uut.Regulate();
            Assert.That(_heater.HeaterState, Is.EqualTo(false));
        }

        [Test]
        public void Regulate_HeaterOnCalled()
        {
            _uut.SetThreshold(30);
            _uut.Regulate();
            Assert.That(_heater.HeaterState, Is.EqualTo(true));
        }
        [Test]
        public void GetThreshold_return15()
        {
            Assert.That(_uut.GetThreshold(), Is.EqualTo(15));
        }
        [Test]
        public void GetCurTemp_return25()
        {
            Assert.That(_uut.GetCurTemp(), Is.EqualTo(25));
        }
        [Test]
        public void RunSelfTest_returnTrue()
        {
            Assert.That(_uut.RunSelfTest(), Is.EqualTo(true));
        }
    }
}