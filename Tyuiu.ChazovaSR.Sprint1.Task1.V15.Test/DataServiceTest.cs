using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint1.Task1.V15.Lib;

namespace Tyuiu.ChazovaSR.Sprint1.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 5;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }
    }
}
