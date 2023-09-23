using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint1.Task3.V13.Lib;
namespace Tyuiu.ZamyatinDY.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 123;
            var res = ds.MultiplyOfDigits(x);
            Assert.AreEqual(6, res);
        }
    }
}
