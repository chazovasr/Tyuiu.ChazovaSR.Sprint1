﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint1.Task2.V9.Lib;

namespace Tyuiu.ChazovaSR.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 3;
            var res = ds.CalculateVolumeCircle(r);
            Assert.AreEqual(113.094, res);
        }
    }
}
