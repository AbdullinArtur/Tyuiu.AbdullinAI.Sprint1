using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint1.Task4.V7.Lib;

namespace Tyuiu.AbdullinAI.Sprint1.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x, y;
            x = 4;
            y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 0.078);


        }
    }
}
