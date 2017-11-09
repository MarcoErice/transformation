using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using TransformationLib;

namespace OpenFilesTestsLib
{
    [TestClass]
    public class OpenFilesTest
    {
        [TestMethod]
        public void One_Times_One_Returns_One()
        {
            var expected = "12.50x2 = 25.00";
            var amountContent = "12.50";
            var quantityContent = "2";

            var actual = Transformation.Transform(amountContent, quantityContent);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Two_Times_Two_Returns_Four()
        {
            
            var expected = "12.50x2 = 25.00\n12.50x10 = 125.00\n17.50x2 = 35.00\n17.50x10 = 175.00";
            var amountContent = "12.50\n17.50";
            var quantityContent = "2\n10";
            var actual = Transformation.Transform(amountContent, quantityContent);
            Assert.AreEqual(expected, actual);
        }

    }
}
