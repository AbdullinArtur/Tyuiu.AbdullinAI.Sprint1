using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint1.Task6.V2.Lib;

namespace Tyuiu.AbdullinAI.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "Привет друзья!";
            var res = ds.CheckHello(x);
            Assert.AreEqual(res, false); 


        }
    }
}
