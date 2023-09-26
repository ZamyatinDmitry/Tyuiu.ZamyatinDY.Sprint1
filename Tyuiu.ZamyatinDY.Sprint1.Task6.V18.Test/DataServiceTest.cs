using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint1.Task6.V18.Lib;
namespace Tyuiu.ZamyatinDY.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string x = "123";
            var res = ds.CheckNumber(x);
            Assert.AreEqual(true, res);
        }
    }
}
