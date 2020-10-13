using ClassLibrary;
using CoreClassLibrary;
using NUnit.Framework;
using System;

namespace NetCoreTests
{
    public class ApiAnnotations
    {
        [Test]
        public void NullableAnnotations()
        {
            var instance = new SampleClass();
            var result = instance.SampleMethod(null);
        }

        [Test]
        public void CreateMyDictionaryInstance()
        {
            var dictionary = new MyDictionary<string?, string?>();
        }

        [Test]
        public void JsonConvertWithBetterAnnotation()
        {
            var player = MyJsonConvert.DeserializeObject<Player>("null");

            Assert.Throws<NullReferenceException>(() => {
                var foo = player.Username;
            });
        }
    }
}
