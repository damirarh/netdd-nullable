using ClassLibrary;
using NUnit.Framework;

namespace NetCoreTests
{
    public class Basics
    {
        [Test]
        public void FlagFilenameForSlovenianPlayer()
        {
            var player = new Player("Invincible", "invincible@player.si", Country.Slovenia);

            var filename = player.GetFlagFilename();

            Assert.AreEqual("si.png", filename);
        }

        [Test]
        public void FlagFilenameForPlayerWithoutCountry()
        {
            var player = new Player("Mysterious", "mysterious@unknown.country");

            var filename = player.GetFlagFilename();

            Assert.AreEqual("unknown.png", filename);
        }
    }
}
