using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethod.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void VolumeTest()
        {
            var volume = new AquosCommand("VOLM", 30);
            var volume2 = AquosCommand.Volume(30);

            Assert.IsTrue(volume.ToString() == volume2.ToString());
        }

        [TestMethod]
        public void PowerTest()
        {
            var povwer = new AquosCommand("POWR", 0);
            var power2 = AquosCommand.Power(PowerSetting.Off);

            Assert.IsTrue(povwer.ToString() == power2.ToString());
        }
    }
}
