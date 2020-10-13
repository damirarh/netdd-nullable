using ClassLibrary;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace NetCoreTests
{
    public class LibraryAnnotations
    {
        [Test]
        public void ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => JsonConvert.DeserializeObject<Player>(null));
        }

        [Test]
        public void CanAssignNullToNonNullableType()
        {
            Player player = JsonConvert.DeserializeObject<Player>("null");

            Assert.Throws<NullReferenceException>(() =>
            {
                var foo = player.Username;
            });
        }

        [Test]
        public void CanDereferenceNonNullableType()
        {
            Player? player = JsonConvert.DeserializeObject<Player>("null");

            Assert.Throws<NullReferenceException>(() =>
            {
                var foo = player.Username;
            });
        }

        [Test]
        public void CanReturnNullableType()
        {
            var player = JsonConvert.DeserializeObject<Player?>("null");

            Assert.Throws<NullReferenceException>(() =>
            {
                var foo = player.Username;
            });
        }
    }
}