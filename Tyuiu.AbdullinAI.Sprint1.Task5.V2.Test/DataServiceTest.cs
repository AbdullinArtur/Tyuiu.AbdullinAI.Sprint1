using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint1.Task5.V2.Lib;

namespace Tyuiu.AbdullinAI.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 12;
            var res = ds.FahrenheitToСelsius(x);
            Assert.AreEqual(res, -11);
        }
    }
}
