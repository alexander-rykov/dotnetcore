using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;

namespace UnitTestProjectForConvert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EncodeName()
        {
            //used XmlConvert for get name 
            var nameForConvert = "Test\\Name\" for:convert";

            var expected = "Test_x005C_Name_x0022__x0020_for:convert";

            var actual = string.Empty;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecodeName()
        {
            //used XmlConvert for get name 
            var nameForConvert = "Test_x005C_Name_x0022__x0020_for:convert";

            var expected = "Test\\Name\" for:convert";

            var actual = string.Empty;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsConvertFrom()
        {
            //check can convert i to t.
            TypeConverter t = new TypeConverter();
            var i = int.MaxValue;

            Assert.IsTrue(false);
        }

        [TestMethod]
        public void ConvertTo()
        {
            //convert TestClassA to string
            TypeConverter t = new TypeConverter();
        }

        [TestMethod]
        public void ConvertToInt()
        {
            //use Convert
            var startValue = "123";
            var expected = 123;
            var actual = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvertToInt()
        {
            //use Convert in type int
            var startValue = "123";
            var expected = 123;
            var actual = 0;
            var result = false;


            Assert.AreEqual(expected, actual);
            Assert.IsTrue(result);
        }
    }
}
