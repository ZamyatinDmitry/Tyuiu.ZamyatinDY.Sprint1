using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint1.Task4.V2.Lib;
namespace Tyuiu.ZamyatinDY.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 7.0;
            double wait = 0.25;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
