using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    public class TempSensorUnitTest
    {
        private ITempSensor _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new TempSensor();
        }

        [Test]
        public void GetTemp_Return25()
        {
            Assert.That(_uut.GetTemp(), Is.EqualTo(25));
        }

        [Test]
        public void RunSelfTest_ReturnTrue5()
        {
            Assert.That(_uut.RunSelfTest(), Is.EqualTo(true));
        }
    }
}
