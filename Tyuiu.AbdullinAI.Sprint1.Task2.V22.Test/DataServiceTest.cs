using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint1.Task2.V22.Lib;

namespace Tyuiu.AbdullinAI.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            int z = 1;
            var res = ds.CalculateAVGValue(x,y,z);
            Assert.AreEqual(res, 1);



        }
    }
}
