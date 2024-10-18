using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShakirovaGM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShakirovaGM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Тюлень";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Тюлень", res);
        }
    }
}
