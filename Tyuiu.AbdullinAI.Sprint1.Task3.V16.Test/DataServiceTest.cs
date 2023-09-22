using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint1.Task3.V16.Lib;

namespace Tyuiu.AbdullinAI.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2.0;
            double x2 = 3.0;
            Assert.AreEqual(ds.CoeffOfQuadraticEquation(x1, x2), -5.0);
        }
    }
}
