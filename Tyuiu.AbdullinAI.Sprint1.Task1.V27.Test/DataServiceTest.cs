using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint1.Task1.V27.Lib;

namespace Tyuiu.AbdullinAI.Sprint1.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 1.0);

        }
    }
}
