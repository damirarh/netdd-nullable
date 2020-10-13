using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetFxTests
{
    [TestClass]
    public class ApiAnnotations
    {
        [TestMethod]
        public void NullableAnnotations()
        {
            var instance = new SampleClass();
            var result = instance.SampleMethod(null);
        }
    }
}
