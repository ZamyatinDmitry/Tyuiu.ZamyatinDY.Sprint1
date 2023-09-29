using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint1.Task7.V19.Lib;
namespace Tyuiu.ZamyatinDY.Sprint1.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -5;
            var res = ds.Calculate(x);
            Assert.AreEqual(-3754.559, res);
        }
    }
}
