using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parser;

namespace Tests
{
    [TestClass]
    public class ParserVisitorTest
    {
        [TestMethod]
        public void GetOwnTest()
        {
            Assert.AreEqual(File.ReadAllText(@"ParserVisitorTestGetOwnTest.txt") + "<EOF>", ParserHelper.GetOwnText(@"ParserVisitorTestGetOwnTest.txt"));
        }
    }
}
